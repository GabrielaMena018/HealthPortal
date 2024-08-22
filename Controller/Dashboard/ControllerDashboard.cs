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
        bool isSideBarExpanded = true;
        const int collapsedWidth = 150;
        const int expandedWidth = 280;
        const int collapsedLogoX = 43;
        const int expandedLogoX = 108;
        readonly int[] collapsedButtonX = {59, 51};
        const int expandedButtonX = 34;
        const int logoY = 43;
        public ControllerDashboard(FrmDashboard view)
        {
            objDashboard = view;
            objDashboard.Load += new EventHandler(InitialLoad);
            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnMenu", Tuple.Create(Resources.menu, Resources.hoverMenu)},
                { "btnMainMenu", Tuple.Create(Resources.main, Resources.hoverMain) },
                { "btnVisits", Tuple.Create(Resources.visits, Resources.hoverVisits) },
                { "btnInventory", Tuple.Create(Resources.inventory, Resources.hoverInventory) },
                { "btnStatistics", Tuple.Create(Resources.statistics, Resources.hoverStatistics) },
                { "btnSections", Tuple.Create(Resources.sections, Resources.hoverSections) },
                { "btnUsers", Tuple.Create(Resources.users, Resources.hoverUsers) },
                { "btnLogout", Tuple.Create(Resources.logout, Resources.hoverLogout) }
            };

            // Expandir / Colapsar la sidebar
            objDashboard.btnMenu.Click += new EventHandler(MorphSideBar);

            // Abrir Formularios
            //objDashboard.btnMainMenu.Click += new EventHandler(OpenMainMenuForm);
            objDashboard.btnVisits.Click += new EventHandler(OpenPatientAdministrationForm);
            objDashboard.btnInventory.Click += new EventHandler(OpenInventoryAdministrationForm);
            //objDashboard.btnStatistics.Click += new EventHandler(OpenStatisticsForm);
            objDashboard.btnSections.Click += new EventHandler(OpenSectionAdministrationForm);
            objDashboard.btnUsers.Click += new EventHandler(OpenUserAdministrationForm);

            // Cambios de imagen por MouseEnter
            objDashboard.btnMenu.MouseEnter += new EventHandler(MouseEnterControl);
            objDashboard.btnMainMenu.MouseEnter += new EventHandler(MouseEnterControl);
            objDashboard.btnVisits.MouseEnter += new EventHandler(MouseEnterControl);
            objDashboard.btnInventory.MouseEnter += new EventHandler(MouseEnterControl);
            objDashboard.btnStatistics.MouseEnter += new EventHandler(MouseEnterControl);
            objDashboard.btnSections.MouseEnter += new EventHandler(MouseEnterControl);
            objDashboard.btnUsers.MouseEnter += new EventHandler(MouseEnterControl);
            objDashboard.btnLogout.MouseEnter += new EventHandler(MouseEnterControl);

            // Cambios de imagen por MouseLeave
            objDashboard.btnMenu.MouseLeave += new EventHandler(MouseLeaveControl);
            objDashboard.btnMainMenu.MouseLeave += new EventHandler(MouseLeaveControl);
            objDashboard.btnVisits.MouseLeave += new EventHandler(MouseLeaveControl);
            objDashboard.btnInventory.MouseLeave += new EventHandler(MouseLeaveControl);
            objDashboard.btnStatistics.MouseLeave += new EventHandler(MouseLeaveControl);
            objDashboard.btnSections.MouseLeave += new EventHandler(MouseLeaveControl);
            objDashboard.btnUsers.MouseLeave += new EventHandler(MouseLeaveControl);
            objDashboard.btnLogout.MouseLeave += new EventHandler(MouseLeaveControl);

            // Cerrar Sesión
            objDashboard.btnLogout.Click += new EventHandler(Logout);
            objDashboard.FormClosing += new FormClosingEventHandler(CloseProgram);
        }
        private void InitialLoad(object sender, EventArgs e)
        {
            CheckUserAccessRole();
        }
        private void MorphSideBar(object sender, EventArgs e)
        {
            // Se actualiza el ancho del panel lateral donde están los botoncitos
            objDashboard.pnlSideBar.Width = isSideBarExpanded ? collapsedWidth : expandedWidth;
            objDashboard.btnMenu.Location = new Point(isSideBarExpanded ? collapsedLogoX : expandedLogoX, logoY);

            // Se actualizan todos los paneles para que tengan el mismo ancho del recién cambiado panel lateral
            foreach (Panel pnl in new Panel[] { objDashboard.pnlMenu, objDashboard.flpTabs, objDashboard.pnlMainMenu, objDashboard.pnlVisits, objDashboard.pnlInventory, objDashboard.pnlStatistics, objDashboard.pnlSections, objDashboard.pnlUsers, objDashboard.pnlLogout })
            {
                pnl.Width = objDashboard.pnlSideBar.Width;
            }

            // Se actualizan todos los botones basándose en el estado del panel lateral
            foreach (Button btn in new Button[] { objDashboard.btnMainMenu, objDashboard.btnVisits, objDashboard.btnInventory, objDashboard.btnStatistics, objDashboard.btnSections, objDashboard.btnUsers, objDashboard.btnLogout })
            {
                if (isSideBarExpanded)
                {
                    btn.Text = "";
                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                    if(!(btn == objDashboard.btnLogout)) btn.Size = new Size(32, 32);
                    else btn.Size = new Size(48, 48);
                    btn.Location = new Point(btn == objDashboard.btnLogout ? collapsedButtonX[1] : collapsedButtonX[0], btn.Location.Y);
                }
                else
                {
                    btn.Text = GetButtonText(btn);
                    btn.Visible = true;
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    if (!(btn == objDashboard.btnLogout)) btn.Size = new Size(208, 32);
                    else btn.Size = new Size(208, 48);
                    btn.Location = new Point(expandedButtonX, btn.Location.Y);
                }
                // Se refresca el botón que acaba de ser actualizado, por qué no :)
                btn.Refresh();
            }
            isSideBarExpanded = !isSideBarExpanded;
        }
        private void OpenPatientAdministrationForm(object sender, EventArgs e)
        {
            objDashboard.btnMainMenu.Image = Resources.main;
            objDashboard.btnVisits.Image = Resources.hoverVisits;
            objDashboard.btnInventory.Image = Resources.inventory;
            objDashboard.btnStatistics.Image = Resources.statistics;
            objDashboard.btnSections.Image = Resources.sections;
            objDashboard.btnUsers.Image = Resources.users;

            objDashboard.btnMainMenu.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnVisits.ForeColor = Color.FromArgb(31, 43, 91);
            objDashboard.btnInventory.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnStatistics.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnSections.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnUsers.ForeColor = Color.FromArgb(142, 202, 230);

            objDashboard.pnlMainMenu.BackColor = Color.White;
            objDashboard.pnlVisits.BackColor = Color.FromArgb(142, 202, 230);
            objDashboard.pnlInventory.BackColor = Color.White;
            objDashboard.pnlStatistics.BackColor = Color.White;
            objDashboard.pnlSections.BackColor = Color.White;
            objDashboard.pnlUsers.BackColor = Color.White;

            objDashboard.btnMainMenu.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnVisits.FlatAppearance.BorderColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnInventory.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnStatistics.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnSections.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnUsers.FlatAppearance.BorderColor = Color.White;

            OpenForm<FrmPatientAdministration>(objDashboard.btnVisits);
        }
        private void OpenInventoryAdministrationForm(object sender, EventArgs e)
        {
            objDashboard.btnMainMenu.Image = Resources.main;
            objDashboard.btnVisits.Image = Resources.visits;
            objDashboard.btnInventory.Image = Resources.hoverInventory;
            objDashboard.btnStatistics.Image = Resources.statistics;
            objDashboard.btnSections.Image = Resources.sections;
            objDashboard.btnUsers.Image = Resources.users;

            objDashboard.btnMainMenu.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnVisits.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnInventory.ForeColor = Color.FromArgb(31, 43, 91);
            objDashboard.btnStatistics.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnSections.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnUsers.ForeColor = Color.FromArgb(142, 202, 230);

            objDashboard.pnlMainMenu.BackColor = Color.White;
            objDashboard.pnlVisits.BackColor = Color.White;
            objDashboard.pnlInventory.BackColor = Color.FromArgb(142, 202, 230);
            objDashboard.pnlStatistics.BackColor = Color.White;
            objDashboard.pnlSections.BackColor = Color.White;
            objDashboard.pnlUsers.BackColor = Color.White;

            objDashboard.btnMainMenu.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnVisits.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnInventory.FlatAppearance.BorderColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnStatistics.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnSections.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnUsers.FlatAppearance.BorderColor = Color.White;

            OpenForm<FrmInventoryAdministration>(objDashboard.btnInventory);
        }
        private void OpenSectionAdministrationForm(object sender, EventArgs e)
        {
            objDashboard.btnMainMenu.Image = Resources.main;
            objDashboard.btnVisits.Image = Resources.visits;
            objDashboard.btnInventory.Image = Resources.inventory;
            objDashboard.btnStatistics.Image = Resources.statistics;
            objDashboard.btnSections.Image = Resources.hoverSections;
            objDashboard.btnUsers.Image = Resources.users;

            objDashboard.btnMainMenu.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnVisits.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnInventory.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnStatistics.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnSections.ForeColor = Color.FromArgb(31, 43, 91);
            objDashboard.btnUsers.ForeColor = Color.FromArgb(142, 202, 230);

            objDashboard.pnlMainMenu.BackColor = Color.White;
            objDashboard.pnlVisits.BackColor = Color.White;
            objDashboard.pnlInventory.BackColor = Color.White;
            objDashboard.pnlStatistics.BackColor = Color.White;
            objDashboard.pnlSections.BackColor = Color.FromArgb(142, 202, 230);
            objDashboard.pnlUsers.BackColor = Color.White;

            objDashboard.btnMainMenu.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnVisits.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnInventory.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnStatistics.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnSections.FlatAppearance.BorderColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnUsers.FlatAppearance.BorderColor = Color.White;

            OpenForm<FrmSectionAdministration>(objDashboard.btnSections);
        }
        private void OpenUserAdministrationForm(object sender, EventArgs e)
        {
            objDashboard.btnMainMenu.Image = Resources.main;
            objDashboard.btnVisits.Image = Resources.visits;
            objDashboard.btnInventory.Image = Resources.inventory;
            objDashboard.btnStatistics.Image = Resources.statistics;
            objDashboard.btnSections.Image = Resources.sections;
            objDashboard.btnUsers.Image = Resources.hoverUsers;

            objDashboard.btnMainMenu.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnVisits.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnInventory.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnStatistics.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnSections.ForeColor = Color.FromArgb(142, 202, 230);
            objDashboard.btnUsers.ForeColor = Color.FromArgb(31, 43, 91);

            objDashboard.pnlMainMenu.BackColor = Color.White;
            objDashboard.pnlVisits.BackColor = Color.White;
            objDashboard.pnlInventory.BackColor = Color.White;
            objDashboard.pnlStatistics.BackColor = Color.White;
            objDashboard.pnlSections.BackColor = Color.White;
            objDashboard.pnlUsers.BackColor = Color.FromArgb(142, 202, 230);

            objDashboard.btnMainMenu.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnVisits.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnInventory.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnStatistics.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnSections.FlatAppearance.BorderColor = Color.White;
            objDashboard.btnUsers.FlatAppearance.BorderColor = Color.FromArgb(142, 202, 230);

            OpenForm<FrmUserAdministration>(objDashboard.btnUsers);
        }
        private void MouseEnterControl(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.Image = imageMapping[btn.Name].Item2;
                btn.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void MouseLeaveControl(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                if (btn != currentButton)
                {
                    btn.Image = imageMapping[btn.Name].Item1;
                    btn.ForeColor = Color.FromArgb(142, 202, 230);
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
        private void CloseProgram(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar el programa directamente? Considere que se cerrará la sesión de manera automática", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                commonMethods.DisposeOfCurrentUserData();
                Environment.Exit(0);
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
        private string GetButtonText(Button btn)
        {
            if (btn == objDashboard.btnMainMenu) return "Página Principal";
            if (btn == objDashboard.btnVisits) return "Visitas";
            if (btn == objDashboard.btnInventory) return "Inventario";
            if (btn == objDashboard.btnStatistics) return "Estadísticas";
            if (btn == objDashboard.btnSections) return "Secciones";
            if (btn == objDashboard.btnUsers) return "Usuarios";
            if (btn == objDashboard.btnLogout) return "Cerrar Sesión";
            return "";
        }
    }
}
