using HealthPortal.Helper;
using HealthPortal.View.Dashboard;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.View.InventoryAdministration;
using HealthPortal.View.PatientAdministration;
using HealthPortal.View.SectionAdministration;
using HealthPortal.View.UserAdministration;
using HealthPortal.Properties;
using HealthPortal.View.Login;

namespace HealthPortal.Controller.Dashboard
{
    internal class ControllerDashboard
    {
        FrmDashboard objDashboard;
        Form currentForm;
        Button currentButton;
        CommonMethods commonMethods = new CommonMethods();
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        bool isSideBarExpanded = false;
        const int collapsedWidth = 150;
        const int expandedWidth = 280;
        const int collapsedLogoX = 27;
        const int expandedLogoX = 92;
        const int logoY = 27;
        public ControllerDashboard(FrmDashboard view)
        {
            objDashboard = view;
            objDashboard.Load += new EventHandler(InitialLoad);
            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnMainMenu", Tuple.Create(Resources.main, Resources.hoverMain) },
                { "btnVisits", Tuple.Create(Resources.visits, Resources.hoverVisits) },
                { "btnInventory", Tuple.Create(Resources.inventory, Resources.hoverInventory) },
                { "btnStatistics", Tuple.Create(Resources.mdi_graph_line1, Resources.hoverStatistics) },
                { "btnSections", Tuple.Create(Resources.bx_book1, Resources.hoverSections) },
                { "btnUsers", Tuple.Create(Resources.users, Resources.hoverUsers) },
                { "btnLogout", Tuple.Create(Resources.logout, Resources.hoverLogout) }
            };

            // Expandir / Colapsar la sidebar
            objDashboard.btnLogo.Click += new EventHandler(MorphSideBar);

            // Abrir Formularios
            //objDashboard.btnMainMenu.Click += new EventHandler(OpenMainMenuForm);
            objDashboard.btnVisits.Click += new EventHandler(OpenPatientAdministrationForm);
            objDashboard.btnInventory.Click += new EventHandler(OpenInventoryAdministrationForm);
            //objDashboard.btnStatistics.Click += new EventHandler(OpenStatisticsForm);
            objDashboard.btnSections.Click += new EventHandler(OpenSectionAdministrationForm);
            objDashboard.btnUsers.Click += new EventHandler(OpenUserAdministrationForm);

            // Cambios de imagen por MouseEnter
            objDashboard.btnMainMenu.MouseEnter += new EventHandler(MouseEnterControl);
            objDashboard.btnVisits.MouseEnter += new EventHandler(MouseEnterControl);
            objDashboard.btnInventory.MouseEnter += new EventHandler(MouseEnterControl);
            objDashboard.btnStatistics.MouseEnter += new EventHandler(MouseEnterControl);
            objDashboard.btnSections.MouseEnter += new EventHandler(MouseEnterControl);
            objDashboard.btnUsers.MouseEnter += new EventHandler(MouseEnterControl);
            objDashboard.btnLogout.MouseEnter += new EventHandler(MouseEnterControl);

            // Cambios de imagen por MouseLeave
            objDashboard.btnMainMenu.MouseLeave += new EventHandler(MouseLeaveControl);
            objDashboard.btnVisits.MouseLeave += new EventHandler(MouseLeaveControl);
            objDashboard.btnInventory.MouseLeave += new EventHandler(MouseLeaveControl);
            objDashboard.btnStatistics.MouseLeave += new EventHandler(MouseLeaveControl);
            objDashboard.btnSections.MouseLeave += new EventHandler(MouseLeaveControl);
            objDashboard.btnUsers.MouseLeave += new EventHandler(MouseLeaveControl);
            objDashboard.btnLogout.MouseLeave += new EventHandler(MouseLeaveControl);

