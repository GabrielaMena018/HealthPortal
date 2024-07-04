namespace RegistroPacientes
{
    partial class FrmAddPatience
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddPatience));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbRol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtObservaciones = new CustomPanel.BorderRadiusTXT();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbMedicamentoRegistro = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PickHoraRegistro = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.PickFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CmbEspecidalidadRegistro = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtCodigoPaciente = new CustomPanel.BorderRadiusTXT();
            this.CmBGradoRegistro = new System.Windows.Forms.ComboBox();
            this.CmbSeccionRegistro = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtApellidoPaciente = new CustomPanel.BorderRadiusTXT();
            this.btnAgregarPaciente = new CustomPanel.RJButton();
            this.rjButton1 = new CustomPanel.RJButton();
            this.TxtNombrePaciente = new CustomPanel.BorderRadiusTXT();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingreso de pacientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombres";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(602, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rol";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbRol
            // 
            this.CmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRol.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbRol.FormattingEnabled = true;
            this.CmbRol.Location = new System.Drawing.Point(607, 116);
            this.CmbRol.Name = "CmbRol";
            this.CmbRol.Size = new System.Drawing.Size(156, 31);
            this.CmbRol.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(73, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Documento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(353, 62);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(283, 31);
            this.comboBox4.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(312, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Área de trabajo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Location = new System.Drawing.Point(20, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 121);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal de la Institución";
            this.groupBox1.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.maskedTextBox1.Location = new System.Drawing.Point(96, 63);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(163, 30);
            this.maskedTextBox1.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtObservaciones);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.CmbMedicamentoRegistro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.PickHoraRegistro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.PickFechaRegistro);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Location = new System.Drawing.Point(21, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 369);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visita";
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.BackColor = System.Drawing.SystemColors.Window;
            this.TxtObservaciones.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtObservaciones.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtObservaciones.BorderRadius = 20;
            this.TxtObservaciones.BorderSize = 1;
            this.TxtObservaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtObservaciones.Location = new System.Drawing.Point(16, 146);
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtObservaciones.PasswordChar = false;
            this.TxtObservaciones.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtObservaciones.PlaceholderText = "";
            this.TxtObservaciones.Size = new System.Drawing.Size(727, 198);
            this.TxtObservaciones.TabIndex = 16;
            this.TxtObservaciones.Texts = "";
            this.TxtObservaciones.UnderlinedStyle = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(11, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 28);
            this.label11.TabIndex = 21;
            this.label11.Text = "Observaciones";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbMedicamentoRegistro
            // 
            this.CmbMedicamentoRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMedicamentoRegistro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMedicamentoRegistro.FormattingEnabled = true;
            this.CmbMedicamentoRegistro.Location = new System.Drawing.Point(522, 58);
            this.CmbMedicamentoRegistro.Name = "CmbMedicamentoRegistro";
            this.CmbMedicamentoRegistro.Size = new System.Drawing.Size(224, 31);
            this.CmbMedicamentoRegistro.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(517, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 28);
            this.label10.TabIndex = 20;
            this.label10.Text = "Medicamento";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PickHoraRegistro
            // 
            this.PickHoraRegistro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickHoraRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.PickHoraRegistro.Location = new System.Drawing.Point(374, 59);
            this.PickHoraRegistro.Name = "PickHoraRegistro";
            this.PickHoraRegistro.Size = new System.Drawing.Size(112, 30);
            this.PickHoraRegistro.TabIndex = 19;
            this.PickHoraRegistro.Value = new System.DateTime(2024, 6, 24, 12, 39, 57, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(369, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "Hora ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PickFechaRegistro
            // 
            this.PickFechaRegistro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickFechaRegistro.Location = new System.Drawing.Point(16, 59);
            this.PickFechaRegistro.Name = "PickFechaRegistro";
            this.PickFechaRegistro.Size = new System.Drawing.Size(331, 30);
            this.PickFechaRegistro.TabIndex = 17;
            this.PickFechaRegistro.Value = new System.DateTime(2024, 6, 24, 12, 39, 57, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(11, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fecha ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(712, 788);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 32);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(550, 788);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(28, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 28);
            this.label12.TabIndex = 22;
            this.label12.Text = "Apellidos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.CmbEspecidalidadRegistro);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.TxtCodigoPaciente);
            this.groupBox3.Controls.Add(this.CmBGradoRegistro);
            this.groupBox3.Controls.Add(this.CmbSeccionRegistro);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox3.Location = new System.Drawing.Point(20, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(768, 121);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estudiante";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(615, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 28);
            this.label13.TabIndex = 10;
            this.label13.Text = "Sección";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbEspecidalidadRegistro
            // 
            this.CmbEspecidalidadRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEspecidalidadRegistro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEspecidalidadRegistro.FormattingEnabled = true;
            this.CmbEspecidalidadRegistro.Location = new System.Drawing.Point(232, 63);
            this.CmbEspecidalidadRegistro.Name = "CmbEspecidalidadRegistro";
            this.CmbEspecidalidadRegistro.Size = new System.Drawing.Size(221, 31);
            this.CmbEspecidalidadRegistro.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(8, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 28);
            this.label14.TabIndex = 8;
            this.label14.Text = "Código";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(227, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 28);
            this.label15.TabIndex = 14;
            this.label15.Text = "Especialidad";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodigoPaciente
            // 
            this.TxtCodigoPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCodigoPaciente.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtCodigoPaciente.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtCodigoPaciente.BorderRadius = 20;
            this.TxtCodigoPaciente.BorderSize = 1;
            this.TxtCodigoPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtCodigoPaciente.Location = new System.Drawing.Point(13, 56);
            this.TxtCodigoPaciente.Multiline = false;
            this.TxtCodigoPaciente.Name = "TxtCodigoPaciente";
            this.TxtCodigoPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtCodigoPaciente.PasswordChar = false;
            this.TxtCodigoPaciente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtCodigoPaciente.PlaceholderText = "";
            this.TxtCodigoPaciente.Size = new System.Drawing.Size(191, 38);
            this.TxtCodigoPaciente.TabIndex = 9;
            this.TxtCodigoPaciente.Texts = "";
            this.TxtCodigoPaciente.UnderlinedStyle = false;
            // 
            // CmBGradoRegistro
            // 
            this.CmBGradoRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBGradoRegistro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBGradoRegistro.FormattingEnabled = true;
            this.CmBGradoRegistro.Location = new System.Drawing.Point(471, 63);
            this.CmBGradoRegistro.Name = "CmBGradoRegistro";
            this.CmBGradoRegistro.Size = new System.Drawing.Size(110, 31);
            this.CmBGradoRegistro.TabIndex = 13;
            // 
            // CmbSeccionRegistro
            // 
            this.CmbSeccionRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSeccionRegistro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSeccionRegistro.FormattingEnabled = true;
            this.CmbSeccionRegistro.Location = new System.Drawing.Point(620, 63);
            this.CmbSeccionRegistro.Name = "CmbSeccionRegistro";
            this.CmbSeccionRegistro.Size = new System.Drawing.Size(123, 31);
            this.CmbSeccionRegistro.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(466, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 28);
            this.label16.TabIndex = 12;
            this.label16.Text = "Grado";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtApellidoPaciente
            // 
            this.TxtApellidoPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtApellidoPaciente.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtApellidoPaciente.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtApellidoPaciente.BorderRadius = 20;
            this.TxtApellidoPaciente.BorderSize = 1;
            this.TxtApellidoPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtApellidoPaciente.Location = new System.Drawing.Point(33, 192);
            this.TxtApellidoPaciente.Multiline = false;
            this.TxtApellidoPaciente.Name = "TxtApellidoPaciente";
            this.TxtApellidoPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtApellidoPaciente.PasswordChar = false;
            this.TxtApellidoPaciente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtApellidoPaciente.PlaceholderText = "";
            this.TxtApellidoPaciente.Size = new System.Drawing.Size(730, 38);
            this.TxtApellidoPaciente.TabIndex = 23;
            this.TxtApellidoPaciente.Texts = "";
            this.TxtApellidoPaciente.UnderlinedStyle = false;
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAgregarPaciente.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAgregarPaciente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAgregarPaciente.BorderRadius = 40;
            this.btnAgregarPaciente.BorderSize = 0;
            this.btnAgregarPaciente.FlatAppearance.BorderSize = 0;
            this.btnAgregarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPaciente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPaciente.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarPaciente.Location = new System.Drawing.Point(615, 780);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(148, 44);
            this.btnAgregarPaciente.TabIndex = 19;
            this.btnAgregarPaciente.Text = "Agregar";
            this.btnAgregarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPaciente.TextColor = System.Drawing.Color.Black;
            this.btnAgregarPaciente.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.rjButton1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.rjButton1.BorderRadius = 40;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(411, 780);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(196, 42);
            this.rjButton1.TabIndex = 18;
            this.rjButton1.Text = "Agregar Visita";
            this.rjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // TxtNombrePaciente
            // 
            this.TxtNombrePaciente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombrePaciente.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtNombrePaciente.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtNombrePaciente.BorderRadius = 20;
            this.TxtNombrePaciente.BorderSize = 1;
            this.TxtNombrePaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtNombrePaciente.Location = new System.Drawing.Point(36, 109);
            this.TxtNombrePaciente.Multiline = false;
            this.TxtNombrePaciente.Name = "TxtNombrePaciente";
            this.TxtNombrePaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtNombrePaciente.PasswordChar = false;
            this.TxtNombrePaciente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombrePaciente.PlaceholderText = "";
            this.TxtNombrePaciente.Size = new System.Drawing.Size(547, 38);
            this.TxtNombrePaciente.TabIndex = 6;
            this.TxtNombrePaciente.Texts = "";
            this.TxtNombrePaciente.UnderlinedStyle = false;
            // 
            // FrmAddPatience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 860);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TxtApellidoPaciente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnAgregarPaciente);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CmbRol);
            this.Controls.Add(this.TxtNombrePaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmAddPatience";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Paciente";
            this.Load += new System.EventHandler(this.FrmAddPatience_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker PickFechaRegistro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private CustomPanel.RJButton rjButton1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.ComboBox CmbRol;
        public System.Windows.Forms.ComboBox CmBGradoRegistro;
        public System.Windows.Forms.ComboBox CmbMedicamentoRegistro;
        public System.Windows.Forms.ComboBox CmbSeccionRegistro;
        public CustomPanel.BorderRadiusTXT TxtNombrePaciente;
        public System.Windows.Forms.ComboBox CmbEspecidalidadRegistro;
        public CustomPanel.BorderRadiusTXT TxtCodigoPaciente;
        public CustomPanel.BorderRadiusTXT TxtObservaciones;
        protected internal System.Windows.Forms.DateTimePicker PickHoraRegistro;
        public CustomPanel.RJButton btnAgregarPaciente;
        public CustomPanel.BorderRadiusTXT TxtApellidoPaciente;
    }
}