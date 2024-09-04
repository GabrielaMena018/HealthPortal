namespace HealthPortal.View.SectionAdministration
{
    partial class FrmAddUpdateSection
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabAcademicLevel = new System.Windows.Forms.TabControl();
            this.btnUpdateGrade = new CustomPanel.RJButton();
            this.btnAddGrade = new CustomPanel.RJButton();
            this.grpGrade = new System.Windows.Forms.GroupBox();
            this.txtGrade = new CustomPanel.BorderRadiusTXT();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateSpecialty = new CustomPanel.RJButton();
            this.btnAddSpecialty = new CustomPanel.RJButton();
            this.grpSpecialty = new System.Windows.Forms.GroupBox();
            this.txtSpecialty = new CustomPanel.BorderRadiusTXT();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateAcademicSection = new CustomPanel.RJButton();
            this.btnAddAcademicSection = new CustomPanel.RJButton();
            this.grpAcademicSection = new System.Windows.Forms.GroupBox();
            this.txtAcademicSection = new CustomPanel.BorderRadiusTXT();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateSection = new CustomPanel.RJButton();
            this.btnAddSection = new CustomPanel.RJButton();
            this.grpSection = new System.Windows.Forms.GroupBox();
            this.txtTechnicalGroup = new CustomPanel.BorderRadiusTXT();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSpecialty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAcademicSection = new System.Windows.Forms.ComboBox();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabAcademicLevel.SuspendLayout();
            this.grpGrade.SuspendLayout();
            this.grpSpecialty.SuspendLayout();
            this.grpAcademicSection.SuspendLayout();
            this.grpSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.btnUpdateGrade);
            this.tabPage4.Controls.Add(this.btnAddGrade);
            this.tabPage4.Controls.Add(this.grpGrade);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage4.ForeColor = System.Drawing.Color.Black;
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(526, 317);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Grados";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.btnUpdateAcademicSection);
            this.tabPage3.Controls.Add(this.btnAddAcademicSection);
            this.tabPage3.Controls.Add(this.grpAcademicSection);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(526, 317);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Secciones Académicas";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnUpdateSpecialty);
            this.tabPage2.Controls.Add(this.btnAddSpecialty);
            this.tabPage2.Controls.Add(this.grpSpecialty);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(526, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Especialidades";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnUpdateSection);
            this.tabPage1.Controls.Add(this.btnAddSection);
            this.tabPage1.Controls.Add(this.grpSection);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(526, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Secciones";
            // 
            // tabAcademicLevel
            // 
            this.tabAcademicLevel.Controls.Add(this.tabPage1);
            this.tabAcademicLevel.Controls.Add(this.tabPage2);
            this.tabAcademicLevel.Controls.Add(this.tabPage3);
            this.tabAcademicLevel.Controls.Add(this.tabPage4);
            this.tabAcademicLevel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAcademicLevel.Location = new System.Drawing.Point(0, 0);
            this.tabAcademicLevel.Margin = new System.Windows.Forms.Padding(0);
            this.tabAcademicLevel.Name = "tabAcademicLevel";
            this.tabAcademicLevel.Padding = new System.Drawing.Point(20, 10);
            this.tabAcademicLevel.SelectedIndex = 0;
            this.tabAcademicLevel.Size = new System.Drawing.Size(534, 360);
            this.tabAcademicLevel.TabIndex = 3;
            this.tabAcademicLevel.Tag = "AddButton";
            // 
            // btnUpdateGrade
            // 
            this.btnUpdateGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateGrade.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateGrade.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateGrade.BorderRadius = 30;
            this.btnUpdateGrade.BorderSize = 0;
            this.btnUpdateGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateGrade.FlatAppearance.BorderSize = 0;
            this.btnUpdateGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateGrade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateGrade.Location = new System.Drawing.Point(190, 260);
            this.btnUpdateGrade.Margin = new System.Windows.Forms.Padding(10);
            this.btnUpdateGrade.Name = "btnUpdateGrade";
            this.btnUpdateGrade.Size = new System.Drawing.Size(141, 39);
            this.btnUpdateGrade.TabIndex = 38;
            this.btnUpdateGrade.TabStop = false;
            this.btnUpdateGrade.Text = "Actualizar";
            this.btnUpdateGrade.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateGrade.UseVisualStyleBackColor = false;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddGrade.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddGrade.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddGrade.BorderRadius = 30;
            this.btnAddGrade.BorderSize = 0;
            this.btnAddGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGrade.FlatAppearance.BorderSize = 0;
            this.btnAddGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGrade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddGrade.Location = new System.Drawing.Point(351, 260);
            this.btnAddGrade.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(141, 39);
            this.btnAddGrade.TabIndex = 37;
            this.btnAddGrade.TabStop = false;
            this.btnAddGrade.Text = "Agregar";
            this.btnAddGrade.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddGrade.UseVisualStyleBackColor = false;
            // 
            // grpGrade
            // 
            this.grpGrade.Controls.Add(this.txtGrade);
            this.grpGrade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGrade.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpGrade.Location = new System.Drawing.Point(17, 70);
            this.grpGrade.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.grpGrade.Name = "grpGrade";
            this.grpGrade.Size = new System.Drawing.Size(475, 170);
            this.grpGrade.TabIndex = 36;
            this.grpGrade.TabStop = false;
            this.grpGrade.Text = "Información de nuevo grado";
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.SystemColors.Window;
            this.txtGrade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtGrade.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGrade.BorderRadius = 18;
            this.txtGrade.BorderSize = 2;
            this.txtGrade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtGrade.Location = new System.Drawing.Point(23, 29);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.txtGrade.MaxLength = 50;
            this.txtGrade.Multiline = false;
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.txtGrade.PasswordChar = false;
            this.txtGrade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGrade.PlaceholderText = "";
            this.txtGrade.Size = new System.Drawing.Size(429, 118);
            this.txtGrade.TabIndex = 19;
            this.txtGrade.Texts = "Grado";
            this.txtGrade.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 35;
            this.label1.Text = "Agregar Grado";
            // 
            // btnUpdateSpecialty
            // 
            this.btnUpdateSpecialty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateSpecialty.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateSpecialty.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateSpecialty.BorderRadius = 30;
            this.btnUpdateSpecialty.BorderSize = 0;
            this.btnUpdateSpecialty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSpecialty.FlatAppearance.BorderSize = 0;
            this.btnUpdateSpecialty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSpecialty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateSpecialty.Location = new System.Drawing.Point(190, 260);
            this.btnUpdateSpecialty.Margin = new System.Windows.Forms.Padding(10);
            this.btnUpdateSpecialty.Name = "btnUpdateSpecialty";
            this.btnUpdateSpecialty.Size = new System.Drawing.Size(141, 39);
            this.btnUpdateSpecialty.TabIndex = 42;
            this.btnUpdateSpecialty.TabStop = false;
            this.btnUpdateSpecialty.Text = "Actualizar";
            this.btnUpdateSpecialty.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateSpecialty.UseVisualStyleBackColor = false;
            // 
            // btnAddSpecialty
            // 
            this.btnAddSpecialty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddSpecialty.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddSpecialty.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddSpecialty.BorderRadius = 30;
            this.btnAddSpecialty.BorderSize = 0;
            this.btnAddSpecialty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSpecialty.FlatAppearance.BorderSize = 0;
            this.btnAddSpecialty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpecialty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSpecialty.Location = new System.Drawing.Point(351, 260);
            this.btnAddSpecialty.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddSpecialty.Name = "btnAddSpecialty";
            this.btnAddSpecialty.Size = new System.Drawing.Size(141, 39);
            this.btnAddSpecialty.TabIndex = 41;
            this.btnAddSpecialty.TabStop = false;
            this.btnAddSpecialty.Text = "Agregar";
            this.btnAddSpecialty.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSpecialty.UseVisualStyleBackColor = false;
            // 
            // grpSpecialty
            // 
            this.grpSpecialty.Controls.Add(this.txtSpecialty);
            this.grpSpecialty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSpecialty.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpSpecialty.Location = new System.Drawing.Point(17, 70);
            this.grpSpecialty.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.grpSpecialty.Name = "grpSpecialty";
            this.grpSpecialty.Size = new System.Drawing.Size(475, 170);
            this.grpSpecialty.TabIndex = 40;
            this.grpSpecialty.TabStop = false;
            this.grpSpecialty.Text = "Información de nueva especialidad";
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.BackColor = System.Drawing.SystemColors.Window;
            this.txtSpecialty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtSpecialty.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSpecialty.BorderRadius = 18;
            this.txtSpecialty.BorderSize = 2;
            this.txtSpecialty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtSpecialty.Location = new System.Drawing.Point(23, 29);
            this.txtSpecialty.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.txtSpecialty.MaxLength = 50;
            this.txtSpecialty.Multiline = false;
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.txtSpecialty.PasswordChar = false;
            this.txtSpecialty.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSpecialty.PlaceholderText = "";
            this.txtSpecialty.Size = new System.Drawing.Size(429, 118);
            this.txtSpecialty.TabIndex = 19;
            this.txtSpecialty.Texts = "Especialidad";
            this.txtSpecialty.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 37);
            this.label2.TabIndex = 39;
            this.label2.Text = "Agregar Especialidad";
            // 
            // btnUpdateAcademicSection
            // 
            this.btnUpdateAcademicSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateAcademicSection.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateAcademicSection.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateAcademicSection.BorderRadius = 30;
            this.btnUpdateAcademicSection.BorderSize = 0;
            this.btnUpdateAcademicSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAcademicSection.FlatAppearance.BorderSize = 0;
            this.btnUpdateAcademicSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAcademicSection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAcademicSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateAcademicSection.Location = new System.Drawing.Point(190, 260);
            this.btnUpdateAcademicSection.Margin = new System.Windows.Forms.Padding(10);
            this.btnUpdateAcademicSection.Name = "btnUpdateAcademicSection";
            this.btnUpdateAcademicSection.Size = new System.Drawing.Size(141, 39);
            this.btnUpdateAcademicSection.TabIndex = 46;
            this.btnUpdateAcademicSection.TabStop = false;
            this.btnUpdateAcademicSection.Text = "Actualizar";
            this.btnUpdateAcademicSection.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateAcademicSection.UseVisualStyleBackColor = false;
            // 
            // btnAddAcademicSection
            // 
            this.btnAddAcademicSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddAcademicSection.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddAcademicSection.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddAcademicSection.BorderRadius = 30;
            this.btnAddAcademicSection.BorderSize = 0;
            this.btnAddAcademicSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAcademicSection.FlatAppearance.BorderSize = 0;
            this.btnAddAcademicSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAcademicSection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAcademicSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddAcademicSection.Location = new System.Drawing.Point(351, 260);
            this.btnAddAcademicSection.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddAcademicSection.Name = "btnAddAcademicSection";
            this.btnAddAcademicSection.Size = new System.Drawing.Size(141, 39);
            this.btnAddAcademicSection.TabIndex = 45;
            this.btnAddAcademicSection.TabStop = false;
            this.btnAddAcademicSection.Text = "Agregar";
            this.btnAddAcademicSection.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddAcademicSection.UseVisualStyleBackColor = false;
            // 
            // grpAcademicSection
            // 
            this.grpAcademicSection.Controls.Add(this.txtAcademicSection);
            this.grpAcademicSection.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAcademicSection.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpAcademicSection.Location = new System.Drawing.Point(17, 70);
            this.grpAcademicSection.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.grpAcademicSection.Name = "grpAcademicSection";
            this.grpAcademicSection.Size = new System.Drawing.Size(475, 170);
            this.grpAcademicSection.TabIndex = 44;
            this.grpAcademicSection.TabStop = false;
            this.grpAcademicSection.Text = "Información de nueva sección académica";
            // 
            // txtAcademicSection
            // 
            this.txtAcademicSection.BackColor = System.Drawing.SystemColors.Window;
            this.txtAcademicSection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtAcademicSection.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAcademicSection.BorderRadius = 18;
            this.txtAcademicSection.BorderSize = 2;
            this.txtAcademicSection.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcademicSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtAcademicSection.Location = new System.Drawing.Point(23, 29);
            this.txtAcademicSection.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.txtAcademicSection.MaxLength = 50;
            this.txtAcademicSection.Multiline = false;
            this.txtAcademicSection.Name = "txtAcademicSection";
            this.txtAcademicSection.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.txtAcademicSection.PasswordChar = false;
            this.txtAcademicSection.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAcademicSection.PlaceholderText = "";
            this.txtAcademicSection.Size = new System.Drawing.Size(429, 118);
            this.txtAcademicSection.TabIndex = 19;
            this.txtAcademicSection.Texts = "Sección Académica";
            this.txtAcademicSection.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(10, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 37);
            this.label3.TabIndex = 43;
            this.label3.Text = "Agregar Sección Académica";
            // 
            // btnUpdateSection
            // 
            this.btnUpdateSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateSection.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateSection.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateSection.BorderRadius = 30;
            this.btnUpdateSection.BorderSize = 0;
            this.btnUpdateSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSection.FlatAppearance.BorderSize = 0;
            this.btnUpdateSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateSection.Location = new System.Drawing.Point(195, 260);
            this.btnUpdateSection.Margin = new System.Windows.Forms.Padding(10);
            this.btnUpdateSection.Name = "btnUpdateSection";
            this.btnUpdateSection.Size = new System.Drawing.Size(141, 39);
            this.btnUpdateSection.TabIndex = 46;
            this.btnUpdateSection.TabStop = false;
            this.btnUpdateSection.Text = "Actualizar";
            this.btnUpdateSection.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdateSection.UseVisualStyleBackColor = false;
            // 
            // btnAddSection
            // 
            this.btnAddSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddSection.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddSection.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddSection.BorderRadius = 30;
            this.btnAddSection.BorderSize = 0;
            this.btnAddSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSection.FlatAppearance.BorderSize = 0;
            this.btnAddSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSection.Location = new System.Drawing.Point(356, 260);
            this.btnAddSection.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(141, 39);
            this.btnAddSection.TabIndex = 45;
            this.btnAddSection.TabStop = false;
            this.btnAddSection.Text = "Agregar";
            this.btnAddSection.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSection.UseVisualStyleBackColor = false;
            // 
            // grpSection
            // 
            this.grpSection.Controls.Add(this.label7);
            this.grpSection.Controls.Add(this.cmbAcademicSection);
            this.grpSection.Controls.Add(this.label5);
            this.grpSection.Controls.Add(this.label6);
            this.grpSection.Controls.Add(this.cmbSpecialty);
            this.grpSection.Controls.Add(this.cmbGrade);
            this.grpSection.Controls.Add(this.txtTechnicalGroup);
            this.grpSection.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSection.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpSection.Location = new System.Drawing.Point(22, 70);
            this.grpSection.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.grpSection.Name = "grpSection";
            this.grpSection.Size = new System.Drawing.Size(475, 170);
            this.grpSection.TabIndex = 44;
            this.grpSection.TabStop = false;
            this.grpSection.Text = "Información de nueva sección";
            // 
            // txtTechnicalGroup
            // 
            this.txtTechnicalGroup.BackColor = System.Drawing.SystemColors.Window;
            this.txtTechnicalGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtTechnicalGroup.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTechnicalGroup.BorderRadius = 18;
            this.txtTechnicalGroup.BorderSize = 2;
            this.txtTechnicalGroup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTechnicalGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtTechnicalGroup.Location = new System.Drawing.Point(23, 89);
            this.txtTechnicalGroup.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.txtTechnicalGroup.MaxLength = 50;
            this.txtTechnicalGroup.Multiline = false;
            this.txtTechnicalGroup.Name = "txtTechnicalGroup";
            this.txtTechnicalGroup.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.txtTechnicalGroup.PasswordChar = false;
            this.txtTechnicalGroup.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTechnicalGroup.PlaceholderText = "";
            this.txtTechnicalGroup.Size = new System.Drawing.Size(204, 58);
            this.txtTechnicalGroup.TabIndex = 19;
            this.txtTechnicalGroup.Texts = "Grupo técnico";
            this.txtTechnicalGroup.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 37);
            this.label4.TabIndex = 43;
            this.label4.Text = "Agregar Sección";
            // 
            // cmbGrade
            // 
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.ItemHeight = 17;
            this.cmbGrade.Location = new System.Drawing.Point(23, 47);
            this.cmbGrade.Margin = new System.Windows.Forms.Padding(11);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(204, 25);
            this.cmbGrade.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label6.Location = new System.Drawing.Point(20, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Grado";
            // 
            // cmbSpecialty
            // 
            this.cmbSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbSpecialty.FormattingEnabled = true;
            this.cmbSpecialty.ItemHeight = 17;
            this.cmbSpecialty.Location = new System.Drawing.Point(257, 47);
            this.cmbSpecialty.Margin = new System.Windows.Forms.Padding(20);
            this.cmbSpecialty.Name = "cmbSpecialty";
            this.cmbSpecialty.Size = new System.Drawing.Size(195, 25);
            this.cmbSpecialty.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(254, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Especialidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label7.Location = new System.Drawing.Point(254, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Sección Académica";
            // 
            // cmbAcademicSection
            // 
            this.cmbAcademicSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcademicSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbAcademicSection.FormattingEnabled = true;
            this.cmbAcademicSection.ItemHeight = 17;
            this.cmbAcademicSection.Location = new System.Drawing.Point(257, 112);
            this.cmbAcademicSection.Margin = new System.Windows.Forms.Padding(20);
            this.cmbAcademicSection.Name = "cmbAcademicSection";
            this.cmbAcademicSection.Size = new System.Drawing.Size(195, 25);
            this.cmbAcademicSection.TabIndex = 26;
            // 
            // FrmAddUpdateSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 357);
            this.Controls.Add(this.tabAcademicLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAddUpdateSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabAcademicLevel.ResumeLayout(false);
            this.grpGrade.ResumeLayout(false);
            this.grpSpecialty.ResumeLayout(false);
            this.grpAcademicSection.ResumeLayout(false);
            this.grpSection.ResumeLayout(false);
            this.grpSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabControl tabAcademicLevel;
        public CustomPanel.RJButton btnUpdateGrade;
        public CustomPanel.RJButton btnAddGrade;
        private System.Windows.Forms.GroupBox grpGrade;
        public CustomPanel.BorderRadiusTXT txtGrade;
        private System.Windows.Forms.Label label1;
        public CustomPanel.RJButton btnUpdateSpecialty;
        public CustomPanel.RJButton btnAddSpecialty;
        private System.Windows.Forms.GroupBox grpSpecialty;
        public CustomPanel.BorderRadiusTXT txtSpecialty;
        private System.Windows.Forms.Label label2;
        public CustomPanel.RJButton btnUpdateAcademicSection;
        public CustomPanel.RJButton btnAddAcademicSection;
        private System.Windows.Forms.GroupBox grpAcademicSection;
        public CustomPanel.BorderRadiusTXT txtAcademicSection;
        private System.Windows.Forms.Label label3;
        public CustomPanel.RJButton btnUpdateSection;
        public CustomPanel.RJButton btnAddSection;
        private System.Windows.Forms.GroupBox grpSection;
        public CustomPanel.BorderRadiusTXT txtTechnicalGroup;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbSpecialty;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmbAcademicSection;
    }
}