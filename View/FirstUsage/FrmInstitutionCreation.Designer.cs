namespace HealthPortal.View.FirstUsage
{
    partial class FrmInstitutionCreation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picLocation = new System.Windows.Forms.PictureBox();
            this.grpLogo = new System.Windows.Forms.GroupBox();
            this.grpInstitutionInfo = new System.Windows.Forms.GroupBox();
            this.txtInstitutionName = new CustomPanel.BorderRadiusTXT();
            this.txtInstitutionAddress = new CustomPanel.BorderRadiusTXT();
            this.btnAddLogo = new CustomPanel.RJButton();
            this.btnRegisterInstitution = new CustomPanel.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation)).BeginInit();
            this.grpLogo.SuspendLayout();
            this.grpInstitutionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "¡Bienvendi@ a HealthPortal! Comenzaremos creando una institución que estará asoci" +
    "ada con el programa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Creación de Institución";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::HealthPortal.Properties.Resources.quit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(624, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Location = new System.Drawing.Point(20, 27);
            this.picLogo.Margin = new System.Windows.Forms.Padding(17);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(258, 258);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 28;
            this.picLogo.TabStop = false;
            // 
            // picLocation
            // 
            this.picLocation.Location = new System.Drawing.Point(20, 143);
            this.picLocation.Margin = new System.Windows.Forms.Padding(17);
            this.picLocation.Name = "picLocation";
            this.picLocation.Size = new System.Drawing.Size(258, 167);
            this.picLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLocation.TabIndex = 29;
            this.picLocation.TabStop = false;
            // 
            // grpLogo
            // 
            this.grpLogo.Controls.Add(this.picLogo);
            this.grpLogo.Controls.Add(this.btnAddLogo);
            this.grpLogo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpLogo.Location = new System.Drawing.Point(341, 92);
            this.grpLogo.Name = "grpLogo";
            this.grpLogo.Size = new System.Drawing.Size(298, 330);
            this.grpLogo.TabIndex = 30;
            this.grpLogo.TabStop = false;
            this.grpLogo.Text = "Logotipo de la Institución";
            // 
            // grpInstitutionInfo
            // 
            this.grpInstitutionInfo.Controls.Add(this.picLocation);
            this.grpInstitutionInfo.Controls.Add(this.txtInstitutionName);
            this.grpInstitutionInfo.Controls.Add(this.txtInstitutionAddress);
            this.grpInstitutionInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInstitutionInfo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpInstitutionInfo.Location = new System.Drawing.Point(21, 92);
            this.grpInstitutionInfo.Name = "grpInstitutionInfo";
            this.grpInstitutionInfo.Size = new System.Drawing.Size(298, 330);
            this.grpInstitutionInfo.TabIndex = 31;
            this.grpInstitutionInfo.TabStop = false;
            this.grpInstitutionInfo.Text = "Información de la Institución";
            // 
            // txtInstitutionName
            // 
            this.txtInstitutionName.BackColor = System.Drawing.SystemColors.Window;
            this.txtInstitutionName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtInstitutionName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtInstitutionName.BorderRadius = 18;
            this.txtInstitutionName.BorderSize = 2;
            this.txtInstitutionName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstitutionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtInstitutionName.Location = new System.Drawing.Point(20, 27);
            this.txtInstitutionName.Margin = new System.Windows.Forms.Padding(11);
            this.txtInstitutionName.MaxLength = 50;
            this.txtInstitutionName.Multiline = false;
            this.txtInstitutionName.Name = "txtInstitutionName";
            this.txtInstitutionName.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtInstitutionName.PasswordChar = false;
            this.txtInstitutionName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtInstitutionName.PlaceholderText = "";
            this.txtInstitutionName.Size = new System.Drawing.Size(258, 38);
            this.txtInstitutionName.TabIndex = 1;
            this.txtInstitutionName.Texts = "Nombre de la Institución";
            this.txtInstitutionName.UnderlinedStyle = false;
            // 
            // txtInstitutionAddress
            // 
            this.txtInstitutionAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtInstitutionAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtInstitutionAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtInstitutionAddress.BorderRadius = 18;
            this.txtInstitutionAddress.BorderSize = 2;
            this.txtInstitutionAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstitutionAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtInstitutionAddress.Location = new System.Drawing.Point(20, 82);
            this.txtInstitutionAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtInstitutionAddress.MaxLength = 250;
            this.txtInstitutionAddress.Multiline = false;
            this.txtInstitutionAddress.Name = "txtInstitutionAddress";
            this.txtInstitutionAddress.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtInstitutionAddress.PasswordChar = false;
            this.txtInstitutionAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtInstitutionAddress.PlaceholderText = "";
            this.txtInstitutionAddress.Size = new System.Drawing.Size(258, 38);
            this.txtInstitutionAddress.TabIndex = 2;
            this.txtInstitutionAddress.Texts = "Dirección de la Institución";
            this.txtInstitutionAddress.UnderlinedStyle = false;
            // 
            // btnAddLogo
            // 
            this.btnAddLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddLogo.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddLogo.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddLogo.BorderRadius = 20;
            this.btnAddLogo.BorderSize = 0;
            this.btnAddLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLogo.FlatAppearance.BorderSize = 0;
            this.btnAddLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLogo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddLogo.Location = new System.Drawing.Point(20, 294);
            this.btnAddLogo.Margin = new System.Windows.Forms.Padding(7);
            this.btnAddLogo.Name = "btnAddLogo";
            this.btnAddLogo.Size = new System.Drawing.Size(258, 26);
            this.btnAddLogo.TabIndex = 3;
            this.btnAddLogo.Text = "Añadir Logo de la Institución";
            this.btnAddLogo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddLogo.UseVisualStyleBackColor = false;
            // 
            // btnRegisterInstitution
            // 
            this.btnRegisterInstitution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnRegisterInstitution.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnRegisterInstitution.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegisterInstitution.BorderRadius = 30;
            this.btnRegisterInstitution.BorderSize = 0;
            this.btnRegisterInstitution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterInstitution.FlatAppearance.BorderSize = 0;
            this.btnRegisterInstitution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterInstitution.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterInstitution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnRegisterInstitution.Location = new System.Drawing.Point(21, 445);
            this.btnRegisterInstitution.Margin = new System.Windows.Forms.Padding(176, 3, 176, 20);
            this.btnRegisterInstitution.Name = "btnRegisterInstitution";
            this.btnRegisterInstitution.Size = new System.Drawing.Size(620, 40);
            this.btnRegisterInstitution.TabIndex = 4;
            this.btnRegisterInstitution.Text = "Registrar Institución";
            this.btnRegisterInstitution.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnRegisterInstitution.UseVisualStyleBackColor = false;
            // 
            // FrmInstitutionCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 514);
            this.Controls.Add(this.grpInstitutionInfo);
            this.Controls.Add(this.grpLogo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegisterInstitution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInstitutionCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInstitutionCreation";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation)).EndInit();
            this.grpLogo.ResumeLayout(false);
            this.grpInstitutionInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CustomPanel.RJButton btnRegisterInstitution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnExit;
        public CustomPanel.BorderRadiusTXT txtInstitutionAddress;
        public CustomPanel.BorderRadiusTXT txtInstitutionName;
        public CustomPanel.RJButton btnAddLogo;
        private System.Windows.Forms.GroupBox grpLogo;
        private System.Windows.Forms.GroupBox grpInstitutionInfo;
        public System.Windows.Forms.PictureBox picLogo;
        public System.Windows.Forms.PictureBox picLocation;
    }
}