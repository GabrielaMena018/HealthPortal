namespace HealthPortal.View.Report.patient
{
    partial class FrmReportGeneralPatient
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
            this.dataSetReportPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReportPatient = new HealthPortal.View.Report.patient.DataSetReportPatient();
            this.panelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.borderRadiusTXT1 = new CustomPanel.BorderRadiusTXT();
            this.btnNew = new CustomPanel.RJButton();
            this.viewGeneralReportPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewGeneralReportPatientTableAdapter = new HealthPortal.View.Report.patient.DataSetReportPatientTableAdapters.ViewGeneralReportPatientTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportPatient)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGeneralReportPatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetReportPatientBindingSource
            // 
            this.dataSetReportPatientBindingSource.DataSource = this.dataSetReportPatient;
            this.dataSetReportPatientBindingSource.Position = 0;
            // 
            // dataSetReportPatient
            // 
            this.dataSetReportPatient.DataSetName = "DataSetReportPatient";
            this.dataSetReportPatient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.borderRadiusTXT1);
            this.panelTop.Controls.Add(this.btnNew);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1261, 68);
            this.panelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 17, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar paciente:";
            // 
            // borderRadiusTXT1
            // 
            this.borderRadiusTXT1.BackColor = System.Drawing.SystemColors.Window;
            this.borderRadiusTXT1.BorderColor = System.Drawing.Color.Transparent;
            this.borderRadiusTXT1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.borderRadiusTXT1.BorderRadius = 0;
            this.borderRadiusTXT1.BorderSize = 2;
            this.borderRadiusTXT1.Location = new System.Drawing.Point(150, 15);
            this.borderRadiusTXT1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.borderRadiusTXT1.Multiline = false;
            this.borderRadiusTXT1.Name = "borderRadiusTXT1";
            this.borderRadiusTXT1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.borderRadiusTXT1.PasswordChar = false;
            this.borderRadiusTXT1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.borderRadiusTXT1.PlaceholderText = "";
            this.borderRadiusTXT1.Size = new System.Drawing.Size(426, 31);
            this.borderRadiusTXT1.TabIndex = 1;
            this.borderRadiusTXT1.Texts = "";
            this.borderRadiusTXT1.UnderlinedStyle = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnNew.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnNew.BorderRadius = 40;
            this.btnNew.BorderSize = 0;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(589, 8);
            this.btnNew.Margin = new System.Windows.Forms.Padding(10, 8, 3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(163, 46);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Generar Reporte";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextColor = System.Drawing.Color.Black;
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // viewGeneralReportPatientBindingSource
            // 
            this.viewGeneralReportPatientBindingSource.DataMember = "ViewGeneralReportPatient";
            this.viewGeneralReportPatientBindingSource.DataSource = this.dataSetReportPatient;
            // 
            // viewGeneralReportPatientTableAdapter
            // 
            this.viewGeneralReportPatientTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "GeneralReportPatient";
            reportDataSource1.Value = this.viewGeneralReportPatientBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealthPortal.View.Report.patient.FrmGeneralReportPatient.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 68);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1261, 518);
            this.reportViewer1.TabIndex = 1;
            // 
            // FrmReportGeneralPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 586);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelTop);
            this.Name = "FrmReportGeneralPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Visitas de los pacientes";
            this.Load += new System.EventHandler(this.FrmReportGeneralPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportPatient)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGeneralReportPatientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelTop;
        private System.Windows.Forms.Label label1;
        private CustomPanel.BorderRadiusTXT borderRadiusTXT1;
        public CustomPanel.RJButton btnNew;

        private System.Windows.Forms.BindingSource viewAdminPacientesBindingSource;
        private DataSetReportPatient dataSetReportPatient;
        private System.Windows.Forms.BindingSource viewGeneralReportPatientBindingSource;
        private DataSetReportPatientTableAdapters.ViewGeneralReportPatientTableAdapter viewGeneralReportPatientTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetReportPatientBindingSource;
    }
}