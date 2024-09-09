namespace HealthPortal.View.InventoryAdministration
{
    partial class FrmAddUpdateMedicine
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.MenuStrip();
            this.dtpEntryTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnUpdateInventory = new CustomControls.RJButton();
            this.btnAddImage = new CustomControls.RJButton();
            this.btnAddInventory = new CustomControls.RJButton();
            this.txtDescription = new CustomControls.CustomTextBox();
            this.txtMedicineName = new CustomControls.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.lblTitle.Location = new System.Drawing.Point(14, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(479, 61);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Ingreso de Inventario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(370, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(249, 32);
            this.label12.TabIndex = 28;
            this.label12.Text = "Fecha de vencimineto";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(651, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Capsulas por envase";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblName.Location = new System.Drawing.Point(376, 105);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(297, 32);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Nombre del Medicamento";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDate.Location = new System.Drawing.Point(382, 469);
            this.dtpExpirationDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(206, 35);
            this.dtpExpirationDate.TabIndex = 30;
            this.dtpExpirationDate.Value = new System.DateTime(2024, 6, 24, 12, 39, 57, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(651, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 32);
            this.label4.TabIndex = 31;
            this.label4.Text = "Hora de Ingreso";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(376, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 32);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fecha de ingreso";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescription.Location = new System.Drawing.Point(26, 532);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(138, 32);
            this.lblDescription.TabIndex = 35;
            this.lblDescription.Text = "Descripción";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCategory.Location = new System.Drawing.Point(376, 222);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(311, 32);
            this.lblCategory.TabIndex = 41;
            this.lblCategory.Text = "Categoría del Medicamento";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(374, 257);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(506, 37);
            this.cmbCategory.TabIndex = 42;
            // 
            // txtID
            // 
            this.txtID.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.txtID.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.txtID.Location = new System.Drawing.Point(0, 0);
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.txtID.Size = new System.Drawing.Size(904, 24);
            this.txtID.TabIndex = 45;
            this.txtID.Text = "menuStrip1";
            // 
            // dtpEntryTime
            // 
            this.dtpEntryTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntryTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntryTime.Location = new System.Drawing.Point(657, 471);
            this.dtpEntryTime.Name = "dtpEntryTime";
            this.dtpEntryTime.Size = new System.Drawing.Size(205, 34);
            this.dtpEntryTime.TabIndex = 47;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntryDate.Location = new System.Drawing.Point(382, 357);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(216, 34);
            this.dtpEntryDate.TabIndex = 46;
            // 
            // numStock
            // 
            this.numStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStock.Location = new System.Drawing.Point(670, 357);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(192, 35);
            this.numStock.TabIndex = 52;
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(32, 105);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(314, 347);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 53;
            this.picImage.TabStop = false;
            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateInventory.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateInventory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateInventory.BorderRadius = 40;
            this.btnUpdateInventory.BorderSize = 0;
            this.btnUpdateInventory.FlatAppearance.BorderSize = 0;
            this.btnUpdateInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInventory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInventory.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateInventory.Location = new System.Drawing.Point(522, 848);
            this.btnUpdateInventory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(165, 49);
            this.btnUpdateInventory.TabIndex = 43;
            this.btnUpdateInventory.Text = "Actualizar";
            this.btnUpdateInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateInventory.TextColor = System.Drawing.Color.Black;
            this.btnUpdateInventory.UseVisualStyleBackColor = false;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddImage.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAddImage.BorderRadius = 40;
            this.btnAddImage.BorderSize = 0;
            this.btnAddImage.FlatAppearance.BorderSize = 0;
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.ForeColor = System.Drawing.Color.Black;
            this.btnAddImage.Location = new System.Drawing.Point(32, 457);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(153, 48);
            this.btnAddImage.TabIndex = 38;
            this.btnAddImage.Text = "Agregar";
            this.btnAddImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddImage.TextColor = System.Drawing.Color.Black;
            this.btnAddImage.UseVisualStyleBackColor = false;
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddInventory.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddInventory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAddInventory.BorderRadius = 40;
            this.btnAddInventory.BorderSize = 0;
            this.btnAddInventory.FlatAppearance.BorderSize = 0;
            this.btnAddInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInventory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInventory.ForeColor = System.Drawing.Color.Black;
            this.btnAddInventory.Location = new System.Drawing.Point(722, 840);
            this.btnAddInventory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(141, 49);
            this.btnAddInventory.TabIndex = 37;
            this.btnAddInventory.Text = "Agregar";
            this.btnAddInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddInventory.TextColor = System.Drawing.Color.Black;
            this.btnAddInventory.UseVisualStyleBackColor = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDescription.BorderRadius = 20;
            this.txtDescription.BorderSize = 1;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(26, 569);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.Size = new System.Drawing.Size(856, 248);
            this.txtDescription.TabIndex = 36;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.BackColor = System.Drawing.SystemColors.Window;
            this.txtMedicineName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMedicineName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMedicineName.BorderRadius = 20;
            this.txtMedicineName.BorderSize = 1;
            this.txtMedicineName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMedicineName.Location = new System.Drawing.Point(375, 152);
            this.txtMedicineName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMedicineName.Multiline = false;
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtMedicineName.PasswordChar = false;
            this.txtMedicineName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMedicineName.PlaceholderText = "";
            this.txtMedicineName.Size = new System.Drawing.Size(514, 63);
            this.txtMedicineName.TabIndex = 26;
            this.txtMedicineName.Texts = "";
            this.txtMedicineName.UnderlinedStyle = false;
            // 
            // FrmAddUpdateMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(904, 922);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.dtpEntryTime);
            this.Controls.Add(this.dtpEntryDate);
            this.Controls.Add(this.btnUpdateInventory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.btnAddInventory);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpExpirationDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.txtID;
            this.Name = "FrmAddUpdateMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAddUpdateMedicine";
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        public CustomControls.CustomTextBox txtMedicineName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public CustomControls.CustomTextBox txtDescription;
        public CustomControls.RJButton btnAddImage;
        public CustomControls.RJButton btnAddInventory;
        public CustomControls.RJButton btnUpdateInventory;
        public System.Windows.Forms.DateTimePicker dtpExpirationDate;
        public System.Windows.Forms.ComboBox cmbCategory;
        public System.Windows.Forms.MenuStrip txtID;
        public System.Windows.Forms.DateTimePicker dtpEntryTime;
        public System.Windows.Forms.DateTimePicker dtpEntryDate;
        public System.Windows.Forms.NumericUpDown numStock;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.PictureBox picImage;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.Label lblDescription;
    }
}