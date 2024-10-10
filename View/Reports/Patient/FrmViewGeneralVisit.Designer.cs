namespace HealthPortal.View.Reports.Patient
{
    partial class FrmViewGeneralVisit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetInfoVisit = new HealthPortal.View.Reports.Patient.DataSetInfoVisit();
            this.tbVisitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbVisitasTableAdapter = new HealthPortal.View.Reports.Patient.DataSetInfoVisitTableAdapters.tbVisitasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVisitasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbVisitasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealthPortal.View.Reports.Patient.General_Visit.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetInfoVisit
            // 
            this.dataSetInfoVisit.DataSetName = "DataSetInfoVisit";
            this.dataSetInfoVisit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbVisitasBindingSource
            // 
            this.tbVisitasBindingSource.DataMember = "tbVisitas";
            this.tbVisitasBindingSource.DataSource = this.dataSetInfoVisit;
            // 
            // tbVisitasTableAdapter
            // 
            this.tbVisitasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmViewGeneralVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmViewGeneralVisit";
            this.Text = "FrmViewGeneralVisit";
            this.Load += new System.EventHandler(this.FrmViewGeneralVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVisitasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetInfoVisit dataSetInfoVisit;
        private System.Windows.Forms.BindingSource tbVisitasBindingSource;
        private DataSetInfoVisitTableAdapters.tbVisitasTableAdapter tbVisitasTableAdapter;
    }
}