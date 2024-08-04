using RegistroPacientes.View.UserAdministration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroPacientes.Controller;
using RegistroPacientes.Model.DAO;
using System.Data;
using System.Windows.Forms;

namespace RegistroPacientes.Controller.UserAdministration
{
    internal class ControllerAddUpdateUser
    {
        FrmAddUpdateUser objFrmAddUpdateUser;
        private int procedure;
        private string role;
        private string personId;
        public ControllerAddUpdateUser(FrmAddUpdateUser View, int procedure)
        {
            objFrmAddUpdateUser = View;
            this.procedure = procedure;
            verifyProcedure();
            objFrmAddUpdateUser.Load += new EventHandler(LoadComboBox);
            objFrmAddUpdateUser.btnAddNewUser.Click += new EventHandler(NewUser);
        }
        public ControllerAddUpdateUser(FrmAddUpdateUser View, int procedure, int personId, string firstName, string lastName, string email, string phoneNumber, string username, string role)
        {
            objFrmAddUpdateUser = View;
            this.procedure = procedure;
            this.role = role;
            this.personId = personId.ToString();
            verifyProcedure();
            objFrmAddUpdateUser.Load += new EventHandler(LoadComboBox);
            LoadValues(personId, firstName, lastName, email, phoneNumber, username);
            objFrmAddUpdateUser.btnUpdateUser.Click += new EventHandler(UpdateUserInfo);
        }
        public void verifyProcedure()
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

            // Persona
            daoUserAdministration.NombrePersona = objFrmAddUpdateUser.txtUserAdministrationName.Texts.Trim();
            daoUserAdministration.ApellidoPersona = objFrmAddUpdateUser.txtUserAdministrationLastName.Texts.Trim();
            daoUserAdministration.CorreoPersona = objFrmAddUpdateUser.txtUserAdministrationEmail.Texts.Trim();
            daoUserAdministration.TelefonoPersona = objFrmAddUpdateUser.txtUserAdministrationPhoneNumber.Texts.Trim();

            // Usuario
            daoUserAdministration.Usuario = objFrmAddUpdateUser.txtUserAdministrationUsername.Texts.Trim();
            daoUserAdministration.Contrasena = objFrmAddUpdateUser.txtUserAdministrationUsername.Texts.Trim() + "PU123";
            daoUserAdministration.EstadoUsuario = true;
            daoUserAdministration.IntentosUsuario = 0;
            daoUserAdministration.IdRol = int.Parse(objFrmAddUpdateUser.cmbUserAdministrationRole.SelectedValue.ToString());
            int returnedValue = daoUserAdministration.RegisterUser();
            if (returnedValue == 1)
            {
                MessageBox.Show("Los datos han sido ingresados de manera exitosa.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los datos no han podido ser registrados.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateUserInfo(object sender, EventArgs e)
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
        public void LoadValues(int personId, string firstName, string lastName, string email, string phoneNumber, string username)
        {
            //objFrmAddUpdateUser.txtUserAdministrationId.Texts = personId.ToString();
            objFrmAddUpdateUser.txtUserAdministrationName.Texts = firstName;
            objFrmAddUpdateUser.txtUserAdministrationLastName.Texts = lastName;
            objFrmAddUpdateUser.txtUserAdministrationEmail.Texts = email;
            objFrmAddUpdateUser.txtUserAdministrationPhoneNumber.Texts = phoneNumber;
            objFrmAddUpdateUser.txtUserAdministrationUsername.Texts = username;
        }
    }
}
