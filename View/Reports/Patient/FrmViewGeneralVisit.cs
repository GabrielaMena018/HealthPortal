using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.View.Reports.Patient
{
    public partial class FrmViewGeneralVisit : Form
    {
        public FrmViewGeneralVisit()
        {
            InitializeComponent();
        }

        private void FrmViewGeneralVisit_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetInfoVisit.tbVisitas' Puede moverla o quitarla según sea necesario.
            this.tbVisitasTableAdapter.FillNewInfoVisit(this.dataSetInfoVisit.tbVisitas);
            // TODO: esta línea de código carga datos en la tabla 'dataSetInfoVisit.tbVisitas' Puede moverla o quitarla según sea necesario.
            this.tbVisitasTableAdapter.FillNewInfoVisit(this.dataSetInfoVisit.tbVisitas);
            this.reportViewer1.RefreshReport();
        }
    }
}
