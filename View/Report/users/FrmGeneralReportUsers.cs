using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.View.Report.users
{
    public partial class FrmGeneralReportUsers : Form
    {
        public FrmGeneralReportUsers()
        {
            InitializeComponent();
        }

        private void FrmGeneralReportUsers_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetUsers.viewPersonas' Puede moverla o quitarla según sea necesario.
            this.viewPersonasTableAdapter.GeneralReportUsers(this.dataSetUsers.viewPersonas);

            this.reportViewer2.RefreshReport();
        }
    }
}
