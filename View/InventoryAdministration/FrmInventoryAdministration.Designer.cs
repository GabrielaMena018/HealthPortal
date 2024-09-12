namespace HealthPortal.View.InventoryAdministration
{
    partial class FrmInventoryAdministration
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
            this.cmsDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsView = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpInventory = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelCustom1 = new CustomControls.PanelCustom();
            this.tlpSide = new System.Windows.Forms.TableLayoutPanel();
            this.grpAddInventory = new System.Windows.Forms.GroupBox();
            this.tlpSubSide1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new CustomControls.RJButton();
            this.panelCustom2 = new CustomControls.PanelCustom();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.grpMedicineInfo = new System.Windows.Forms.GroupBox();
            this.tlpSubSide2 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSearch = new CustomControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new CustomControls.CustomTextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton1 = new CustomControls.RJButton();
            this.cmsDataGrid.SuspendLayout();
            this.tlpInventory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCustom1.SuspendLayout();
            this.tlpSide.SuspendLayout();
            this.grpAddInventory.SuspendLayout();
            this.tlpSubSide1.SuspendLayout();
            this.panelCustom2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.grpMedicineInfo.SuspendLayout();
            this.tlpSubSide2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsDataGrid
            // 
            this.cmsDataGrid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDelete,
            this.cmsView,
            this.cmsUpdate});
            this.cmsDataGrid.Name = "cmsDataGrid";
            this.cmsDataGrid.Size = new System.Drawing.Size(279, 70);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(278, 22);
            this.cmsDelete.Text = "Eliminar Usuario";
            // 
            // cmsView
            // 
            this.cmsView.Name = "cmsView";
            this.cmsView.Size = new System.Drawing.Size(278, 22);
            this.cmsView.Text = "Ver Información del Usuario";
            // 
            // cmsUpdate
            // 
            this.cmsUpdate.Name = "cmsUpdate";
            this.cmsUpdate.Size = new System.Drawing.Size(278, 22);
            this.cmsUpdate.Text = "Actualizar Información del Usuario";
            // 
            // tlpInventory
            // 
            this.tlpInventory.ColumnCount = 5;
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.830345F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.45971F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.830345F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.04926F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.830345F));
            this.tlpInventory.Controls.Add(this.panel1, 0, 0);
            this.tlpInventory.Controls.Add(this.panelCustom1, 1, 2);
            this.tlpInventory.Controls.Add(this.panelCustom2, 3, 2);
            this.tlpInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInventory.Location = new System.Drawing.Point(0, 0);
            this.tlpInventory.Name = "tlpInventory";
            this.tlpInventory.RowCount = 4;
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.630542F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.4532F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.630542F));
            this.tlpInventory.Size = new System.Drawing.Size(1370, 825);
            this.tlpInventory.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.tlpInventory.SetColumnSpan(this.panel1, 5);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 117);
            this.panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblTitle.Location = new System.Drawing.Point(32, 39);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(186, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inventario";
            // 
            // panelCustom1
            // 
            this.panelCustom1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCustom1.BackColor = System.Drawing.Color.White;
            this.panelCustom1.BorderRadius = 30;
            this.panelCustom1.Controls.Add(this.tlpSide);
            this.panelCustom1.ForeColor = System.Drawing.Color.Black;
            this.panelCustom1.GradientAngle = 90F;
            this.panelCustom1.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustom1.GradientTopColor = System.Drawing.Color.White;
            this.panelCustom1.Location = new System.Drawing.Point(38, 155);
            this.panelCustom1.Margin = new System.Windows.Forms.Padding(0);
            this.panelCustom1.Name = "panelCustom1";
            this.panelCustom1.Size = new System.Drawing.Size(348, 630);
            this.panelCustom1.TabIndex = 2;
            // 
            // tlpSide
            // 
            this.tlpSide.ColumnCount = 3;
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.85F));
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.3F));
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.85F));
            this.tlpSide.Controls.Add(this.grpAddInventory, 1, 3);
            this.tlpSide.Controls.Add(this.grpMedicineInfo, 1, 1);
            this.tlpSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSide.Location = new System.Drawing.Point(0, 0);
            this.tlpSide.Name = "tlpSide";
            this.tlpSide.RowCount = 5;
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.007008F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.26527F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.105105F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.61562F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.007008F));
            this.tlpSide.Size = new System.Drawing.Size(348, 630);
            this.tlpSide.TabIndex = 0;
            // 
            // grpAddInventory
            // 
            this.grpAddInventory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAddInventory.Controls.Add(this.tlpSubSide1);
            this.grpAddInventory.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddInventory.ForeColor = System.Drawing.Color.DarkGray;
            this.grpAddInventory.Location = new System.Drawing.Point(44, 487);
            this.grpAddInventory.Margin = new System.Windows.Forms.Padding(0);
            this.grpAddInventory.Name = "grpAddInventory";
            this.grpAddInventory.Size = new System.Drawing.Size(258, 98);
            this.grpAddInventory.TabIndex = 1;
            this.grpAddInventory.TabStop = false;
            this.grpAddInventory.Text = "Añadir Medicamentos";
            // 
            // tlpSubSide1
            // 
            this.tlpSubSide1.ColumnCount = 3;
            this.tlpSubSide1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.33F));
            this.tlpSubSide1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.34F));
            this.tlpSubSide1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.33F));
            this.tlpSubSide1.Controls.Add(this.btnNew, 1, 1);
            this.tlpSubSide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSubSide1.Location = new System.Drawing.Point(3, 17);
            this.tlpSubSide1.Name = "tlpSubSide1";
            this.tlpSubSide1.RowCount = 3;
            this.tlpSubSide1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92F));
            this.tlpSubSide1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.16F));
            this.tlpSubSide1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92F));
            this.tlpSubSide1.Size = new System.Drawing.Size(252, 78);
            this.tlpSubSide1.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnNew.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnNew.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnNew.BorderRadius = 30;
            this.btnNew.BorderSize = 0;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnNew.Location = new System.Drawing.Point(20, 20);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(210, 36);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Agregar Medicamento";
            this.btnNew.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // panelCustom2
            // 
            this.panelCustom2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCustom2.BackColor = System.Drawing.Color.White;
            this.panelCustom2.BorderRadius = 30;
            this.panelCustom2.Controls.Add(this.dgvInventory);
            this.panelCustom2.ForeColor = System.Drawing.Color.Black;
            this.panelCustom2.GradientAngle = 90F;
            this.panelCustom2.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustom2.GradientTopColor = System.Drawing.Color.White;
            this.panelCustom2.Location = new System.Drawing.Point(424, 155);
            this.panelCustom2.Margin = new System.Windows.Forms.Padding(0);
            this.panelCustom2.Name = "panelCustom2";
            this.panelCustom2.Size = new System.Drawing.Size(904, 630);
            this.panelCustom2.TabIndex = 3;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.ContextMenuStrip = this.cmsDataGrid;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.dgvInventory.Location = new System.Drawing.Point(0, 0);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.Size = new System.Drawing.Size(904, 630);
            this.dgvInventory.TabIndex = 0;
            // 
            // grpMedicineInfo
            // 
            this.grpMedicineInfo.Controls.Add(this.tlpSubSide2);
            this.grpMedicineInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMedicineInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpMedicineInfo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpMedicineInfo.Location = new System.Drawing.Point(47, 47);
            this.grpMedicineInfo.Name = "grpMedicineInfo";
            this.grpMedicineInfo.Size = new System.Drawing.Size(252, 405);
            this.grpMedicineInfo.TabIndex = 2;
            this.grpMedicineInfo.TabStop = false;
            this.grpMedicineInfo.Text = "Información de inventario";
            // 
            // tlpSubSide2
            // 
            this.tlpSubSide2.ColumnCount = 4;
            this.tlpSubSide2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.331946F));
            this.tlpSubSide2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66805F));
            this.tlpSubSide2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66805F));
            this.tlpSubSide2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.331946F));
            this.tlpSubSide2.Controls.Add(this.chart1, 1, 12);
            this.tlpSubSide2.Controls.Add(this.btnSearch, 2, 9);
            this.tlpSubSide2.Controls.Add(this.label2, 1, 11);
            this.tlpSubSide2.Controls.Add(this.label3, 1, 1);
            this.tlpSubSide2.Controls.Add(this.txtSearch, 1, 7);
            this.tlpSubSide2.Controls.Add(this.cmbCategory, 1, 2);
            this.tlpSubSide2.Controls.Add(this.label1, 1, 6);
            this.tlpSubSide2.Controls.Add(this.rjButton1, 2, 4);
            this.tlpSubSide2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSubSide2.Location = new System.Drawing.Point(3, 17);
            this.tlpSubSide2.Name = "tlpSubSide2";
            this.tlpSubSide2.RowCount = 14;
            this.tlpSubSide2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpSubSide2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpSubSide2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpSubSide2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpSubSide2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpSubSide2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpSubSide2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpSubSide2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpSubSide2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpSubSide2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpSubSide2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpSubSide2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpSubSide2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpSubSide2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpSubSide2.Size = new System.Drawing.Size(246, 385);
            this.tlpSubSide2.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.tlpSubSide2.SetColumnSpan(this.chart1, 2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(25, 329);
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
            this.chart1.Size = new System.Drawing.Size(194, 17);
            this.chart1.SuppressExceptions = true;
            this.chart1.TabIndex = 32;
            this.chart1.TabStop = false;
            this.chart1.Text = "hola";
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
            this.btnSearch.Location = new System.Drawing.Point(122, 243);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(23, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Índice de uso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tlpSubSide2.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(20, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Filtrar inventario por categoría";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.BorderSize = 2;
            this.tlpSubSide2.SetColumnSpan(this.txtSearch, 2);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtSearch.Location = new System.Drawing.Point(20, 189);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Size = new System.Drawing.Size(204, 27);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // cmbCategory
            // 
            this.tlpSubSide2.SetColumnSpan(this.cmbCategory, 2);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(20, 54);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(204, 23);
            this.cmbCategory.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tlpSubSide2.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(23, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Buscar producto del inventario";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.rjButton1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.rjButton1.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rjButton1.BorderRadius = 30;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.rjButton1.Location = new System.Drawing.Point(122, 108);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(0);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(75, 27);
            this.rjButton1.TabIndex = 30;
            this.rjButton1.Text = "Filtrar";
            this.rjButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // FrmInventoryAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1370, 825);
            this.Controls.Add(this.tlpInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1240, 825);
            this.Name = "FrmInventoryAdministration";
            this.Text = "FrmUserAdministration";
            this.cmsDataGrid.ResumeLayout(false);
            this.tlpInventory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCustom1.ResumeLayout(false);
            this.tlpSide.ResumeLayout(false);
            this.grpAddInventory.ResumeLayout(false);
            this.tlpSubSide1.ResumeLayout(false);
            this.panelCustom2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.grpMedicineInfo.ResumeLayout(false);
            this.tlpSubSide2.ResumeLayout(false);
            this.tlpSubSide2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ContextMenuStrip cmsDataGrid;
        public System.Windows.Forms.ToolStripMenuItem cmsDelete;
        public System.Windows.Forms.ToolStripMenuItem cmsView;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdate;
        private System.Windows.Forms.TableLayoutPanel tlpInventory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        public CustomControls.PanelCustom panelCustom1;
        private System.Windows.Forms.GroupBox grpAddInventory;
        public CustomControls.PanelCustom panelCustom2;
        public System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TableLayoutPanel tlpSide;
        private System.Windows.Forms.TableLayoutPanel tlpSubSide1;
        public CustomControls.RJButton btnNew;
        private System.Windows.Forms.GroupBox grpMedicineInfo;
        private System.Windows.Forms.TableLayoutPanel tlpSubSide2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public CustomControls.RJButton btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public CustomControls.CustomTextBox txtSearch;
        public System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        public CustomControls.RJButton rjButton1;
    }
}