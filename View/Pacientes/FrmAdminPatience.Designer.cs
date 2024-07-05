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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminPatience));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGrafica = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelCustumPequeño = new CustomPanel.PanelCustom();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.borderRadiusTXT2 = new CustomPanel.BorderRadiusTXT();
            this.rjButton3 = new CustomPanel.RJButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rjButton2 = new CustomPanel.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelbuscador = new System.Windows.Forms.Panel();
            this.rjButton1 = new CustomPanel.RJButton();
            this.borderRadiusTXT1 = new CustomPanel.BorderRadiusTXT();
            this.PanelContenedor = new CustomPanel.PanelCustom();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContenedorFiltros = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNew = new CustomPanel.RJButton();
            this.CmbSeccion = new System.Windows.Forms.ComboBox();
            this.CmbGrado = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGrafica.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelCustumPequeño.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelbuscador.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ContenedorFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 81);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pacientes";
            // 
            // panelGrafica
            // 
            this.panelGrafica.Controls.Add(this.panelTitulo);
            this.panelGrafica.Controls.Add(this.flowLayoutPanel1);
            this.panelGrafica.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGrafica.Location = new System.Drawing.Point(20, 20);
            this.panelGrafica.Margin = new System.Windows.Forms.Padding(10);
            this.panelGrafica.MaximumSize = new System.Drawing.Size(800, 0);
            this.panelGrafica.Name = "panelGrafica";
            this.panelGrafica.Size = new System.Drawing.Size(325, 710);
            this.panelGrafica.TabIndex = 1;
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.panelCustumPequeño);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitulo.Location = new System.Drawing.Point(0, 139);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(325, 571);
            this.panelTitulo.TabIndex = 1;
            // 
            // panelCustumPequeño
            // 
            this.panelCustumPequeño.BackColor = System.Drawing.Color.White;
            this.panelCustumPequeño.BorderRadius = 30;
            this.panelCustumPequeño.Controls.Add(this.panel6);
            this.panelCustumPequeño.Controls.Add(this.panelButton);
            this.panelCustumPequeño.Controls.Add(this.pictureBox2);
            this.panelCustumPequeño.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustumPequeño.ForeColor = System.Drawing.Color.Black;
            this.panelCustumPequeño.GradientAngle = 90F;
            this.panelCustumPequeño.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustumPequeño.GradientTopColor = System.Drawing.Color.White;
            this.panelCustumPequeño.Location = new System.Drawing.Point(0, 0);
            this.panelCustumPequeño.Name = "panelCustumPequeño";
            this.panelCustumPequeño.Size = new System.Drawing.Size(325, 571);
            this.panelCustumPequeño.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chart1);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(325, 446);
            this.panel6.TabIndex = 15;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.pictureBox5);
            this.panelButton.Controls.Add(this.label4);
            this.panelButton.Controls.Add(this.borderRadiusTXT2);
            this.panelButton.Controls.Add(this.rjButton3);
            this.panelButton.Controls.Add(this.pictureBox3);
            this.panelButton.Controls.Add(this.rjButton2);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 446);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(325, 125);
            this.panelButton.TabIndex = 14;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad Total:";
            // 
            // borderRadiusTXT2
            // 
            this.borderRadiusTXT2.BackColor = System.Drawing.SystemColors.Window;
            this.borderRadiusTXT2.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.borderRadiusTXT2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.borderRadiusTXT2.BorderRadius = 0;
            this.borderRadiusTXT2.BorderSize = 2;
            this.borderRadiusTXT2.Location = new System.Drawing.Point(161, 0);
            this.borderRadiusTXT2.Multiline = false;
            this.borderRadiusTXT2.Name = "borderRadiusTXT2";
            this.borderRadiusTXT2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.borderRadiusTXT2.PasswordChar = false;
            this.borderRadiusTXT2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.borderRadiusTXT2.PlaceholderText = "";
            this.borderRadiusTXT2.Size = new System.Drawing.Size(94, 31);
            this.borderRadiusTXT2.TabIndex = 9;
            this.borderRadiusTXT2.Texts = "";
            this.borderRadiusTXT2.UnderlinedStyle = true;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.rjButton3.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.rjButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.rjButton3.BorderRadius = 40;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(117, 60);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(188, 47);
            this.rjButton3.TabIndex = 11;
            this.rjButton3.Text = "Imprimir Reporte";
            this.rjButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
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
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton2.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton2.BorderRadius = 40;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(18, 60);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(93, 47);
            this.rjButton2.TabIndex = 10;
            this.rjButton2.Text = "PDF";
            this.rjButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 157);
            this.panel4.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 37);
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
            this.label3.Size = new System.Drawing.Size(145, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "atendidos";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(17, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(174, 36);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "Esta Semana";
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
            // panelbuscador
            // 
            this.panelbuscador.Controls.Add(this.rjButton1);
            this.panelbuscador.Controls.Add(this.borderRadiusTXT1);
            this.panelbuscador.Location = new System.Drawing.Point(3, 84);
            this.panelbuscador.Name = "panelbuscador";
            this.panelbuscador.Size = new System.Drawing.Size(319, 55);
            this.panelbuscador.TabIndex = 0;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.White;
            this.rjButton1.BackGroundColor = System.Drawing.Color.White;
            this.rjButton1.BackgroundImage = global::RegistroPacientes.Properties.Resources.busqueda__1_;
            this.rjButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rjButton1.BorderColor = System.Drawing.Color.White;
            this.rjButton1.BorderRadius = 40;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(270, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(46, 35);
            this.rjButton1.TabIndex = 4;
            this.rjButton1.Text = " ";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // borderRadiusTXT1
            // 
            this.borderRadiusTXT1.BackColor = System.Drawing.SystemColors.Window;
            this.borderRadiusTXT1.BorderColor = System.Drawing.Color.White;
            this.borderRadiusTXT1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.borderRadiusTXT1.BorderRadius = 20;
            this.borderRadiusTXT1.BorderSize = 2;
            this.borderRadiusTXT1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.borderRadiusTXT1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.borderRadiusTXT1.Location = new System.Drawing.Point(3, 3);
            this.borderRadiusTXT1.Multiline = false;
            this.borderRadiusTXT1.Name = "borderRadiusTXT1";
            this.borderRadiusTXT1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.borderRadiusTXT1.PasswordChar = false;
            this.borderRadiusTXT1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.borderRadiusTXT1.PlaceholderText = "";
            this.borderRadiusTXT1.Size = new System.Drawing.Size(313, 43);
            this.borderRadiusTXT1.TabIndex = 3;
            this.borderRadiusTXT1.Texts = "Buscar";
            this.borderRadiusTXT1.UnderlinedStyle = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.White;
            this.PanelContenedor.BorderRadius = 20;
            this.PanelContenedor.Controls.Add(this.panel8);
            this.PanelContenedor.Controls.Add(this.ContenedorFiltros);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelContenedor.ForeColor = System.Drawing.Color.Black;
            this.PanelContenedor.GradientAngle = 90F;
            this.PanelContenedor.GradientBottomColor = System.Drawing.Color.White;
            this.PanelContenedor.GradientTopColor = System.Drawing.Color.White;
            this.PanelContenedor.Location = new System.Drawing.Point(420, 20);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(10);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Padding = new System.Windows.Forms.Padding(0, 4, 4, 15);
            this.PanelContenedor.Size = new System.Drawing.Size(940, 710);
            this.PanelContenedor.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dataGridView1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 104);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(936, 591);
            this.panel8.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaciente,
            this.Documento,
            this.NombrePaciente,
            this.Apellido,
            this.TipoPersona,
            this.FechaVisita,
            this.HoraVisita,
            this.Opciones});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(936, 591);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdPaciente
            // 
            this.IdPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdPaciente.FillWeight = 50F;
            this.IdPaciente.HeaderText = "Idpaciente";
            this.IdPaciente.MinimumWidth = 6;
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Documento.FillWeight = 50F;
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // NombrePaciente
            // 
            this.NombrePaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombrePaciente.FillWeight = 75F;
            this.NombrePaciente.HeaderText = "Nombres";
            this.NombrePaciente.MinimumWidth = 6;
            this.NombrePaciente.Name = "NombrePaciente";
            this.NombrePaciente.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.FillWeight = 75F;
            this.Apellido.HeaderText = "Apellidos";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // TipoPersona
            // 
            this.TipoPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoPersona.FillWeight = 50F;
            this.TipoPersona.HeaderText = "Rol";
            this.TipoPersona.MinimumWidth = 6;
            this.TipoPersona.Name = "TipoPersona";
            this.TipoPersona.ReadOnly = true;
            // 
            // FechaVisita
            // 
            this.FechaVisita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaVisita.FillWeight = 40F;
            this.FechaVisita.HeaderText = "Fecha";
            this.FechaVisita.MinimumWidth = 6;
            this.FechaVisita.Name = "FechaVisita";
            this.FechaVisita.ReadOnly = true;
            // 
            // HoraVisita
            // 
            this.HoraVisita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoraVisita.FillWeight = 50F;
            this.HoraVisita.HeaderText = "Hora";
            this.HoraVisita.MinimumWidth = 6;
            this.HoraVisita.Name = "HoraVisita";
            this.HoraVisita.ReadOnly = true;
            // 
            // Opciones
            // 
            this.Opciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opciones.FillWeight = 50F;
            this.Opciones.HeaderText = "Opciones";
            this.Opciones.MinimumWidth = 6;
            this.Opciones.Name = "Opciones";
            this.Opciones.ReadOnly = true;
            // 
            // ContenedorFiltros
            // 
            this.ContenedorFiltros.Controls.Add(this.label9);
            this.ContenedorFiltros.Controls.Add(this.label8);
            this.ContenedorFiltros.Controls.Add(this.label7);
            this.ContenedorFiltros.Controls.Add(this.label6);
            this.ContenedorFiltros.Controls.Add(this.CmbEspecialidad);
            this.ContenedorFiltros.Controls.Add(this.pictureBox4);
            this.ContenedorFiltros.Controls.Add(this.label5);
            this.ContenedorFiltros.Controls.Add(this.btnNew);
            this.ContenedorFiltros.Controls.Add(this.CmbSeccion);
            this.ContenedorFiltros.Controls.Add(this.CmbGrado);
            this.ContenedorFiltros.Controls.Add(this.dateTimePicker1);
            this.ContenedorFiltros.Controls.Add(this.CmbCategoria);
            this.ContenedorFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContenedorFiltros.Location = new System.Drawing.Point(0, 4);
            this.ContenedorFiltros.Name = "ContenedorFiltros";
            this.ContenedorFiltros.Size = new System.Drawing.Size(936, 100);
            this.ContenedorFiltros.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(651, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sección";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(549, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Grado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(359, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Especialidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(173, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Categoria";
            // 
            // CmbEspecialidad
            // 
            this.CmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEspecialidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CmbEspecialidad.FormattingEnabled = true;
            this.CmbEspecialidad.Location = new System.Drawing.Point(363, 49);
            this.CmbEspecialidad.Name = "CmbEspecialidad";
            this.CmbEspecialidad.Size = new System.Drawing.Size(175, 33);
            this.CmbEspecialidad.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(879, 46);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 35);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(10, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha";
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
            this.btnNew.Location = new System.Drawing.Point(764, 36);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(155, 46);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nuevo Paciente";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextColor = System.Drawing.Color.Black;
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // CmbSeccion
            // 
            this.CmbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSeccion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CmbSeccion.FormattingEnabled = true;
            this.CmbSeccion.Location = new System.Drawing.Point(655, 49);
            this.CmbSeccion.Name = "CmbSeccion";
            this.CmbSeccion.Size = new System.Drawing.Size(103, 33);
            this.CmbSeccion.TabIndex = 1;
            // 
            // CmbGrado
            // 
            this.CmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGrado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CmbGrado.FormattingEnabled = true;
            this.CmbGrado.Location = new System.Drawing.Point(553, 49);
            this.CmbGrado.Name = "CmbGrado";
            this.CmbGrado.Size = new System.Drawing.Size(85, 33);
            this.CmbGrado.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 32);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategoria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(177, 49);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(169, 33);
            this.CmbCategoria.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 163);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(322, 275);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.panelbuscador);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(325, 139);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // FrmAdminPatience
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1380, 750);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.panelGrafica);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1330, 750);
            this.Name = "FrmAdminPatience";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelGrafica.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelCustumPequeño.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelbuscador.ResumeLayout(false);
            this.PanelContenedor.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ContenedorFiltros.ResumeLayout(false);
            this.ContenedorFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomPanel.PanelCustom panelCustumPequeño;
        private System.Windows.Forms.Label label1;
        private CustomPanel.BorderRadiusTXT borderRadiusTXT1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomPanel.RJButton rjButton3;
        private CustomPanel.RJButton rjButton2;
        private CustomPanel.BorderRadiusTXT borderRadiusTXT2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelGrafica;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelbuscador;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private CustomPanel.RJButton rjButton1;
        private CustomPanel.PanelCustom PanelContenedor;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opciones;
        private System.Windows.Forms.Panel ContenedorFiltros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox CmbEspecialidad;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        public CustomPanel.RJButton btnNew;
        public System.Windows.Forms.ComboBox CmbSeccion;
        public System.Windows.Forms.ComboBox CmbGrado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

