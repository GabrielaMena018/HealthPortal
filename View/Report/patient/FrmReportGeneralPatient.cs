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
            // TODO: esta línea de código carga datos en la tabla 'dataSetReportPatient.ViewGeneralReportPatient' Puede moverla o quitarla según sea necesario.
            this.viewGeneralReportPatientTableAdapter.GeneralPatientReport(this.dataSetReportPatient.ViewGeneralReportPatient);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.viewAdminPacientes' Puede moverla o quitarla según sea 
            this.reportViewer1.RefreshReport();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string Param1;
            this.viewGeneralReportPatientTableAdapter.AdminInventaryEspecifico(this.dataSetReportPatient.ViewGeneralReportPatient, Param1 = txtSearchPatient.Texts) ;
              
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.viewAdminPacientes' Puede moverla o quitarla según sea 
            this.reportViewer1.RefreshReport();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.viewGeneralReportPatientTableAdapter.GeneralPatientReport(this.dataSetReportPatient.ViewGeneralReportPatient);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.viewAdminPacientes' Puede moverla o quitarla según sea 
            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string param1, param2;
            this.viewGeneralReportPatientTableAdapter.AdminPatientDate(this.dataSetReportPatient.ViewGeneralReportPatient, param1 = dtpDesde.Value.ToString(), param2 = dtpHasta.Value.ToString());

            // TODO: esta línea de código carga datos en la tabla 'dataSet1.viewAdminPacientes' Puede moverla o quitarla según sea 
            this.reportViewer1.RefreshReport();
        }
    }
}
