using RegistroPacientes.View.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using RegistroPacientes.Model.DAO;
using RegistroPacientes.Model;
using RegistroPacientes.Helper;
using RegistroPacientes.View.Dashboard;
using System.Windows.Forms;
using System.Drawing;

namespace RegistroPacientes.Controller.Login
{
    internal class ControllerLogin
    {
        FrmLogin objLogin;
        public ControllerLogin(FrmLogin view)
        {
            objLogin = view;
            objLogin.txtUsername.Enter += new EventHandler(EnterTxtUsername);
            objLogin.txtUsername.Leave += new EventHandler(LeaveTxtUsername);
            objLogin.txtPassword.Enter += new EventHandler(EnterTxtPassword);
            objLogin.txtPassword.Leave += new EventHandler(LeaveTxtPassword);
            objLogin.picTestConnection.Click += new EventHandler(TestConnection);
            objLogin.picExit.Click += new EventHandler(ExitApplication);
            objLogin.btnLogin.Click += new EventHandler(AttemptLogin);
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
            }
        }
        private void LeaveTxtPassword(object sender, EventArgs e)
        {
            if (objLogin.txtPassword.Texts.Trim().Equals(""))
            {
                objLogin.txtPassword.Texts = "Contraseña";
                objLogin.txtPassword.ForeColor = Color.FromArgb(142, 202, 230);
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
            bool result = daoLogin.EvaluateLogin();
            if (result == true)
            {
                objLogin.Hide();
                FrmDashboard objDashboard = new FrmDashboard();
                objDashboard.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}