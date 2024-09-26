namespace HealthPortal.View.InventoryAdministration
{
    partial class FrmAddUpdateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUpdateCategory));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnExitAddUpdateCategory = new System.Windows.Forms.Button();
            this.btnUpdate = new CustomControls.RJButton();
            this.btnAdd = new CustomControls.RJButton();
            this.txtCategoriaMedicamento = new CustomControls.CustomTextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblTitle.Name = "lblTitle";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            // 
            // btnExitAddUpdateCategory
            // 
            resources.ApplyResources(this.btnExitAddUpdateCategory, "btnExitAddUpdateCategory");
            this.btnExitAddUpdateCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitAddUpdateCategory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExitAddUpdateCategory.FlatAppearance.BorderSize = 0;
            this.btnExitAddUpdateCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExitAddUpdateCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExitAddUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.btnExitAddUpdateCategory.Image = global::HealthPortal.Properties.Resources.quit;
            this.btnExitAddUpdateCategory.Name = "btnExitAddUpdateCategory";
            this.btnExitAddUpdateCategory.TabStop = false;
            this.btnExitAddUpdateCategory.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.BackGroundColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.BorderRadius = 30;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.TabStop = false;
            this.btnUpdate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.BackGroundColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.BorderRadius = 30;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.TabStop = false;
            this.btnAdd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtCategoriaMedicamento
            // 
            this.txtCategoriaMedicamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtCategoriaMedicamento.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCategoriaMedicamento.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCategoriaMedicamento.BorderRadius = 15;
            this.txtCategoriaMedicamento.BorderSize = 1;
            resources.ApplyResources(this.txtCategoriaMedicamento, "txtCategoriaMedicamento");
            this.txtCategoriaMedicamento.MaxLength = 50;
            this.txtCategoriaMedicamento.Multiline = false;
            this.txtCategoriaMedicamento.Name = "txtCategoriaMedicamento";
            this.txtCategoriaMedicamento.PasswordChar = false;
            this.txtCategoriaMedicamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCategoriaMedicamento.PlaceholderText = "";
            this.txtCategoriaMedicamento.SelectionLength = 0;
            this.txtCategoriaMedicamento.SelectionStart = 0;
            this.txtCategoriaMedicamento.Tag = "name";
            this.txtCategoriaMedicamento.Texts = "";
            this.txtCategoriaMedicamento.UnderlinedStyle = false;
            // 
            // FrmAddUpdateCategory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.btnExitAddUpdateCategory);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCategoriaMedicamento);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddUpdateCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CustomControls.CustomTextBox txtCategoriaMedicamento;
        public CustomControls.RJButton btnAdd;
        public CustomControls.RJButton btnUpdate;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Button btnExitAddUpdateCategory;
    }
}