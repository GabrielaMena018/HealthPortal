namespace HealthPortal.View.Reports.User
{
    partial class FrmViewGeneralUsers
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
            this.tbUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInfoUsers = new HealthPortal.View.Reports.User.DataSetInfoUsers();
            this.tbUsersTableAdapter = new HealthPortal.View.Reports.User.DataSetInfoUsersTableAdapters.tbUsersTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetInfoUsers1 = new HealthPortal.View.Reports.User.DataSetInfoUsers();
            this.tbUsersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoUsers1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsersBindingSource
            // 
            this.tbUsersBindingSource.DataMember = "tbUsers";
            this.tbUsersBindingSource.DataSource = this.dataSetInfoUsers;
            // 
            // dataSetInfoUsers
            // 
            this.dataSetInfoUsers.DataSetName = "DataSetInfoUsers";
            this.dataSetInfoUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsersTableAdapter
            // 
            this.tbUsersTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNewUsers";
            reportDataSource1.Value = this.tbUsersBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealthPortal.View.Reports.User.General_Users.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetInfoUsers1
            // 
            this.dataSetInfoUsers1.DataSetName = "DataSetInfoUsers";
            this.dataSetInfoUsers1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsersBindingSource1
            // 
            this.tbUsersBindingSource1.DataMember = "tbUsers";
            this.tbUsersBindingSource1.DataSource = this.dataSetInfoUsers1;
            // 
            // FrmViewGeneralUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmViewGeneralUsers";
            this.Text = "FrmViewGeneralUsers";
            this.Load += new System.EventHandler(this.FrmViewGeneralUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInfoUsers1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSetInfoUsers dataSetInfoUsers;
        private System.Windows.Forms.BindingSource tbUsersBindingSource;
        private DataSetInfoUsersTableAdapters.tbUsersTableAdapter tbUsersTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetInfoUsers dataSetInfoUsers1;
        private System.Windows.Forms.BindingSource tbUsersBindingSource1;
    }
}