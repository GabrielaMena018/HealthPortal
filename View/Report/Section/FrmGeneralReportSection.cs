using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.View.Report.Section
{
    public partial class FrmGeneralReportSection : Form
    {
        public FrmGeneralReportSection()
        {
            InitializeComponent();
        }

        private void FrmGeneralReportSection_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetSection.viewGradoSeccion' Puede moverla o quitarla según sea necesario.
            this.viewGradoSeccionTableAdapter.AdminSection(this.dataSetSection.viewGradoSeccion);
            // TODO: esta línea de código carga datos en la tabla 'dataSetUsers.viewPersonas' Puede moverla o quitarla 
            // TODO: esta línea de código carga datos en la tabla 'dataSetSection.viewGradoSeccion' Puede moverla o quitarla según sea necesario.
            this.viewGradoSeccionTableAdapter.AdminSection(this.dataSetSection.viewGradoSeccion);

            this.reportViewer1.RefreshReport();
        }
    }
}
