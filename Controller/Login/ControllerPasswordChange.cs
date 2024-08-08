using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthPortal.Model.DAO;
using HealthPortal.View.Login;
using HealthPortal.Helper;
using System.Windows.Forms;

namespace HealthPortal.Controller.Login
{
    internal class ControllerPasswordChange
    {
        FrmPasswordChange objPasswordChange;
        CommonMethods commonMethods = new CommonMethods();
        public ControllerPasswordChange(FrmPasswordChange view)
        {
            objPasswordChange = view;
            objPasswordChange.btnChangePassword.Click += new EventHandler(AttemptPasswordChange);
        }
        private void AttemptPasswordChange(object sender, EventArgs e)
        {
            DAOLogin daoLogin = new DAOLogin();
            if (VerifyPassword() == true)
            {
                if (CheckNewPassword() == true)
                {
                    daoLogin.Username = CurrentUserData.Username;
                    daoLogin.Password = commonMethods.ComputeSha256Hash(objPasswordChange.txtNewPassword.Texts.Trim());
                    if (daoLogin.UpdatePassword() == true)
                    {
                        MessageBox.Show("Contraseña cambiada con éxito. Vuelva a iniciar sesión con su nueva contraseña.", "Cambio de contraseña exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BackToLogin();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña no pudo ser actualizada.", "Cambio de contraseña fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las nuevas contraseñas ingresadas no coinciden entre sí.", "Error al cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La contraseña ingresada no coincide con el usuario.", "Error al cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool VerifyPassword()
        {
            DAOLogin daoLogin = new DAOLogin();
            string password = commonMethods.ComputeSha256Hash(objPasswordChange.txtPreviousPassword.Texts.Trim());
            return daoLogin.VerifyCurrentUserPassword(password);
        }
        private bool CheckNewPassword()
        {
            if (objPasswordChange.txtNewPassword.Texts.Trim() == objPasswordChange.txtNewPasswordConfirmation.Texts.Trim())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void BackToLogin()
        {
            commonMethods.DisposeOfCurrentUserData();
            FrmLogin objLogin = new FrmLogin();
            objLogin.Show();
            objPasswordChange.Dispose();
        }
    }
}