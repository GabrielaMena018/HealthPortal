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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsViewUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsReestablishPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpInventory = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSide = new CustomControls.PanelCustom();
            this.tlpSide = new System.Windows.Forms.TableLayoutPanel();
            this.grpNewUser = new System.Windows.Forms.GroupBox();
            this.tlpSub1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddNewUser = new CustomControls.RJButton();
            this.grpFilterSearchUsers = new System.Windows.Forms.GroupBox();
            this.tlpSub2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchForUser = new CustomControls.RJButton();
            this.txtUserAdministrationSearch = new CustomControls.CustomTextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.rdoShowInactiveUsers = new System.Windows.Forms.RadioButton();
            this.pnlMain = new CustomControls.PanelCustom();
            this.dgvUserDisplay = new System.Windows.Forms.DataGridView();
            this.cmsDataGrid.SuspendLayout();
            this.tlpInventory.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlSide.SuspendLayout();
            this.tlpSide.SuspendLayout();
            this.grpNewUser.SuspendLayout();
            this.tlpSub1.SuspendLayout();
            this.grpFilterSearchUsers.SuspendLayout();
            this.tlpSub2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsDataGrid
            // 
            this.cmsDataGrid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeleteUser,
            this.cmsViewUserInfo,
            this.cmsUpdateUserInfo,
            this.cmsReestablishPassword});
            this.cmsDataGrid.Name = "cmsDataGrid";
            this.cmsDataGrid.Size = new System.Drawing.Size(278, 92);
            // 
            // cmsDeleteUser
            // 
            this.cmsDeleteUser.Name = "cmsDeleteUser";
            this.cmsDeleteUser.Size = new System.Drawing.Size(277, 22);
            this.cmsDeleteUser.Text = "Eliminar usuario";
            // 
            // cmsViewUserInfo
            // 
            this.cmsViewUserInfo.Name = "cmsViewUserInfo";
            this.cmsViewUserInfo.Size = new System.Drawing.Size(277, 22);
            this.cmsViewUserInfo.Text = "Ver información del usuario";
            // 
            // cmsUpdateUserInfo
            // 
            this.cmsUpdateUserInfo.Name = "cmsUpdateUserInfo";
            this.cmsUpdateUserInfo.Size = new System.Drawing.Size(277, 22);
            this.cmsUpdateUserInfo.Text = "Actualizar información del usuario";
            // 
            // cmsReestablishPassword
            // 
            this.cmsReestablishPassword.Name = "cmsReestablishPassword";
            this.cmsReestablishPassword.Size = new System.Drawing.Size(277, 22);
            this.cmsReestablishPassword.Text = "Reestablecer contraseña";
            // 
            // tlpInventory
            // 
            this.tlpInventory.ColumnCount = 5;
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.830345F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.45971F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.830345F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.04926F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.830345F));
            this.tlpInventory.Controls.Add(this.pnlTitle, 0, 0);
            this.tlpInventory.Controls.Add(this.pnlSide, 1, 2);
            this.tlpInventory.Controls.Add(this.pnlMain, 3, 2);
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
            // pnlTitle
            // 
            this.pnlTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.tlpInventory.SetColumnSpan(this.pnlTitle, 5);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1370, 117);
            this.pnlTitle.TabIndex = 1;
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
            // pnlSide
            // 
            this.pnlSide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSide.BackColor = System.Drawing.Color.White;
            this.pnlSide.BorderRadius = 30;
            this.pnlSide.Controls.Add(this.tlpSide);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSide.ForeColor = System.Drawing.Color.Black;
            this.pnlSide.GradientAngle = 90F;
            this.pnlSide.GradientBottomColor = System.Drawing.Color.White;
            this.pnlSide.GradientTopColor = System.Drawing.Color.White;
            this.pnlSide.Location = new System.Drawing.Point(38, 155);
            this.pnlSide.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(348, 630);
            this.pnlSide.TabIndex = 2;
            // 
            // tlpSide
            // 
            this.tlpSide.ColumnCount = 3;
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.85F));
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.3F));
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.85F));
            this.tlpSide.Controls.Add(this.grpNewUser, 1, 3);
            this.tlpSide.Controls.Add(this.grpFilterSearchUsers, 1, 1);
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
            // grpNewUser
            // 
            this.grpNewUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpNewUser.Controls.Add(this.tlpSub1);
            this.grpNewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNewUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewUser.ForeColor = System.Drawing.Color.DarkGray;
            this.grpNewUser.Location = new System.Drawing.Point(44, 487);
            this.grpNewUser.Margin = new System.Windows.Forms.Padding(0);
            this.grpNewUser.Name = "grpNewUser";
            this.grpNewUser.Size = new System.Drawing.Size(258, 98);
            this.grpNewUser.TabIndex = 1;
            this.grpNewUser.TabStop = false;
            this.grpNewUser.Text = "Añadir usuarios";
            // 
            // tlpSub1
            // 
            this.tlpSub1.ColumnCount = 3;
            this.tlpSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.33F));
            this.tlpSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.34F));
            this.tlpSub1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.33F));
            this.tlpSub1.Controls.Add(this.btnAddNewUser, 1, 1);
            this.tlpSub1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSub1.Location = new System.Drawing.Point(3, 17);
            this.tlpSub1.Name = "tlpSub1";
            this.tlpSub1.RowCount = 3;
            this.tlpSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92F));
            this.tlpSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.16F));
            this.tlpSub1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92F));
            this.tlpSub1.Size = new System.Drawing.Size(252, 78);
            this.tlpSub1.TabIndex = 0;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddNewUser.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddNewUser.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddNewUser.BorderRadius = 30;
            this.btnAddNewUser.BorderSize = 0;
            this.btnAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewUser.FlatAppearance.BorderSize = 0;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddNewUser.Location = new System.Drawing.Point(20, 20);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(210, 36);
            this.btnAddNewUser.TabIndex = 1;
            this.btnAddNewUser.TabStop = false;
            this.btnAddNewUser.Text = "Nuevo Usuario";
            this.btnAddNewUser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            // 
            // grpFilterSearchUsers
            // 
            this.grpFilterSearchUsers.Controls.Add(this.tlpSub2);
            this.grpFilterSearchUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFilterSearchUsers.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpFilterSearchUsers.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpFilterSearchUsers.Location = new System.Drawing.Point(47, 47);
            this.grpFilterSearchUsers.Name = "grpFilterSearchUsers";
            this.grpFilterSearchUsers.Size = new System.Drawing.Size(252, 405);
            this.grpFilterSearchUsers.TabIndex = 2;
            this.grpFilterSearchUsers.TabStop = false;
            this.grpFilterSearchUsers.Text = "Filtrar / Buscar usuarios";
            // 
            // tlpSub2
            // 
            this.tlpSub2.ColumnCount = 4;
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.331947F));
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66805F));
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66805F));
            this.tlpSub2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.331947F));
            this.tlpSub2.Controls.Add(this.btnSearchForUser, 2, 5);
            this.tlpSub2.Controls.Add(this.txtUserAdministrationSearch, 1, 3);
            this.tlpSub2.Controls.Add(this.lblSearch, 1, 1);
            this.tlpSub2.Controls.Add(this.rdoShowInactiveUsers, 1, 7);
            this.tlpSub2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSub2.Location = new System.Drawing.Point(3, 17);
            this.tlpSub2.Name = "tlpSub2";
            this.tlpSub2.RowCount = 14;
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.989553F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.935065F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.012987F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.831169F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.311688F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.896104F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.935065F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.155844F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.233766F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.863127F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.935065F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.31169F));
            this.tlpSub2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.989553F));
            this.tlpSub2.Size = new System.Drawing.Size(246, 385);
            this.tlpSub2.TabIndex = 3;
            // 
            // btnSearchForUser
            // 
            this.btnSearchForUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSearchForUser.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnSearchForUser.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearchForUser.BorderRadius = 30;
            this.btnSearchForUser.BorderSize = 0;
            this.btnSearchForUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchForUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchForUser.FlatAppearance.BorderSize = 0;
            this.btnSearchForUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchForUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSearchForUser.Location = new System.Drawing.Point(122, 114);
            this.btnSearchForUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchForUser.Name = "btnSearchForUser";
            this.btnSearchForUser.Size = new System.Drawing.Size(102, 32);
            this.btnSearchForUser.TabIndex = 35;
            this.btnSearchForUser.TabStop = false;
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
            this.tlpSub2.SetColumnSpan(this.txtUserAdministrationSearch, 2);
            this.txtUserAdministrationSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserAdministrationSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.txtUserAdministrationSearch.Location = new System.Drawing.Point(20, 69);
            this.txtUserAdministrationSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserAdministrationSearch.MaxLength = 60;
            this.txtUserAdministrationSearch.Multiline = false;
            this.txtUserAdministrationSearch.Name = "txtUserAdministrationSearch";
            this.txtUserAdministrationSearch.Padding = new System.Windows.Forms.Padding(20, 9, 20, 9);
            this.txtUserAdministrationSearch.PasswordChar = false;
            this.txtUserAdministrationSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationSearch.PlaceholderText = "";
            this.txtUserAdministrationSearch.SelectionLength = 0;
            this.txtUserAdministrationSearch.SelectionStart = 0;
            this.txtUserAdministrationSearch.Size = new System.Drawing.Size(204, 34);
            this.txtUserAdministrationSearch.TabIndex = 34;
            this.txtUserAdministrationSearch.TabStop = false;
            this.txtUserAdministrationSearch.Tag = "name";
            this.txtUserAdministrationSearch.Texts = "";
            this.txtUserAdministrationSearch.UnderlinedStyle = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.tlpSub2.SetColumnSpan(this.lblSearch, 2);
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblSearch.Location = new System.Drawing.Point(23, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(198, 19);
            this.lblSearch.TabIndex = 33;
            this.lblSearch.Text = "Buscar usuarios";
            // 
            // rdoShowInactiveUsers
            // 
            this.rdoShowInactiveUsers.AutoSize = true;
            this.tlpSub2.SetColumnSpan(this.rdoShowInactiveUsers, 2);
            this.rdoShowInactiveUsers.Location = new System.Drawing.Point(20, 161);
            this.rdoShowInactiveUsers.Margin = new System.Windows.Forms.Padding(0);
            this.rdoShowInactiveUsers.Name = "rdoShowInactiveUsers";
            this.rdoShowInactiveUsers.Size = new System.Drawing.Size(164, 19);
            this.rdoShowInactiveUsers.TabIndex = 36;
            this.rdoShowInactiveUsers.TabStop = true;
            this.rdoShowInactiveUsers.Text = "Mostrar usuarios inactivos";
            this.rdoShowInactiveUsers.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderRadius = 30;
            this.pnlMain.Controls.Add(this.dgvUserDisplay);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.Black;
            this.pnlMain.GradientAngle = 90F;
            this.pnlMain.GradientBottomColor = System.Drawing.Color.White;
            this.pnlMain.GradientTopColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(424, 155);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(904, 630);
            this.pnlMain.TabIndex = 3;
            // 
            // dgvUserDisplay
            // 
            this.dgvUserDisplay.AllowUserToAddRows = false;
            this.dgvUserDisplay.AllowUserToDeleteRows = false;
            this.dgvUserDisplay.AllowUserToResizeColumns = false;
            this.dgvUserDisplay.AllowUserToResizeRows = false;
            this.dgvUserDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserDisplay.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUserDisplay.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvUserDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.NullValue = "-----";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUserDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserDisplay.ContextMenuStrip = this.cmsDataGrid;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = "-----";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserDisplay.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUserDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserDisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dgvUserDisplay.Location = new System.Drawing.Point(0, 0);
            this.dgvUserDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.dgvUserDisplay.MultiSelect = false;
            this.dgvUserDisplay.Name = "dgvUserDisplay";
            this.dgvUserDisplay.ReadOnly = true;
            this.dgvUserDisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.NullValue = "-----";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUserDisplay.RowHeadersVisible = false;
            this.dgvUserDisplay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUserDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUserDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvUserDisplay.Size = new System.Drawing.Size(904, 630);
            this.dgvUserDisplay.TabIndex = 0;
            this.dgvUserDisplay.TabStop = false;
            // 
            // FrmUserAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1370, 825);
            this.Controls.Add(this.tlpInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserAdministration";
            this.Text = "HealthPortal | Inventario";
            this.cmsDataGrid.ResumeLayout(false);
            this.tlpInventory.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlSide.ResumeLayout(false);
            this.tlpSide.ResumeLayout(false);
            this.grpNewUser.ResumeLayout(false);
            this.tlpSub1.ResumeLayout(false);
            this.grpFilterSearchUsers.ResumeLayout(false);
            this.tlpSub2.ResumeLayout(false);
            this.tlpSub2.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ContextMenuStrip cmsDataGrid;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteUser;
        public System.Windows.Forms.ToolStripMenuItem cmsViewUserInfo;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateUserInfo;
        private System.Windows.Forms.TableLayoutPanel tlpInventory;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        public CustomControls.PanelCustom pnlSide;
        private System.Windows.Forms.GroupBox grpNewUser;
        public CustomControls.PanelCustom pnlMain;
        public System.Windows.Forms.DataGridView dgvUserDisplay;
        private System.Windows.Forms.TableLayoutPanel tlpSide;
        private System.Windows.Forms.TableLayoutPanel tlpSub1;
        public CustomControls.RJButton btnAddNewUser;
        private System.Windows.Forms.GroupBox grpFilterSearchUsers;
        private System.Windows.Forms.TableLayoutPanel tlpSub2;
        public CustomControls.RJButton btnSearchForUser;
        public CustomControls.CustomTextBox txtUserAdministrationSearch;
        private System.Windows.Forms.Label lblSearch;
        public System.Windows.Forms.RadioButton rdoShowInactiveUsers;
        public System.Windows.Forms.ToolStripMenuItem cmsReestablishPassword;
    }
}