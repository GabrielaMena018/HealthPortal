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
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchPatient = new CustomPanel.BorderRadiusTXT();
            this.btnNew = new CustomPanel.RJButton();
            this.rjButton1 = new CustomPanel.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new CustomPanel.RJButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
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
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.txtSearchPatient);
            this.panelTop.Controls.Add(this.btnNew);
            this.panelTop.Controls.Add(this.rjButton1);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.dtpDesde);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.dtpHasta);
            this.panelTop.Controls.Add(this.btnFiltrar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1403, 68);
            this.panelTop.TabIndex = 1;
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchPatient.BorderColor = System.Drawing.Color.Transparent;
            this.txtSearchPatient.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearchPatient.BorderRadius = 0;
            this.txtSearchPatient.BorderSize = 2;
            this.txtSearchPatient.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPatient.Location = new System.Drawing.Point(150, 15);
            this.txtSearchPatient.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtSearchPatient.MaxLength = 32767;
            this.txtSearchPatient.Multiline = false;
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearchPatient.PasswordChar = false;
            this.txtSearchPatient.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchPatient.PlaceholderText = "";
            this.txtSearchPatient.Size = new System.Drawing.Size(381, 38);
            this.txtSearchPatient.TabIndex = 1;
            this.txtSearchPatient.Texts = "";
            this.txtSearchPatient.UnderlinedStyle = false;
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
            this.btnNew.Location = new System.Drawing.Point(544, 8);
            this.btnNew.Margin = new System.Windows.Forms.Padding(10, 8, 3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(163, 46);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Generar Reporte";
            this.btnNew.TextColor = System.Drawing.Color.Black;
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.rjButton1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.rjButton1.BorderRadius = 40;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(720, 8);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(10, 8, 3, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(143, 46);
            this.rjButton1.TabIndex = 4;
            this.rjButton1.Text = "Mostrar Todos";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(869, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 17, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpDesde.CustomFormat = "yyyy-MM-dd";
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(936, 15);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(132, 30);
            this.dtpDesde.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1074, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 17, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpHasta.CustomFormat = "yyyy-MM-dd";
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(1137, 15);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(132, 30);
            this.dtpHasta.TabIndex = 11;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnFiltrar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnFiltrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnFiltrar.BorderRadius = 40;
            this.btnFiltrar.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.Location = new System.Drawing.Point(1282, 8);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(10, 8, 3, 3);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(95, 46);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextColor = System.Drawing.Color.Black;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 68);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1403, 518);
            this.reportViewer1.TabIndex = 3;
            // 
            // FrmReportGeneralPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 586);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelTop);
            this.Name = "FrmReportGeneralPatient";
            this.Text = "FrmReportGeneralPatient";
            this.Load += new System.EventHandler(this.FrmReportGeneralPatient_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelTop;
        private CustomPanel.BorderRadiusTXT txtSearchPatient;
        public CustomPanel.RJButton btnNew;
        public CustomPanel.RJButton rjButton1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpHasta;
        public CustomPanel.RJButton btnFiltrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}