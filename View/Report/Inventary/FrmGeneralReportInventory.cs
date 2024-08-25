using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.View.Report.Inventary
{
    public partial class FrmGeneralReportInventory : Form
    {
        public FrmGeneralReportInventory()
        {
            InitializeComponent();
        }

        private void FrmGeneralReportInventory_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetInventary3.ViewGenarlReportInventary' Puede moverla o quitarla según sea necesario.
            this.viewGenarlReportInventaryTableAdapter3.AdminInventory(this.dataSetInventary3.ViewGenarlReportInventary);

            this.reportViewer1.RefreshReport();
        }
    }
}
