using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Controller;
using HealthPortal.Controller.CategoryAdministration;

namespace HealthPortal.View.CategoryAdministration
{
    public partial class FrmAddUpdateCategory : Form
    {
        public FrmAddUpdateCategory(int action)
        {
            InitializeComponent();
            ControllerAddUpdateCategory control = new ControllerAddUpdateCategory(this, action);
        }

        public FrmAddUpdateCategory(int action,int id, string medicineCategory)
        {
            InitializeComponent();
            ControllerAddUpdateCategory control = new ControllerAddUpdateCategory(this, action, id, medicineCategory);
        }
    }
}
