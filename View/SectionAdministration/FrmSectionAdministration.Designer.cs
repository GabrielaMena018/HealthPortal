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
            this.cmsGrade = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAddGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAcademicSection = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteASection = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateASection = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAddASection = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCustom2 = new CustomControls.PanelCustom();
            this.tabAcademicLevel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panelCustom1 = new CustomControls.PanelCustom();
            this.dgvAcademicLevelDisplay = new System.Windows.Forms.DataGridView();
            this.cmsSpecialty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAddSpecialty = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateSpecialty = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteSpecialty = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSection = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAddSection = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateSection = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteSection = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.cmsGrade.SuspendLayout();
            this.cmsAcademicSection.SuspendLayout();
            this.panelCustom2.SuspendLayout();
            this.tabAcademicLevel.SuspendLayout();
            this.panelCustom1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicLevelDisplay)).BeginInit();
            this.cmsSpecialty.SuspendLayout();
            this.cmsSection.SuspendLayout();
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
            // cmsGrade
            // 
            this.cmsGrade.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsGrade.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAddGrade,
            this.cmsUpdateGrade,
            this.cmsDeleteGrade});
            this.cmsGrade.Name = "cmsDataGrid";
            this.cmsGrade.Size = new System.Drawing.Size(178, 70);
            // 
            // cmsDeleteGrade
            // 
            this.cmsDeleteGrade.Name = "cmsDeleteGrade";
            this.cmsDeleteGrade.Size = new System.Drawing.Size(177, 22);
            this.cmsDeleteGrade.Text = "Eliminar Grado";
            // 
            // cmsUpdateGrade
            // 
            this.cmsUpdateGrade.Name = "cmsUpdateGrade";
            this.cmsUpdateGrade.Size = new System.Drawing.Size(177, 22);
            this.cmsUpdateGrade.Text = "Actualizar Grado";
            // 
            // cmsAddGrade
            // 
            this.cmsAddGrade.Name = "cmsAddGrade";
            this.cmsAddGrade.Size = new System.Drawing.Size(177, 22);
            this.cmsAddGrade.Text = "Agregar Grado";
            // 
            // cmsAcademicSection
            // 
            this.cmsAcademicSection.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsAcademicSection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAddASection,
            this.cmsUpdateASection,
            this.cmsDeleteASection});
            this.cmsAcademicSection.Name = "cmsDataGrid";
            this.cmsAcademicSection.Size = new System.Drawing.Size(263, 92);
            // 
            // cmsDeleteASection
            // 
            this.cmsDeleteASection.Name = "cmsDeleteASection";
            this.cmsDeleteASection.Size = new System.Drawing.Size(262, 22);
            this.cmsDeleteASection.Text = "Eliminar Sección Académica";
            // 
            // cmsUpdateASection
            // 
            this.cmsUpdateASection.Name = "cmsUpdateASection";
            this.cmsUpdateASection.Size = new System.Drawing.Size(262, 22);
            this.cmsUpdateASection.Text = "Actualizar Sección Académica";
            // 
            // cmsAddASection
            // 
            this.cmsAddASection.Name = "cmsAddASection";
            this.cmsAddASection.Size = new System.Drawing.Size(262, 22);
            this.cmsAddASection.Text = "Agregar Sección Académica";
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
            this.tabAcademicLevel.Size = new System.Drawing.Size(1288, 38);
            this.tabAcademicLevel.TabIndex = 2;
            this.tabAcademicLevel.Tag = "AddButton";
            // 
            // tabPage1
            // 
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1280, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Secciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1280, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Especialidades";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1280, 97);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Secciones Académicas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage4.ForeColor = System.Drawing.Color.Black;
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1280, 0);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Grados";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.panelCustom1.Location = new System.Drawing.Point(0, 39);
            this.panelCustom1.Margin = new System.Windows.Forms.Padding(32);
            this.panelCustom1.Name = "panelCustom1";
            this.panelCustom1.Size = new System.Drawing.Size(1288, 602);
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
            this.dgvAcademicLevelDisplay.Size = new System.Drawing.Size(1288, 602);
            this.dgvAcademicLevelDisplay.TabIndex = 1;
            // 
            // cmsSpecialty
            // 
            this.cmsSpecialty.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsSpecialty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAddSpecialty,
            this.cmsUpdateSpecialty,
            this.cmsDeleteSpecialty});
            this.cmsSpecialty.Name = "cmsDataGrid";
            this.cmsSpecialty.Size = new System.Drawing.Size(216, 70);
            // 
            // cmsAddSpecialty
            // 
            this.cmsAddSpecialty.Name = "cmsAddSpecialty";
            this.cmsAddSpecialty.Size = new System.Drawing.Size(215, 22);
            this.cmsAddSpecialty.Text = "Agregar Especialidad";
            // 
            // cmsUpdateSpecialty
            // 
            this.cmsUpdateSpecialty.Name = "cmsUpdateSpecialty";
            this.cmsUpdateSpecialty.Size = new System.Drawing.Size(215, 22);
            this.cmsUpdateSpecialty.Text = "Actualizar Especialidad";
            // 
            // cmsDeleteSpecialty
            // 
            this.cmsDeleteSpecialty.Name = "cmsDeleteSpecialty";
            this.cmsDeleteSpecialty.Size = new System.Drawing.Size(215, 22);
            this.cmsDeleteSpecialty.Text = "Eliminar Especialidad";
            // 
            // cmsSection
            // 
            this.cmsSection.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsSection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAddSection,
            this.cmsUpdateSection,
            this.cmsDeleteSection});
            this.cmsSection.Name = "cmsDataGrid";
            this.cmsSection.Size = new System.Drawing.Size(189, 70);
            // 
            // cmsAddSection
            // 
            this.cmsAddSection.Name = "cmsAddSection";
            this.cmsAddSection.Size = new System.Drawing.Size(188, 22);
            this.cmsAddSection.Text = "Agregar Sección";
            // 
            // cmsUpdateSection
            // 
            this.cmsUpdateSection.Name = "cmsUpdateSection";
            this.cmsUpdateSection.Size = new System.Drawing.Size(188, 22);
            this.cmsUpdateSection.Text = "Actualizar Sección";
            // 
            // cmsDeleteSection
            // 
            this.cmsDeleteSection.Name = "cmsDeleteSection";
            this.cmsDeleteSection.Size = new System.Drawing.Size(188, 22);
            this.cmsDeleteSection.Text = "Eliminar Sección";
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
            this.cmsGrade.ResumeLayout(false);
            this.cmsAcademicSection.ResumeLayout(false);
            this.panelCustom2.ResumeLayout(false);
            this.tabAcademicLevel.ResumeLayout(false);
            this.panelCustom1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicLevelDisplay)).EndInit();
            this.cmsSpecialty.ResumeLayout(false);
            this.cmsSection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.ContextMenuStrip cmsGrade;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteGrade;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateGrade;
        public CustomControls.PanelCustom panelCustom2;
        public CustomControls.PanelCustom panelCustom1;
        public System.Windows.Forms.DataGridView dgvAcademicLevelDisplay;
        public System.Windows.Forms.TabControl tabAcademicLevel;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.ContextMenuStrip cmsAcademicSection;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteASection;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateASection;
        public System.Windows.Forms.ToolStripMenuItem cmsAddASection;
        public System.Windows.Forms.ToolStripMenuItem cmsAddGrade;
        public System.Windows.Forms.ContextMenuStrip cmsSpecialty;
        public System.Windows.Forms.ToolStripMenuItem cmsAddSpecialty;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateSpecialty;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteSpecialty;
        public System.Windows.Forms.ContextMenuStrip cmsSection;
        public System.Windows.Forms.ToolStripMenuItem cmsAddSection;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateSection;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteSection;
    }
}