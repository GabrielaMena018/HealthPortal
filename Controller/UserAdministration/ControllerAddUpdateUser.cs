using HealthPortal.View.UserAdministration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthPortal.Controller;
using HealthPortal.Model.DAO;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;
using HealthPortal.Helper;
using HealthPortal.Model.DTO;

namespace HealthPortal.Controller.UserAdministration
{
    internal class ControllerAddUpdateUser
    {
        FrmAddUpdateUser objFrmAddUpdateUser;
        private int procedure;
        private string role;
        private string personId;
        public ControllerAddUpdateUser(FrmAddUpdateUser view, int procedure)
        {
            objFrmAddUpdateUser = view;
            this.procedure = procedure;
            VerifyProcedure();
            objFrmAddUpdateUser.Load += new EventHandler(LoadComboBox);
            objFrmAddUpdateUser.btnAddNewUser.Click += new EventHandler(NewUser);
        }
        public ControllerAddUpdateUser(FrmAddUpdateUser view, int procedure, int personId, string firstName, string lastName, string email, string phoneNumber, string username, string role)
        {
            objFrmAddUpdateUser = view;
            this.procedure = procedure;
            this.role = role;
            this.personId = personId.ToString();
            VerifyProcedure();
            objFrmAddUpdateUser.Load += new EventHandler(LoadComboBox);
            LoadValues(personId, firstName, lastName, email, phoneNumber, username);
            objFrmAddUpdateUser.btnUpdateUser.Click += new EventHandler(UpdateUserInfo);
        }
        public void VerifyProcedure()
        {
            if (procedure == 1)
            {
                objFrmAddUpdateUser.btnAddNewUser.Enabled = true;
                objFrmAddUpdateUser.btnUpdateUser.Enabled = false;
            }
            else if (procedure == 2)
            {
                objFrmAddUpdateUser.btnAddNewUser.Enabled = false;
                objFrmAddUpdateUser.btnUpdateUser.Enabled = true;
                objFrmAddUpdateUser.txtUserAdministrationUsername.Enabled = false;
            }
            else
            {
                objFrmAddUpdateUser.btnAddNewUser.Enabled = false;
                objFrmAddUpdateUser.btnUpdateUser.Enabled = false;
                objFrmAddUpdateUser.txtUserAdministrationName.Enabled = false;
                objFrmAddUpdateUser.txtUserAdministrationLastName.Enabled = false;
                objFrmAddUpdateUser.txtUserAdministrationEmail.Enabled = false;
                objFrmAddUpdateUser.txtUserAdministrationPhoneNumber.Enabled = false;
                objFrmAddUpdateUser.txtUserAdministrationUsername.Enabled = false;
                objFrmAddUpdateUser.cmbUserAdministrationRole.Enabled = false;
            }
        }
        public void LoadComboBox(object sender, EventArgs e)
        {
            DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
            DataSet ds = daoUserAdministration.GetRoles();
            objFrmAddUpdateUser.cmbUserAdministrationRole.DataSource = ds.Tables["tbRoles"];
            objFrmAddUpdateUser.cmbUserAdministrationRole.ValueMember = "idRol";
            objFrmAddUpdateUser.cmbUserAdministrationRole.DisplayMember = "nombreRol";
            if (procedure == 2)
            {
                objFrmAddUpdateUser.cmbUserAdministrationRole.Text = role;
                objFrmAddUpdateUser.txtUserAdministrationId.Texts = personId;
            }
        }
        public void NewUser(object sender, EventArgs e)
        {
            DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
            CommonMethods commonMethods = new CommonMethods();
            string temporaryPassword;
            string email;

            // Persona
            daoUserAdministration.NombrePersona = objFrmAddUpdateUser.txtUserAdministrationName.Texts.Trim();
            daoUserAdministration.ApellidoPersona = objFrmAddUpdateUser.txtUserAdministrationLastName.Texts.Trim();
            email = objFrmAddUpdateUser.txtUserAdministrationEmail.Texts.Trim();
            daoUserAdministration.CorreoPersona = objFrmAddUpdateUser.txtUserAdministrationEmail.Texts.Trim();
            daoUserAdministration.TelefonoPersona = objFrmAddUpdateUser.txtUserAdministrationPhoneNumber.Texts.Trim();

            // Usuario
            daoUserAdministration.Usuario = objFrmAddUpdateUser.txtUserAdministrationUsername.Texts.Trim();
            temporaryPassword = commonMethods.GenerateRandomPassword();
            daoUserAdministration.Contrasena = commonMethods.ComputeSha256Hash(temporaryPassword);
            daoUserAdministration.EstadoUsuario = true;
            daoUserAdministration.IntentosUsuario = 0;
            daoUserAdministration.ContrasenaTemporal = true;
            daoUserAdministration.IdRol = int.Parse(objFrmAddUpdateUser.cmbUserAdministrationRole.SelectedValue.ToString());
            if (daoUserAdministration.RegisterUser() == 2)
            {
                MessageBox.Show("Los datos han sido guardados de manera exitosa.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (commonMethods.SendEmail(temporaryPassword, email) == false)
                {
                    daoUserAdministration.IdPersona = daoUserAdministration.GetMaxID();
                    daoUserAdministration.DeleteUser();
                }
                else
                {
                    MessageBox.Show("Los datos han sido registrados en la base de datos de manera exitosa.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Los datos no han podido ser registrados.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateUserInfo(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(objFrmAddUpdateUser.txtUserAdministrationName.Texts.Trim()) || string.IsNullOrEmpty(objFrmAddUpdateUser.txtUserAdministrationLastName.Texts.Trim()) || string.IsNullOrEmpty(objFrmAddUpdateUser.txtUserAdministrationEmail.Texts.Trim()) || string.IsNullOrEmpty(objFrmAddUpdateUser.txtUserAdministrationPhoneNumber.Texts.Trim()))
            {
                DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
                daoUserAdministration.IdPersona = int.Parse(objFrmAddUpdateUser.txtUserAdministrationId.Texts.Trim());
                daoUserAdministration.NombrePersona = objFrmAddUpdateUser.txtUserAdministrationName.Texts.Trim();
                daoUserAdministration.ApellidoPersona = objFrmAddUpdateUser.txtUserAdministrationLastName.Texts.Trim();
                daoUserAdministration.CorreoPersona = objFrmAddUpdateUser.txtUserAdministrationEmail.Texts.Trim();
                daoUserAdministration.TelefonoPersona = objFrmAddUpdateUser.txtUserAdministrationPhoneNumber.Texts.Trim();
                daoUserAdministration.Usuario = objFrmAddUpdateUser.txtUserAdministrationUsername.Texts.Trim();
                daoUserAdministration.IdRol = (int)objFrmAddUpdateUser.cmbUserAdministrationRole.SelectedValue;

                int returnedValue = daoUserAdministration.UpdateUserInfo();
                if (returnedValue == 2)
                {
                    MessageBox.Show("Los datos han sido actualizado exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (returnedValue == 1)
                {
                    MessageBox.Show("Los datos no pudieron ser actualizados completamente", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacíos, complete cada uno de los apartados.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LoadValues(int personId, string firstName, string lastName, string email, string phoneNumber, string username)
        {
            objFrmAddUpdateUser.txtUserAdministrationId.Texts = personId.ToString();
            objFrmAddUpdateUser.txtUserAdministrationName.Texts = firstName;
            objFrmAddUpdateUser.txtUserAdministrationLastName.Texts = lastName;
            objFrmAddUpdateUser.txtUserAdministrationEmail.Texts = email;
            objFrmAddUpdateUser.txtUserAdministrationPhoneNumber.Texts = phoneNumber;
            objFrmAddUpdateUser.txtUserAdministrationUsername.Texts = username;
        }
    }
}
