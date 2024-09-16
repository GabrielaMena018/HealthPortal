﻿namespace HealthPortal.View.SectionAdministration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSectionAdministration));
            this.cmsSection = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAddSection = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateSection = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteSection = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpSections = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMain = new CustomControls.PanelCustom();
            this.tlpSub = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAcademicLevelDisplay = new System.Windows.Forms.DataGridView();
            this.tabAcademicLevel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmsSpecialty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAddSpecialty = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateSpecialty = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteSpecialty = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAcademicSection = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAddASection = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateASection = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteASection = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsGrade = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAddGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTitleSub = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.cmsSection.SuspendLayout();
            this.tlpSections.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tlpSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicLevelDisplay)).BeginInit();
            this.tabAcademicLevel.SuspendLayout();
            this.cmsSpecialty.SuspendLayout();
            this.cmsAcademicSection.SuspendLayout();
            this.cmsGrade.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            this.tlpTitleSub.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsSection
            // 
            this.cmsSection.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsSection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAddSection,
            this.cmsUpdateSection,
            this.cmsDeleteSection});
            this.cmsSection.Name = "cmsDataGrid";
            this.cmsSection.Size = new System.Drawing.Size(187, 70);
            // 
            // cmsAddSection
            // 
            this.cmsAddSection.Name = "cmsAddSection";
            this.cmsAddSection.Size = new System.Drawing.Size(186, 22);
            this.cmsAddSection.Text = "Añadir sección";
            // 
            // cmsUpdateSection
            // 
            this.cmsUpdateSection.Name = "cmsUpdateSection";
            this.cmsUpdateSection.Size = new System.Drawing.Size(186, 22);
            this.cmsUpdateSection.Text = "Actualizar sección";
            // 
            // cmsDeleteSection
            // 
            this.cmsDeleteSection.Name = "cmsDeleteSection";
            this.cmsDeleteSection.Size = new System.Drawing.Size(186, 22);
            this.cmsDeleteSection.Text = "Eliminar sección";
            // 
            // tlpSections
            // 
            this.tlpSections.ColumnCount = 5;
            this.tlpSections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.830345F));
            this.tlpSections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.45971F));
            this.tlpSections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.830345F));
            this.tlpSections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.04926F));
            this.tlpSections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.830345F));
            this.tlpSections.Controls.Add(this.pnlTitle, 0, 0);
            this.tlpSections.Controls.Add(this.pnlMain, 1, 2);
            this.tlpSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSections.Location = new System.Drawing.Point(0, 0);
            this.tlpSections.Name = "tlpSections";
            this.tlpSections.RowCount = 4;
            this.tlpSections.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpSections.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.630542F));
            this.tlpSections.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.4532F));
            this.tlpSections.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.630542F));
            this.tlpSections.Size = new System.Drawing.Size(1370, 825);
            this.tlpSections.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderRadius = 30;
            this.tlpSections.SetColumnSpan(this.pnlMain, 3);
            this.pnlMain.Controls.Add(this.tlpSub);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.Black;
            this.pnlMain.GradientAngle = 90F;
            this.pnlMain.GradientBottomColor = System.Drawing.Color.White;
            this.pnlMain.GradientTopColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(38, 155);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1290, 630);
            this.pnlMain.TabIndex = 3;
            // 
            // tlpSub
            // 
            this.tlpSub.ColumnCount = 1;
            this.tlpSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSub.Controls.Add(this.dgvAcademicLevelDisplay, 0, 1);
            this.tlpSub.Controls.Add(this.tabAcademicLevel, 0, 0);
            this.tlpSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSub.Location = new System.Drawing.Point(0, 0);
            this.tlpSub.Name = "tlpSub";
            this.tlpSub.RowCount = 2;
            this.tlpSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.936508F));
            this.tlpSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.06349F));
            this.tlpSub.Size = new System.Drawing.Size(1290, 630);
            this.tlpSub.TabIndex = 0;
            // 
            // dgvAcademicLevelDisplay
            // 
            this.dgvAcademicLevelDisplay.AllowUserToAddRows = false;
            this.dgvAcademicLevelDisplay.AllowUserToDeleteRows = false;
            this.dgvAcademicLevelDisplay.AllowUserToResizeColumns = false;
            this.dgvAcademicLevelDisplay.AllowUserToResizeRows = false;
            this.dgvAcademicLevelDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAcademicLevelDisplay.BackgroundColor = System.Drawing.Color.White;
            this.dgvAcademicLevelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAcademicLevelDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAcademicLevelDisplay.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvAcademicLevelDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.NullValue = "-----";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcademicLevelDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAcademicLevelDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcademicLevelDisplay.ContextMenuStrip = this.cmsSection;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = "-----";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAcademicLevelDisplay.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAcademicLevelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAcademicLevelDisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dgvAcademicLevelDisplay.Location = new System.Drawing.Point(0, 50);
            this.dgvAcademicLevelDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.dgvAcademicLevelDisplay.MultiSelect = false;
            this.dgvAcademicLevelDisplay.Name = "dgvAcademicLevelDisplay";
            this.dgvAcademicLevelDisplay.ReadOnly = true;
            this.dgvAcademicLevelDisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.NullValue = "-----";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcademicLevelDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAcademicLevelDisplay.RowHeadersVisible = false;
            this.dgvAcademicLevelDisplay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAcademicLevelDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAcademicLevelDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAcademicLevelDisplay.Size = new System.Drawing.Size(1290, 580);
            this.dgvAcademicLevelDisplay.TabIndex = 2;
            this.dgvAcademicLevelDisplay.TabStop = false;
            // 
            // tabAcademicLevel
            // 
            this.tabAcademicLevel.Controls.Add(this.tabPage1);
            this.tabAcademicLevel.Controls.Add(this.tabPage2);
            this.tabAcademicLevel.Controls.Add(this.tabPage3);
            this.tabAcademicLevel.Controls.Add(this.tabPage4);
            this.tabAcademicLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAcademicLevel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAcademicLevel.Location = new System.Drawing.Point(0, 0);
            this.tabAcademicLevel.Margin = new System.Windows.Forms.Padding(0);
            this.tabAcademicLevel.Name = "tabAcademicLevel";
            this.tabAcademicLevel.Padding = new System.Drawing.Point(20, 15);
            this.tabAcademicLevel.SelectedIndex = 0;
            this.tabAcademicLevel.Size = new System.Drawing.Size(1290, 50);
            this.tabAcademicLevel.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 50);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(10);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(1282, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Secciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 50);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1282, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Especialidades";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 50);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1282, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Secciones Académicas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 50);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1282, 0);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Grados";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmsSpecialty
            // 
            this.cmsSpecialty.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsSpecialty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAddSpecialty,
            this.cmsUpdateSpecialty,
            this.cmsDeleteSpecialty});
            this.cmsSpecialty.Name = "cmsDataGrid";
            this.cmsSpecialty.Size = new System.Drawing.Size(218, 70);
            // 
            // cmsAddSpecialty
            // 
            this.cmsAddSpecialty.Name = "cmsAddSpecialty";
            this.cmsAddSpecialty.Size = new System.Drawing.Size(217, 22);
            this.cmsAddSpecialty.Text = "Añadir especialidad";
            // 
            // cmsUpdateSpecialty
            // 
            this.cmsUpdateSpecialty.Name = "cmsUpdateSpecialty";
            this.cmsUpdateSpecialty.Size = new System.Drawing.Size(217, 22);
            this.cmsUpdateSpecialty.Text = "Actualizar especialidad";
            // 
            // cmsDeleteSpecialty
            // 
            this.cmsDeleteSpecialty.Name = "cmsDeleteSpecialty";
            this.cmsDeleteSpecialty.Size = new System.Drawing.Size(217, 22);
            this.cmsDeleteSpecialty.Text = "Eliminar especialidad";
            // 
            // cmsAcademicSection
            // 
            this.cmsAcademicSection.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsAcademicSection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAddASection,
            this.cmsUpdateASection,
            this.cmsDeleteASection});
            this.cmsAcademicSection.Name = "cmsDataGrid";
            this.cmsAcademicSection.Size = new System.Drawing.Size(260, 70);
            // 
            // cmsAddASection
            // 
            this.cmsAddASection.Name = "cmsAddASection";
            this.cmsAddASection.Size = new System.Drawing.Size(259, 22);
            this.cmsAddASection.Text = "Añadir sección académica";
            // 
            // cmsUpdateASection
            // 
            this.cmsUpdateASection.Name = "cmsUpdateASection";
            this.cmsUpdateASection.Size = new System.Drawing.Size(259, 22);
            this.cmsUpdateASection.Text = "Actualizar sección académica";
            // 
            // cmsDeleteASection
            // 
            this.cmsDeleteASection.Name = "cmsDeleteASection";
            this.cmsDeleteASection.Size = new System.Drawing.Size(259, 22);
            this.cmsDeleteASection.Text = "Eliminar sección académica";
            // 
            // cmsGrade
            // 
            this.cmsGrade.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsGrade.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAddGrade,
            this.cmsUpdateGrade,
            this.cmsDeleteGrade});
            this.cmsGrade.Name = "cmsDataGrid";
            this.cmsGrade.Size = new System.Drawing.Size(176, 70);
            // 
            // cmsAddGrade
            // 
            this.cmsAddGrade.Name = "cmsAddGrade";
            this.cmsAddGrade.Size = new System.Drawing.Size(175, 22);
            this.cmsAddGrade.Text = "Añadir grado";
            // 
            // cmsUpdateGrade
            // 
            this.cmsUpdateGrade.Name = "cmsUpdateGrade";
            this.cmsUpdateGrade.Size = new System.Drawing.Size(175, 22);
            this.cmsUpdateGrade.Text = "Actualizar grado";
            // 
            // cmsDeleteGrade
            // 
            this.cmsDeleteGrade.Name = "cmsDeleteGrade";
            this.cmsDeleteGrade.Size = new System.Drawing.Size(175, 22);
            this.cmsDeleteGrade.Text = "Eliminar grado";
            // 
            // pnlTitle
            // 
            this.pnlTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.tlpSections.SetColumnSpan(this.pnlTitle, 5);
            this.pnlTitle.Controls.Add(this.tlpTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1370, 117);
            this.pnlTitle.TabIndex = 4;
            // 
            // tlpTitle
            // 
            this.tlpTitle.ColumnCount = 2;
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.9927F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0073F));
            this.tlpTitle.Controls.Add(this.tlpTitleSub, 0, 0);
            this.tlpTitle.Controls.Add(this.tlpControls, 1, 0);
            this.tlpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitle.Location = new System.Drawing.Point(0, 0);
            this.tlpTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 1;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tlpTitle.Size = new System.Drawing.Size(1370, 117);
            this.tlpTitle.TabIndex = 0;
            // 
            // tlpTitleSub
            // 
            this.tlpTitleSub.ColumnCount = 3;
            this.tlpTitleSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0022F));
            this.tlpTitleSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.9956F));
            this.tlpTitleSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0022F));
            this.tlpTitleSub.Controls.Add(this.lblTitle, 1, 1);
            this.tlpTitleSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitleSub.Location = new System.Drawing.Point(0, 0);
            this.tlpTitleSub.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitleSub.Name = "tlpTitleSub";
            this.tlpTitleSub.RowCount = 3;
            this.tlpTitleSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpTitleSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpTitleSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTitleSub.Size = new System.Drawing.Size(1000, 117);
            this.tlpTitleSub.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblTitle.Location = new System.Drawing.Point(50, 40);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(899, 46);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Adminstración de Niveles Académicos";
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 5;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86792F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.886792F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86792F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.37736F));
            this.tlpControls.Controls.Add(this.btnExit, 3, 1);
            this.tlpControls.Controls.Add(this.btnResize, 1, 1);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(1000, 0);
            this.tlpControls.Margin = new System.Windows.Forms.Padding(0);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 3;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControls.Size = new System.Drawing.Size(370, 117);
            this.tlpControls.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::HealthPortal.Properties.Resources.quit;
            this.btnExit.Location = new System.Drawing.Point(260, 39);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 39);
            this.btnExit.TabIndex = 38;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnResize
            // 
            this.btnResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResize.FlatAppearance.BorderSize = 0;
            this.btnResize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnResize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResize.ForeColor = System.Drawing.Color.White;
            this.btnResize.Image = ((System.Drawing.Image)(resources.GetObject("btnResize.Image")));
            this.btnResize.Location = new System.Drawing.Point(185, 39);
            this.btnResize.Margin = new System.Windows.Forms.Padding(0);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(69, 39);
            this.btnResize.TabIndex = 39;
            this.btnResize.TabStop = false;
            this.btnResize.UseVisualStyleBackColor = false;
            // 
            // FrmSectionAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1370, 825);
            this.Controls.Add(this.tlpSections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSectionAdministration";
            this.Text = "HealthPortal | Inventario";
            this.cmsSection.ResumeLayout(false);
            this.tlpSections.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.tlpSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicLevelDisplay)).EndInit();
            this.tabAcademicLevel.ResumeLayout(false);
            this.cmsSpecialty.ResumeLayout(false);
            this.cmsAcademicSection.ResumeLayout(false);
            this.cmsGrade.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitleSub.ResumeLayout(false);
            this.tlpTitleSub.PerformLayout();
            this.tlpControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ContextMenuStrip cmsSection;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteSection;
        public System.Windows.Forms.ToolStripMenuItem cmsAddSection;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateSection;
        private System.Windows.Forms.TableLayoutPanel tlpSections;
        public CustomControls.PanelCustom pnlMain;
        private System.Windows.Forms.TableLayoutPanel tlpSub;
        public System.Windows.Forms.TabControl tabAcademicLevel;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.DataGridView dgvAcademicLevelDisplay;
        public System.Windows.Forms.ContextMenuStrip cmsSpecialty;
        public System.Windows.Forms.ToolStripMenuItem cmsAddSpecialty;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateSpecialty;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteSpecialty;
        public System.Windows.Forms.ContextMenuStrip cmsAcademicSection;
        public System.Windows.Forms.ToolStripMenuItem cmsAddASection;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateASection;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteASection;
        public System.Windows.Forms.ContextMenuStrip cmsGrade;
        public System.Windows.Forms.ToolStripMenuItem cmsAddGrade;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateGrade;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteGrade;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.TableLayoutPanel tlpTitle;
        private System.Windows.Forms.TableLayoutPanel tlpTitleSub;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnResize;
    }
}