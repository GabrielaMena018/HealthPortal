using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Model.DAO;
using HealthPortal.View.InventoryAdministration;
using HealthPortal.View.PatientAdministration;

namespace HealthPortal.Controller.PatientAdministration
{
    internal class ControllerAddRole 
    {
        FrmAddRole objRole;

        int action;

        public ControllerAddRole(FrmAddRole view, int action)
        {
           objRole = view;
            this.action = action;
            objRole.btnExitE.Click += new EventHandler(CloseForm);
            objRole.btnAddRole.Click += new EventHandler(AddRole);
        }

        private void AddRole(object sender, EventArgs e)
        {
            
        }
        private void CloseForm(object sender, EventArgs e)
        {
            objRole.Dispose();
        }
    }
}
