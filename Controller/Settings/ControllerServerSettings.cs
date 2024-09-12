using CustomControls;
using HealthPortal.Helper;
using HealthPortal.Model;
using HealthPortal.Model.DTO;
using HealthPortal.View.Login;
using HealthPortal.View.Settings;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HealthPortal.Controller.Settings
{
    internal class ControllerServerSettings
    {
        FrmServerSettings frmServerSettings;
        int expandedFormWidth = (int)(1090 * CurrentUserData.ScaleFactor);
        Size expandedGrpSize = new Size((int)(571 * CurrentUserData.ScaleFactor), (int)(219 * CurrentUserData.ScaleFactor));
        Size collapsedGrpSize = new Size((int)(467 * CurrentUserData.ScaleFactor), (int)(219 * CurrentUserData.ScaleFactor));
        Size expandedPnlSize = new Size((int)(1034 * CurrentUserData.ScaleFactor), (int)(528 * CurrentUserData.ScaleFactor));
        Size collapsedPnlSize = new Size((int)(930 * CurrentUserData.ScaleFactor), (int)(528 * CurrentUserData.ScaleFactor));
        Size expandedTxtSize = new Size((int)(525 * CurrentUserData.ScaleFactor), (int)(68 * CurrentUserData.ScaleFactor));
        Size collapsedTxtSize = new Size((int)(421 * CurrentUserData.ScaleFactor), (int)(68 * CurrentUserData.ScaleFactor));
        int expandedAuthTxtXLocation = (int)(66 * CurrentUserData.ScaleFactor);
        public ControllerServerSettings(FrmServerSettings view)
        {
            frmServerSettings = view;
            frmServerSettings.Resize += new EventHandler(ResizeControls);

            frmServerSettings.txtServerURL.Enter += new EventHandler(EnterTextBox);
            frmServerSettings.txtDataBase.Enter += new EventHandler(EnterTextBox);
            frmServerSettings.txtSQLAuth.Enter += new EventHandler(EnterTextBox);
            frmServerSettings.txtPassword.Enter += new EventHandler(EnterTextBox);

            frmServerSettings.txtServerURL.Leave += new EventHandler(LeaveTextBox);
            frmServerSettings.txtDataBase.Leave += new EventHandler(LeaveTextBox);
            frmServerSettings.txtSQLAuth.Leave += new EventHandler(LeaveTextBox);
            frmServerSettings.txtPassword.Leave += new EventHandler(LeaveTextBox);

            frmServerSettings.rdoTrue.CheckedChanged += new EventHandler(rdTrueMarked);
            frmServerSettings.rdoFalse.CheckedChanged += new EventHandler(rdFalseMarked);

            frmServerSettings.btnSaveConfig.Click += new EventHandler(SaveDataBaseConfiguration);

            frmServerSettings.btnSaveConfig.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmServerSettings.btnSaveConfig.MouseLeave += new EventHandler(MouseLeaveTextButton);

            VerifyOrigin();
        }
        private void VerifyOrigin()
        {
            if (CurrentUserData.ServerSettingsOrigin == 1)
            {
                CommonMethods.EnableFormDrag(frmServerSettings, frmServerSettings);
                CommonMethods.EnableFormDrag(frmServerSettings, frmServerSettings.picImage);
                CommonMethods.EnableFormDrag(frmServerSettings, frmServerSettings.pnlTitle);
            }
            else
            {
                frmServerSettings.txtServerURL.Texts = DTOdbContext.Server;
                frmServerSettings.txtDataBase.Texts = DTOdbContext.Database;
                frmServerSettings.txtSQLAuth.Texts = DTOdbContext.User;
                frmServerSettings.txtPassword.Texts = DTOdbContext.Password;
                if (string.IsNullOrEmpty(DTOdbContext.User) && string.IsNullOrEmpty(DTOdbContext.Password)) frmServerSettings.rdoFalse.Checked = true;
            }
        }
        private void MouseEnterTextButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(31, 43, 91);
            btn.ForeColor = Color.White;
        }
        private void MouseLeaveTextButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.FromArgb(31, 43, 91);
        }
        private void rdFalseMarked(object sender, EventArgs e)
        {
            if (frmServerSettings.rdoTrue.Checked == true)
            {
                frmServerSettings.pnlAuth.Enabled = true;
                frmServerSettings.txtSQLAuth.Texts = GetPlaceholderText(frmServerSettings.txtSQLAuth);
                frmServerSettings.txtPassword.Texts = GetPlaceholderText(frmServerSettings.txtPassword);
            }
        }

        private void rdTrueMarked(object sender, EventArgs e)
        {
            if (frmServerSettings.rdoFalse.Checked == true)
            {
                frmServerSettings.pnlAuth.Enabled = false;
                frmServerSettings.txtSQLAuth.Clear();
                frmServerSettings.txtPassword.Clear();
            }
        }
        private void SaveDataBaseConfiguration(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration decl = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(decl);
                XmlElement root = doc.CreateElement("connection");
                doc.AppendChild(root);
                XmlElement server = doc.CreateElement("server");
                string codedServer = CommonMethods.CodeString(frmServerSettings.txtServerURL.Texts.Trim());

                server.InnerText = codedServer;
                root.AppendChild(server);

                XmlElement Database = doc.CreateElement("database");
                string codedDatabase = CommonMethods.CodeString(frmServerSettings.txtDataBase.Texts.Trim());
                Database.InnerText = codedDatabase;
                root.AppendChild(Database);
                XmlElement SqlAuth = doc.CreateElement("sqlAuth");
                XmlElement SqlPassword = doc.CreateElement("sqlPassword");

                if (frmServerSettings.rdoTrue.Checked == true)
                {
                    string codedSqlAuth = CommonMethods.CodeString(frmServerSettings.txtSQLAuth.Texts.Trim());
                    SqlAuth.InnerText = codedSqlAuth;

                    string codedSqlPassword = CommonMethods.CodeString(frmServerSettings.txtPassword.Texts.Trim());
                    SqlPassword.InnerText = codedSqlPassword;
                }
                else
                {
                    SqlAuth.InnerText = string.Empty;

                    SqlPassword.InnerText = string.Empty;
                }

                root.AppendChild(SqlAuth);
                root.AppendChild(SqlPassword);

                SqlConnection connection = dbContext.testConnection(frmServerSettings.txtServerURL.Texts.Trim(), frmServerSettings.txtDataBase.Texts.Trim(), frmServerSettings.txtSQLAuth.Texts.Trim(), frmServerSettings.txtPassword.Texts.Trim());

                if (connection != null)
                {
                    doc.Save("config_server.xml");
                    DTOdbContext.Server = frmServerSettings.txtServerURL.Texts.Trim();
                    DTOdbContext.Database = frmServerSettings.txtDataBase.Texts.Trim();
                    DTOdbContext.User = frmServerSettings.txtSQLAuth.Texts.Trim();
                    DTOdbContext.Password = frmServerSettings.txtPassword.Texts.Trim();
                    MessageBox.Show($"El archivo fue creado exitosamente.", "Archivo de configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmServerSettings.Dispose();
                }
            }
            catch (XmlException)
            {
                MessageBox.Show("No se pudo crear el archivo de configuración.", "Consulte el manual técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResizeControls(object sender, EventArgs e)
        {
            if (frmServerSettings.Width == expandedFormWidth)
            {
                MessageBox.Show(expandedPnlSize.ToString());
                frmServerSettings.panel2.Size = expandedPnlSize;
                frmServerSettings.grpConnectionInfo.Size = expandedGrpSize;
                frmServerSettings.grpLocalConfig.Size = expandedGrpSize;
                frmServerSettings.txtSQLAuth.Location = new Point(expandedAuthTxtXLocation, frmServerSettings.txtSQLAuth.Location.Y);
                frmServerSettings.txtPassword.Location = new Point(expandedAuthTxtXLocation, frmServerSettings.txtPassword.Location.Y);
                frmServerSettings.txtServerURL.Size = expandedTxtSize;
                frmServerSettings.txtDataBase.Size = expandedTxtSize;
            }
            else
            {
                MessageBox.Show(expandedPnlSize.ToString());
                frmServerSettings.panel2.Size = collapsedPnlSize;
                frmServerSettings.grpConnectionInfo.Size = collapsedGrpSize;
                frmServerSettings.grpLocalConfig.Size = collapsedGrpSize;
                frmServerSettings.txtSQLAuth.Location = new Point(0, frmServerSettings.txtSQLAuth.Location.Y);
                frmServerSettings.txtPassword.Location = new Point(0, frmServerSettings.txtPassword.Location.Y);
                frmServerSettings.txtServerURL.Size = collapsedTxtSize;
                frmServerSettings.txtDataBase.Size = collapsedTxtSize;
            }
            frmServerSettings.Refresh();
        }
        private void EnterTextBox(object sender, EventArgs e)
        {
            CustomTextBox txt = sender as CustomTextBox;
            if (txt != null)
            {
                if (txt.Texts.Trim() == GetPlaceholderText(txt))
                {
                    txt.Clear();
                    txt.ForeColor = Color.FromArgb(31, 43, 91);
                }
            }
        }
        private void LeaveTextBox(object sender, EventArgs e)
        {
            CustomTextBox txt = sender as CustomTextBox;
            if (txt != null)
            {
                if (string.IsNullOrEmpty(txt.Texts))
                {
                    txt.Texts = GetPlaceholderText(txt);
                    txt.ForeColor = Color.FromArgb(142, 202, 230);
                }
            }
        }
        private string GetPlaceholderText(CustomTextBox txt)
        {
            if (txt == frmServerSettings.txtServerURL) return "URL del servidor";
            if (txt == frmServerSettings.txtDataBase) return "Nombre de la base de datos";
            if (txt == frmServerSettings.txtSQLAuth) return "Autenticación SQL";
            if (txt == frmServerSettings.txtPassword) return "Contraseña";
            return string.Empty;
        }
    }
}
