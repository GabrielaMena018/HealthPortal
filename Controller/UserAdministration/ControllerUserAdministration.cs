﻿using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.View.PasswordManagement;
using HealthPortal.View.UserAdministration;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.UserAdministration
{
    internal class ControllerUserAdministration
    {
        FrmUserAdministration objUserAdministration;
        public ControllerUserAdministration(FrmUserAdministration view)
        {
            objUserAdministration = view;
            //objUserAdministration.Load += new EventHandler(LoadComboBoxes);
            objUserAdministration.Load += new EventHandler(LoadData);
            objUserAdministration.Load += new EventHandler(VerifyAccessLevel);
            objUserAdministration.btnFilter.Click += new EventHandler(SortData);
            objUserAdministration.btnSearchForUser.Click += new EventHandler(SearchDatabase);
            objUserAdministration.btnAddNewUser.Click += new EventHandler(AddUser);
            objUserAdministration.cmsUpdateUser.Click += new EventHandler(UpdateUser);
            objUserAdministration.cmsDeleteUser.Click += new EventHandler(DeleteUser);
            objUserAdministration.cmsViewUser.Click += new EventHandler(ViewUser);
            objUserAdministration.cmsReestablishPassword.Click += new EventHandler(ChangeUserPassword);
        }
        //public void LoadComboBoxes(object sender, EventArgs e)
        //{
        //    DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
        //    DataSet ds = daoUserAdministration.GetColumnNames();
        //    objUserAdministration.cmbUserAdministrationFilter.DataSource = ds.Tables["tbRegistros"];
        //    objUserAdministration.cmbUserAdministrationFilter.DisplayMember = "nombreRegistro";
        //    objUserAdministration.cmbUserAdministrationFilter.ValueMember = "idRegistro";
        //}
        public void LoadData(object sender, EventArgs e)
        {
            ReloadData();
        }
        public void ReloadData()
        {
            DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
            DataSet ds = daoUserAdministration.GetUserInfo();
            objUserAdministration.dgvUserDisplay.DataSource = ds.Tables["viewPersonas"];
        }
        public void VerifyAccessLevel(object sender, EventArgs e)
        {
            if (CurrentUserData.RoleId == 1)
            {
                objUserAdministration.cmsReestablishPassword.Enabled = true;
            }
            else
            {
                objUserAdministration.cmsReestablishPassword.Enabled = false;
            }
        }
        public void SortData(object sender, EventArgs e)
        {
            DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
            string column = objUserAdministration.cmbUserAdministrationFilter.Text;
            DataSet ds = daoUserAdministration.GetSortedUserInfo(column);
            objUserAdministration.dgvUserDisplay.DataSource = ds.Tables["viewPersonas"];
        }
        public void SearchDatabase(object sender, EventArgs e)
        {
            DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
            string search = objUserAdministration.txtUserAdministrationSearch.Texts.Trim();
            DataSet ds = daoUserAdministration.SearchDesiredUserInfo(search);
            objUserAdministration.dgvUserDisplay.DataSource = ds.Tables["viewPersonas"];
        }
        public void AddUser(object sender, EventArgs e)
        {
            FrmAddUpdateUser handleForm = new FrmAddUpdateUser(1);
            handleForm.ShowDialog();
            ReloadData();
        }
        public void UpdateUser(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea actualizar los datos del usuario?", "Actualización de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int position = objUserAdministration.dgvUserDisplay.CurrentRow.Index;
                int personId = int.Parse(objUserAdministration.dgvUserDisplay[0, position].Value.ToString());
                string firstName = objUserAdministration.dgvUserDisplay[1, position].Value.ToString();
                string lastName = objUserAdministration.dgvUserDisplay[2, position].Value.ToString();
                string email = objUserAdministration.dgvUserDisplay[3, position].Value.ToString();
                string phoneNumber = objUserAdministration.dgvUserDisplay[4, position].Value.ToString();
                string username = objUserAdministration.dgvUserDisplay[5, position].Value.ToString();
                string role = objUserAdministration.dgvUserDisplay[6, position].Value.ToString();

                FrmAddUpdateUser handleForm = new FrmAddUpdateUser(2, personId, firstName, lastName, email, phoneNumber, username, role);
                handleForm.ShowDialog();
                ReloadData();
            }
        }
        public void ViewUser(object sender, EventArgs e)
        {
            int position = objUserAdministration.dgvUserDisplay.CurrentRow.Index;
            int personId = int.Parse(objUserAdministration.dgvUserDisplay[0, position].Value.ToString());
            string firstName = objUserAdministration.dgvUserDisplay[1, position].Value.ToString();
            string lastName = objUserAdministration.dgvUserDisplay[2, position].Value.ToString();
            string email = objUserAdministration.dgvUserDisplay[3, position].Value.ToString();
            string phoneNumber = objUserAdministration.dgvUserDisplay[4, position].Value.ToString();
            string username = objUserAdministration.dgvUserDisplay[5, position].Value.ToString();
            string role = objUserAdministration.dgvUserDisplay[6, position].Value.ToString();

            FrmAddUpdateUser handleForm = new FrmAddUpdateUser(3, personId, firstName, lastName, email, phoneNumber, username, role);
            handleForm.ShowDialog();
        }
        public void DeleteUser(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar los datos del usuario? Esta acción no se puede deshacer.", "Eliminación de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int position = objUserAdministration.dgvUserDisplay.CurrentRow.Index;
                DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
                daoUserAdministration.Username = objUserAdministration.dgvUserDisplay[5, position].Value.ToString();
                daoUserAdministration.PersonId = int.Parse(objUserAdministration.dgvUserDisplay[0, position].Value.ToString());
                if (daoUserAdministration.DeleteUser() == 2)
                {
                    MessageBox.Show("Usuario eliminado.", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadData();
                }
                else
                {
                    MessageBox.Show("El usuario no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ChangeUserPassword(object sender, EventArgs e)
        {
            CommonMethods commonMethods = new CommonMethods();
            DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
            int position = objUserAdministration.dgvUserDisplay.CurrentRow.Index;
            daoUserAdministration.Username = objUserAdministration.dgvUserDisplay[5, position].Value.ToString();
            string email = objUserAdministration.dgvUserDisplay[3, position].Value.ToString();
            string temporaryPassword = commonMethods.GenerateRandomPassword();
            daoUserAdministration.Password = commonMethods.ComputeSha256Hash(temporaryPassword);
            commonMethods.SendRecoveryEmail(temporaryPassword, email);
            daoUserAdministration.ReestablishUserPassword();
        }
    }
}
