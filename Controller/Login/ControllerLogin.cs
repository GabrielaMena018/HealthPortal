using HealthPortal.View.Login;
using HealthPortal.View.PasswordManagement;
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
        FrmLogin frmLogin;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerLogin(FrmLogin view)
        {
            frmLogin = view;

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "picShowPassword", Tuple.Create(Resources.show, Resources.hoverShow) },
                { "picHidePassword", Tuple.Create(Resources.hide, Resources.hoverHide) },
                { "picExit", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "picTestConnection", Tuple.Create(Resources.wifi, Resources.hoverWifi) }
            };

            frmLogin.MouseDown += new MouseEventHandler(FormMouseDown);
            frmLogin.MouseMove += new MouseEventHandler(FormMouseMove);
            frmLogin.MouseUp += new MouseEventHandler(FormMouseUp);
            frmLogin.Load += new EventHandler(HidePassword);
            frmLogin.txtUsername.Enter += new EventHandler(EnterTxtUsername);
            frmLogin.txtUsername.Leave += new EventHandler(LeaveTxtUsername);
            frmLogin.txtPassword.Enter += new EventHandler(EnterTxtPassword);
            frmLogin.txtPassword.Leave += new EventHandler(LeaveTxtPassword);
            frmLogin.picTestConnection.Click += new EventHandler(TestConnection);
            frmLogin.picExit.Click += new EventHandler(ExitApplication);
            frmLogin.btnLogin.Click += new EventHandler(AttemptLogin);
            frmLogin.picHidePassword.Click += new EventHandler(ShowPassword);
            frmLogin.picShowPassword.Click += new EventHandler(HidePassword);
            frmLogin.llbForgotPassword.Click += new EventHandler(OpenPasswordRecoveryForm);
            frmLogin.picExit.MouseEnter += new EventHandler(MouseEnterControl);
            frmLogin.picHidePassword.MouseEnter += new EventHandler(MouseEnterControl);
            frmLogin.picShowPassword.MouseEnter += new EventHandler(MouseEnterControl);
            frmLogin.picTestConnection.MouseEnter += new EventHandler(MouseEnterControl);
            frmLogin.btnLogin.MouseEnter += new EventHandler(MouseEnterButton);
            frmLogin.picExit.MouseLeave += new EventHandler(MouseLeaveControl);
            frmLogin.picHidePassword.MouseLeave += new EventHandler(MouseLeaveControl);
            frmLogin.picShowPassword.MouseLeave += new EventHandler(MouseLeaveControl);
            frmLogin.picTestConnection.MouseLeave += new EventHandler(MouseLeaveControl);
            frmLogin.btnLogin.MouseLeave += new EventHandler(MouseLeaveButton);
        }
        private void FormMouseDown(object sender, EventArgs e)
        {
            CommonMethods.FormMouseDown(sender);
        }
        private void FormMouseMove(object sender, EventArgs e)
        {
            CommonMethods.FormMouseMove(sender);
        }
        private void FormMouseUp(object sender, EventArgs e)
        {
            CommonMethods.FormMouseUp(sender);
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
            if (frmLogin.txtUsername.Texts.Trim().Equals("Usuario"))
            {
                frmLogin.txtUsername.Clear();
                frmLogin.txtUsername.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void LeaveTxtUsername(object sender, EventArgs e)
        {
            if (frmLogin.txtUsername.Texts.Trim().Equals(""))
            {
                frmLogin.txtUsername.Texts = "Usuario";
                frmLogin.txtUsername.ForeColor = Color.FromArgb(142, 202, 230);
            }
        }
        private void EnterTxtPassword(object sender, EventArgs e)
        {
            if (frmLogin.txtPassword.Texts.Trim().Equals("Contraseña"))
            {
                frmLogin.txtPassword.Clear();
                frmLogin.txtPassword.ForeColor = Color.FromArgb(31, 43, 91);
                HidePassword(sender, e);
            }
        }
        private void LeaveTxtPassword(object sender, EventArgs e)
        {
            if (frmLogin.txtPassword.Texts.Trim().Equals(""))
            {
                frmLogin.txtPassword.Texts = "Contraseña";
                frmLogin.txtPassword.ForeColor = Color.FromArgb(142, 202, 230);
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
            DAOLogin dao = new DAOLogin();
            CommonMethods commonMethods = new CommonMethods();
            dao.Username = frmLogin.txtUsername.Texts.Trim();
            dao.Password = commonMethods.ComputeSha256Hash(frmLogin.txtPassword.Texts.Trim());
            if (dao.EvaluateLogin() == true && CurrentUserData.Username.Equals(dao.Username))
            {
                frmLogin.Hide();
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
            frmLogin.txtPassword.PasswordChar = false;
            frmLogin.picHidePassword.Visible = false;
            frmLogin.picShowPassword.Visible = true;
        }
        private void HidePassword(object sender, EventArgs e)
        {
            if (!frmLogin.txtPassword.Texts.Trim().Equals("Contraseña"))
            {
                frmLogin.txtPassword.PasswordChar = true;
                frmLogin.picShowPassword.Visible = false;
                frmLogin.picHidePassword.Visible = true;
            }
        }
        private void OpenPasswordRecoveryForm(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmLogin.txtUsername.Texts.Trim()))
            {
                DAOLogin dao = new DAOLogin();
                dao.Username = frmLogin.txtUsername.Texts.Trim();
                if (dao.ConfirmUser())
                {
                    FrmRecoveryMethods frmRecoveryMethods = new FrmRecoveryMethods(frmLogin.txtUsername.Texts.Trim());
                    frmLogin.Hide();
                    frmRecoveryMethods.Show();
                }
                else
                {
                    MessageBox.Show("El usuario ingresado NO existe. Verifique el usuario ingresado e intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Para poder utilizar los métodos de recuperación disponibles, por favor ingrese su usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}