using HealthPortal.View.Login;
using HealthPortal.View.PasswordChange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using HealthPortal.Model.DAO;
using HealthPortal.Model;
using HealthPortal.Helper;
using HealthPortal.View.Dashboard;
using System.Windows.Forms;
using System.Drawing;
using HealthPortal.Properties;
using CustomPanel;

namespace HealthPortal.Controller.Login
{
    internal class ControllerLogin
    {
        FrmLogin objLogin;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerLogin(FrmLogin view)
        {
            objLogin = view;

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "picShowPassword", Tuple.Create(Resources.show, Resources.hoverShow) },
                { "picHidePassword", Tuple.Create(Resources.hide, Resources.hoverHide) },
                { "picExit", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "picTestConnection", Tuple.Create(Resources.wifi, Resources.hoverWifi) }
            };

            objLogin.Load += new EventHandler(HidePassword);
            objLogin.txtUsername.Enter += new EventHandler(EnterTxtUsername);
            objLogin.txtUsername.Leave += new EventHandler(LeaveTxtUsername);
            objLogin.txtPassword.Enter += new EventHandler(EnterTxtPassword);
            objLogin.txtPassword.Leave += new EventHandler(LeaveTxtPassword);
            objLogin.picTestConnection.Click += new EventHandler(TestConnection);
            objLogin.picExit.Click += new EventHandler(ExitApplication);
            objLogin.btnLogin.Click += new EventHandler(AttemptLogin);
            objLogin.picHidePassword.Click += new EventHandler(ShowPassword);
            objLogin.picShowPassword.Click += new EventHandler(HidePassword);
            objLogin.llbForgotPassword.Click += new EventHandler(EmailPasswordRecovery);
            objLogin.picExit.MouseEnter += new EventHandler(MouseEnterControl);
            objLogin.picHidePassword.MouseEnter += new EventHandler(MouseEnterControl);
            objLogin.picShowPassword.MouseEnter += new EventHandler(MouseEnterControl);
            objLogin.picTestConnection.MouseEnter += new EventHandler(MouseEnterControl);
            objLogin.btnLogin.MouseEnter += new EventHandler(MouseEnterButton);
            objLogin.picExit.MouseLeave += new EventHandler(MouseLeaveControl);
            objLogin.picHidePassword.MouseLeave += new EventHandler(MouseLeaveControl);
            objLogin.picShowPassword.MouseLeave += new EventHandler(MouseLeaveControl);
            objLogin.picTestConnection.MouseLeave += new EventHandler(MouseLeaveControl);
            objLogin.btnLogin.MouseLeave += new EventHandler(MouseLeaveButton);
        }
        private void MouseEnterButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(31, 43, 91);
            btn.ForeColor = Color.White;
        }
        private void MouseLeaveButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(255, 183, 3);
            btn.ForeColor = Color.FromArgb(31, 43, 91);
        }
        private void MouseEnterControl(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic != null && imageMapping.ContainsKey(pic.Name))
            {
                pic.Image = imageMapping[pic.Name].Item2;
            }
        }
        private void MouseLeaveControl(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic != null && imageMapping.ContainsKey(pic.Name))
            {
                pic.Image = imageMapping[pic.Name].Item1;
            }
        }
        private void EnterTxtUsername(object sender, EventArgs e)
        {
            if (objLogin.txtUsername.Texts.Trim().Equals("Usuario"))
            {
                objLogin.txtUsername.Clear();
                objLogin.txtUsername.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void LeaveTxtUsername(object sender, EventArgs e)
        {
            if (objLogin.txtUsername.Texts.Trim().Equals(""))
            {
                objLogin.txtUsername.Texts = "Usuario";
                objLogin.txtUsername.ForeColor = Color.FromArgb(142, 202, 230);
            }
        }
        private void EnterTxtPassword(object sender, EventArgs e)
        {
            if (objLogin.txtPassword.Texts.Trim().Equals("Contraseña"))
            {
                objLogin.txtPassword.Clear();
                objLogin.txtPassword.ForeColor = Color.FromArgb(31, 43, 91);
                HidePassword(sender, e);
            }
        }
        private void LeaveTxtPassword(object sender, EventArgs e)
        {
            if (objLogin.txtPassword.Texts.Trim().Equals(""))
            {
                objLogin.txtPassword.Texts = "Contraseña";
                objLogin.txtPassword.ForeColor = Color.FromArgb(142, 202, 230);
                ShowPassword(sender, e);
            }
        }
        private void TestConnection(object sender, EventArgs e)
        {
            if (dbContext.getConnection() == null)
            {
                MessageBox.Show("No fue posible realizar la conexión al servidor y/o la base de datos.", "Conexión fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("La conexión al servidor y la base de datos se ha ejecutado correctamente.", "Conexión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AttemptLogin(object sender, EventArgs e)
        {
            DAOLogin daoLogin = new DAOLogin();
            CommonMethods commonMethods = new CommonMethods();
            daoLogin.Username = objLogin.txtUsername.Texts.Trim();
            daoLogin.Password = commonMethods.ComputeSha256Hash(objLogin.txtPassword.Texts.Trim());
            if (daoLogin.EvaluateLogin() == true && CurrentUserData.Username.Equals(daoLogin.Username))
            {
                objLogin.Hide();
                if (CurrentUserData.TemporaryPassword)
                {
                    FrmPasswordChange objPasswordChange = new FrmPasswordChange(1);
                    objPasswordChange.Show();
                }
                else
                {
                    FrmDashboard objDashboard = new FrmDashboard();
                    objDashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ShowPassword(object sender, EventArgs e)
        {
            objLogin.txtPassword.PasswordChar = false;
            objLogin.picHidePassword.Visible = false;
            objLogin.picShowPassword.Visible = true;
        }
        private void HidePassword(object sender, EventArgs e)
        {
            if (!objLogin.txtPassword.Texts.Trim().Equals("Contraseña"))
            {
                objLogin.txtPassword.PasswordChar = true;
                objLogin.picShowPassword.Visible = false;
                objLogin.picHidePassword.Visible = true;
            }
        }
        private void EmailPasswordRecovery(object sender, EventArgs e)
        {
            if (objLogin.txtUsername.Texts.Trim() == "" || objLogin.txtUsername.Texts.Trim() == "Usuario")
            {
                MessageBox.Show("Llene el campo de nombre de usuario para poder verificar las credenciales.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DAOLogin daoLogin = new DAOLogin();
                CommonMethods commonMethods = new CommonMethods();
                string temporaryPassword = commonMethods.GenerateRandomPassword();
                string newPassword = commonMethods.ComputeSha256Hash(temporaryPassword);
                daoLogin.Username = objLogin.txtUsername.Texts.Trim();
                daoLogin.TemporaryPasswordAssignation(newPassword);
                commonMethods.SendRecoveryEmail(temporaryPassword, daoLogin.VerifyEmail(objLogin.txtUsername.Texts.Trim()));
            }
        }
    }
}