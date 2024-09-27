using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthPortal.Model.DAO;
using HealthPortal.View.InventoryAdministration;
using HealthPortal.View.PatientAdministration;

namespace HealthPortal.Controller.PatientAdministration
{
    internal class ControllerAdminRol
    {
        FrmAdminRol frmAdminRol;

      

        public ControllerAdminRol(FrmAdminRol view)
        {
            frmAdminRol = view;
            frmAdminRol.Load += new EventHandler(LoadData);
            frmAdminRol.btnAddRol.Click += new EventHandler(AddRole);
            frmAdminRol.btnExitRoleAdministration.Click += new EventHandler(CloseForm);
        }

        private void LoadData(object sender, EventArgs e)
        {
           RefreshData();
        }

        private void RefreshData() 
        {
            DAOPatientAdministration daoRole = new DAOPatientAdministration();
            DataSet ds = daoRole.GetRole();
            frmAdminRol.dgvRol.DataSource = ds.Tables["tbTipoPersona"];
        }

        private void AddRole(object sender, EventArgs e)
        {
            FrmAddRole openform = new FrmAddRole(1);
            openform.ShowDialog();
        }
        private void CloseForm(object sender, EventArgs e)
        {
            frmAdminRol.Dispose();
        }
    }
}
