using RegistroPacientes.View.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using RegistroPacientes.Model.DAO;
using RegistroPacientes.Helper;
using RegistroPacientes.View.Dashboard;
using System.Windows.Forms;

namespace RegistroPacientes.Controller.Login
{
    internal class ControllerLogin
    {
        FrmLogin objLogin;
        public ControllerLogin(FrmLogin view)
        {
            objLogin = view;
            objLogin.btnLogin.Click += new EventHandler(AttemptLogin);
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