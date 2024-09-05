using CustomPanel;
using HealthPortal.Model;
using HealthPortal.View.Login;
using HealthPortal.View.Settings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.Settings
{
    internal class ControllerServerSettings
    {
        FrmServerSettings frmServerSettings;
        int expandedFormWidth = 1090;
        Size expandedGrpSize = new Size(571, 219);
        Size collapsedGrpSize = new Size(467, 219);
        Size expandedPnlSize = new Size(1034, 528);
        Size collapsedPnlSize = new Size(930, 528);
        Size expandedTxtSize = new Size(525, 68);
        Size collapsedTxtSize = new Size(421, 68);
        int expandedAuthTxtXLocation = 66;
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
            if ((!string.IsNullOrEmpty(frmServerSettings.txtServerURL.Texts.Trim()) || !string.IsNullOrEmpty(frmServerSettings.txtDataBase.Texts.Trim()) || !string.IsNullOrEmpty(frmServerSettings.txtSQLAuth.Texts.Trim()) || !string.IsNullOrEmpty(frmServerSettings.txtPassword.Texts.Trim()) || !(frmServerSettings.txtServerURL.Texts.Trim() == "URL del servidor") || !(frmServerSettings.txtDataBase.Texts.Trim() == "Nombre de la base de datos") || !(frmServerSettings.txtSQLAuth.Texts.Trim() == "Autenticación SQL") || !(frmServerSettings.txtPassword.Texts.Trim() == "Contraseña")) && MessageBox.Show("¿Seguro que desea cambiar la información de conexión? Esto podría, potencialmente, inhabilitar completamente el funcionamiento del programa. Asegúrese de haber ingresado información correcta.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbContext dbContext = new dbContext();
                dbContext.SetConnectionDetails(frmServerSettings.txtServerURL.Texts.Trim(), frmServerSettings.txtDataBase.Texts.Trim(), frmServerSettings.txtSQLAuth.Texts.Trim(), frmServerSettings.txtPassword.Texts.Trim());
            }
            else
            {
                MessageBox.Show("Parece que algunos campos están vacíos. Asegúrese de llenar todos los campos e intente de nuevo.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResizeControls(object sender, EventArgs e)
        {
            if (frmServerSettings.Width == expandedFormWidth)
            {
                // frmServerSettings.panel2.Location = new Point(48, 120);
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
                // frmServerSettings.panel2.Location = new Point(0, 120);
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
            BorderRadiusTXT txt = sender as BorderRadiusTXT;
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
            BorderRadiusTXT txt = sender as BorderRadiusTXT;
            if (txt != null)
            {
                if (string.IsNullOrEmpty(txt.Texts))
                {
                    txt.Texts = GetPlaceholderText(txt);
                    txt.ForeColor = Color.FromArgb(142, 202, 230);
                }
            }
        }
        private string GetPlaceholderText(BorderRadiusTXT txt)
        {
            if (txt == frmServerSettings.txtServerURL) return "URL del servidor";
            if (txt == frmServerSettings.txtDataBase) return "Nombre de la base de datos";
            if (txt == frmServerSettings.txtSQLAuth) return "Autenticación SQL";
            if (txt == frmServerSettings.txtPassword) return "Contraseña";
            return string.Empty;
        }
    }
}
