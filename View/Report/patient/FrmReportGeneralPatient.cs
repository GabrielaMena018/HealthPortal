using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.View.Report.patient
{
    public partial class FrmReportGeneralPatient : Form
    {
        public FrmReportGeneralPatient()
        {
            InitializeComponent();
        }

        private void FrmReportGeneralPatient_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
