namespace HealthPortal.View.UserAdministration
{
    partial class FrmUserAdministration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmsDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsUpdateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsViewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsReestablishPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCustom1 = new CustomPanel.PanelCustom();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvUserDisplay = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnFilter = new CustomPanel.RJButton();
            this.lblUserAdministrationFilter = new System.Windows.Forms.Label();
            this.cmbUserAdministrationFilter = new System.Windows.Forms.ComboBox();
            this.btnAddNewUser = new CustomPanel.RJButton();
            this.panelCustom2 = new CustomPanel.PanelCustom();
            this.txtUserAdministrationSearch = new CustomPanel.BorderRadiusTXT();
            this.btnSearchForUser = new CustomPanel.RJButton();
            this.lblUserAdministrationSearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.cmsDataGrid.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panelCustom1.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDisplay)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelCustom2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(325, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(989, 711);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelCustom1);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(325, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 711);
            this.panel1.TabIndex = 8;
            // 
            // cmsDataGrid
            // 
            this.cmsDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsUpdateUser,
            this.cmsDeleteUser,
            this.cmsViewUser,
            this.cmsReestablishPassword});
            this.cmsDataGrid.Name = "contextDataGrid";
            this.cmsDataGrid.Size = new System.Drawing.Size(204, 114);
            // 
            // cmsUpdateUser
            // 
            this.cmsUpdateUser.Name = "cmsUpdateUser";
            this.cmsUpdateUser.Size = new System.Drawing.Size(203, 22);
            this.cmsUpdateUser.Text = "Actualizar Usuario";
            // 
            // cmsDeleteUser
            // 
            this.cmsDeleteUser.Name = "cmsDeleteUser";
            this.cmsDeleteUser.Size = new System.Drawing.Size(203, 22);
            this.cmsDeleteUser.Text = "Eliminar Usuario";
            // 
            // cmsViewUser
            // 
            this.cmsViewUser.Name = "cmsViewUser";
            this.cmsViewUser.Size = new System.Drawing.Size(203, 22);
            this.cmsViewUser.Text = "Ver Usuario";
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(24, 681);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(935, 30);
            this.panel8.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(24, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(935, 30);
            this.panel5.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(935, 30);
            this.panel7.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(959, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 711);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 711);
            this.panel2.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Location = new System.Drawing.Point(0, 681);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(989, 30);
            this.panel6.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(989, 30);
            this.panel4.TabIndex = 15;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(325, 711);
            this.panel12.TabIndex = 9;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panelCustom2);
            this.panel14.Controls.Add(this.panel18);
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 130);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(325, 581);
            this.panel14.TabIndex = 4;
            // 
            // panel18
            // 
            this.panel18.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel18.Location = new System.Drawing.Point(315, 10);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(10, 561);
            this.panel18.TabIndex = 3;
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(0, 10);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(10, 561);
            this.panel17.TabIndex = 2;
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(0, 571);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(325, 10);
            this.panel16.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(325, 10);
            this.panel15.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label1);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(325, 711);
            this.panel13.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.MaximumSize = new System.Drawing.Size(319, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 108);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administración de Usuarios";
            // 
            // cmsReestablishPassword
            // 
            this.cmsReestablishPassword.Name = "cmsReestablishPassword";
            this.cmsReestablishPassword.Size = new System.Drawing.Size(203, 22);
            this.cmsReestablishPassword.Text = "Reestablecer Contraseña";
            // 
            // panelCustom1
            // 
            this.panelCustom1.BackColor = System.Drawing.Color.White;
            this.panelCustom1.BorderRadius = 30;
            this.panelCustom1.Controls.Add(this.panel11);
            this.panelCustom1.Controls.Add(this.panel9);
            this.panelCustom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustom1.ForeColor = System.Drawing.Color.Black;
            this.panelCustom1.GradientAngle = 90F;
            this.panelCustom1.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustom1.GradientTopColor = System.Drawing.Color.White;
            this.panelCustom1.Location = new System.Drawing.Point(24, 30);
            this.panelCustom1.Name = "panelCustom1";
            this.panelCustom1.Size = new System.Drawing.Size(935, 651);
            this.panelCustom1.TabIndex = 15;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgvUserDisplay);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 87);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(935, 564);
            this.panel11.TabIndex = 1;
            // 
            // dgvUserDisplay
            // 
            this.dgvUserDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserDisplay.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.NullValue = "---";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserDisplay.ContextMenuStrip = this.cmsDataGrid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "---";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserDisplay.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserDisplay.Location = new System.Drawing.Point(0, 0);
            this.dgvUserDisplay.Margin = new System.Windows.Forms.Padding(10);
            this.dgvUserDisplay.Name = "dgvUserDisplay";
            this.dgvUserDisplay.ReadOnly = true;
            this.dgvUserDisplay.RowHeadersWidth = 100;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = "----";
            this.dgvUserDisplay.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserDisplay.Size = new System.Drawing.Size(935, 564);
            this.dgvUserDisplay.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(935, 87);
            this.panel9.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnFilter);
            this.panel10.Controls.Add(this.lblUserAdministrationFilter);
            this.panel10.Controls.Add(this.cmbUserAdministrationFilter);
            this.panel10.Controls.Add(this.btnAddNewUser);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(935, 87);
            this.panel10.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnFilter.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnFilter.BorderRadius = 45;
            this.btnFilter.BorderSize = 0;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Location = new System.Drawing.Point(20, 20);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(20);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(82, 46);
            this.btnFilter.TabIndex = 17;
            this.btnFilter.Text = " Filtrar";
            this.btnFilter.TextColor = System.Drawing.Color.Black;
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // lblUserAdministrationFilter
            // 
            this.lblUserAdministrationFilter.AutoSize = true;
            this.lblUserAdministrationFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserAdministrationFilter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserAdministrationFilter.Location = new System.Drawing.Point(125, 20);
            this.lblUserAdministrationFilter.Name = "lblUserAdministrationFilter";
            this.lblUserAdministrationFilter.Size = new System.Drawing.Size(72, 19);
            this.lblUserAdministrationFilter.TabIndex = 15;
            this.lblUserAdministrationFilter.Text = "Filtrar por:";
            // 
            // cmbUserAdministrationFilter
            // 
            this.cmbUserAdministrationFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserAdministrationFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserAdministrationFilter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbUserAdministrationFilter.FormattingEnabled = true;
            this.cmbUserAdministrationFilter.ItemHeight = 17;
            this.cmbUserAdministrationFilter.Location = new System.Drawing.Point(125, 42);
            this.cmbUserAdministrationFilter.Name = "cmbUserAdministrationFilter";
            this.cmbUserAdministrationFilter.Size = new System.Drawing.Size(285, 25);
            this.cmbUserAdministrationFilter.TabIndex = 6;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddNewUser.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddNewUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddNewUser.BorderRadius = 40;
            this.btnAddNewUser.BorderSize = 0;
            this.btnAddNewUser.FlatAppearance.BorderSize = 0;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewUser.Location = new System.Drawing.Point(760, 20);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(20);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(155, 46);
            this.btnAddNewUser.TabIndex = 3;
            this.btnAddNewUser.Text = "Añadir Usuario";
            this.btnAddNewUser.TextColor = System.Drawing.Color.Black;
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            // 
            // panelCustom2
            // 
            this.panelCustom2.BackColor = System.Drawing.Color.White;
            this.panelCustom2.BorderRadius = 30;
            this.panelCustom2.Controls.Add(this.txtUserAdministrationSearch);
            this.panelCustom2.Controls.Add(this.btnSearchForUser);
            this.panelCustom2.Controls.Add(this.lblUserAdministrationSearch);
            this.panelCustom2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustom2.ForeColor = System.Drawing.Color.Black;
            this.panelCustom2.GradientAngle = 90F;
            this.panelCustom2.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustom2.GradientTopColor = System.Drawing.Color.White;
            this.panelCustom2.Location = new System.Drawing.Point(10, 10);
            this.panelCustom2.Name = "panelCustom2";
            this.panelCustom2.Size = new System.Drawing.Size(305, 561);
            this.panelCustom2.TabIndex = 4;
            // 
            // txtUserAdministrationSearch
            // 
            this.txtUserAdministrationSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserAdministrationSearch.BorderColor = System.Drawing.Color.LightGray;
            this.txtUserAdministrationSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUserAdministrationSearch.BorderRadius = 10;
            this.txtUserAdministrationSearch.BorderSize = 2;
            this.txtUserAdministrationSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserAdministrationSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtUserAdministrationSearch.Location = new System.Drawing.Point(25, 56);
            this.txtUserAdministrationSearch.Multiline = false;
            this.txtUserAdministrationSearch.Name = "txtUserAdministrationSearch";
            this.txtUserAdministrationSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserAdministrationSearch.PasswordChar = false;
            this.txtUserAdministrationSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationSearch.PlaceholderText = "";
            this.txtUserAdministrationSearch.Size = new System.Drawing.Size(259, 34);
            this.txtUserAdministrationSearch.TabIndex = 20;
            this.txtUserAdministrationSearch.Texts = "";
            this.txtUserAdministrationSearch.UnderlinedStyle = false;
            // 
            // btnSearchForUser
            // 
            this.btnSearchForUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSearchForUser.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSearchForUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSearchForUser.BorderRadius = 40;
            this.btnSearchForUser.BorderSize = 0;
            this.btnSearchForUser.FlatAppearance.BorderSize = 0;
            this.btnSearchForUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchForUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearchForUser.ForeColor = System.Drawing.Color.Black;
            this.btnSearchForUser.Location = new System.Drawing.Point(25, 108);
            this.btnSearchForUser.Margin = new System.Windows.Forms.Padding(18, 3, 18, 18);
            this.btnSearchForUser.Name = "btnSearchForUser";
            this.btnSearchForUser.Size = new System.Drawing.Size(259, 46);
            this.btnSearchForUser.TabIndex = 18;
            this.btnSearchForUser.Text = "Buscar Usuario(s)";
            this.btnSearchForUser.TextColor = System.Drawing.Color.Black;
            this.btnSearchForUser.UseVisualStyleBackColor = false;
            // 
            // lblUserAdministrationSearch
            // 
            this.lblUserAdministrationSearch.AutoSize = true;
            this.lblUserAdministrationSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserAdministrationSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserAdministrationSearch.Location = new System.Drawing.Point(21, 23);
            this.lblUserAdministrationSearch.Margin = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.lblUserAdministrationSearch.Name = "lblUserAdministrationSearch";
            this.lblUserAdministrationSearch.Size = new System.Drawing.Size(52, 19);
            this.lblUserAdministrationSearch.TabIndex = 17;
            this.lblUserAdministrationSearch.Text = "Buscar:";
            // 
            // FrmUserAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1314, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.panel12);
            this.MinimumSize = new System.Drawing.Size(1330, 750);
            this.Name = "FrmUserAdministration";
            this.Text = "FrmUserAdministration";
            this.panel1.ResumeLayout(false);
            this.cmsDataGrid.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panelCustom1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDisplay)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panelCustom2.ResumeLayout(false);
            this.panelCustom2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private CustomPanel.PanelCustom panelCustom1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        public CustomPanel.RJButton btnAddNewUser;
        public System.Windows.Forms.ComboBox cmbUserAdministrationFilter;
        private System.Windows.Forms.Label lblUserAdministrationFilter;
        public System.Windows.Forms.DataGridView dgvUserDisplay;
        public CustomPanel.RJButton btnFilter;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private CustomPanel.PanelCustom panelCustom2;
        private System.Windows.Forms.Panel panel18;
        public CustomPanel.RJButton btnSearchForUser;
        public System.Windows.Forms.ContextMenuStrip cmsDataGrid;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateUser;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteUser;
        public CustomPanel.BorderRadiusTXT txtUserAdministrationSearch;
        private System.Windows.Forms.Label lblUserAdministrationSearch;
        public System.Windows.Forms.ToolStripMenuItem cmsViewUser;
        public System.Windows.Forms.ToolStripMenuItem cmsReestablishPassword;
    }
}