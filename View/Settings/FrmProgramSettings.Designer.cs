namespace HealthPortal.View.Settings
{
    partial class FrmProgramSettings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCustom1 = new CustomPanel.PanelCustom();
            this.grpSecurityQuestions = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelCustom2 = new CustomPanel.PanelCustom();
            this.dgvSecurityQuestions = new System.Windows.Forms.DataGridView();
            this.btnAddSecurityQuestion = new CustomPanel.RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCustom1.SuspendLayout();
            this.grpSecurityQuestions.SuspendLayout();
            this.panelCustom2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurityQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 120);
            this.panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(41, 39);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(32, 39, 32, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(496, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Configuración del Programa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelCustom1);
            this.panel2.Location = new System.Drawing.Point(48, 120);
            this.panel2.Margin = new System.Windows.Forms.Padding(48, 0, 48, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 528);
            this.panel2.TabIndex = 2;
            // 
            // panelCustom1
            // 
            this.panelCustom1.BackColor = System.Drawing.Color.White;
            this.panelCustom1.BorderRadius = 30;
            this.panelCustom1.Controls.Add(this.grpSecurityQuestions);
            this.panelCustom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustom1.ForeColor = System.Drawing.Color.Black;
            this.panelCustom1.GradientAngle = 90F;
            this.panelCustom1.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustom1.GradientTopColor = System.Drawing.Color.White;
            this.panelCustom1.Location = new System.Drawing.Point(0, 0);
            this.panelCustom1.Name = "panelCustom1";
            this.panelCustom1.Size = new System.Drawing.Size(986, 528);
            this.panelCustom1.TabIndex = 6;
            // 
            // grpSecurityQuestions
            // 
            this.grpSecurityQuestions.Controls.Add(this.lblInfo);
            this.grpSecurityQuestions.Controls.Add(this.panelCustom2);
            this.grpSecurityQuestions.Controls.Add(this.btnAddSecurityQuestion);
            this.grpSecurityQuestions.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSecurityQuestions.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpSecurityQuestions.Location = new System.Drawing.Point(33, 30);
            this.grpSecurityQuestions.Margin = new System.Windows.Forms.Padding(30);
            this.grpSecurityQuestions.Name = "grpSecurityQuestions";
            this.grpSecurityQuestions.Size = new System.Drawing.Size(923, 219);
            this.grpSecurityQuestions.TabIndex = 5;
            this.grpSecurityQuestions.TabStop = false;
            this.grpSecurityQuestions.Text = "Preguntas de seguridad";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblInfo.Location = new System.Drawing.Point(20, 26);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(36, 16);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Texto";
            // 
            // panelCustom2
            // 
            this.panelCustom2.BackColor = System.Drawing.Color.White;
            this.panelCustom2.BorderRadius = 30;
            this.panelCustom2.Controls.Add(this.dgvSecurityQuestions);
            this.panelCustom2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCustom2.ForeColor = System.Drawing.Color.Black;
            this.panelCustom2.GradientAngle = 90F;
            this.panelCustom2.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustom2.GradientTopColor = System.Drawing.Color.White;
            this.panelCustom2.Location = new System.Drawing.Point(3, 59);
            this.panelCustom2.Name = "panelCustom2";
            this.panelCustom2.Size = new System.Drawing.Size(917, 157);
            this.panelCustom2.TabIndex = 6;
            // 
            // dgvSecurityQuestions
            // 
            this.dgvSecurityQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSecurityQuestions.BackgroundColor = System.Drawing.Color.White;
            this.dgvSecurityQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSecurityQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecurityQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSecurityQuestions.Location = new System.Drawing.Point(0, 0);
            this.dgvSecurityQuestions.Name = "dgvSecurityQuestions";
            this.dgvSecurityQuestions.ReadOnly = true;
            this.dgvSecurityQuestions.Size = new System.Drawing.Size(917, 157);
            this.dgvSecurityQuestions.TabIndex = 0;
            // 
            // btnAddSecurityQuestion
            // 
            this.btnAddSecurityQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddSecurityQuestion.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddSecurityQuestion.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddSecurityQuestion.BorderRadius = 30;
            this.btnAddSecurityQuestion.BorderSize = 0;
            this.btnAddSecurityQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSecurityQuestion.FlatAppearance.BorderSize = 0;
            this.btnAddSecurityQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSecurityQuestion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSecurityQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSecurityQuestion.Location = new System.Drawing.Point(667, 16);
            this.btnAddSecurityQuestion.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddSecurityQuestion.Name = "btnAddSecurityQuestion";
            this.btnAddSecurityQuestion.Size = new System.Drawing.Size(248, 35);
            this.btnAddSecurityQuestion.TabIndex = 6;
            this.btnAddSecurityQuestion.Text = "Añadir pregunta de seguridad";
            this.btnAddSecurityQuestion.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAddSecurityQuestion.UseVisualStyleBackColor = false;
            // 
            // FrmProgramSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1090, 705);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(986, 705);
            this.Name = "FrmProgramSettings";
            this.Text = "FrmUserAdministration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelCustom1.ResumeLayout(false);
            this.grpSecurityQuestions.ResumeLayout(false);
            this.grpSecurityQuestions.PerformLayout();
            this.panelCustom2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurityQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.GroupBox grpSecurityQuestions;
        public CustomPanel.PanelCustom panelCustom1;
        public CustomPanel.RJButton btnAddSecurityQuestion;
        private CustomPanel.PanelCustom panelCustom2;
        public System.Windows.Forms.DataGridView dgvSecurityQuestions;
        public System.Windows.Forms.Label lblInfo;
    }
}