namespace RegistroPacientes.View.Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StpRegistroPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMedicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.btnMenu = new CustomPanel.RJButton();
            this.BtnPicHome = new CustomPanel.RJButton();
            this.BtnInicio = new CustomPanel.RJButton();
            this.BtnPicPaciente = new CustomPanel.RJButton();
            this.BtnPatience = new CustomPanel.RJButton();
            this.BtnPicInventario = new CustomPanel.RJButton();
            this.BtnInventario = new CustomPanel.RJButton();
            this.BtnPicEstadistica = new CustomPanel.RJButton();
            this.BtnEstadistica = new CustomPanel.RJButton();
            this.menuStrip1.SuspendLayout();
            this.flowButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.StpRegistroPacientes,
            this.inventarioMedicamentosToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1900, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(65, 27);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // StpRegistroPacientes
            // 
            this.StpRegistroPacientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPacienteToolStripMenuItem});
            this.StpRegistroPacientes.Name = "StpRegistroPacientes";
            this.StpRegistroPacientes.Size = new System.Drawing.Size(169, 27);
            this.StpRegistroPacientes.Text = "Registros Pacientes";
            // 
            // agregarPacienteToolStripMenuItem
            // 
            this.agregarPacienteToolStripMenuItem.Name = "agregarPacienteToolStripMenuItem";
            this.agregarPacienteToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.agregarPacienteToolStripMenuItem.Text = "Agregar Paciente";
            // 
            // inventarioMedicamentosToolStripMenuItem
            // 
            this.inventarioMedicamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMedicamentoToolStripMenuItem});
            this.inventarioMedicamentosToolStripMenuItem.Name = "inventarioMedicamentosToolStripMenuItem";
            this.inventarioMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(218, 27);
            this.inventarioMedicamentosToolStripMenuItem.Text = "Inventario Medicamentos";
            // 
            // agregarMedicamentoToolStripMenuItem
            // 
            this.agregarMedicamentoToolStripMenuItem.Name = "agregarMedicamentoToolStripMenuItem";
            this.agregarMedicamentoToolStripMenuItem.Size = new System.Drawing.Size(265, 28);
            this.agregarMedicamentoToolStripMenuItem.Text = "Agregar Medicamento";
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirReporteToolStripMenuItem});
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(110, 27);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // imprimirReporteToolStripMenuItem
            // 
            this.imprimirReporteToolStripMenuItem.Name = "imprimirReporteToolStripMenuItem";
            this.imprimirReporteToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.imprimirReporteToolStripMenuItem.Text = "Imprimir Reporte";
            // 
            // flowButtons
            // 
            this.flowButtons.Controls.Add(this.BtnPicHome);
            this.flowButtons.Controls.Add(this.BtnInicio);
            this.flowButtons.Controls.Add(this.BtnPicPaciente);
            this.flowButtons.Controls.Add(this.BtnPatience);
            this.flowButtons.Controls.Add(this.BtnPicInventario);
            this.flowButtons.Controls.Add(this.BtnInventario);
            this.flowButtons.Controls.Add(this.BtnPicEstadistica);
            this.flowButtons.Controls.Add(this.BtnEstadistica);
            this.flowButtons.Location = new System.Drawing.Point(3, 192);
            this.flowButtons.Name = "flowButtons";
            this.flowButtons.Size = new System.Drawing.Size(282, 464);
            this.flowButtons.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 92);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 949);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1900, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.flowButtons);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 31);
            this.sidebar.MaximumSize = new System.Drawing.Size(284, 0);
            this.sidebar.MinimumSize = new System.Drawing.Size(72, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(284, 918);
            this.sidebar.TabIndex = 4;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(284, 31);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1616, 918);
            this.PanelContenedor.TabIndex = 5;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.BackGroundColor = System.Drawing.Color.White;
            this.btnMenu.BackgroundImage = global::RegistroPacientes.Properties.Resources.menu_regular_24;
            this.btnMenu.BorderColor = System.Drawing.Color.White;
            this.btnMenu.BorderRadius = 0;
            this.btnMenu.BorderSize = 1;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(14, 31);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 33);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = " ";
            this.btnMenu.TextColor = System.Drawing.Color.White;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // BtnPicHome
            // 
            this.BtnPicHome.BackColor = System.Drawing.Color.White;
            this.BtnPicHome.BackGroundColor = System.Drawing.Color.White;
            this.BtnPicHome.BackgroundImage = global::RegistroPacientes.Properties.Resources.home_alt_2_regular_36;
            this.BtnPicHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPicHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnPicHome.BorderRadius = 40;
            this.BtnPicHome.BorderSize = 0;
            this.BtnPicHome.FlatAppearance.BorderSize = 0;
            this.BtnPicHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPicHome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPicHome.ForeColor = System.Drawing.Color.Black;
            this.BtnPicHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPicHome.Location = new System.Drawing.Point(3, 3);
            this.BtnPicHome.Name = "BtnPicHome";
            this.BtnPicHome.Size = new System.Drawing.Size(64, 62);
            this.BtnPicHome.TabIndex = 2;
            this.BtnPicHome.Text = " ";
            this.BtnPicHome.TextColor = System.Drawing.Color.Black;
            this.BtnPicHome.UseVisualStyleBackColor = false;
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnInicio.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnInicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnInicio.BorderRadius = 40;
            this.BtnInicio.BorderSize = 0;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.Black;
            this.BtnInicio.Location = new System.Drawing.Point(73, 3);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(200, 62);
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.TextColor = System.Drawing.Color.Black;
            this.BtnInicio.UseVisualStyleBackColor = false;
            // 
            // BtnPicPaciente
            // 
            this.BtnPicPaciente.BackColor = System.Drawing.Color.White;
            this.BtnPicPaciente.BackGroundColor = System.Drawing.Color.White;
            this.BtnPicPaciente.BackgroundImage = global::RegistroPacientes.Properties.Resources.virus_medical_records_diagnosis_document_icon_142190;
            this.BtnPicPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPicPaciente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnPicPaciente.BorderRadius = 40;
            this.BtnPicPaciente.BorderSize = 0;
            this.BtnPicPaciente.FlatAppearance.BorderSize = 0;
            this.BtnPicPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPicPaciente.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPicPaciente.ForeColor = System.Drawing.Color.Black;
            this.BtnPicPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPicPaciente.Location = new System.Drawing.Point(3, 71);
            this.BtnPicPaciente.Name = "BtnPicPaciente";
            this.BtnPicPaciente.Size = new System.Drawing.Size(64, 62);
            this.BtnPicPaciente.TabIndex = 5;
            this.BtnPicPaciente.Text = " ";
            this.BtnPicPaciente.TextColor = System.Drawing.Color.Black;
            this.BtnPicPaciente.UseVisualStyleBackColor = false;
            // 
            // BtnPatience
            // 
            this.BtnPatience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnPatience.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnPatience.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnPatience.BorderRadius = 40;
            this.BtnPatience.BorderSize = 0;
            this.BtnPatience.FlatAppearance.BorderSize = 0;
            this.BtnPatience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPatience.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatience.ForeColor = System.Drawing.Color.Black;
            this.BtnPatience.Location = new System.Drawing.Point(73, 71);
            this.BtnPatience.Name = "BtnPatience";
            this.BtnPatience.Size = new System.Drawing.Size(200, 62);
            this.BtnPatience.TabIndex = 1;
            this.BtnPatience.Text = "Pacientes";
            this.BtnPatience.TextColor = System.Drawing.Color.Black;
            this.BtnPatience.UseVisualStyleBackColor = false;
            // 
            // BtnPicInventario
            // 
            this.BtnPicInventario.BackColor = System.Drawing.Color.White;
            this.BtnPicInventario.BackGroundColor = System.Drawing.Color.White;
            this.BtnPicInventario.BackgroundImage = global::RegistroPacientes.Properties.Resources.home_alt_2_regular_36;
            this.BtnPicInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPicInventario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnPicInventario.BorderRadius = 40;
            this.BtnPicInventario.BorderSize = 0;
            this.BtnPicInventario.FlatAppearance.BorderSize = 0;
            this.BtnPicInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPicInventario.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPicInventario.ForeColor = System.Drawing.Color.Black;
            this.BtnPicInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPicInventario.Location = new System.Drawing.Point(3, 139);
            this.BtnPicInventario.Name = "BtnPicInventario";
            this.BtnPicInventario.Size = new System.Drawing.Size(64, 62);
            this.BtnPicInventario.TabIndex = 6;
            this.BtnPicInventario.Text = " ";
            this.BtnPicInventario.TextColor = System.Drawing.Color.Black;
            this.BtnPicInventario.UseVisualStyleBackColor = false;
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnInventario.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnInventario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnInventario.BorderRadius = 40;
            this.BtnInventario.BorderSize = 0;
            this.BtnInventario.FlatAppearance.BorderSize = 0;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.ForeColor = System.Drawing.Color.Black;
            this.BtnInventario.Location = new System.Drawing.Point(73, 139);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(200, 62);
            this.BtnInventario.TabIndex = 2;
            this.BtnInventario.Text = "Inventario Medicamentos";
            this.BtnInventario.TextColor = System.Drawing.Color.Black;
            this.BtnInventario.UseVisualStyleBackColor = false;
            // 
            // BtnPicEstadistica
            // 
            this.BtnPicEstadistica.BackColor = System.Drawing.Color.White;
            this.BtnPicEstadistica.BackGroundColor = System.Drawing.Color.White;
            this.BtnPicEstadistica.BackgroundImage = global::RegistroPacientes.Properties.Resources.home_alt_2_regular_36;
            this.BtnPicEstadistica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPicEstadistica.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnPicEstadistica.BorderRadius = 40;
            this.BtnPicEstadistica.BorderSize = 0;
            this.BtnPicEstadistica.FlatAppearance.BorderSize = 0;
            this.BtnPicEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPicEstadistica.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPicEstadistica.ForeColor = System.Drawing.Color.Black;
            this.BtnPicEstadistica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPicEstadistica.Location = new System.Drawing.Point(3, 207);
            this.BtnPicEstadistica.Name = "BtnPicEstadistica";
            this.BtnPicEstadistica.Size = new System.Drawing.Size(64, 62);
            this.BtnPicEstadistica.TabIndex = 7;
            this.BtnPicEstadistica.Text = " ";
            this.BtnPicEstadistica.TextColor = System.Drawing.Color.Black;
            this.BtnPicEstadistica.UseVisualStyleBackColor = false;
            // 
            // BtnEstadistica
            // 
            this.BtnEstadistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnEstadistica.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnEstadistica.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.BtnEstadistica.BorderRadius = 40;
            this.BtnEstadistica.BorderSize = 0;
            this.BtnEstadistica.FlatAppearance.BorderSize = 0;
            this.BtnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstadistica.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstadistica.ForeColor = System.Drawing.Color.Black;
            this.BtnEstadistica.Location = new System.Drawing.Point(73, 207);
            this.BtnEstadistica.Name = "BtnEstadistica";
            this.BtnEstadistica.Size = new System.Drawing.Size(200, 62);
            this.BtnEstadistica.TabIndex = 3;
            this.BtnEstadistica.Text = "Estadisticas";
            this.BtnEstadistica.TextColor = System.Drawing.Color.Black;
            this.BtnEstadistica.UseVisualStyleBackColor = false;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1900, 971);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1918, 1018);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMedicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirReporteToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripMenuItem StpRegistroPacientes;
        public System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel1;
        public CustomPanel.RJButton BtnPatience;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public CustomPanel.RJButton btnMenu;
        public System.Windows.Forms.Panel sidebar;
        public System.Windows.Forms.Panel PanelContenedor;
        public System.Windows.Forms.FlowLayoutPanel flowButtons;
        public CustomPanel.RJButton BtnInicio;
        public CustomPanel.RJButton BtnInventario;
        public CustomPanel.RJButton BtnEstadistica;
        public CustomPanel.RJButton BtnPicHome;
        public CustomPanel.RJButton BtnPicPaciente;
        public CustomPanel.RJButton BtnPicInventario;
        public CustomPanel.RJButton BtnPicEstadistica;
    }
}