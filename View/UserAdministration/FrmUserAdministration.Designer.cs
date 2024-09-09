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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmsDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsReestablishPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsViewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCustom2 = new CustomControls.PanelCustom();
            this.dgvUserDisplay = new System.Windows.Forms.DataGridView();
            this.panelCustom1 = new CustomControls.PanelCustom();
            this.grpFilterSearchUser = new System.Windows.Forms.GroupBox();
            this.chkShowInactiveUsers = new System.Windows.Forms.CheckBox();
            this.btnSearchForUser = new CustomControls.RJButton();
            this.txtUserAdministrationSearch = new CustomControls.CustomTextBox();
            this.lblUserAdministrationSearch = new System.Windows.Forms.Label();
            this.btnFilter = new CustomControls.RJButton();
            this.cmbUserAdministrationFilter = new System.Windows.Forms.ComboBox();
            this.lblUserAdministrationFilter = new System.Windows.Forms.Label();
            this.grpNewUser = new System.Windows.Forms.GroupBox();
            this.btnAddNewUser = new CustomControls.RJButton();
            this.panel1.SuspendLayout();
            this.cmsDataGrid.SuspendLayout();
            this.panelCustom2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDisplay)).BeginInit();
            this.panelCustom1.SuspendLayout();
            this.grpFilterSearchUser.SuspendLayout();
            this.grpNewUser.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(471, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Administración de Usuarios";
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
            this.panelCustom2.Controls.Add(this.dgvUserDisplay);
            this.panelCustom2.ForeColor = System.Drawing.Color.Black;
            this.panelCustom2.GradientAngle = 90F;
            this.panelCustom2.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustom2.GradientTopColor = System.Drawing.Color.White;
            this.panelCustom2.Location = new System.Drawing.Point(421, 152);
            this.panelCustom2.Margin = new System.Windows.Forms.Padding(0, 32, 32, 32);
            this.panelCustom2.Name = "panelCustom2";
            this.panelCustom2.Size = new System.Drawing.Size(908, 641);
            this.panelCustom2.TabIndex = 1;
            // 
            // dgvUserDisplay
            // 
            this.dgvUserDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserDisplay.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserDisplay.ContextMenuStrip = this.cmsDataGrid;
            this.dgvUserDisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.dgvUserDisplay.Location = new System.Drawing.Point(0, 0);
            this.dgvUserDisplay.Name = "dgvUserDisplay";
            this.dgvUserDisplay.ReadOnly = true;
            this.dgvUserDisplay.Size = new System.Drawing.Size(908, 641);
            this.dgvUserDisplay.TabIndex = 0;
            // 
            // panelCustom1
            // 
            this.panelCustom1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCustom1.BackColor = System.Drawing.Color.White;
            this.panelCustom1.BorderRadius = 30;
            this.panelCustom1.Controls.Add(this.grpFilterSearchUser);
            this.panelCustom1.Controls.Add(this.grpNewUser);
            this.panelCustom1.ForeColor = System.Drawing.Color.Black;
            this.panelCustom1.GradientAngle = 90F;
            this.panelCustom1.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustom1.GradientTopColor = System.Drawing.Color.White;
            this.panelCustom1.Location = new System.Drawing.Point(39, 152);
            this.panelCustom1.Margin = new System.Windows.Forms.Padding(32);
            this.panelCustom1.Name = "panelCustom1";
            this.panelCustom1.Size = new System.Drawing.Size(350, 641);
            this.panelCustom1.TabIndex = 0;
            // 
            // grpFilterSearchUser
            // 
            this.grpFilterSearchUser.Controls.Add(this.chkShowInactiveUsers);
            this.grpFilterSearchUser.Controls.Add(this.btnSearchForUser);
            this.grpFilterSearchUser.Controls.Add(this.txtUserAdministrationSearch);
            this.grpFilterSearchUser.Controls.Add(this.lblUserAdministrationSearch);
            this.grpFilterSearchUser.Controls.Add(this.btnFilter);
            this.grpFilterSearchUser.Controls.Add(this.cmbUserAdministrationFilter);
            this.grpFilterSearchUser.Controls.Add(this.lblUserAdministrationFilter);
            this.grpFilterSearchUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilterSearchUser.ForeColor = System.Drawing.Color.DarkGray;
            this.grpFilterSearchUser.Location = new System.Drawing.Point(45, 45);
            this.grpFilterSearchUser.Margin = new System.Windows.Forms.Padding(45);
            this.grpFilterSearchUser.Name = "grpFilterSearchUser";
            this.grpFilterSearchUser.Size = new System.Drawing.Size(260, 418);
            this.grpFilterSearchUser.TabIndex = 2;
            this.grpFilterSearchUser.TabStop = false;
            this.grpFilterSearchUser.Text = "Filtrar / Buscar Usuarios";
            // 
            // chkShowInactiveUsers
            // 
            this.chkShowInactiveUsers.AutoSize = true;
            this.chkShowInactiveUsers.Location = new System.Drawing.Point(24, 240);
            this.chkShowInactiveUsers.Name = "chkShowInactiveUsers";
            this.chkShowInactiveUsers.Size = new System.Drawing.Size(165, 19);
            this.chkShowInactiveUsers.TabIndex = 6;
            this.chkShowInactiveUsers.Text = "Mostrar usuarios inactivos";
            this.chkShowInactiveUsers.UseVisualStyleBackColor = true;
            // 
            // btnSearchForUser
            // 
            this.btnSearchForUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSearchForUser.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSearchForUser.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearchForUser.BorderRadius = 30;
            this.btnSearchForUser.BorderSize = 0;
            this.btnSearchForUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchForUser.FlatAppearance.BorderSize = 0;
            this.btnSearchForUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchForUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSearchForUser.Location = new System.Drawing.Point(161, 180);
            this.btnSearchForUser.Name = "btnSearchForUser";
            this.btnSearchForUser.Size = new System.Drawing.Size(75, 32);
            this.btnSearchForUser.TabIndex = 5;
            this.btnSearchForUser.Text = "Buscar";
            this.btnSearchForUser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSearchForUser.UseVisualStyleBackColor = false;
            // 
            // txtUserAdministrationSearch
            // 
            this.txtUserAdministrationSearch.BackColor = System.Drawing.Color.White;
            this.txtUserAdministrationSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUserAdministrationSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserAdministrationSearch.BorderRadius = 15;
            this.txtUserAdministrationSearch.BorderSize = 2;
            this.txtUserAdministrationSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUserAdministrationSearch.Location = new System.Drawing.Point(24, 144);
            this.txtUserAdministrationSearch.MaxLength = 32767;
            this.txtUserAdministrationSearch.Multiline = false;
            this.txtUserAdministrationSearch.Name = "txtUserAdministrationSearch";
            this.txtUserAdministrationSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserAdministrationSearch.PasswordChar = false;
            this.txtUserAdministrationSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationSearch.PlaceholderText = "";
            this.txtUserAdministrationSearch.Size = new System.Drawing.Size(212, 30);
            this.txtUserAdministrationSearch.TabIndex = 4;
            this.txtUserAdministrationSearch.Texts = "";
            this.txtUserAdministrationSearch.UnderlinedStyle = false;
            // 
            // lblUserAdministrationSearch
            // 
            this.lblUserAdministrationSearch.AutoSize = true;
            this.lblUserAdministrationSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblUserAdministrationSearch.Location = new System.Drawing.Point(21, 126);
            this.lblUserAdministrationSearch.Name = "lblUserAdministrationSearch";
            this.lblUserAdministrationSearch.Size = new System.Drawing.Size(92, 15);
            this.lblUserAdministrationSearch.TabIndex = 3;
            this.lblUserAdministrationSearch.Text = "Buscar usuarios";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnFilter.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnFilter.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnFilter.BorderRadius = 30;
            this.btnFilter.BorderSize = 0;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnFilter.Location = new System.Drawing.Point(161, 79);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 32);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // cmbUserAdministrationFilter
            // 
            this.cmbUserAdministrationFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserAdministrationFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.cmbUserAdministrationFilter.FormattingEnabled = true;
            this.cmbUserAdministrationFilter.Location = new System.Drawing.Point(24, 48);
            this.cmbUserAdministrationFilter.Margin = new System.Windows.Forms.Padding(5);
            this.cmbUserAdministrationFilter.Name = "cmbUserAdministrationFilter";
            this.cmbUserAdministrationFilter.Size = new System.Drawing.Size(212, 23);
            this.cmbUserAdministrationFilter.TabIndex = 1;
            // 
            // lblUserAdministrationFilter
            // 
            this.lblUserAdministrationFilter.AutoSize = true;
            this.lblUserAdministrationFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblUserAdministrationFilter.Location = new System.Drawing.Point(21, 28);
            this.lblUserAdministrationFilter.Name = "lblUserAdministrationFilter";
            this.lblUserAdministrationFilter.Size = new System.Drawing.Size(109, 15);
            this.lblUserAdministrationFilter.TabIndex = 0;
            this.lblUserAdministrationFilter.Text = "Filtrar usuarios por:";
            // 
            // grpNewUser
            // 
            this.grpNewUser.Controls.Add(this.btnAddNewUser);
            this.grpNewUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewUser.ForeColor = System.Drawing.Color.DarkGray;
            this.grpNewUser.Location = new System.Drawing.Point(45, 496);
            this.grpNewUser.Margin = new System.Windows.Forms.Padding(45);
            this.grpNewUser.Name = "grpNewUser";
            this.grpNewUser.Size = new System.Drawing.Size(260, 100);
            this.grpNewUser.TabIndex = 1;
            this.grpNewUser.TabStop = false;
            this.grpNewUser.Text = "Añadir Usuarios";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddNewUser.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddNewUser.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddNewUser.BorderRadius = 40;
            this.btnAddNewUser.BorderSize = 0;
            this.btnAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewUser.FlatAppearance.BorderSize = 0;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddNewUser.Location = new System.Drawing.Point(24, 28);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(21);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(212, 48);
            this.btnAddNewUser.TabIndex = 0;
            this.btnAddNewUser.Text = "Nuevo Usuario";
            this.btnAddNewUser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            // 
            // FrmUserAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1370, 825);
            this.Controls.Add(this.panelCustom2);
            this.Controls.Add(this.panelCustom1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1240, 825);
            this.Name = "FrmUserAdministration";
            this.Text = "FrmUserAdministration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsDataGrid.ResumeLayout(false);
            this.panelCustom2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDisplay)).EndInit();
            this.panelCustom1.ResumeLayout(false);
            this.grpFilterSearchUser.ResumeLayout(false);
            this.grpFilterSearchUser.PerformLayout();
            this.grpNewUser.ResumeLayout(false);
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
        public System.Windows.Forms.DataGridView dgvUserDisplay;
        public CustomControls.PanelCustom panelCustom1;
        private System.Windows.Forms.GroupBox grpFilterSearchUser;
        private System.Windows.Forms.CheckBox chkShowInactiveUsers;
        public CustomControls.RJButton btnSearchForUser;
        public CustomControls.CustomTextBox txtUserAdministrationSearch;
        private System.Windows.Forms.Label lblUserAdministrationSearch;
        public CustomControls.RJButton btnFilter;
        public System.Windows.Forms.ComboBox cmbUserAdministrationFilter;
        private System.Windows.Forms.Label lblUserAdministrationFilter;
        private System.Windows.Forms.GroupBox grpNewUser;
        public CustomControls.RJButton btnAddNewUser;
        public CustomControls.PanelCustom panelCustom2;
    }
}