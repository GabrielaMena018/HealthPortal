namespace RegistroPacientes
{
    partial class FrmAdminPatience
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminPatience));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsVer = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnView = new CustomPanel.RJButton();
            this.GridViewPatient = new System.Windows.Forms.DataGridView();
            this.ContenedorFiltros = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnNew = new CustomPanel.RJButton();
            this.BtnFiltrar = new CustomPanel.RJButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbSpecialty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbGrade = new System.Windows.Forms.ComboBox();
            this.PickFechaVisita = new System.Windows.Forms.DateTimePicker();
            this.panelGrafica = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelCustumPequeño = new CustomPanel.PanelCustom();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.rjButton4 = new CustomPanel.RJButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.rjButton1 = new CustomPanel.RJButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelbuscador = new System.Windows.Forms.Panel();
            this.BtnBuscar = new CustomPanel.RJButton();
            this.txtSearch = new CustomPanel.BorderRadiusTXT();
            this.contextDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPatient)).BeginInit();
            this.ContenedorFiltros.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelGrafica.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelCustumPequeño.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelbuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextDataGrid
            // 
            this.contextDataGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsVer,
            this.cmsActualizar,
            this.cmsEliminar});
            this.contextDataGrid.Name = "contextDataGrid";
            this.contextDataGrid.Size = new System.Drawing.Size(193, 82);
            // 
            // cmsVer
            // 
            this.cmsVer.Image = ((System.Drawing.Image)(resources.GetObject("cmsVer.Image")));
            this.cmsVer.Name = "cmsVer";
            this.cmsVer.Size = new System.Drawing.Size(192, 26);
            this.cmsVer.Text = "Ver Ficha del Paciente";
            // 
            // cmsActualizar
            // 
            this.cmsActualizar.Image = ((System.Drawing.Image)(resources.GetObject("cmsActualizar.Image")));
            this.cmsActualizar.Name = "cmsActualizar";
            this.cmsActualizar.Size = new System.Drawing.Size(192, 26);
            this.cmsActualizar.Text = "Actualizar Paciente";
            // 
            // cmsEliminar
            // 
            this.cmsEliminar.Image = ((System.Drawing.Image)(resources.GetObject("cmsEliminar.Image")));
            this.cmsEliminar.Name = "cmsEliminar";
            this.cmsEliminar.Size = new System.Drawing.Size(192, 26);
            this.cmsEliminar.Text = "Eliminar Paciente";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(255, 70);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 32);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(65, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 32);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.ContenedorFiltros);
            this.panel3.Controls.Add(this.panelGrafica);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(20, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1340, 710);
            this.panel3.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.ContextMenuStrip = this.contextDataGrid;
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Controls.Add(this.GridViewPatient);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(338, 100);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1002, 610);
            this.panel8.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 69);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtnView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(783, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 69);
            this.panel5.TabIndex = 19;
            // 
            // BtnView
            // 
            this.BtnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnView.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnView.BorderRadius = 40;
            this.BtnView.BorderSize = 0;
            this.BtnView.FlatAppearance.BorderSize = 0;
            this.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnView.ForeColor = System.Drawing.Color.Black;
            this.BtnView.Location = new System.Drawing.Point(22, 10);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(173, 46);
            this.BtnView.TabIndex = 18;
            this.BtnView.Text = "Mostrar Todo";
            this.BtnView.TextColor = System.Drawing.Color.Black;
            this.BtnView.UseVisualStyleBackColor = false;
            // 
            // GridViewPatient
            // 
            this.GridViewPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewPatient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.GridViewPatient.BackgroundColor = System.Drawing.Color.White;
            this.GridViewPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewPatient.ColumnHeadersHeight = 40;
            this.GridViewPatient.ContextMenuStrip = this.contextDataGrid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewPatient.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPatient.EnableHeadersVisualStyles = false;
            this.GridViewPatient.Location = new System.Drawing.Point(0, 0);
            this.GridViewPatient.MultiSelect = false;
            this.GridViewPatient.Name = "GridViewPatient";
            this.GridViewPatient.ReadOnly = true;
            this.GridViewPatient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridViewPatient.RowHeadersVisible = false;
            this.GridViewPatient.RowHeadersWidth = 25;
            this.GridViewPatient.RowTemplate.Height = 24;
            this.GridViewPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewPatient.Size = new System.Drawing.Size(1002, 610);
            this.GridViewPatient.TabIndex = 0;
            // 
            // ContenedorFiltros
            // 
            this.ContenedorFiltros.BackColor = System.Drawing.Color.White;
            this.ContenedorFiltros.Controls.Add(this.label6);
            this.ContenedorFiltros.Controls.Add(this.cmbRol);
            this.ContenedorFiltros.Controls.Add(this.panel1);
            this.ContenedorFiltros.Controls.Add(this.BtnFiltrar);
            this.ContenedorFiltros.Controls.Add(this.label8);
            this.ContenedorFiltros.Controls.Add(this.label7);
            this.ContenedorFiltros.Controls.Add(this.CmbSpecialty);
            this.ContenedorFiltros.Controls.Add(this.label5);
            this.ContenedorFiltros.Controls.Add(this.CmbGrade);
            this.ContenedorFiltros.Controls.Add(this.PickFechaVisita);
            this.ContenedorFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContenedorFiltros.Location = new System.Drawing.Point(338, 0);
            this.ContenedorFiltros.Name = "ContenedorFiltros";
            this.ContenedorFiltros.Size = new System.Drawing.Size(1002, 100);
            this.ContenedorFiltros.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(567, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tipo Persona";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Todos"});
            this.cmbRol.Location = new System.Drawing.Point(571, 48);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(183, 28);
            this.cmbRol.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(822, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 100);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(128, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 28);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
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
            this.btnNew.Location = new System.Drawing.Point(3, 35);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(163, 46);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nuevo Paciente";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextColor = System.Drawing.Color.Black;
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnFiltrar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnFiltrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnFiltrar.BorderRadius = 40;
            this.BtnFiltrar.BorderSize = 0;
            this.BtnFiltrar.FlatAppearance.BorderSize = 0;
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.BtnFiltrar.Location = new System.Drawing.Point(15, 35);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(85, 46);
            this.BtnFiltrar.TabIndex = 17;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.TextColor = System.Drawing.Color.Black;
            this.BtnFiltrar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(483, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Grado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(280, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Especialidad";
            // 
            // CmbSpecialty
            // 
            this.CmbSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSpecialty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CmbSpecialty.FormattingEnabled = true;
            this.CmbSpecialty.Items.AddRange(new object[] {
            "Todos"});
            this.CmbSpecialty.Location = new System.Drawing.Point(284, 47);
            this.CmbSpecialty.Name = "CmbSpecialty";
            this.CmbSpecialty.Size = new System.Drawing.Size(185, 28);
            this.CmbSpecialty.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(114, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha de la Visita";
            // 
            // CmbGrade
            // 
            this.CmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGrade.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CmbGrade.FormattingEnabled = true;
            this.CmbGrade.Items.AddRange(new object[] {
            "Todos"});
            this.CmbGrade.Location = new System.Drawing.Point(487, 47);
            this.CmbGrade.Name = "CmbGrade";
            this.CmbGrade.Size = new System.Drawing.Size(65, 28);
            this.CmbGrade.TabIndex = 3;
            // 
            // PickFechaVisita
            // 
            this.PickFechaVisita.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PickFechaVisita.CustomFormat = "yyyy-MM-dd";
            this.PickFechaVisita.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.PickFechaVisita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PickFechaVisita.Location = new System.Drawing.Point(118, 47);
            this.PickFechaVisita.Name = "PickFechaVisita";
            this.PickFechaVisita.Size = new System.Drawing.Size(150, 27);
            this.PickFechaVisita.TabIndex = 6;
            // 
            // panelGrafica
            // 
            this.panelGrafica.Controls.Add(this.panelTitulo);
            this.panelGrafica.Controls.Add(this.flowLayoutPanel1);
            this.panelGrafica.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGrafica.Location = new System.Drawing.Point(0, 0);
            this.panelGrafica.Margin = new System.Windows.Forms.Padding(30);
            this.panelGrafica.MaximumSize = new System.Drawing.Size(800, 0);
            this.panelGrafica.Name = "panelGrafica";
            this.panelGrafica.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.panelGrafica.Size = new System.Drawing.Size(338, 710);
            this.panelGrafica.TabIndex = 2;
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.panelCustumPequeño);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitulo.Location = new System.Drawing.Point(0, 139);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(308, 571);
            this.panelTitulo.TabIndex = 1;
            // 
            // panelCustumPequeño
            // 
            this.panelCustumPequeño.BackColor = System.Drawing.Color.White;
            this.panelCustumPequeño.BorderRadius = 30;
            this.panelCustumPequeño.Controls.Add(this.panel6);
            this.panelCustumPequeño.Controls.Add(this.panelButton);
            this.panelCustumPequeño.Controls.Add(this.pictureBox2);
            this.panelCustumPequeño.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCustumPequeño.ForeColor = System.Drawing.Color.Black;
            this.panelCustumPequeño.GradientAngle = 90F;
            this.panelCustumPequeño.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustumPequeño.GradientTopColor = System.Drawing.Color.White;
            this.panelCustumPequeño.Location = new System.Drawing.Point(0, 0);
            this.panelCustumPequeño.Name = "panelCustumPequeño";
            this.panelCustumPequeño.Size = new System.Drawing.Size(308, 571);
            this.panelCustumPequeño.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox7);
            this.panel6.Controls.Add(this.rjButton4);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.rjButton1);
            this.panel6.Controls.Add(this.chart1);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(308, 558);
            this.panel6.TabIndex = 15;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(101, 502);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(26, 28);
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton4.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton4.BorderRadius = 40;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(43, 489);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(96, 46);
            this.rjButton4.TabIndex = 16;
            this.rjButton4.Text = "PDF";
            this.rjButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(248, 502);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 28);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.rjButton1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.rjButton1.BorderRadius = 40;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(157, 489);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(129, 46);
            this.rjButton1.TabIndex = 14;
            this.rjButton1.Text = "Imprimir";
            this.rjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 157);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(308, 245);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 157);
            this.panel4.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total de pacientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "atendidos";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(17, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(174, 29);
            this.comboBox2.TabIndex = 6;
            // 
            // panelButton
            // 
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(200, 100);
            this.panelButton.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(340, 447);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.panelbuscador);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(308, 139);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pacientes";
            // 
            // panelbuscador
            // 
            this.panelbuscador.Controls.Add(this.BtnBuscar);
            this.panelbuscador.Controls.Add(this.txtSearch);
            this.panelbuscador.Location = new System.Drawing.Point(3, 68);
            this.panelbuscador.Name = "panelbuscador";
            this.panelbuscador.Size = new System.Drawing.Size(319, 55);
            this.panelbuscador.TabIndex = 0;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnBuscar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnBuscar.BorderRadius = 20;
            this.BtnBuscar.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(245, 6);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(49, 43);
            this.BtnBuscar.TabIndex = 17;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.TextColor = System.Drawing.Color.Black;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.White;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Size = new System.Drawing.Size(219, 36);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Texts = "Búscar";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // FrmAdminPatience
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1380, 750);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1330, 750);
            this.Name = "FrmAdminPatience";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contextDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPatient)).EndInit();
            this.ContenedorFiltros.ResumeLayout(false);
            this.ContenedorFiltros.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelGrafica.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelCustumPequeño.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelbuscador.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomPanel.RJButton rjButton3;
        private CustomPanel.RJButton rjButton2;
        private CustomPanel.BorderRadiusTXT borderRadiusTXT2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.ContextMenuStrip contextDataGrid;
        public System.Windows.Forms.ToolStripMenuItem cmsVer;
        public System.Windows.Forms.ToolStripMenuItem cmsActualizar;
        public System.Windows.Forms.ToolStripMenuItem cmsEliminar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelGrafica;
        private System.Windows.Forms.Panel panelTitulo;
        private CustomPanel.PanelCustom panelCustumPequeño;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox7;
        public CustomPanel.RJButton rjButton4;
        private System.Windows.Forms.PictureBox pictureBox6;
        public CustomPanel.RJButton rjButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelbuscador;
        public CustomPanel.RJButton BtnBuscar;
        public CustomPanel.BorderRadiusTXT txtSearch;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.DataGridView GridViewPatient;
        private System.Windows.Forms.Panel ContenedorFiltros;
        public CustomPanel.RJButton BtnFiltrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox CmbSpecialty;
        private System.Windows.Forms.Label label5;
        public CustomPanel.RJButton btnNew;
        public System.Windows.Forms.ComboBox CmbGrade;
        public System.Windows.Forms.DateTimePicker PickFechaVisita;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        public CustomPanel.RJButton BtnView;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbRol;
    }
}

