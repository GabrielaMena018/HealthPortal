using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.View.PasswordManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.PasswordManagement
{
    internal class ControllerAdminIntervention
    {
        FrmAdminIntervention frmAdminIntervention;
        string userUsername;
        public ControllerAdminIntervention(FrmAdminIntervention view, string username)
        {
            frmAdminIntervention = view;
            userUsername = username;
            frmAdminIntervention.btnConfirmPasswordChange.Click += new EventHandler(AttemptPasswordChangeConfirmation);
        }
        private void AttemptPasswordChangeConfirmation(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAdminIntervention.txtUsername.Texts.Trim()) || !string.IsNullOrEmpty(frmAdminIntervention.txtPassword.Texts.Trim()) || frmAdminIntervention.txtUsername.Texts.Trim() == "Usuario" || frmAdminIntervention.txtPassword.Texts.Trim() == "Contraseña")
            {
                MessageBox.Show("ninguno vacío");
                DAOPasswordManagement dao = new DAOPasswordManagement();
                dao.Username = frmAdminIntervention.txtUsername.Texts.Trim();
                dao.Password = CommonMethods.ComputeSha256Hash(frmAdminIntervention.txtPassword.Texts.Trim());
                if (dao.VerifyCredentials())
                {
                    string temporaryPassword = CommonMethods.GenerateRandomPassword(8);
                    CommonMethods.SendRecoveryEmail(temporaryPassword, dao.VerifyEmail(userUsername));
                    dao.Username = userUsername;
                    dao.Password = CommonMethods.ComputeSha256Hash(temporaryPassword);
                    if (dao.TemporaryPasswordAssignation())
                    {
                        MessageBox.Show("Contraseña cambiada con éxito.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Los datos ingresados no son correctos.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
