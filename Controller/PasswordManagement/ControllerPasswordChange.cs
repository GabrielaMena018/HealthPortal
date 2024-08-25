using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.View.PasswordManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.View.Login;

namespace HealthPortal.Controller.PasswordManagement
{
    internal class ControllerPasswordChange
    {
        FrmPasswordChange objPasswordChange;
        CommonMethods commonMethods = new CommonMethods();
        readonly int procedure;
        readonly string username;
        public ControllerPasswordChange(FrmPasswordChange view, int procedure)
        {
            this.procedure = procedure;
            objPasswordChange = view;
            objPasswordChange.Load += new EventHandler(VerifyProcedure);
            objPasswordChange.btnChangePassword.Click += new EventHandler(RespectiveAction);
            objPasswordChange.picExit.Click += new EventHandler(CloseForm);
        }
        public ControllerPasswordChange(FrmPasswordChange view, int procedure, string username)
        {
            this.procedure = procedure;
            this.username = username;
            objPasswordChange = view;
            objPasswordChange.Load += new EventHandler(VerifyProcedure);
            objPasswordChange.btnChangePassword.Click += new EventHandler(RespectiveAction);
            objPasswordChange.picExit.Click += new EventHandler(CloseForm);
        }
        private void VerifyProcedure(object sender, EventArgs e)
        {
            if (procedure == 2)
            {
                objPasswordChange.txtPreviousPassword.Enabled = false;
            }
            else
            {
                objPasswordChange.txtPreviousPassword.Enabled = true;
            }
        }
        private void RespectiveAction(object sender, EventArgs e)
        {
            if (procedure == 1)
            {
                AttemptPasswordChange();
            }
            else
            {
                ChangeUserPassword(username);
            }
        }
        private void ChangeUserPassword(string username)
        {
            DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
            if (CheckNewPassword() == true)
            {
                daoUserAdministration.Password = commonMethods.ComputeSha256Hash(objPasswordChange.txtNewPassword.Texts.Trim());
                daoUserAdministration.Username = username;
                if (daoUserAdministration.ReestablishUserPassword() == true)
                {
                    MessageBox.Show("Contraseña cambiada con éxito. Ha de informar al usuario del más reciente cambio. Cuando el usuario inicie sesión, también deberá de crear una nueva contraseña.", "Cambio de contraseña exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void AttemptPasswordChange()
        {
            DAOPasswordManagement daoPasswordChange = new DAOPasswordManagement();
            if (VerifyPassword() == true)
            {
                if (CheckNewPassword() == true)
                {
                    daoPasswordChange.Username = CurrentUserData.Username;
                    daoPasswordChange.Password = commonMethods.ComputeSha256Hash(objPasswordChange.txtNewPassword.Texts.Trim());
                    if (daoPasswordChange.UpdatePassword() == true)
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
            DAOPasswordManagement daoPasswordChange = new DAOPasswordManagement();
            string password = commonMethods.ComputeSha256Hash(objPasswordChange.txtPreviousPassword.Texts.Trim());
            return daoPasswordChange.VerifyCurrentUserPassword(password);
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
        private void CloseForm(object sender, EventArgs e)
        {
            objPasswordChange.Close();
            objPasswordChange.Dispose();
        }
    }
}
