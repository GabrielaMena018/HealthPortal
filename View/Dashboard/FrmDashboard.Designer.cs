namespace HealthPortal.View.Dashboard
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsrMain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrPatientAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrInventoryAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMedicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrUserAdminsitration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrSectionAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMainImg = new CustomPanel.RJButton();
            this.btnMain = new CustomPanel.RJButton();
            this.btnPatientAdministrationImg = new CustomPanel.RJButton();
            this.btnPatientAdministration = new CustomPanel.RJButton();
            this.btnInventoryAdministrationImg = new CustomPanel.RJButton();
            this.btnInventoryAdministration = new CustomPanel.RJButton();
            this.btnStatisticsImg = new CustomPanel.RJButton();
            this.btnStatistics = new CustomPanel.RJButton();
            this.btnUserAdministrationImg = new CustomPanel.RJButton();
            this.btnUserAdministration = new CustomPanel.RJButton();
            this.btnSectionAdministrationImg = new CustomPanel.RJButton();
            this.btnSectionAdministration = new CustomPanel.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new CustomPanel.RJButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLogoutImg = new CustomPanel.RJButton();
            this.btnLogout = new CustomPanel.RJButton();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.flowButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrMain,
            this.tsrPatientAdministration,
            this.tsrInventoryAdministration,
            this.tsrStatistics,
            this.tsrUserAdminsitration,
            this.tsrSectionAdministration});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1901, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsrMain
            // 
            this.tsrMain.Name = "tsrMain";
            this.tsrMain.Size = new System.Drawing.Size(65, 27);
            this.tsrMain.Text = "Inicio";
            // 
            // tsrPatientAdministration
            // 
            this.tsrPatientAdministration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPacienteToolStripMenuItem});
            this.tsrPatientAdministration.Name = "tsrPatientAdministration";
            this.tsrPatientAdministration.Size = new System.Drawing.Size(146, 27);
            this.tsrPatientAdministration.Text = "Registros Visitas";
            // 
            // agregarPacienteToolStripMenuItem
            // 
            this.agregarPacienteToolStripMenuItem.Name = "agregarPacienteToolStripMenuItem";
            this.agregarPacienteToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.agregarPacienteToolStripMenuItem.Text = "Agregar Visita";
            // 
            // tsrInventoryAdministration
            // 
            this.tsrInventoryAdministration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMedicamentoToolStripMenuItem});
            this.tsrInventoryAdministration.Name = "tsrInventoryAdministration";
            this.tsrInventoryAdministration.Size = new System.Drawing.Size(218, 27);
            this.tsrInventoryAdministration.Text = "Inventario Medicamentos";
            // 
            // agregarMedicamentoToolStripMenuItem
            // 
            this.agregarMedicamentoToolStripMenuItem.Name = "agregarMedicamentoToolStripMenuItem";
            this.agregarMedicamentoToolStripMenuItem.Size = new System.Drawing.Size(265, 28);
            this.agregarMedicamentoToolStripMenuItem.Text = "Agregar Medicamento";
            // 
            // tsrStatistics
            // 
            this.tsrStatistics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirReporteToolStripMenuItem});
            this.tsrStatistics.Name = "tsrStatistics";
            this.tsrStatistics.Size = new System.Drawing.Size(110, 27);
            this.tsrStatistics.Text = "Estadisticas";
            // 
            // imprimirReporteToolStripMenuItem
            // 
            this.imprimirReporteToolStripMenuItem.Name = "imprimirReporteToolStripMenuItem";
            this.imprimirReporteToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.imprimirReporteToolStripMenuItem.Text = "Imprimir Reporte";
            // 
            // tsrUserAdminsitration
            // 
            this.tsrUserAdminsitration.Name = "tsrUserAdminsitration";
            this.tsrUserAdminsitration.Size = new System.Drawing.Size(182, 27);
            this.tsrUserAdminsitration.Text = "Administrar Usuarios";
            // 
            // tsrSectionAdministration
            // 
            this.tsrSectionAdministration.Name = "tsrSectionAdministration";
            this.tsrSectionAdministration.Size = new System.Drawing.Size(171, 27);
            this.tsrSectionAdministration.Text = "Administrar Grados";
            // 
            // flowButtons
            // 
            this.flowButtons.Controls.Add(this.btnMainImg);
            this.flowButtons.Controls.Add(this.btnMain);
            this.flowButtons.Controls.Add(this.btnPatientAdministrationImg);
            this.flowButtons.Controls.Add(this.btnPatientAdministration);
            this.flowButtons.Controls.Add(this.btnInventoryAdministrationImg);
            this.flowButtons.Controls.Add(this.btnInventoryAdministration);
            this.flowButtons.Controls.Add(this.btnStatisticsImg);
            this.flowButtons.Controls.Add(this.btnStatistics);
            this.flowButtons.Controls.Add(this.btnUserAdministrationImg);
            this.flowButtons.Controls.Add(this.btnUserAdministration);
            this.flowButtons.Controls.Add(this.btnSectionAdministrationImg);
            this.flowButtons.Controls.Add(this.btnSectionAdministration);
            this.flowButtons.Location = new System.Drawing.Point(3, 192);
            this.flowButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowButtons.Name = "flowButtons";
            this.flowButtons.Size = new System.Drawing.Size(283, 464);
            this.flowButtons.TabIndex = 1;
            // 
            // btnMainImg
            // 
            this.btnMainImg.AccessibleDescription = "Inicio";
            this.btnMainImg.BackColor = System.Drawing.Color.White;
            this.btnMainImg.BackGroundColor = System.Drawing.Color.White;
            this.btnMainImg.BackgroundImage = global::HealthPortal.Properties.Resources.hogar1;
            this.btnMainImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnMainImg.BorderRadius = 40;
            this.btnMainImg.BorderSize = 0;
            this.btnMainImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainImg.FlatAppearance.BorderSize = 0;
            this.btnMainImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainImg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainImg.ForeColor = System.Drawing.Color.Black;
            this.btnMainImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainImg.Location = new System.Drawing.Point(3, 2);
            this.btnMainImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainImg.Name = "btnMainImg";
            this.btnMainImg.Size = new System.Drawing.Size(64, 62);
            this.btnMainImg.TabIndex = 2;
            this.btnMainImg.Tag = "Inicio";
            this.btnMainImg.TextColor = System.Drawing.Color.Black;
            this.btnMainImg.UseVisualStyleBackColor = false;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnMain.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnMain.BorderRadius = 40;
            this.btnMain.BorderSize = 0;
            this.btnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.Black;
            this.btnMain.Location = new System.Drawing.Point(73, 2);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(200, 62);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "Inicio";
            this.btnMain.TextColor = System.Drawing.Color.Black;
            this.btnMain.UseVisualStyleBackColor = false;
            // 
            // btnPatientAdministrationImg
            // 
            this.btnPatientAdministrationImg.BackColor = System.Drawing.Color.White;
            this.btnPatientAdministrationImg.BackGroundColor = System.Drawing.Color.White;
            this.btnPatientAdministrationImg.BackgroundImage = global::HealthPortal.Properties.Resources.lista_del_portapapeles;
            this.btnPatientAdministrationImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPatientAdministrationImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnPatientAdministrationImg.BorderRadius = 40;
            this.btnPatientAdministrationImg.BorderSize = 0;
            this.btnPatientAdministrationImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientAdministrationImg.FlatAppearance.BorderSize = 0;
            this.btnPatientAdministrationImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientAdministrationImg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientAdministrationImg.ForeColor = System.Drawing.Color.Black;
            this.btnPatientAdministrationImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientAdministrationImg.Location = new System.Drawing.Point(3, 68);
            this.btnPatientAdministrationImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPatientAdministrationImg.Name = "btnPatientAdministrationImg";
            this.btnPatientAdministrationImg.Size = new System.Drawing.Size(64, 62);
            this.btnPatientAdministrationImg.TabIndex = 5;
            this.btnPatientAdministrationImg.Text = " ";
            this.btnPatientAdministrationImg.TextColor = System.Drawing.Color.Black;
            this.btnPatientAdministrationImg.UseVisualStyleBackColor = false;
            // 
            // btnPatientAdministration
            // 
            this.btnPatientAdministration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnPatientAdministration.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnPatientAdministration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnPatientAdministration.BorderRadius = 40;
            this.btnPatientAdministration.BorderSize = 0;
            this.btnPatientAdministration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientAdministration.FlatAppearance.BorderSize = 0;
            this.btnPatientAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientAdministration.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientAdministration.ForeColor = System.Drawing.Color.Black;
            this.btnPatientAdministration.Location = new System.Drawing.Point(73, 68);
            this.btnPatientAdministration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPatientAdministration.Name = "btnPatientAdministration";
            this.btnPatientAdministration.Size = new System.Drawing.Size(200, 62);
            this.btnPatientAdministration.TabIndex = 1;
            this.btnPatientAdministration.Text = "Visitas";
            this.btnPatientAdministration.TextColor = System.Drawing.Color.Black;
            this.btnPatientAdministration.UseVisualStyleBackColor = false;
            // 
            // btnInventoryAdministrationImg
            // 
            this.btnInventoryAdministrationImg.BackColor = System.Drawing.Color.White;
            this.btnInventoryAdministrationImg.BackGroundColor = System.Drawing.Color.White;
            this.btnInventoryAdministrationImg.BackgroundImage = global::HealthPortal.Properties.Resources.pastillas;
            this.btnInventoryAdministrationImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInventoryAdministrationImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnInventoryAdministrationImg.BorderRadius = 40;
            this.btnInventoryAdministrationImg.BorderSize = 0;
            this.btnInventoryAdministrationImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventoryAdministrationImg.FlatAppearance.BorderSize = 0;
            this.btnInventoryAdministrationImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryAdministrationImg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryAdministrationImg.ForeColor = System.Drawing.Color.Black;
            this.btnInventoryAdministrationImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventoryAdministrationImg.Location = new System.Drawing.Point(3, 134);
            this.btnInventoryAdministrationImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventoryAdministrationImg.Name = "btnInventoryAdministrationImg";
            this.btnInventoryAdministrationImg.Size = new System.Drawing.Size(64, 62);
            this.btnInventoryAdministrationImg.TabIndex = 6;
            this.btnInventoryAdministrationImg.Text = " ";
            this.btnInventoryAdministrationImg.TextColor = System.Drawing.Color.Black;
            this.btnInventoryAdministrationImg.UseVisualStyleBackColor = false;
            // 
            // btnInventoryAdministration
            // 
            this.btnInventoryAdministration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnInventoryAdministration.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnInventoryAdministration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnInventoryAdministration.BorderRadius = 40;
            this.btnInventoryAdministration.BorderSize = 0;
            this.btnInventoryAdministration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventoryAdministration.FlatAppearance.BorderSize = 0;
            this.btnInventoryAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryAdministration.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryAdministration.ForeColor = System.Drawing.Color.Black;
            this.btnInventoryAdministration.Location = new System.Drawing.Point(73, 134);
            this.btnInventoryAdministration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventoryAdministration.Name = "btnInventoryAdministration";
            this.btnInventoryAdministration.Size = new System.Drawing.Size(200, 62);
            this.btnInventoryAdministration.TabIndex = 2;
            this.btnInventoryAdministration.Text = "Inventario Medicamentos";
            this.btnInventoryAdministration.TextColor = System.Drawing.Color.Black;
            this.btnInventoryAdministration.UseVisualStyleBackColor = false;
            // 
            // btnStatisticsImg
            // 
            this.btnStatisticsImg.BackColor = System.Drawing.Color.White;
            this.btnStatisticsImg.BackGroundColor = System.Drawing.Color.White;
            this.btnStatisticsImg.BackgroundImage = global::HealthPortal.Properties.Resources.grafico_histograma;
            this.btnStatisticsImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatisticsImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnStatisticsImg.BorderRadius = 40;
            this.btnStatisticsImg.BorderSize = 0;
            this.btnStatisticsImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatisticsImg.FlatAppearance.BorderSize = 0;
            this.btnStatisticsImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatisticsImg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatisticsImg.ForeColor = System.Drawing.Color.Black;
            this.btnStatisticsImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatisticsImg.Location = new System.Drawing.Point(3, 200);
            this.btnStatisticsImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatisticsImg.Name = "btnStatisticsImg";
            this.btnStatisticsImg.Size = new System.Drawing.Size(64, 62);
            this.btnStatisticsImg.TabIndex = 7;
            this.btnStatisticsImg.Text = " ";
            this.btnStatisticsImg.TextColor = System.Drawing.Color.Black;
            this.btnStatisticsImg.UseVisualStyleBackColor = false;
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnStatistics.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnStatistics.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnStatistics.BorderRadius = 40;
            this.btnStatistics.BorderSize = 0;
            this.btnStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.ForeColor = System.Drawing.Color.Black;
            this.btnStatistics.Location = new System.Drawing.Point(73, 200);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(200, 62);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.Text = "Estadisticas";
            this.btnStatistics.TextColor = System.Drawing.Color.Black;
            this.btnStatistics.UseVisualStyleBackColor = false;
            // 
            // btnUserAdministrationImg
            // 
            this.btnUserAdministrationImg.BackColor = System.Drawing.Color.White;
            this.btnUserAdministrationImg.BackGroundColor = System.Drawing.Color.White;
            this.btnUserAdministrationImg.BackgroundImage = global::HealthPortal.Properties.Resources.agregar_usuario;
            this.btnUserAdministrationImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUserAdministrationImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnUserAdministrationImg.BorderRadius = 40;
            this.btnUserAdministrationImg.BorderSize = 0;
            this.btnUserAdministrationImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserAdministrationImg.FlatAppearance.BorderSize = 0;
            this.btnUserAdministrationImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAdministrationImg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAdministrationImg.ForeColor = System.Drawing.Color.Black;
            this.btnUserAdministrationImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserAdministrationImg.Location = new System.Drawing.Point(3, 266);
            this.btnUserAdministrationImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserAdministrationImg.Name = "btnUserAdministrationImg";
            this.btnUserAdministrationImg.Size = new System.Drawing.Size(64, 62);
            this.btnUserAdministrationImg.TabIndex = 8;
            this.btnUserAdministrationImg.Text = " ";
            this.btnUserAdministrationImg.TextColor = System.Drawing.Color.Black;
            this.btnUserAdministrationImg.UseVisualStyleBackColor = false;
            // 
            // btnUserAdministration
            // 
            this.btnUserAdministration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnUserAdministration.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnUserAdministration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnUserAdministration.BorderRadius = 40;
            this.btnUserAdministration.BorderSize = 0;
            this.btnUserAdministration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserAdministration.FlatAppearance.BorderSize = 0;
            this.btnUserAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAdministration.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAdministration.ForeColor = System.Drawing.Color.Black;
            this.btnUserAdministration.Location = new System.Drawing.Point(73, 266);
            this.btnUserAdministration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserAdministration.Name = "btnUserAdministration";
            this.btnUserAdministration.Size = new System.Drawing.Size(200, 62);
            this.btnUserAdministration.TabIndex = 9;
            this.btnUserAdministration.Text = "Administrar Usuarios";
            this.btnUserAdministration.TextColor = System.Drawing.Color.Black;
            this.btnUserAdministration.UseVisualStyleBackColor = false;
            // 
            // btnSectionAdministrationImg
            // 
            this.btnSectionAdministrationImg.BackColor = System.Drawing.Color.White;
            this.btnSectionAdministrationImg.BackGroundColor = System.Drawing.Color.White;
            this.btnSectionAdministrationImg.BackgroundImage = global::HealthPortal.Properties.Resources.leccion__2_;
            this.btnSectionAdministrationImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSectionAdministrationImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSectionAdministrationImg.BorderRadius = 40;
            this.btnSectionAdministrationImg.BorderSize = 0;
            this.btnSectionAdministrationImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSectionAdministrationImg.FlatAppearance.BorderSize = 0;
            this.btnSectionAdministrationImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSectionAdministrationImg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectionAdministrationImg.ForeColor = System.Drawing.Color.Black;
            this.btnSectionAdministrationImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSectionAdministrationImg.Location = new System.Drawing.Point(3, 332);
            this.btnSectionAdministrationImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSectionAdministrationImg.Name = "btnSectionAdministrationImg";
            this.btnSectionAdministrationImg.Size = new System.Drawing.Size(64, 62);
            this.btnSectionAdministrationImg.TabIndex = 10;
            this.btnSectionAdministrationImg.Text = " ";
            this.btnSectionAdministrationImg.TextColor = System.Drawing.Color.Black;
            this.btnSectionAdministrationImg.UseVisualStyleBackColor = false;
            // 
            // btnSectionAdministration
            // 
            this.btnSectionAdministration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSectionAdministration.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSectionAdministration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSectionAdministration.BorderRadius = 40;
            this.btnSectionAdministration.BorderSize = 0;
            this.btnSectionAdministration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSectionAdministration.FlatAppearance.BorderSize = 0;
            this.btnSectionAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSectionAdministration.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectionAdministration.ForeColor = System.Drawing.Color.Black;
            this.btnSectionAdministration.Location = new System.Drawing.Point(73, 332);
            this.btnSectionAdministration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSectionAdministration.Name = "btnSectionAdministration";
            this.btnSectionAdministration.Size = new System.Drawing.Size(200, 62);
            this.btnSectionAdministration.TabIndex = 11;
            this.btnSectionAdministration.Text = "Administrar Grados";
            this.btnSectionAdministration.TextColor = System.Drawing.Color.Black;
            this.btnSectionAdministration.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 192);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 92);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menú";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.BackGroundColor = System.Drawing.Color.White;
            this.btnMenu.BackgroundImage = global::HealthPortal.Properties.Resources.menu_regular_24;
            this.btnMenu.BorderColor = System.Drawing.Color.White;
            this.btnMenu.BorderRadius = 0;
            this.btnMenu.BorderSize = 1;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(13, 31);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 33);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = " ";
            this.btnMenu.TextColor = System.Drawing.Color.White;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 956);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1901, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.Controls.Add(this.flowLayoutPanel1);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.flowButtons);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 31);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar.MaximumSize = new System.Drawing.Size(284, 0);
            this.sidebar.MinimumSize = new System.Drawing.Size(72, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(284, 925);
            this.sidebar.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnLogoutImg);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 818);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnLogoutImg
            // 
            this.btnLogoutImg.BackColor = System.Drawing.Color.White;
            this.btnLogoutImg.BackGroundColor = System.Drawing.Color.White;
            this.btnLogoutImg.BackgroundImage = global::HealthPortal.Properties.Resources.salida;
            this.btnLogoutImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogoutImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnLogoutImg.BorderRadius = 40;
            this.btnLogoutImg.BorderSize = 0;
            this.btnLogoutImg.FlatAppearance.BorderSize = 0;
            this.btnLogoutImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutImg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutImg.ForeColor = System.Drawing.Color.Black;
            this.btnLogoutImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogoutImg.Location = new System.Drawing.Point(3, 2);
            this.btnLogoutImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogoutImg.Name = "btnLogoutImg";
            this.btnLogoutImg.Size = new System.Drawing.Size(64, 62);
            this.btnLogoutImg.TabIndex = 8;
            this.btnLogoutImg.Text = " ";
            this.btnLogoutImg.TextColor = System.Drawing.Color.Black;
            this.btnLogoutImg.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.BackGroundColor = System.Drawing.Color.White;
            this.btnLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnLogout.BorderRadius = 40;
            this.btnLogout.BorderSize = 2;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnLogout.Location = new System.Drawing.Point(73, 2);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 62);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(284, 31);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PanelContenedor.Size = new System.Drawing.Size(1617, 925);
            this.PanelContenedor.TabIndex = 5;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1901, 978);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1917, 1016);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HealthPortal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMedicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirReporteToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripMenuItem tsrPatientAdministration;
        public System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel1;
        public CustomPanel.RJButton btnPatientAdministration;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public CustomPanel.RJButton btnMenu;
        public System.Windows.Forms.Panel sidebar;
        public System.Windows.Forms.Panel PanelContenedor;
        public System.Windows.Forms.FlowLayoutPanel flowButtons;
        public CustomPanel.RJButton btnMain;
        public CustomPanel.RJButton btnInventoryAdministration;
        public CustomPanel.RJButton btnStatistics;
        public CustomPanel.RJButton btnMainImg;
        public CustomPanel.RJButton btnPatientAdministrationImg;
        public CustomPanel.RJButton btnInventoryAdministrationImg;
        public CustomPanel.RJButton btnStatisticsImg;
        public CustomPanel.RJButton btnLogoutImg;
        public CustomPanel.RJButton btnLogout;
        public CustomPanel.RJButton btnUserAdministrationImg;
        public CustomPanel.RJButton btnUserAdministration;
        public System.Windows.Forms.ToolStripMenuItem tsrUserAdminsitration;
        public CustomPanel.RJButton btnSectionAdministrationImg;
        public CustomPanel.RJButton btnSectionAdministration;
        public System.Windows.Forms.ToolStripMenuItem tsrMain;
        public System.Windows.Forms.ToolStripMenuItem tsrInventoryAdministration;
        public System.Windows.Forms.ToolStripMenuItem tsrStatistics;
        public System.Windows.Forms.ToolStripMenuItem tsrSectionAdministration;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}