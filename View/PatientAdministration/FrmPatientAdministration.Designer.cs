namespace HealthPortal.View.PatientAdministration
{
    partial class FrmPatientAdministration
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmsDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsView = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsShowAll = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCustom2 = new CustomControls.PanelCustom();
            this.dgvPatientInfo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFilter = new CustomControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpVisitDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSpecialty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowAll = new CustomControls.RJButton();
            this.panelCustom1 = new CustomControls.PanelCustom();
            this.grpPatients = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblPatientTotal = new System.Windows.Forms.Label();
            this.btnSearch = new CustomControls.RJButton();
            this.txtSearch = new CustomControls.CustomTextBox();
            this.lblUserAdministrationSearch = new System.Windows.Forms.Label();
            this.grpNewUser = new System.Windows.Forms.GroupBox();
            this.btnNew = new CustomControls.RJButton();
            this.panel1.SuspendLayout();
            this.cmsDataGrid.SuspendLayout();
            this.panelCustom2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelCustom1.SuspendLayout();
            this.grpPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.grpNewUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 120);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblTitle.Location = new System.Drawing.Point(32, 39);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(122, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Visitas";
            // 
            // cmsDataGrid
            // 
            this.cmsDataGrid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDelete,
            this.cmsView,
            this.cmsUpdate,
            this.cmsShowAll});
            this.cmsDataGrid.Name = "cmsDataGrid";
            this.cmsDataGrid.Size = new System.Drawing.Size(280, 92);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(279, 22);
            this.cmsDelete.Text = "Eliminar Visita";
            // 
            // cmsView
            // 
            this.cmsView.Name = "cmsView";
            this.cmsView.Size = new System.Drawing.Size(279, 22);
            this.cmsView.Text = "Ver Información de la Visita";
            // 
            // cmsUpdate
            // 
            this.cmsUpdate.Name = "cmsUpdate";
            this.cmsUpdate.Size = new System.Drawing.Size(279, 22);
            this.cmsUpdate.Text = "Actualizar Información de la Visita";
            // 
            // cmsShowAll
            // 
            this.cmsShowAll.Name = "cmsShowAll";
            this.cmsShowAll.Size = new System.Drawing.Size(279, 22);
            this.cmsShowAll.Text = "Mostrar Todos";
            // 
            // panelCustom2
            // 
            this.panelCustom2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCustom2.BackColor = System.Drawing.Color.White;
            this.panelCustom2.BorderRadius = 30;
            this.panelCustom2.Controls.Add(this.dgvPatientInfo);
            this.panelCustom2.Controls.Add(this.panel2);
            this.panelCustom2.ForeColor = System.Drawing.Color.Black;
            this.panelCustom2.GradientAngle = 90F;
            this.panelCustom2.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustom2.GradientTopColor = System.Drawing.Color.White;
            this.panelCustom2.Location = new System.Drawing.Point(421, 152);
            this.panelCustom2.Margin = new System.Windows.Forms.Padding(0, 32, 32, 32);
            this.panelCustom2.Name = "panelCustom2";
            this.panelCustom2.Size = new System.Drawing.Size(908, 641);
            this.panelCustom2.TabIndex = 1;
            // 
            // dgvPatientInfo
            // 
            this.dgvPatientInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatientInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientInfo.ContextMenuStrip = this.cmsDataGrid;
            this.dgvPatientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatientInfo.Location = new System.Drawing.Point(0, 100);
            this.dgvPatientInfo.Name = "dgvPatientInfo";
            this.dgvPatientInfo.ReadOnly = true;
            this.dgvPatientInfo.Size = new System.Drawing.Size(908, 541);
            this.dgvPatientInfo.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpVisitDate);
            this.panel2.Controls.Add(this.cmbSpecialty);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbGrade);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbRole);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnShowAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 100);
            this.panel2.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnFilter.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnFilter.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnFilter.BorderRadius = 40;
            this.btnFilter.BorderSize = 0;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnFilter.Location = new System.Drawing.Point(26, 26);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(26);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(117, 48);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(172, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de la visita";
            // 
            // dtpVisitDate
            // 
            this.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVisitDate.Location = new System.Drawing.Point(175, 54);
            this.dtpVisitDate.Margin = new System.Windows.Forms.Padding(26);
            this.dtpVisitDate.Name = "dtpVisitDate";
            this.dtpVisitDate.Size = new System.Drawing.Size(118, 20);
            this.dtpVisitDate.TabIndex = 8;
            // 
            // cmbSpecialty
            // 
            this.cmbSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbSpecialty.FormattingEnabled = true;
            this.cmbSpecialty.Location = new System.Drawing.Point(324, 53);
            this.cmbSpecialty.Margin = new System.Windows.Forms.Padding(5);
            this.cmbSpecialty.Name = "cmbSpecialty";
            this.cmbSpecialty.Size = new System.Drawing.Size(118, 21);
            this.cmbSpecialty.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(321, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Especialidad";
            // 
            // cmbGrade
            // 
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(473, 53);
            this.cmbGrade.Margin = new System.Windows.Forms.Padding(26);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(65, 21);
            this.cmbGrade.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(470, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grado";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(569, 53);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(5);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(118, 21);
            this.cmbRole.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(566, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de persona";
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnShowAll.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnShowAll.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowAll.BorderRadius = 40;
            this.btnShowAll.BorderSize = 0;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnShowAll.Location = new System.Drawing.Point(718, 26);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(26);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(164, 48);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "Mostrar Todos";
            this.btnShowAll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnShowAll.UseVisualStyleBackColor = false;
            // 
            // panelCustom1
            // 
            this.panelCustom1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCustom1.BackColor = System.Drawing.Color.White;
            this.panelCustom1.BorderRadius = 30;
            this.panelCustom1.Controls.Add(this.grpPatients);
            this.panelCustom1.Controls.Add(this.grpNewUser);
            this.panelCustom1.ForeColor = System.Drawing.Color.Black;
            this.panelCustom1.GradientAngle = 90F;
            this.panelCustom1.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustom1.GradientTopColor = System.Drawing.Color.White;
            this.panelCustom1.Location = new System.Drawing.Point(39, 152);
            this.panelCustom1.Margin = new System.Windows.Forms.Padding(32);
            this.panelCustom1.Name = "panelCustom1";
            this.panelCustom1.Size = new System.Drawing.Size(350, 641);
            this.panelCustom1.TabIndex = 0;
            // 
            // grpPatients
            // 
            this.grpPatients.Controls.Add(this.chart1);
            this.grpPatients.Controls.Add(this.lblPatientTotal);
            this.grpPatients.Controls.Add(this.btnSearch);
            this.grpPatients.Controls.Add(this.txtSearch);
            this.grpPatients.Controls.Add(this.lblUserAdministrationSearch);
            this.grpPatients.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatients.ForeColor = System.Drawing.Color.DarkGray;
            this.grpPatients.Location = new System.Drawing.Point(45, 45);
            this.grpPatients.Margin = new System.Windows.Forms.Padding(45);
            this.grpPatients.Name = "grpPatients";
            this.grpPatients.Size = new System.Drawing.Size(260, 418);
            this.grpPatients.TabIndex = 2;
            this.grpPatients.TabStop = false;
            this.grpPatients.Text = "Información de Pacientes";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(8, 166);
            this.chart1.Margin = new System.Windows.Forms.Padding(5);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(244, 244);
            this.chart1.SuppressExceptions = true;
            this.chart1.TabIndex = 7;
            this.chart1.TabStop = false;
            this.chart1.Text = "hola";
            // 
            // lblPatientTotal
            // 
            this.lblPatientTotal.AutoSize = true;
            this.lblPatientTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblPatientTotal.Location = new System.Drawing.Point(21, 140);
            this.lblPatientTotal.Name = "lblPatientTotal";
            this.lblPatientTotal.Size = new System.Drawing.Size(161, 15);
            this.lblPatientTotal.TabIndex = 6;
            this.lblPatientTotal.Text = "Total de pacientes atendidos";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSearch.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSearch.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.BorderRadius = 30;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSearch.Location = new System.Drawing.Point(161, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtSearch.Location = new System.Drawing.Point(24, 46);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Size = new System.Drawing.Size(212, 30);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // lblUserAdministrationSearch
            // 
            this.lblUserAdministrationSearch.AutoSize = true;
            this.lblUserAdministrationSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblUserAdministrationSearch.Location = new System.Drawing.Point(21, 28);
            this.lblUserAdministrationSearch.Name = "lblUserAdministrationSearch";
            this.lblUserAdministrationSearch.Size = new System.Drawing.Size(100, 15);
            this.lblUserAdministrationSearch.TabIndex = 3;
            this.lblUserAdministrationSearch.Text = "Buscar pacientes";
            // 
            // grpNewUser
            // 
            this.grpNewUser.Controls.Add(this.btnNew);
            this.grpNewUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewUser.ForeColor = System.Drawing.Color.DarkGray;
            this.grpNewUser.Location = new System.Drawing.Point(45, 496);
            this.grpNewUser.Margin = new System.Windows.Forms.Padding(45);
            this.grpNewUser.Name = "grpNewUser";
            this.grpNewUser.Size = new System.Drawing.Size(260, 100);
            this.grpNewUser.TabIndex = 1;
            this.grpNewUser.TabStop = false;
            this.grpNewUser.Text = "Nueva Visita";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnNew.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnNew.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnNew.BorderRadius = 40;
            this.btnNew.BorderSize = 0;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnNew.Location = new System.Drawing.Point(24, 28);
            this.btnNew.Margin = new System.Windows.Forms.Padding(21);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(212, 48);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nueva Visita";
            this.btnNew.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // FrmPatientAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1370, 825);
            this.Controls.Add(this.panelCustom2);
            this.Controls.Add(this.panelCustom1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1240, 825);
            this.Name = "FrmPatientAdministration";
            this.Text = "FrmUserAdministration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsDataGrid.ResumeLayout(false);
            this.panelCustom2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCustom1.ResumeLayout(false);
            this.grpPatients.ResumeLayout(false);
            this.grpPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.grpNewUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.ContextMenuStrip cmsDataGrid;
        public System.Windows.Forms.ToolStripMenuItem cmsDelete;
        public System.Windows.Forms.ToolStripMenuItem cmsView;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdate;
        public CustomControls.PanelCustom panelCustom1;
        private System.Windows.Forms.GroupBox grpPatients;
        public CustomControls.RJButton btnSearch;
        public CustomControls.CustomTextBox txtSearch;
        private System.Windows.Forms.Label lblUserAdministrationSearch;
        private System.Windows.Forms.GroupBox grpNewUser;
        public CustomControls.RJButton btnNew;
        public CustomControls.PanelCustom panelCustom2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblPatientTotal;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvPatientInfo;
        public CustomControls.RJButton btnShowAll;
        public System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbSpecialty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public CustomControls.RJButton btnFilter;
        public System.Windows.Forms.DateTimePicker dtpVisitDate;
        public System.Windows.Forms.ToolStripMenuItem cmsShowAll;
    }
}