namespace HealthPortal.View.Report.Section
{
    partial class FrmGeneralReportSection
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
            this.panelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetSection = new HealthPortal.View.Report.Section.DataSetSection();
            this.viewGradoSeccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewGradoSeccionTableAdapter = new HealthPortal.View.Report.Section.DataSetSectionTableAdapters.viewGradoSeccionTableAdapter();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGradoSeccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1018, 85);
            this.panelTop.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 17, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte de Secciones";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetSection";
            reportDataSource1.Value = this.viewGradoSeccionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealthPortal.View.Report.Section.GeneralReportSection.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1018, 460);
            this.reportViewer1.TabIndex = 6;
            // 
            // dataSetSection
            // 
            this.dataSetSection.DataSetName = "DataSetSection";
            this.dataSetSection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewGradoSeccionBindingSource
            // 
            this.viewGradoSeccionBindingSource.DataMember = "viewGradoSeccion";
            this.viewGradoSeccionBindingSource.DataSource = this.dataSetSection;
            // 
            // viewGradoSeccionTableAdapter
            // 
            this.viewGradoSeccionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGeneralReportSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 545);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelTop);
            this.Name = "FrmGeneralReportSection";
            this.Text = "FrmGeneralReportSection";
            this.Load += new System.EventHandler(this.FrmGeneralReportSection_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGradoSeccionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panelTop;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetSection dataSetSection;
        private System.Windows.Forms.BindingSource viewGradoSeccionBindingSource;
        private DataSetSectionTableAdapters.viewGradoSeccionTableAdapter viewGradoSeccionTableAdapter;
    }
}