            // Cerrar Sesión
            objDashboard.btnLogout.Click += new EventHandler(Logout);
        }
        private void InitialLoad(object sender, EventArgs e)
        {
            CheckUserAccessRole();
        }
        private void MorphSideBar(object sender, EventArgs e)
        {
            isSideBarExpanded = !isSideBarExpanded;
            objDashboard.pnlSideBar.Width = isSideBarExpanded ? collapsedWidth : expandedWidth;
            objDashboard.btnLogo.Location = new Point(isSideBarExpanded ? collapsedLogoX : expandedLogoX, logoY);
            objDashboard.pnlLogo.Width = objDashboard.pnlSideBar.Width;
            objDashboard.flpTabs.Width = objDashboard.pnlSideBar.Width;
            objDashboard.pnlMainMenu.Width = objDashboard.pnlSideBar.Width;
            objDashboard.pnlVisits.Width = objDashboard.pnlSideBar.Width;
            objDashboard.pnlInventory.Width = objDashboard.pnlSideBar.Width;
            objDashboard.pnlStatistics.Width = objDashboard.pnlSideBar.Width;
            objDashboard.pnlSections.Width = objDashboard.pnlSideBar.Width;
            objDashboard.pnlUsers.Width = objDashboard.pnlSideBar.Width;
            objDashboard.pnlLogout.Width = objDashboard.pnlSideBar.Width;
        }
        private void OpenPatientAdministrationForm(object sender, EventArgs e)
        {
            objDashboard.btnMainMenu.BackgroundImage = Resources.main;
            objDashboard.btnVisits.BackgroundImage = Resources.hoverVisits;
            objDashboard.btnInventory.BackgroundImage = Resources.inventory;
            objDashboard.btnStatistics.BackgroundImage = Resources.mdi_graph_line1;
            objDashboard.btnSections.BackgroundImage = Resources.bx_book1;
            objDashboard.btnUsers.BackgroundImage = Resources.users;

            objDashboard.pnlMainMenu.BackColor = Color.White;
            objDashboard.pnlVisits.BackColor = Color.FromArgb(142, 202, 230);
            objDashboard.pnlInventory.BackColor = Color.White;
            objDashboard.pnlStatistics.BackColor = Color.White;
            objDashboard.pnlSections.BackColor = Color.White;
            objDashboard.pnlUsers.BackColor = Color.White;

            OpenForm<FrmPatientAdministration>(objDashboard.btnVisits);
        }
        private void OpenInventoryAdministrationForm(object sender, EventArgs e)
        {
            objDashboard.btnMainMenu.BackgroundImage = Resources.main;
            objDashboard.btnVisits.BackgroundImage = Resources.visits;
            objDashboard.btnInventory.BackgroundImage = Resources.hoverInventory;
            objDashboard.btnStatistics.BackgroundImage = Resources.mdi_graph_line1;
            objDashboard.btnSections.BackgroundImage = Resources.bx_book1;
            objDashboard.btnUsers.BackgroundImage = Resources.users;

            objDashboard.pnlMainMenu.BackColor = Color.White;
            objDashboard.pnlVisits.BackColor = Color.White;
            objDashboard.pnlInventory.BackColor = Color.FromArgb(142, 202, 230);
            objDashboard.pnlStatistics.BackColor = Color.White;
            objDashboard.pnlSections.BackColor = Color.White;
            objDashboard.pnlUsers.BackColor = Color.White;

            OpenForm<FrmInventoryAdministration>(objDashboard.btnInventory);
        }
        private void OpenSectionAdministrationForm(object sender, EventArgs e)
        {
            objDashboard.btnMainMenu.BackgroundImage = Resources.main;
            objDashboard.btnVisits.BackgroundImage = Resources.visits;
            objDashboard.btnInventory.BackgroundImage = Resources.inventory;
            objDashboard.btnStatistics.BackgroundImage = Resources.mdi_graph_line1;
            objDashboard.btnSections.BackgroundImage = Resources.hoverSections;
            objDashboard.btnUsers.BackgroundImage = Resources.users;

            objDashboard.pnlMainMenu.BackColor = Color.White;
            objDashboard.pnlVisits.BackColor = Color.White;
            objDashboard.pnlInventory.BackColor = Color.White;
            objDashboard.pnlStatistics.BackColor = Color.White;
            objDashboard.pnlSections.BackColor = Color.FromArgb(142, 202, 230);
            objDashboard.pnlUsers.BackColor = Color.White;

            OpenForm<FrmSectionAdministration>(objDashboard.btnSections);
        }
        private void OpenUserAdministrationForm(object sender, EventArgs e)
        {
            objDashboard.btnMainMenu.BackgroundImage = Resources.main;
            objDashboard.btnVisits.BackgroundImage = Resources.visits;
            objDashboard.btnInventory.BackgroundImage = Resources.inventory;
            objDashboard.btnStatistics.BackgroundImage = Resources.mdi_graph_line1;
            objDashboard.btnSections.BackgroundImage = Resources.bx_book1;
            objDashboard.btnUsers.BackgroundImage = Resources.hoverUsers;

            objDashboard.pnlMainMenu.BackColor = Color.White;
            objDashboard.pnlVisits.BackColor = Color.White;
            objDashboard.pnlInventory.BackColor = Color.White;
            objDashboard.pnlStatistics.BackColor = Color.White;
            objDashboard.pnlSections.BackColor = Color.White;
            objDashboard.pnlUsers.BackColor = Color.FromArgb(142, 202, 230);

            OpenForm<FrmUserAdministration>(objDashboard.btnUsers);
        }
        private void MouseEnterControl(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.BackgroundImage = imageMapping[btn.Name].Item2;
            }
        }
        private void MouseLeaveControl(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                if (btn != currentButton)
                {
                    btn.BackgroundImage = imageMapping[btn.Name].Item1;
                }
            }
        }
        private void Logout(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                commonMethods.DisposeOfCurrentUserData();
                FrmLogin objLogin = new FrmLogin();
                objLogin.Show();
                objDashboard.Dispose();
            }
        }
        private void OpenForm<NewForm>(Button associatedBtn) where NewForm : Form, new()
        {
            Form form;
            form = objDashboard.pnlContainer.Controls.OfType<NewForm>().FirstOrDefault();
            if (form == null)
            {
                form = new NewForm();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                //form.Opacity = 0.75;
                if (currentForm != null)
                {
                    currentForm.Close();
                    objDashboard.pnlContainer.Controls.Remove(currentForm);
                }
                currentForm = form;
                objDashboard.pnlContainer.Controls.Add(form);
                objDashboard.pnlContainer.Tag = form;
                form.Show();
                form.BringToFront();
            }
            else
            {
                form.BringToFront();
            }
            currentButton = associatedBtn;
        }
        private void CheckUserAccessRole()
        {
            if (CurrentUserData.RoleId != 1)
            {
                objDashboard.btnSections.Visible = false;
                objDashboard.btnUsers.Visible = false;
            }
        }
    }
}
