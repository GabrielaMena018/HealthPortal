namespace HealthPortal.View.PatientAdministration
{
    partial class FrmAddUpdatePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUpdatePatient));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservations = new CustomPanel.BorderRadiusTXT();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbMedicamentoRegistro = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpRegisterTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupStudent = new System.Windows.Forms.GroupBox();
            this.txtGrupo = new CustomPanel.BorderRadiusTXT();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbRegisterSpecialty = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPatientCode = new CustomPanel.BorderRadiusTXT();
            this.CmBGradoRegistro = new System.Windows.Forms.ComboBox();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtId = new System.Windows.Forms.ToolStripTextBox();
            this.txtPatientLastName = new CustomPanel.BorderRadiusTXT();
            this.btnAddPatient = new CustomPanel.RJButton();
            this.btnUpdate = new CustomPanel.RJButton();
            this.txtPatientName = new CustomPanel.BorderRadiusTXT();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.btnPDF = new CustomPanel.RJButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupStudent.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingreso de pacientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombres";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(396, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rol";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(393, 94);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(180, 27);
            this.cmbRole.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObservations);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmbMedicamentoRegistro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtpRegisterTime);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtpRegisterDate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Location = new System.Drawing.Point(16, 329);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(576, 300);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visita";
            // 
            // txtObservations
            // 
            this.txtObservations.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservations.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtObservations.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtObservations.BorderRadius = 20;
            this.txtObservations.BorderSize = 1;
            this.txtObservations.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObservations.Location = new System.Drawing.Point(12, 119);
            this.txtObservations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtObservations.PasswordChar = false;
            this.txtObservations.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtObservations.PlaceholderText = "";
            this.txtObservations.Size = new System.Drawing.Size(545, 161);
            this.txtObservations.TabIndex = 12;
            this.txtObservations.Texts = "";
            this.txtObservations.UnderlinedStyle = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(8, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "Observaciones";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMedicamentoRegistro
            // 
            this.cmbMedicamentoRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicamentoRegistro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicamentoRegistro.FormattingEnabled = true;
            this.cmbMedicamentoRegistro.ItemHeight = 19;
            this.cmbMedicamentoRegistro.Location = new System.Drawing.Point(392, 47);
            this.cmbMedicamentoRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMedicamentoRegistro.Name = "cmbMedicamentoRegistro";
            this.cmbMedicamentoRegistro.Size = new System.Drawing.Size(169, 27);
            this.cmbMedicamentoRegistro.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(388, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Medicamento";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpRegisterTime
            // 
            this.dtpRegisterTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegisterTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRegisterTime.Location = new System.Drawing.Point(280, 48);
            this.dtpRegisterTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpRegisterTime.Name = "dtpRegisterTime";
            this.dtpRegisterTime.Size = new System.Drawing.Size(85, 26);
            this.dtpRegisterTime.TabIndex = 10;
            this.dtpRegisterTime.Value = new System.DateTime(2024, 6, 24, 12, 39, 57, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(277, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Time ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegisterDate.Location = new System.Drawing.Point(12, 48);
            this.dtpRegisterDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(249, 26);
            this.dtpRegisterDate.TabIndex = 9;
            this.dtpRegisterDate.Value = new System.DateTime(2024, 7, 18, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(8, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "date ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(452, 644);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 26);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 645);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(21, 131);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "Apellidos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupStudent
            // 
            this.groupStudent.Controls.Add(this.txtGrupo);
            this.groupStudent.Controls.Add(this.label5);
            this.groupStudent.Controls.Add(this.label13);
            this.groupStudent.Controls.Add(this.cmbRegisterSpecialty);
            this.groupStudent.Controls.Add(this.label14);
            this.groupStudent.Controls.Add(this.label15);
            this.groupStudent.Controls.Add(this.txtPatientCode);
            this.groupStudent.Controls.Add(this.CmBGradoRegistro);
            this.groupStudent.Controls.Add(this.cmbSection);
            this.groupStudent.Controls.Add(this.label16);
            this.groupStudent.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupStudent.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupStudent.Location = new System.Drawing.Point(16, 209);
            this.groupStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupStudent.Name = "groupStudent";
            this.groupStudent.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupStudent.Size = new System.Drawing.Size(576, 98);
            this.groupStudent.TabIndex = 17;
            this.groupStudent.TabStop = false;
            this.groupStudent.Text = "Estudiante";
            // 
            // txtGrupo
            // 
            this.txtGrupo.BackColor = System.Drawing.SystemColors.Window;
            this.txtGrupo.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGrupo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGrupo.BorderRadius = 0;
            this.txtGrupo.BorderSize = 1;
            this.txtGrupo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGrupo.Location = new System.Drawing.Point(293, 47);
            this.txtGrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGrupo.Multiline = false;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtGrupo.PasswordChar = false;
            this.txtGrupo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGrupo.PlaceholderText = "";
            this.txtGrupo.Size = new System.Drawing.Size(79, 32);
            this.txtGrupo.TabIndex = 6;
            this.txtGrupo.Texts = "";
            this.txtGrupo.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(294, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Grupo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(483, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 21);
            this.label13.TabIndex = 10;
            this.label13.Text = "Sección";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbRegisterSpecialty
            // 
            this.cmbRegisterSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegisterSpecialty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRegisterSpecialty.FormattingEnabled = true;
            this.cmbRegisterSpecialty.Location = new System.Drawing.Point(130, 49);
            this.cmbRegisterSpecialty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRegisterSpecialty.Name = "cmbRegisterSpecialty";
            this.cmbRegisterSpecialty.Size = new System.Drawing.Size(150, 27);
            this.cmbRegisterSpecialty.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(6, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 21);
            this.label14.TabIndex = 8;
            this.label14.Text = "Código";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(126, 22);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 21);
            this.label15.TabIndex = 14;
            this.label15.Text = "Especialidad";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPatientCode
            // 
            this.txtPatientCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtPatientCode.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPatientCode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPatientCode.BorderRadius = 20;
            this.txtPatientCode.BorderSize = 1;
            this.txtPatientCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatientCode.Location = new System.Drawing.Point(10, 46);
            this.txtPatientCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPatientCode.Multiline = false;
            this.txtPatientCode.Name = "txtPatientCode";
            this.txtPatientCode.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtPatientCode.PasswordChar = false;
            this.txtPatientCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPatientCode.PlaceholderText = "";
            this.txtPatientCode.Size = new System.Drawing.Size(104, 32);
            this.txtPatientCode.TabIndex = 4;
            this.txtPatientCode.Texts = "";
            this.txtPatientCode.UnderlinedStyle = false;
            // 
            // CmBGradoRegistro
            // 
            this.CmBGradoRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBGradoRegistro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBGradoRegistro.FormattingEnabled = true;
            this.CmBGradoRegistro.Location = new System.Drawing.Point(392, 51);
            this.CmBGradoRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmBGradoRegistro.Name = "CmBGradoRegistro";
            this.CmBGradoRegistro.Size = new System.Drawing.Size(84, 27);
            this.CmBGradoRegistro.TabIndex = 7;
            // 
            // cmbSection
            // 
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(487, 51);
            this.cmbSection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(72, 27);
            this.cmbSection.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(390, 24);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 21);
            this.label16.TabIndex = 12;
            this.label16.Text = "Grado";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtId});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 27);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            // 
            // txtPatientLastName
            // 
            this.txtPatientLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtPatientLastName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPatientLastName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPatientLastName.BorderRadius = 20;
            this.txtPatientLastName.BorderSize = 1;
            this.txtPatientLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatientLastName.Location = new System.Drawing.Point(25, 156);
            this.txtPatientLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPatientLastName.Multiline = false;
            this.txtPatientLastName.Name = "txtPatientLastName";
            this.txtPatientLastName.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtPatientLastName.PasswordChar = false;
            this.txtPatientLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPatientLastName.PlaceholderText = "";
            this.txtPatientLastName.Size = new System.Drawing.Size(548, 32);
            this.txtPatientLastName.TabIndex = 3;
            this.txtPatientLastName.Texts = "";
            this.txtPatientLastName.UnderlinedStyle = false;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddPatient.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddPatient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddPatient.BorderRadius = 40;
            this.btnAddPatient.BorderSize = 0;
            this.btnAddPatient.Enabled = false;
            this.btnAddPatient.FlatAppearance.BorderSize = 0;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.ForeColor = System.Drawing.Color.Black;
            this.btnAddPatient.Location = new System.Drawing.Point(380, 638);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(111, 36);
            this.btnAddPatient.TabIndex = 19;
            this.btnAddPatient.Text = "Agregar";
            this.btnAddPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPatient.TextColor = System.Drawing.Color.Black;
            this.btnAddPatient.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdate.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdate.BorderRadius = 40;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(243, 639);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 34);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextColor = System.Drawing.Color.Black;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.SystemColors.Window;
            this.txtPatientName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPatientName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPatientName.BorderRadius = 20;
            this.txtPatientName.BorderSize = 1;
            this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatientName.Location = new System.Drawing.Point(27, 89);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPatientName.Multiline = false;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtPatientName.PasswordChar = false;
            this.txtPatientName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPatientName.PlaceholderText = "";
            this.txtPatientName.Size = new System.Drawing.Size(353, 32);
            this.txtPatientName.TabIndex = 1;
            this.txtPatientName.Texts = "";
            this.txtPatientName.UnderlinedStyle = false;
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(544, 649);
            this.pic2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(20, 23);
            this.pic2.TabIndex = 19;
            this.pic2.TabStop = false;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDF.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDF.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDF.BorderRadius = 40;
            this.btnPDF.BorderSize = 0;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Location = new System.Drawing.Point(500, 639);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(72, 37);
            this.btnPDF.TabIndex = 18;
            this.btnPDF.Text = "PDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDF.TextColor = System.Drawing.Color.White;
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // FrmAddUpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 699);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.groupStudent);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.txtPatientLastName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAddUpdatePatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Paciente";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupStudent.ResumeLayout(false);
            this.groupStudent.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.ComboBox cmbRole;
        public System.Windows.Forms.ComboBox CmBGradoRegistro;
        public System.Windows.Forms.ComboBox cmbMedicamentoRegistro;
        public System.Windows.Forms.ComboBox cmbSection;
        public CustomPanel.BorderRadiusTXT txtPatientName;
        public System.Windows.Forms.ComboBox cmbRegisterSpecialty;
        public CustomPanel.BorderRadiusTXT txtPatientCode;
        public CustomPanel.BorderRadiusTXT txtObservations;
        public CustomPanel.RJButton btnAddPatient;
        public CustomPanel.BorderRadiusTXT txtPatientLastName;
        public System.Windows.Forms.DateTimePicker dtpRegisterDate;
        public System.Windows.Forms.DateTimePicker dtpRegisterTime;
        public CustomPanel.BorderRadiusTXT txtGrupo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.GroupBox groupStudent;
        public CustomPanel.RJButton btnUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripTextBox txtId;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox1;
        public CustomPanel.RJButton btnPDF;
        public System.Windows.Forms.PictureBox pic2;
    }
}