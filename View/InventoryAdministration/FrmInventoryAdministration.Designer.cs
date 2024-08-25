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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelGrafica = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelCustumPequeño = new CustomPanel.PanelCustom();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnPrintReport = new CustomPanel.RJButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelbuscador = new System.Windows.Forms.Panel();
            this.btnSearch = new CustomPanel.RJButton();
            this.txtSearch = new CustomPanel.BorderRadiusTXT();
            this.cmsDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsView = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelContenedor = new CustomPanel.PanelCustom();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.ContenedorFiltros = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNew = new CustomPanel.RJButton();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.panelGrafica.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelCustumPequeño.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelbuscador.SuspendLayout();
            this.cmsDataGrid.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.ContenedorFiltros.SuspendLayout();
            this.SuspendLayout();
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
            this.panelGrafica.Size = new System.Drawing.Size(325, 663);
            this.panelGrafica.TabIndex = 2;
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.panelCustumPequeño);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitulo.Location = new System.Drawing.Point(0, 133);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(325, 530);
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
            this.panelCustumPequeño.Size = new System.Drawing.Size(325, 530);
            this.panelCustumPequeño.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chart1);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(325, 405);
            this.panel6.TabIndex = 15;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 163);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
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
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Indice de Uso";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(16, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(174, 36);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "Esta Semana";
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.pictureBox5);
            this.panelButton.Controls.Add(this.btnPrintReport);
            this.panelButton.Controls.Add(this.pictureBox3);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 405);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(325, 125);
            this.panelButton.TabIndex = 14;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.btnPrintReport.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.btnPrintReport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.btnPrintReport.BorderRadius = 40;
            this.btnPrintReport.BorderSize = 0;
            this.btnPrintReport.FlatAppearance.BorderSize = 0;
            this.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReport.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.ForeColor = System.Drawing.Color.White;
            this.btnPrintReport.Location = new System.Drawing.Point(117, 60);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(188, 47);
            this.btnPrintReport.TabIndex = 11;
            this.btnPrintReport.Text = "Imprimir Reporte";
            this.btnPrintReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintReport.TextColor = System.Drawing.Color.White;
            this.btnPrintReport.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.panelbuscador);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(325, 133);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventario";
            // 
            // panelbuscador
            // 
            this.panelbuscador.Controls.Add(this.btnSearch);
            this.panelbuscador.Controls.Add(this.txtSearch);
            this.panelbuscador.Location = new System.Drawing.Point(3, 79);
            this.panelbuscador.Name = "panelbuscador";
            this.panelbuscador.Size = new System.Drawing.Size(319, 55);
            this.panelbuscador.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackGroundColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = global::HealthPortal.Properties.Resources.busqueda__1_;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.BorderColor = System.Drawing.Color.White;
            this.btnSearch.BorderRadius = 40;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(270, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = " ";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.White;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Size = new System.Drawing.Size(313, 43);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Texts = "Buscar";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // cmsDataGrid
            // 
            this.cmsDataGrid.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDelete,
            this.cmsUpdate,
            this.cmsView,
            this.cmsPDF});
            this.cmsDataGrid.Name = "cmsDataGrid";
            this.cmsDataGrid.Size = new System.Drawing.Size(204, 100);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(203, 24);
            this.cmsDelete.Text = "Eliminar Registro";
            // 
            // cmsUpdate
            // 
            this.cmsUpdate.Name = "cmsUpdate";
            this.cmsUpdate.Size = new System.Drawing.Size(203, 24);
            this.cmsUpdate.Text = "Actualizar Registro";
            // 
            // cmsView
            // 
            this.cmsView.Name = "cmsView";
            this.cmsView.Size = new System.Drawing.Size(203, 24);
            this.cmsView.Text = "Ver registro";
            // 
            // cmsPDF
            // 
            this.cmsPDF.Name = "cmsPDF";
            this.cmsPDF.Size = new System.Drawing.Size(203, 24);
            this.cmsPDF.Text = "Imprimir PDF";
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
            this.PanelContenedor.Location = new System.Drawing.Point(402, 20);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(10);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Padding = new System.Windows.Forms.Padding(0, 4, 4, 15);
            this.PanelContenedor.Size = new System.Drawing.Size(940, 663);
            this.PanelContenedor.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvInventory);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 104);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(936, 544);
            this.panel8.TabIndex = 15;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeColumns = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.ColumnHeadersHeight = 50;
            this.dgvInventory.ContextMenuStrip = this.cmsDataGrid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.EnableHeadersVisualStyles = false;
            this.dgvInventory.Location = new System.Drawing.Point(0, 0);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidth = 25;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(936, 544);
            this.dgvInventory.TabIndex = 0;
            // 
            // ContenedorFiltros
            // 
            this.ContenedorFiltros.Controls.Add(this.label6);
            this.ContenedorFiltros.Controls.Add(this.btnNew);
            this.ContenedorFiltros.Controls.Add(this.CmbCategoria);
            this.ContenedorFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContenedorFiltros.Location = new System.Drawing.Point(0, 4);
            this.ContenedorFiltros.Name = "ContenedorFiltros";
            this.ContenedorFiltros.Size = new System.Drawing.Size(936, 100);
            this.ContenedorFiltros.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(43, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Categoria";
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
            this.btnNew.Location = new System.Drawing.Point(710, 36);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(209, 46);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Agregar Medicamento";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextColor = System.Drawing.Color.Black;
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategoria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(47, 42);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(228, 33);
            this.CmbCategoria.TabIndex = 5;
            // 
            // FrmInventoryAdministration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1362, 703);
            this.Controls.Add(this.panelGrafica);
            this.Controls.Add(this.PanelContenedor);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventoryAdministration";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "FrmAdminInventary";
            this.panelGrafica.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelCustumPequeño.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelbuscador.ResumeLayout(false);
            this.cmsDataGrid.ResumeLayout(false);
            this.PanelContenedor.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ContenedorFiltros.ResumeLayout(false);
            this.ContenedorFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel.PanelCustom PanelContenedor;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel ContenedorFiltros;
        private System.Windows.Forms.Label label6;
        public CustomPanel.RJButton btnNew;
        public System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.Panel panelGrafica;
        private System.Windows.Forms.Panel panelTitulo;
        private CustomPanel.PanelCustom panelCustumPequeño;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelbuscador;
        public System.Windows.Forms.DataGridView dgvInventory;
        public System.Windows.Forms.ContextMenuStrip cmsDataGrid;
        public System.Windows.Forms.ToolStripMenuItem cmsDelete;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdate;
        public System.Windows.Forms.ToolStripMenuItem cmsView;
        public CustomPanel.RJButton btnSearch;
        public CustomPanel.BorderRadiusTXT txtSearch;
        public System.Windows.Forms.ToolStripMenuItem cmsPDF;
        public CustomPanel.RJButton btnPrintReport;
    }
}