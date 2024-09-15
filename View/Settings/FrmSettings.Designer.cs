namespace HealthPortal.View.Settings
{
    partial class FrmSettings
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
            this.tlpSettings = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUserSettings = new System.Windows.Forms.Panel();
            this.btnUserSettings = new System.Windows.Forms.Button();
            this.pnlInstitutionSettings = new System.Windows.Forms.Panel();
            this.btnInstitutionSettings = new System.Windows.Forms.Button();
            this.pnlServerSettings = new System.Windows.Forms.Panel();
            this.btnServerSettings = new System.Windows.Forms.Button();
            this.pnlProgramSettings = new System.Windows.Forms.Panel();
            this.btnProgramSettings = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.tlpSettings.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlSide.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.pnlUserSettings.SuspendLayout();
            this.pnlInstitutionSettings.SuspendLayout();
            this.pnlServerSettings.SuspendLayout();
            this.pnlProgramSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSettings
            // 
            this.tlpSettings.ColumnCount = 2;
            this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.92701F));
            this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.07299F));
            this.tlpSettings.Controls.Add(this.pnlTitle, 0, 0);
            this.tlpSettings.Controls.Add(this.pnlSide, 1, 1);
            this.tlpSettings.Controls.Add(this.pnlContainer, 0, 1);
            this.tlpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSettings.Location = new System.Drawing.Point(0, 0);
            this.tlpSettings.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSettings.Name = "tlpSettings";
            this.tlpSettings.RowCount = 1;
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.71F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSettings.Size = new System.Drawing.Size(1370, 825);
            this.tlpSettings.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.tlpSettings.SetColumnSpan(this.pnlTitle, 2);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1370, 117);
            this.pnlTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblTitle.Location = new System.Drawing.Point(32, 39);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(257, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Configuración";
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.White;
            this.pnlSide.Controls.Add(this.flpButtons);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSide.Location = new System.Drawing.Point(1096, 117);
            this.pnlSide.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(274, 708);
            this.pnlSide.TabIndex = 2;
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.pnlUserSettings);
            this.flpButtons.Controls.Add(this.pnlInstitutionSettings);
            this.flpButtons.Controls.Add(this.pnlServerSettings);
            this.flpButtons.Controls.Add(this.pnlProgramSettings);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButtons.Location = new System.Drawing.Point(0, 0);
            this.flpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(274, 708);
            this.flpButtons.TabIndex = 3;
            // 
            // pnlUserSettings
            // 
            this.pnlUserSettings.Controls.Add(this.btnUserSettings);
            this.pnlUserSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlUserSettings.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUserSettings.Name = "pnlUserSettings";
            this.pnlUserSettings.Size = new System.Drawing.Size(280, 85);
            this.pnlUserSettings.TabIndex = 10;
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnUserSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUserSettings.FlatAppearance.BorderSize = 0;
            this.btnUserSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnUserSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUserSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUserSettings.Image = global::HealthPortal.Properties.Resources.users;
            this.btnUserSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserSettings.Location = new System.Drawing.Point(34, 26);
            this.btnUserSettings.Margin = new System.Windows.Forms.Padding(34, 27, 34, 27);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(208, 32);
            this.btnUserSettings.TabIndex = 1;
            this.btnUserSettings.TabStop = false;
            this.btnUserSettings.Text = "Usuario";
            this.btnUserSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserSettings.UseVisualStyleBackColor = false;
            // 
            // pnlInstitutionSettings
            // 
            this.pnlInstitutionSettings.Controls.Add(this.btnInstitutionSettings);
            this.pnlInstitutionSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInstitutionSettings.Location = new System.Drawing.Point(0, 85);
            this.pnlInstitutionSettings.Margin = new System.Windows.Forms.Padding(0);
            this.pnlInstitutionSettings.Name = "pnlInstitutionSettings";
            this.pnlInstitutionSettings.Size = new System.Drawing.Size(280, 85);
            this.pnlInstitutionSettings.TabIndex = 11;
            // 
            // btnInstitutionSettings
            // 
            this.btnInstitutionSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnInstitutionSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstitutionSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInstitutionSettings.FlatAppearance.BorderSize = 0;
            this.btnInstitutionSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnInstitutionSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInstitutionSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInstitutionSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstitutionSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstitutionSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnInstitutionSettings.Image = global::HealthPortal.Properties.Resources.school;
            this.btnInstitutionSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInstitutionSettings.Location = new System.Drawing.Point(34, 26);
            this.btnInstitutionSettings.Margin = new System.Windows.Forms.Padding(34, 27, 34, 27);
            this.btnInstitutionSettings.Name = "btnInstitutionSettings";
            this.btnInstitutionSettings.Size = new System.Drawing.Size(208, 32);
            this.btnInstitutionSettings.TabIndex = 1;
            this.btnInstitutionSettings.TabStop = false;
            this.btnInstitutionSettings.Text = "Institución";
            this.btnInstitutionSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstitutionSettings.UseVisualStyleBackColor = false;
            // 
            // pnlServerSettings
            // 
            this.pnlServerSettings.Controls.Add(this.btnServerSettings);
            this.pnlServerSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlServerSettings.Location = new System.Drawing.Point(0, 170);
            this.pnlServerSettings.Margin = new System.Windows.Forms.Padding(0);
            this.pnlServerSettings.Name = "pnlServerSettings";
            this.pnlServerSettings.Size = new System.Drawing.Size(280, 85);
            this.pnlServerSettings.TabIndex = 12;
            // 
            // btnServerSettings
            // 
            this.btnServerSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnServerSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServerSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnServerSettings.FlatAppearance.BorderSize = 0;
            this.btnServerSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnServerSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnServerSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnServerSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnServerSettings.Image = global::HealthPortal.Properties.Resources.server;
            this.btnServerSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServerSettings.Location = new System.Drawing.Point(34, 26);
            this.btnServerSettings.Margin = new System.Windows.Forms.Padding(34, 27, 34, 27);
            this.btnServerSettings.Name = "btnServerSettings";
            this.btnServerSettings.Size = new System.Drawing.Size(208, 32);
            this.btnServerSettings.TabIndex = 1;
            this.btnServerSettings.TabStop = false;
            this.btnServerSettings.Text = "Servidor";
            this.btnServerSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServerSettings.UseVisualStyleBackColor = false;
            // 
            // pnlProgramSettings
            // 
            this.pnlProgramSettings.Controls.Add(this.btnProgramSettings);
            this.pnlProgramSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProgramSettings.Location = new System.Drawing.Point(0, 255);
            this.pnlProgramSettings.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProgramSettings.Name = "pnlProgramSettings";
            this.pnlProgramSettings.Size = new System.Drawing.Size(280, 85);
            this.pnlProgramSettings.TabIndex = 13;
            // 
            // btnProgramSettings
            // 
            this.btnProgramSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnProgramSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProgramSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProgramSettings.FlatAppearance.BorderSize = 0;
            this.btnProgramSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnProgramSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProgramSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProgramSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnProgramSettings.Image = global::HealthPortal.Properties.Resources.healthPortal;
            this.btnProgramSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProgramSettings.Location = new System.Drawing.Point(34, 26);
            this.btnProgramSettings.Margin = new System.Windows.Forms.Padding(34, 27, 34, 27);
            this.btnProgramSettings.Name = "btnProgramSettings";
            this.btnProgramSettings.Size = new System.Drawing.Size(208, 32);
            this.btnProgramSettings.TabIndex = 1;
            this.btnProgramSettings.TabStop = false;
            this.btnProgramSettings.Text = "Programa";
            this.btnProgramSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgramSettings.UseVisualStyleBackColor = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 117);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1095, 708);
            this.pnlContainer.TabIndex = 4;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1370, 825);
            this.Controls.Add(this.tlpSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSettings";
            this.Text = "FrmUserAdministration";
            this.tlpSettings.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlSide.ResumeLayout(false);
            this.flpButtons.ResumeLayout(false);
            this.pnlUserSettings.ResumeLayout(false);
            this.pnlInstitutionSettings.ResumeLayout(false);
            this.pnlServerSettings.ResumeLayout(false);
            this.pnlProgramSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlSide;
        public System.Windows.Forms.FlowLayoutPanel flpButtons;
        public System.Windows.Forms.Panel pnlUserSettings;
        public System.Windows.Forms.Button btnUserSettings;
        public System.Windows.Forms.Panel pnlInstitutionSettings;
        public System.Windows.Forms.Button btnInstitutionSettings;
        public System.Windows.Forms.Panel pnlServerSettings;
        public System.Windows.Forms.Button btnServerSettings;
        public System.Windows.Forms.Panel pnlProgramSettings;
        public System.Windows.Forms.Button btnProgramSettings;
        public System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.TableLayoutPanel tlpSettings;
    }
}