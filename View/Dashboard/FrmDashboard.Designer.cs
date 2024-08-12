namespace HealthPortal.View.Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.flpTabs = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.pnlVisits = new System.Windows.Forms.Panel();
            this.btnVisits = new System.Windows.Forms.Button();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.pnlStatistics = new System.Windows.Forms.Panel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.pnlSections = new System.Windows.Forms.Panel();
            this.btnSections = new System.Windows.Forms.Button();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlSideBar.SuspendLayout();
            this.flpTabs.SuspendLayout();
            this.pnlMainMenu.SuspendLayout();
            this.pnlVisits.SuspendLayout();
            this.pnlInventory.SuspendLayout();
            this.pnlStatistics.SuspendLayout();
            this.pnlSections.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            this.pnlLogout.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.White;
            this.pnlSideBar.Controls.Add(this.flpTabs);
            this.pnlSideBar.Controls.Add(this.pnlLogout);
            this.pnlSideBar.Controls.Add(this.pnlLogo);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(150, 825);
            this.pnlSideBar.TabIndex = 0;
            // 
            // flpTabs
            // 
            this.flpTabs.Controls.Add(this.pnlMainMenu);
            this.flpTabs.Controls.Add(this.pnlVisits);
            this.flpTabs.Controls.Add(this.pnlInventory);
            this.flpTabs.Controls.Add(this.pnlStatistics);
            this.flpTabs.Controls.Add(this.pnlSections);
            this.flpTabs.Controls.Add(this.pnlUsers);
            this.flpTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTabs.Location = new System.Drawing.Point(0, 150);
            this.flpTabs.Margin = new System.Windows.Forms.Padding(0);
            this.flpTabs.Name = "flpTabs";
            this.flpTabs.Size = new System.Drawing.Size(150, 550);
            this.flpTabs.TabIndex = 8;
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.Controls.Add(this.btnMainMenu);
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(150, 80);
            this.pnlMainMenu.TabIndex = 7;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackgroundImage = global::HealthPortal.Properties.Resources.main;
            this.btnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Location = new System.Drawing.Point(51, 16);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(51, 16, 51, 16);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(48, 48);
            this.btnMainMenu.TabIndex = 1;
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // pnlVisits
            // 
            this.pnlVisits.Controls.Add(this.btnVisits);
            this.pnlVisits.Location = new System.Drawing.Point(0, 80);
            this.pnlVisits.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVisits.Name = "pnlVisits";
            this.pnlVisits.Size = new System.Drawing.Size(150, 100);
            this.pnlVisits.TabIndex = 8;
            // 
            // btnVisits
            // 
            this.btnVisits.BackgroundImage = global::HealthPortal.Properties.Resources.visits;
            this.btnVisits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVisits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisits.FlatAppearance.BorderSize = 0;
            this.btnVisits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVisits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVisits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisits.Location = new System.Drawing.Point(51, 26);
            this.btnVisits.Margin = new System.Windows.Forms.Padding(51, 29, 51, 29);
            this.btnVisits.Name = "btnVisits";
            this.btnVisits.Size = new System.Drawing.Size(48, 48);
            this.btnVisits.TabIndex = 2;
            this.btnVisits.UseVisualStyleBackColor = true;
            // 
            // pnlInventory
            // 
            this.pnlInventory.Controls.Add(this.btnInventory);
            this.pnlInventory.Location = new System.Drawing.Point(0, 180);
            this.pnlInventory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(150, 100);
            this.pnlInventory.TabIndex = 9;
            // 
            // btnInventory
            // 
            this.btnInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInventory.BackgroundImage")));
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Location = new System.Drawing.Point(51, 26);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(51, 22, 51, 22);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(48, 48);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.Controls.Add(this.btnStatistics);
            this.pnlStatistics.Location = new System.Drawing.Point(0, 280);
            this.pnlStatistics.Margin = new System.Windows.Forms.Padding(0);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.Size = new System.Drawing.Size(150, 80);
            this.pnlStatistics.TabIndex = 10;
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStatistics.BackgroundImage")));
            this.btnStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Location = new System.Drawing.Point(51, 16);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(51, 22, 51, 22);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(48, 48);
            this.btnStatistics.TabIndex = 4;
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // pnlSections
            // 
            this.pnlSections.Controls.Add(this.btnSections);
            this.pnlSections.Location = new System.Drawing.Point(0, 360);
            this.pnlSections.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSections.Name = "pnlSections";
            this.pnlSections.Size = new System.Drawing.Size(150, 100);
            this.pnlSections.TabIndex = 11;
            // 
            // btnSections
            // 
            this.btnSections.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSections.BackgroundImage")));
            this.btnSections.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSections.FlatAppearance.BorderSize = 0;
            this.btnSections.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSections.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSections.Location = new System.Drawing.Point(51, 26);
            this.btnSections.Margin = new System.Windows.Forms.Padding(51, 22, 51, 22);
            this.btnSections.Name = "btnSections";
            this.btnSections.Size = new System.Drawing.Size(48, 48);
            this.btnSections.TabIndex = 5;
            this.btnSections.UseVisualStyleBackColor = true;
            // 
            // pnlUsers
            // 
            this.pnlUsers.Controls.Add(this.btnUsers);
            this.pnlUsers.Location = new System.Drawing.Point(0, 460);
            this.pnlUsers.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(150, 90);
            this.pnlUsers.TabIndex = 12;
            // 
            // btnUsers
            // 
            this.btnUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.BackgroundImage")));
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Location = new System.Drawing.Point(51, 21);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(51, 22, 51, 22);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(48, 48);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // pnlLogout
            // 
            this.pnlLogout.Controls.Add(this.btnLogout);
            this.pnlLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLogout.Location = new System.Drawing.Point(0, 700);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(150, 125);
            this.pnlLogout.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(51, 38);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(51, 22, 51, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(48, 48);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.btnLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(150, 150);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnLogo
            // 
            this.btnLogo.BackgroundImage = global::HealthPortal.Properties.Resources.Ícono;
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Location = new System.Drawing.Point(27, 27);
            this.btnLogo.Margin = new System.Windows.Forms.Padding(27);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(96, 96);
            this.btnLogo.TabIndex = 0;
            this.btnLogo.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(150, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1370, 825);
            this.pnlContainer.TabIndex = 1;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1520, 825);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewDashboard";
            this.pnlSideBar.ResumeLayout(false);
            this.flpTabs.ResumeLayout(false);
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlVisits.ResumeLayout(false);
            this.pnlInventory.ResumeLayout(false);
            this.pnlStatistics.ResumeLayout(false);
            this.pnlSections.ResumeLayout(false);
            this.pnlUsers.ResumeLayout(false);
            this.pnlLogout.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlLogo;
        public System.Windows.Forms.Button btnLogo;
        public System.Windows.Forms.Panel pnlUsers;
        public System.Windows.Forms.Button btnUsers;
        public System.Windows.Forms.Panel pnlSections;
        public System.Windows.Forms.Button btnSections;
        public System.Windows.Forms.Panel pnlStatistics;
        public System.Windows.Forms.Button btnStatistics;
        public System.Windows.Forms.Panel pnlInventory;
        public System.Windows.Forms.Button btnInventory;
        public System.Windows.Forms.Panel pnlVisits;
        public System.Windows.Forms.Button btnVisits;
        public System.Windows.Forms.Panel pnlMainMenu;
        public System.Windows.Forms.Button btnMainMenu;
        public System.Windows.Forms.Panel pnlLogout;
        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Panel pnlSideBar;
        public System.Windows.Forms.FlowLayoutPanel flpTabs;
        public System.Windows.Forms.Panel pnlContainer;
    }
}