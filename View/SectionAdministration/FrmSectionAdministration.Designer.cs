namespace HealthPortal.View.SectionAdministration
{
    partial class FrmSectionAdministration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmsDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsReestablishPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsViewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCustom2 = new CustomPanel.PanelCustom();
            this.tabAcademicLevel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddSection = new CustomPanel.RJButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddSpecialty = new CustomPanel.RJButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddAcademicSection = new CustomPanel.RJButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnAddGrade = new CustomPanel.RJButton();
            this.panelCustom1 = new CustomPanel.PanelCustom();
            this.dgvAcademicLevelDisplay = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.cmsDataGrid.SuspendLayout();
            this.panelCustom2.SuspendLayout();
            this.tabAcademicLevel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panelCustom1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicLevelDisplay)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(681, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Administración de Niveles Académicos";
            // 
            // cmsDataGrid
            // 
            this.cmsDataGrid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeleteUser,
            this.cmsReestablishPassword,
            this.cmsViewUser,
            this.cmsUpdateUser});
            this.cmsDataGrid.Name = "cmsDataGrid";
            this.cmsDataGrid.Size = new System.Drawing.Size(279, 92);
            // 
            // cmsDeleteUser
            // 
            this.cmsDeleteUser.Name = "cmsDeleteUser";
            this.cmsDeleteUser.Size = new System.Drawing.Size(278, 22);
            this.cmsDeleteUser.Text = "Eliminar Usuario";
            // 
            // cmsReestablishPassword
            // 
            this.cmsReestablishPassword.Name = "cmsReestablishPassword";
            this.cmsReestablishPassword.Size = new System.Drawing.Size(278, 22);
            this.cmsReestablishPassword.Text = "Reestablecer Contraseña";
            // 
            // cmsViewUser
            // 
            this.cmsViewUser.Name = "cmsViewUser";
            this.cmsViewUser.Size = new System.Drawing.Size(278, 22);
            this.cmsViewUser.Text = "Ver Información del Usuario";
            // 
            // cmsUpdateUser
            // 
            this.cmsUpdateUser.Name = "cmsUpdateUser";
            this.cmsUpdateUser.Size = new System.Drawing.Size(278, 22);
            this.cmsUpdateUser.Text = "Actualizar Información del Usuario";
            // 
            // panelCustom2
            // 
            this.panelCustom2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCustom2.BackColor = System.Drawing.Color.White;
            this.panelCustom2.BorderRadius = 30;
            this.panelCustom2.Controls.Add(this.tabAcademicLevel);
            this.panelCustom2.Controls.Add(this.panelCustom1);
            this.panelCustom2.ForeColor = System.Drawing.Color.Black;
            this.panelCustom2.GradientAngle = 90F;
            this.panelCustom2.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustom2.GradientTopColor = System.Drawing.Color.White;
            this.panelCustom2.Location = new System.Drawing.Point(41, 152);
            this.panelCustom2.Margin = new System.Windows.Forms.Padding(32);
            this.panelCustom2.Name = "panelCustom2";
            this.panelCustom2.Size = new System.Drawing.Size(1288, 641);
            this.panelCustom2.TabIndex = 1;
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
            this.tabAcademicLevel.Size = new System.Drawing.Size(1288, 140);
            this.tabAcademicLevel.TabIndex = 2;
            this.tabAcademicLevel.Tag = "AddButton";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddSection);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1280, 97);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Secciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddSection
            // 
            this.btnAddSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddSection.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddSection.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddSection.BorderRadius = 40;
            this.btnAddSection.BorderSize = 0;
            this.btnAddSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSection.FlatAppearance.BorderSize = 0;
            this.btnAddSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSection.Location = new System.Drawing.Point(1042, 26);
            this.btnAddSection.Margin = new System.Windows.Forms.Padding(23);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(212, 48);
            this.btnAddSection.TabIndex = 5;
            this.btnAddSection.Tag = "AddButton";
            this.btnAddSection.Text = "Nueva Sección";
            this.btnAddSection.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSection.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddSpecialty);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1280, 97);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Especialidades";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddSpecialty
            // 
            this.btnAddSpecialty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddSpecialty.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddSpecialty.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddSpecialty.BorderRadius = 40;
            this.btnAddSpecialty.BorderSize = 0;
            this.btnAddSpecialty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSpecialty.FlatAppearance.BorderSize = 0;
            this.btnAddSpecialty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpecialty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSpecialty.Location = new System.Drawing.Point(1042, 26);
            this.btnAddSpecialty.Margin = new System.Windows.Forms.Padding(23);
            this.btnAddSpecialty.Name = "btnAddSpecialty";
            this.btnAddSpecialty.Size = new System.Drawing.Size(212, 48);
            this.btnAddSpecialty.TabIndex = 6;
            this.btnAddSpecialty.Tag = "AddButton";
            this.btnAddSpecialty.Text = "Nueva Especialidad";
            this.btnAddSpecialty.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSpecialty.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddAcademicSection);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1280, 97);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Secciones Académicas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddAcademicSection
            // 
            this.btnAddAcademicSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddAcademicSection.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddAcademicSection.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddAcademicSection.BorderRadius = 40;
            this.btnAddAcademicSection.BorderSize = 0;
            this.btnAddAcademicSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAcademicSection.FlatAppearance.BorderSize = 0;
            this.btnAddAcademicSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAcademicSection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAcademicSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddAcademicSection.Location = new System.Drawing.Point(983, 26);
            this.btnAddAcademicSection.Margin = new System.Windows.Forms.Padding(23);
            this.btnAddAcademicSection.Name = "btnAddAcademicSection";
            this.btnAddAcademicSection.Size = new System.Drawing.Size(271, 48);
            this.btnAddAcademicSection.TabIndex = 7;
            this.btnAddAcademicSection.Tag = "AddButton";
            this.btnAddAcademicSection.Text = "Nueva Sección Académica";
            this.btnAddAcademicSection.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddAcademicSection.UseVisualStyleBackColor = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnAddGrade);
            this.tabPage4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage4.ForeColor = System.Drawing.Color.Black;
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1280, 97);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Grados";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddGrade.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddGrade.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddGrade.BorderRadius = 40;
            this.btnAddGrade.BorderSize = 0;
            this.btnAddGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGrade.FlatAppearance.BorderSize = 0;
            this.btnAddGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGrade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddGrade.Location = new System.Drawing.Point(1042, 26);
            this.btnAddGrade.Margin = new System.Windows.Forms.Padding(23);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(212, 48);
            this.btnAddGrade.TabIndex = 6;
            this.btnAddGrade.Tag = "AddButton";
            this.btnAddGrade.Text = "Nuevo Grado";
            this.btnAddGrade.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddGrade.UseVisualStyleBackColor = false;
            // 
            // panelCustom1
            // 
            this.panelCustom1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCustom1.BackColor = System.Drawing.Color.White;
            this.panelCustom1.BorderRadius = 30;
            this.panelCustom1.Controls.Add(this.dgvAcademicLevelDisplay);
            this.panelCustom1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCustom1.ForeColor = System.Drawing.Color.Black;
            this.panelCustom1.GradientAngle = 90F;
            this.panelCustom1.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustom1.GradientTopColor = System.Drawing.Color.White;
            this.panelCustom1.Location = new System.Drawing.Point(0, 139);
            this.panelCustom1.Margin = new System.Windows.Forms.Padding(32);
            this.panelCustom1.Name = "panelCustom1";
            this.panelCustom1.Size = new System.Drawing.Size(1288, 502);
            this.panelCustom1.TabIndex = 2;
            // 
            // dgvAcademicLevelDisplay
            // 
            this.dgvAcademicLevelDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAcademicLevelDisplay.BackgroundColor = System.Drawing.Color.White;
            this.dgvAcademicLevelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAcademicLevelDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcademicLevelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAcademicLevelDisplay.Location = new System.Drawing.Point(0, 0);
            this.dgvAcademicLevelDisplay.Name = "dgvAcademicLevelDisplay";
            this.dgvAcademicLevelDisplay.Size = new System.Drawing.Size(1288, 502);
            this.dgvAcademicLevelDisplay.TabIndex = 1;
            // 
            // FrmSectionAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1370, 825);
            this.Controls.Add(this.panelCustom2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1240, 825);
            this.Name = "FrmSectionAdministration";
            this.Text = "FrmUserAdministration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsDataGrid.ResumeLayout(false);
            this.panelCustom2.ResumeLayout(false);
            this.tabAcademicLevel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panelCustom1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicLevelDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.ContextMenuStrip cmsDataGrid;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteUser;
        public System.Windows.Forms.ToolStripMenuItem cmsReestablishPassword;
        public System.Windows.Forms.ToolStripMenuItem cmsViewUser;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateUser;
        public CustomPanel.PanelCustom panelCustom2;
        public CustomPanel.PanelCustom panelCustom1;
        public System.Windows.Forms.DataGridView dgvAcademicLevelDisplay;
        public System.Windows.Forms.TabControl tabAcademicLevel;
        public System.Windows.Forms.TabPage tabPage1;
        public CustomPanel.RJButton btnAddSection;
        private System.Windows.Forms.TabPage tabPage2;
        public CustomPanel.RJButton btnAddSpecialty;
        private System.Windows.Forms.TabPage tabPage3;
        public CustomPanel.RJButton btnAddAcademicSection;
        private System.Windows.Forms.TabPage tabPage4;
        public CustomPanel.RJButton btnAddGrade;
    }
}