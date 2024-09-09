using CustomControls;
using HealthPortal.Helper;
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
        FrmUserAdministration frmUserAdministration;
        int expanedFormWidth = 1370;
        int collapsedFormWidth = 1240;
        public ControllerUserAdministration(FrmUserAdministration view)
        {
            frmUserAdministration = view;
            frmUserAdministration.Load += new EventHandler(LoadData);
            frmUserAdministration.Load += new EventHandler(VerifyAccessLevel);
            frmUserAdministration.Resize += new EventHandler(ResizeControls);

            frmUserAdministration.btnFilter.Click += new EventHandler(SortData);

            frmUserAdministration.btnSearchForUser.Click += new EventHandler(SearchDatabase);
            frmUserAdministration.btnAddNewUser.Click += new EventHandler(AddUser);
            frmUserAdministration.cmsUpdateUser.Click += new EventHandler(UpdateUser);
            frmUserAdministration.cmsDeleteUser.Click += new EventHandler(DeleteUser);
            frmUserAdministration.cmsViewUser.Click += new EventHandler(ViewUser);

            frmUserAdministration.cmsReestablishPassword.Click += new EventHandler(ChangeUserPassword);

            frmUserAdministration.btnAddNewUser.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmUserAdministration.btnFilter.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmUserAdministration.btnSearchForUser.MouseEnter += new EventHandler(MouseEnterTextButton);

            frmUserAdministration.btnAddNewUser.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmUserAdministration.btnFilter.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmUserAdministration.btnSearchForUser.MouseLeave += new EventHandler(MouseLeaveTextButton);
        }
        private void MouseEnterTextButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(31, 43, 91);
            btn.ForeColor = Color.White;
        }
        private void MouseLeaveTextButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(255, 183, 3);
            btn.ForeColor = Color.FromArgb(31, 43, 91);
        }
        private void LoadData(object sender, EventArgs e)
        {
            ReloadData();
        }
        private void ResizeControls(object sender, EventArgs e)
        {
            if (frmUserAdministration.Width == expanedFormWidth)
            {
                frmUserAdministration.panelCustom2.Width = 908;
            } 
            else if (frmUserAdministration.Width == collapsedFormWidth)
            {
                frmUserAdministration.panelCustom2.Width = 778;
            }
            frmUserAdministration.dgvUserDisplay.Dock = DockStyle.Fill;
            SetDataGridViewColumnSize();
            frmUserAdministration.Refresh();
        }
        private void ReloadData()
        {
            DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
            DataSet ds = daoUserAdministration.GetUserInfo();
            frmUserAdministration.dgvUserDisplay.DataSource = ds.Tables["viewPersonas"];
            SetDataGridViewColumnSize();
        }
        private void VerifyAccessLevel(object sender, EventArgs e)
        {
            if (CurrentUserData.RoleId == 1)
            {
                frmUserAdministration.cmsReestablishPassword.Enabled = true;
            }
            else
            {
                frmUserAdministration.cmsReestablishPassword.Enabled = false;
            }
        }
        private void SortData(object sender, EventArgs e)
        {
            DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
            string column = frmUserAdministration.cmbUserAdministrationFilter.Text;
            DataSet ds = daoUserAdministration.GetSortedUserInfo(column);
            frmUserAdministration.dgvUserDisplay.DataSource = ds.Tables["viewPersonas"];
            SetDataGridViewColumnSize();
        }
        private void SearchDatabase(object sender, EventArgs e)
        {
            DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
            string search = frmUserAdministration.txtUserAdministrationSearch.Texts.Trim();
            DataSet ds = daoUserAdministration.SearchDesiredUserInfo(search);
            frmUserAdministration.dgvUserDisplay.DataSource = ds.Tables["viewPersonas"];
            SetDataGridViewColumnSize();
        }
        private void AddUser(object sender, EventArgs e)
        {
            FrmAddUpdateUser handleForm = new FrmAddUpdateUser(1);
            handleForm.ShowDialog();
            ReloadData();
        }
        private void UpdateUser(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea actualizar los datos del usuario?", "Actualización de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int position = frmUserAdministration.dgvUserDisplay.CurrentRow.Index;
                int personId = int.Parse(frmUserAdministration.dgvUserDisplay[0, position].Value.ToString());
                string firstName = frmUserAdministration.dgvUserDisplay[1, position].Value.ToString();
                string lastName = frmUserAdministration.dgvUserDisplay[2, position].Value.ToString();
                string email = frmUserAdministration.dgvUserDisplay[3, position].Value.ToString();
                string phoneNumber = frmUserAdministration.dgvUserDisplay[4, position].Value.ToString();
                string username = frmUserAdministration.dgvUserDisplay[5, position].Value.ToString();
                string role = frmUserAdministration.dgvUserDisplay[6, position].Value.ToString();

                FrmAddUpdateUser handleForm = new FrmAddUpdateUser(2, personId, firstName, lastName, email, phoneNumber, username, role);
                handleForm.ShowDialog();
                ReloadData();
            }
        }
        private void ViewUser(object sender, EventArgs e)
        {
            int position = frmUserAdministration.dgvUserDisplay.CurrentRow.Index;
            int personId = int.Parse(frmUserAdministration.dgvUserDisplay[0, position].Value.ToString());
            string firstName = frmUserAdministration.dgvUserDisplay[1, position].Value.ToString();
            string lastName = frmUserAdministration.dgvUserDisplay[2, position].Value.ToString();
            string email = frmUserAdministration.dgvUserDisplay[3, position].Value.ToString();
            string phoneNumber = frmUserAdministration.dgvUserDisplay[4, position].Value.ToString();
            string username = frmUserAdministration.dgvUserDisplay[5, position].Value.ToString();
            string role = frmUserAdministration.dgvUserDisplay[6, position].Value.ToString();

            FrmAddUpdateUser handleForm = new FrmAddUpdateUser(3, personId, firstName, lastName, email, phoneNumber, username, role);
            handleForm.ShowDialog();
        }
        private void DeleteUser(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar los datos del usuario? Esta acción no se puede deshacer.", "Eliminación de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int position = frmUserAdministration.dgvUserDisplay.CurrentRow.Index;
                DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
                daoUserAdministration.Username = frmUserAdministration.dgvUserDisplay[5, position].Value.ToString();
                daoUserAdministration.PersonId = int.Parse(frmUserAdministration.dgvUserDisplay[0, position].Value.ToString());
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
        private void ChangeUserPassword(object sender, EventArgs e)
        {
            DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
            int position = frmUserAdministration.dgvUserDisplay.CurrentRow.Index;
            daoUserAdministration.Username = frmUserAdministration.dgvUserDisplay[5, position].Value.ToString();
            string email = frmUserAdministration.dgvUserDisplay[3, position].Value.ToString();
            string temporaryPassword = CommonMethods.GenerateRandomPassword(8);
            daoUserAdministration.Password = CommonMethods.ComputeSha256Hash(temporaryPassword);
            CommonMethods.SendRecoveryEmail(temporaryPassword, email);
            daoUserAdministration.ReestablishUserPassword();
        }
        private void SetDataGridViewColumnSize()
        {
            frmUserAdministration.dgvUserDisplay.Columns[0].Width = 32;
        }
    }
}
