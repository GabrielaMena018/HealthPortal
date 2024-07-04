using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPacientes.Controller.Dashboard;

namespace RegistroPacientes.View.Dashboard
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            ControllerDashboard control = new ControllerDashboard(this);

        }

        private void flowButtons_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
