namespace HealthPortal.View.UserAdministration
{
    partial class FrmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUpdateUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelCustom1 = new CustomControls.PanelCustom();
            this.panel9 = new System.Windows.Forms.Panel();
            this.grpLoginInfo = new System.Windows.Forms.GroupBox();
            this.cmbUserAdministrationRole = new System.Windows.Forms.ComboBox();
            this.lblUserAdministrationRole = new System.Windows.Forms.Label();
            this.txtUserAdministrationUsername = new CustomControls.CustomTextBox();
            this.lblUserAdministrationUsername = new System.Windows.Forms.Label();
            this.btnUpdateUser = new CustomControls.RJButton();
            this.btnAddNewUser = new CustomControls.RJButton();
            this.txtUserAdministrationPhoneNumber = new CustomControls.CustomTextBox();
            this.lblUserAdministrationPhoneNumber = new System.Windows.Forms.Label();
            this.txtUserAdministrationEmail = new CustomControls.CustomTextBox();
            this.lblUserAdministrationEmail = new System.Windows.Forms.Label();
            this.txtUserAdministrationLastName = new CustomControls.CustomTextBox();
            this.lblUserAdministrationLastName = new System.Windows.Forms.Label();
            this.txtUserAdministrationName = new CustomControls.CustomTextBox();
            this.lblUserAdministrationName = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtUserAdministrationId = new CustomControls.CustomTextBox();
            this.panel1.SuspendLayout();
            this.panelCustom1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.grpLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUserAdministrationId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 30);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 551);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 30);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 521);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(444, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 521);
            this.panel4.TabIndex = 3;
            // 
            // panelCustom1
            // 
            this.panelCustom1.BackColor = System.Drawing.Color.White;
            this.panelCustom1.BorderRadius = 30;
            this.panelCustom1.Controls.Add(this.panel9);
            this.panelCustom1.Controls.Add(this.panel8);
            this.panelCustom1.Controls.Add(this.panel7);
            this.panelCustom1.Controls.Add(this.panel6);
            this.panelCustom1.Controls.Add(this.panel5);
            this.panelCustom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustom1.ForeColor = System.Drawing.Color.Black;
            this.panelCustom1.GradientAngle = 90F;
            this.panelCustom1.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustom1.GradientTopColor = System.Drawing.Color.White;
            this.panelCustom1.Location = new System.Drawing.Point(30, 30);
            this.panelCustom1.Name = "panelCustom1";
            this.panelCustom1.Size = new System.Drawing.Size(414, 521);
            this.panelCustom1.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.grpLoginInfo);
            this.panel9.Controls.Add(this.btnUpdateUser);
            this.panel9.Controls.Add(this.btnAddNewUser);
            this.panel9.Controls.Add(this.txtUserAdministrationPhoneNumber);
            this.panel9.Controls.Add(this.lblUserAdministrationPhoneNumber);
            this.panel9.Controls.Add(this.txtUserAdministrationEmail);
            this.panel9.Controls.Add(this.lblUserAdministrationEmail);
            this.panel9.Controls.Add(this.txtUserAdministrationLastName);
            this.panel9.Controls.Add(this.lblUserAdministrationLastName);
            this.panel9.Controls.Add(this.txtUserAdministrationName);
            this.panel9.Controls.Add(this.lblUserAdministrationName);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(20, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(374, 481);
            this.panel9.TabIndex = 4;
            // 
            // grpLoginInfo
            // 
            this.grpLoginInfo.Controls.Add(this.cmbUserAdministrationRole);
            this.grpLoginInfo.Controls.Add(this.lblUserAdministrationRole);
            this.grpLoginInfo.Controls.Add(this.txtUserAdministrationUsername);
            this.grpLoginInfo.Controls.Add(this.lblUserAdministrationUsername);
            this.grpLoginInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoginInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpLoginInfo.Location = new System.Drawing.Point(10, 288);
            this.grpLoginInfo.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.grpLoginInfo.Name = "grpLoginInfo";
            this.grpLoginInfo.Padding = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.grpLoginInfo.Size = new System.Drawing.Size(355, 124);
            this.grpLoginInfo.TabIndex = 28;
            this.grpLoginInfo.TabStop = false;
            this.grpLoginInfo.Text = "Información para inicio de sesión";
            // 
            // cmbUserAdministrationRole
            // 
            this.cmbUserAdministrationRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserAdministrationRole.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbUserAdministrationRole.FormattingEnabled = true;
            this.cmbUserAdministrationRole.Location = new System.Drawing.Point(186, 58);
            this.cmbUserAdministrationRole.Name = "cmbUserAdministrationRole";
            this.cmbUserAdministrationRole.Size = new System.Drawing.Size(155, 25);
            this.cmbUserAdministrationRole.TabIndex = 27;
            // 
            // lblUserAdministrationRole
            // 
            this.lblUserAdministrationRole.AutoSize = true;
            this.lblUserAdministrationRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserAdministrationRole.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserAdministrationRole.Location = new System.Drawing.Point(182, 33);
            this.lblUserAdministrationRole.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblUserAdministrationRole.Name = "lblUserAdministrationRole";
            this.lblUserAdministrationRole.Size = new System.Drawing.Size(28, 19);
            this.lblUserAdministrationRole.TabIndex = 30;
            this.lblUserAdministrationRole.Text = "Rol";
            // 
            // txtUserAdministrationUsername
            // 
            this.txtUserAdministrationUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserAdministrationUsername.BorderColor = System.Drawing.Color.LightGray;
            this.txtUserAdministrationUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUserAdministrationUsername.BorderRadius = 10;
            this.txtUserAdministrationUsername.BorderSize = 2;
            this.txtUserAdministrationUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserAdministrationUsername.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtUserAdministrationUsername.Location = new System.Drawing.Point(20, 58);
            this.txtUserAdministrationUsername.Multiline = false;
            this.txtUserAdministrationUsername.Name = "txtUserAdministrationUsername";
            this.txtUserAdministrationUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserAdministrationUsername.PasswordChar = false;
            this.txtUserAdministrationUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationUsername.PlaceholderText = "";
            this.txtUserAdministrationUsername.Size = new System.Drawing.Size(140, 34);
            this.txtUserAdministrationUsername.TabIndex = 26;
            this.txtUserAdministrationUsername.Texts = "";
            this.txtUserAdministrationUsername.UnderlinedStyle = false;
            // 
            // lblUserAdministrationUsername
            // 
            this.lblUserAdministrationUsername.AutoSize = true;
            this.lblUserAdministrationUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserAdministrationUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserAdministrationUsername.Location = new System.Drawing.Point(16, 33);
            this.lblUserAdministrationUsername.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblUserAdministrationUsername.Name = "lblUserAdministrationUsername";
            this.lblUserAdministrationUsername.Size = new System.Drawing.Size(56, 19);
            this.lblUserAdministrationUsername.TabIndex = 29;
            this.lblUserAdministrationUsername.Text = "Usuario";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnUpdateUser.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnUpdateUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnUpdateUser.BorderRadius = 40;
            this.btnUpdateUser.BorderSize = 0;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.Location = new System.Drawing.Point(196, 426);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(155, 46);
            this.btnUpdateUser.TabIndex = 31;
            this.btnUpdateUser.Text = "Actualizar";
            this.btnUpdateUser.TextColor = System.Drawing.Color.Black;
            this.btnUpdateUser.UseVisualStyleBackColor = false;
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
            this.btnAddNewUser.Location = new System.Drawing.Point(15, 426);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(155, 46);
            this.btnAddNewUser.TabIndex = 29;
            this.btnAddNewUser.Text = "Agregar";
            this.btnAddNewUser.TextColor = System.Drawing.Color.Black;
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            // 
            // txtUserAdministrationPhoneNumber
            // 
            this.txtUserAdministrationPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserAdministrationPhoneNumber.BorderColor = System.Drawing.Color.LightGray;
            this.txtUserAdministrationPhoneNumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUserAdministrationPhoneNumber.BorderRadius = 10;
            this.txtUserAdministrationPhoneNumber.BorderSize = 2;
            this.txtUserAdministrationPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserAdministrationPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtUserAdministrationPhoneNumber.Location = new System.Drawing.Point(10, 235);
            this.txtUserAdministrationPhoneNumber.Multiline = false;
            this.txtUserAdministrationPhoneNumber.Name = "txtUserAdministrationPhoneNumber";
            this.txtUserAdministrationPhoneNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserAdministrationPhoneNumber.PasswordChar = false;
            this.txtUserAdministrationPhoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationPhoneNumber.PlaceholderText = "";
            this.txtUserAdministrationPhoneNumber.Size = new System.Drawing.Size(358, 34);
            this.txtUserAdministrationPhoneNumber.TabIndex = 25;
            this.txtUserAdministrationPhoneNumber.Texts = "";
            this.txtUserAdministrationPhoneNumber.UnderlinedStyle = false;
            // 
            // lblUserAdministrationPhoneNumber
            // 
            this.lblUserAdministrationPhoneNumber.AutoSize = true;
            this.lblUserAdministrationPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserAdministrationPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserAdministrationPhoneNumber.Location = new System.Drawing.Point(6, 210);
            this.lblUserAdministrationPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblUserAdministrationPhoneNumber.Name = "lblUserAdministrationPhoneNumber";
            this.lblUserAdministrationPhoneNumber.Size = new System.Drawing.Size(97, 19);
            this.lblUserAdministrationPhoneNumber.TabIndex = 24;
            this.lblUserAdministrationPhoneNumber.Text = "N° de teléfono";
            // 
            // txtUserAdministrationEmail
            // 
            this.txtUserAdministrationEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserAdministrationEmail.BorderColor = System.Drawing.Color.LightGray;
            this.txtUserAdministrationEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUserAdministrationEmail.BorderRadius = 10;
            this.txtUserAdministrationEmail.BorderSize = 2;
            this.txtUserAdministrationEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserAdministrationEmail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtUserAdministrationEmail.Location = new System.Drawing.Point(10, 167);
            this.txtUserAdministrationEmail.Multiline = false;
            this.txtUserAdministrationEmail.Name = "txtUserAdministrationEmail";
            this.txtUserAdministrationEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserAdministrationEmail.PasswordChar = false;
            this.txtUserAdministrationEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationEmail.PlaceholderText = "";
            this.txtUserAdministrationEmail.Size = new System.Drawing.Size(358, 34);
            this.txtUserAdministrationEmail.TabIndex = 23;
            this.txtUserAdministrationEmail.Texts = "";
            this.txtUserAdministrationEmail.UnderlinedStyle = false;
            // 
            // lblUserAdministrationEmail
            // 
            this.lblUserAdministrationEmail.AutoSize = true;
            this.lblUserAdministrationEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserAdministrationEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserAdministrationEmail.Location = new System.Drawing.Point(6, 142);
            this.lblUserAdministrationEmail.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblUserAdministrationEmail.Name = "lblUserAdministrationEmail";
            this.lblUserAdministrationEmail.Size = new System.Drawing.Size(121, 19);
            this.lblUserAdministrationEmail.TabIndex = 22;
            this.lblUserAdministrationEmail.Text = "Correo electrónico";
            // 
            // txtUserAdministrationLastName
            // 
            this.txtUserAdministrationLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserAdministrationLastName.BorderColor = System.Drawing.Color.LightGray;
            this.txtUserAdministrationLastName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUserAdministrationLastName.BorderRadius = 10;
            this.txtUserAdministrationLastName.BorderSize = 2;
            this.txtUserAdministrationLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserAdministrationLastName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtUserAdministrationLastName.Location = new System.Drawing.Point(10, 99);
            this.txtUserAdministrationLastName.Multiline = false;
            this.txtUserAdministrationLastName.Name = "txtUserAdministrationLastName";
            this.txtUserAdministrationLastName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserAdministrationLastName.PasswordChar = false;
            this.txtUserAdministrationLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationLastName.PlaceholderText = "";
            this.txtUserAdministrationLastName.Size = new System.Drawing.Size(358, 34);
            this.txtUserAdministrationLastName.TabIndex = 21;
            this.txtUserAdministrationLastName.Texts = "";
            this.txtUserAdministrationLastName.UnderlinedStyle = false;
            // 
            // lblUserAdministrationLastName
            // 
            this.lblUserAdministrationLastName.AutoSize = true;
            this.lblUserAdministrationLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserAdministrationLastName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserAdministrationLastName.Location = new System.Drawing.Point(6, 74);
            this.lblUserAdministrationLastName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lblUserAdministrationLastName.Name = "lblUserAdministrationLastName";
            this.lblUserAdministrationLastName.Size = new System.Drawing.Size(64, 19);
            this.lblUserAdministrationLastName.TabIndex = 20;
            this.lblUserAdministrationLastName.Text = "Apellidos";
            // 
            // txtUserAdministrationName
            // 
            this.txtUserAdministrationName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserAdministrationName.BorderColor = System.Drawing.Color.LightGray;
            this.txtUserAdministrationName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUserAdministrationName.BorderRadius = 10;
            this.txtUserAdministrationName.BorderSize = 2;
            this.txtUserAdministrationName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserAdministrationName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtUserAdministrationName.Location = new System.Drawing.Point(10, 31);
            this.txtUserAdministrationName.Multiline = false;
            this.txtUserAdministrationName.Name = "txtUserAdministrationName";
            this.txtUserAdministrationName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserAdministrationName.PasswordChar = false;
            this.txtUserAdministrationName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationName.PlaceholderText = "";
            this.txtUserAdministrationName.Size = new System.Drawing.Size(358, 34);
            this.txtUserAdministrationName.TabIndex = 19;
            this.txtUserAdministrationName.Texts = "";
            this.txtUserAdministrationName.UnderlinedStyle = false;
            // 
            // lblUserAdministrationName
            // 
            this.lblUserAdministrationName.AutoSize = true;
            this.lblUserAdministrationName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserAdministrationName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserAdministrationName.Location = new System.Drawing.Point(6, 6);
            this.lblUserAdministrationName.Margin = new System.Windows.Forms.Padding(3);
            this.lblUserAdministrationName.Name = "lblUserAdministrationName";
            this.lblUserAdministrationName.Size = new System.Drawing.Size(65, 19);
            this.lblUserAdministrationName.TabIndex = 16;
            this.lblUserAdministrationName.Text = "Nombres";
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(20, 501);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(374, 20);
            this.panel8.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(20, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(374, 20);
            this.panel7.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(394, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(20, 521);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 521);
            this.panel5.TabIndex = 0;
            // 
            // txtUserAdministrationId
            // 
            this.txtUserAdministrationId.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserAdministrationId.BorderColor = System.Drawing.Color.LightGray;
            this.txtUserAdministrationId.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUserAdministrationId.BorderRadius = 10;
            this.txtUserAdministrationId.BorderSize = 2;
            this.txtUserAdministrationId.Enabled = false;
            this.txtUserAdministrationId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserAdministrationId.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtUserAdministrationId.Location = new System.Drawing.Point(53, 3);
            this.txtUserAdministrationId.Multiline = false;
            this.txtUserAdministrationId.Name = "txtUserAdministrationId";
            this.txtUserAdministrationId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserAdministrationId.PasswordChar = false;
            this.txtUserAdministrationId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAdministrationId.PlaceholderText = "";
            this.txtUserAdministrationId.Size = new System.Drawing.Size(358, 34);
            this.txtUserAdministrationId.TabIndex = 32;
            this.txtUserAdministrationId.Texts = "";
            this.txtUserAdministrationId.UnderlinedStyle = false;
            this.txtUserAdministrationId.Visible = false;
            // 
            // FrmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(474, 581);
            this.Controls.Add(this.panelCustom1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(490, 620);
            this.MinimumSize = new System.Drawing.Size(490, 620);
            this.Name = "FrmAddUpdateUser";
            this.Text = "Gestión de usuarios";
            this.panel1.ResumeLayout(false);
            this.panelCustom1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.grpLoginInfo.ResumeLayout(false);
            this.grpLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private CustomControls.PanelCustom panelCustom1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblUserAdministrationName;
        public CustomControls.CustomTextBox txtUserAdministrationName;
        public CustomControls.CustomTextBox txtUserAdministrationLastName;
        private System.Windows.Forms.Label lblUserAdministrationLastName;
        private System.Windows.Forms.Label lblUserAdministrationPhoneNumber;
        public CustomControls.CustomTextBox txtUserAdministrationEmail;
        private System.Windows.Forms.Label lblUserAdministrationEmail;
        public CustomControls.CustomTextBox txtUserAdministrationPhoneNumber;
        private System.Windows.Forms.GroupBox grpLoginInfo;
        public CustomControls.RJButton btnUpdateUser;
        public CustomControls.RJButton btnAddNewUser;
        private System.Windows.Forms.Label lblUserAdministrationRole;
        public CustomControls.CustomTextBox txtUserAdministrationUsername;
        private System.Windows.Forms.Label lblUserAdministrationUsername;
        public System.Windows.Forms.ComboBox cmbUserAdministrationRole;
        public CustomControls.CustomTextBox txtUserAdministrationId;
    }
}