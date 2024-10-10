namespace HealthPortal.View.Reports.Patient
{
    partial class FrmViewGeneralPatient
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
            this.dataSetInfoPatient = new HealthPortal.View.Reports.Patient.DataSetInfoPatient();
            this.tbPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbPatientTableAdapter = new HealthPortal.View.Reports.Patient.DataSetInfoPatientTableAdapters.tbPatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPatient";
            reportDataSource1.Value = this.tbPatientBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealthPortal.View.Reports.Patient.General_Patient.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetInfoPatient
            // 
            this.dataSetInfoPatient.DataSetName = "DataSetInfoPatient";
            this.dataSetInfoPatient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPatientBindingSource
            // 
            this.tbPatientBindingSource.DataMember = "tbPatient";
            this.tbPatientBindingSource.DataSource = this.dataSetInfoPatient;
            // 
            // tbPatientTableAdapter
            // 
            this.tbPatientTableAdapter.ClearBeforeFill = true;
            // 
            // FrmViewGeneralPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmViewGeneralPatient";
            this.Text = "FrmViewGeneralPatient";
            this.Load += new System.EventHandler(this.FrmViewGeneralPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPatientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetInfoPatient dataSetInfoPatient;
        private System.Windows.Forms.BindingSource tbPatientBindingSource;
        private DataSetInfoPatientTableAdapters.tbPatientTableAdapter tbPatientTableAdapter;
    }
}