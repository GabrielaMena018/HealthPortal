using HealthPortal.Helper;
using HealthPortal.View.Dashboard;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.View.MainPage;
using HealthPortal.View.InventoryAdministration;
using HealthPortal.View.PatientAdministration;
using HealthPortal.View.SectionAdministration;
using HealthPortal.View.UserAdministration;
using HealthPortal.View.Settings;
using HealthPortal.Properties;
using HealthPortal.View.Login;

namespace HealthPortal.Controller.Dashboard
{
    internal class ControllerDashboard
    {
        FrmDashboard frmDashboard;
        Form currentForm;
        Button currentButton;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        const int collapsedLogoX = 43;
        const int expandedLogoX = 108;
        const int logoY = 43;
        public ControllerDashboard(FrmDashboard view)
        {
            frmDashboard = view;
            frmDashboard.Size = new Size((int)(CurrentUserData.ScreenWidth * .75), (int)(CurrentUserData.ScreenHeight * .75));
            frmDashboard.Load += new EventHandler(InitialLoad);
            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnMenu", Tuple.Create(Resources.menu, Resources.hoverMenu)},
                { "btnMainPage", Tuple.Create(Resources.main, Resources.hoverMain) },
                { "btnVisits", Tuple.Create(Resources.visits, Resources.hoverVisits) },
                { "btnInventory", Tuple.Create(Resources.inventory, Resources.hoverInventory) },
                { "btnSettings", Tuple.Create(Resources.settings, Resources.hoverSettings) },
                { "btnSections", Tuple.Create(Resources.sections, Resources.hoverSections) },
                { "btnUsers", Tuple.Create(Resources.users, Resources.hoverUsers) },
                { "btnLogout", Tuple.Create(Resources.logout, Resources.hoverLogout) }
            };

            CommonMethods.EnableFormDrag(frmDashboard, frmDashboard.pnlMenu);

            // Expandir / Colapsar la sidebar
            frmDashboard.btnMenu.Click += new EventHandler(MorphSideBar);

            // Abrir Formularios
            frmDashboard.Load += new EventHandler(OpenMainPageForm);
            frmDashboard.btnMainPage.Click += new EventHandler(OpenMainPageForm);
            frmDashboard.btnVisits.Click += new EventHandler(OpenPatientAdministrationForm);
            frmDashboard.btnInventory.Click += new EventHandler(OpenInventoryAdministrationForm);
            frmDashboard.btnSettings.Click += new EventHandler(OpenSettingsForm);
            frmDashboard.btnSections.Click += new EventHandler(OpenSectionAdministrationForm);
            frmDashboard.btnUsers.Click += new EventHandler(OpenUserAdministrationForm);

            // Cambios de imagen por MouseEnter
            frmDashboard.btnMenu.MouseEnter += new EventHandler(MouseEnterControl);
            frmDashboard.btnMainPage.MouseEnter += new EventHandler(MouseEnterControl);
            frmDashboard.btnVisits.MouseEnter += new EventHandler(MouseEnterControl);
            frmDashboard.btnInventory.MouseEnter += new EventHandler(MouseEnterControl);
            frmDashboard.btnSettings.MouseEnter += new EventHandler(MouseEnterControl);
            frmDashboard.btnSections.MouseEnter += new EventHandler(MouseEnterControl);
            frmDashboard.btnUsers.MouseEnter += new EventHandler(MouseEnterControl);
            frmDashboard.btnLogout.MouseEnter += new EventHandler(MouseEnterControl);

            // Cambios de imagen por MouseLeave
            frmDashboard.btnMenu.MouseLeave += new EventHandler(MouseLeaveControl);
            frmDashboard.btnMainPage.MouseLeave += new EventHandler(MouseLeaveControl);
            frmDashboard.btnVisits.MouseLeave += new EventHandler(MouseLeaveControl);
            frmDashboard.btnInventory.MouseLeave += new EventHandler(MouseLeaveControl);
            frmDashboard.btnSettings.MouseLeave += new EventHandler(MouseLeaveControl);
            frmDashboard.btnSections.MouseLeave += new EventHandler(MouseLeaveControl);
            frmDashboard.btnUsers.MouseLeave += new EventHandler(MouseLeaveControl);
            frmDashboard.btnLogout.MouseLeave += new EventHandler(MouseLeaveControl);

            // Cerrar Sesión
            frmDashboard.btnLogout.Click += new EventHandler(Logout);
            frmDashboard.FormClosing += new FormClosingEventHandler(CloseProgram);
        }
        private void AdjustControlSizes()
        {
            int formWidth = frmDashboard.ClientSize.Width;
            frmDashboard.pnlSideBar.Width = CurrentUserData.IsSideBarExpanded ? (int)(formWidth * (280.0 / 1520.0)) : (int)(formWidth * (150.0 / 1520.0));
        }
        private void InitialLoad(object sender, EventArgs e)
        {
            CurrentUserData.IsSideBarExpanded = true;
            CurrentUserData.MaxSidePanelWidth = frmDashboard.pnlSideBar.Width > CurrentUserData.MaxSidePanelWidth ? frmDashboard.pnlSideBar.Width : CurrentUserData.MaxSidePanelWidth;
            CheckUserAccessRole();
            AdjustControlSizes();
        }
        private void MorphSideBar(object sender, EventArgs e)
        {
            // Se actualiza el ancho del panel lateral donde están los botoncitos
            frmDashboard.pnlSideBar.Width = CurrentUserData.IsSideBarExpanded ? (int)(frmDashboard.Width * (150.0 / 1520.0)) : (int)(frmDashboard.Width * (280.0 / 1520.0));
            CurrentUserData.ScaleFactor = (float)(frmDashboard.ClientSize.Width / 1520.0);
            frmDashboard.btnMenu.Location = new Point(CurrentUserData.IsSideBarExpanded ? (int)(collapsedLogoX * CurrentUserData.ScaleFactor) : (int)(expandedLogoX * CurrentUserData.ScaleFactor), (int)(logoY * CurrentUserData.ScaleFactor));

            // Se actualizan todos los paneles para que tengan el mismo ancho del recién cambiado panel lateral
            foreach (Panel pnl in new Panel[] { frmDashboard.pnlMenu, frmDashboard.flpTabs, frmDashboard.pnlMainPage, frmDashboard.pnlVisits, frmDashboard.pnlInventory, frmDashboard.pnlSettings, frmDashboard.pnlSections, frmDashboard.pnlUsers, frmDashboard.pnlLogout })
            {
                pnl.Width = frmDashboard.pnlSideBar.Width;
            }

            // Se actualizan todos los botones basándose en el estado del panel lateral
            foreach (Button btn in new Button[] { frmDashboard.btnMainPage, frmDashboard.btnVisits, frmDashboard.btnInventory, frmDashboard.btnSettings, frmDashboard.btnSections, frmDashboard.btnUsers, frmDashboard.btnLogout })
            {
                if (CurrentUserData.IsSideBarExpanded)
                {
                    btn.Text = "";
                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                    if(!(btn == frmDashboard.btnLogout)) btn.Size = new Size(32, 32);
                    else btn.Size = new Size(48, 48);
                }
                else
                {
                    btn.Text = GetButtonText(btn);
                    btn.Visible = true;
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    if (!(btn == frmDashboard.btnLogout)) btn.Size = new Size((int)(208 * CurrentUserData.ScaleFactor), 32);
                    else btn.Size = new Size((int)(208 * CurrentUserData.ScaleFactor), 48);
                }
                int diff = (frmDashboard.pnlSideBar.Width - btn.Width) / 2;
                btn.Location = new Point(diff, btn.Location.Y);

                // Se refresca el botón que acaba de ser actualizado, por qué no :)
                btn.Refresh();
            }
            frmDashboard.pnlContainer.Refresh();
            frmDashboard.pnlContainer.Invalidate();
            CurrentUserData.IsSideBarExpanded = !CurrentUserData.IsSideBarExpanded;
            MessageBox.Show("1. " + frmDashboard.pnlContainer.Width.ToString());
        }
        private void OpenMainPageForm(object sender, EventArgs e)
        {
            frmDashboard.btnMainPage.Image = Resources.hoverMain;
            frmDashboard.btnVisits.Image = Resources.visits;
            frmDashboard.btnInventory.Image = Resources.inventory;
            frmDashboard.btnSettings.Image = Resources.settings;
            frmDashboard.btnSections.Image = Resources.sections;
            frmDashboard.btnUsers.Image = Resources.users;

            frmDashboard.btnMainPage.ForeColor = Color.FromArgb(31, 43, 91);
            frmDashboard.btnVisits.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnInventory.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnSettings.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnSections.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnUsers.ForeColor = Color.FromArgb(142, 202, 230);

            frmDashboard.pnlMainPage.BackColor = Color.FromArgb(142, 202, 230);
            frmDashboard.pnlVisits.BackColor = Color.White;
            frmDashboard.pnlInventory.BackColor = Color.White;
            frmDashboard.pnlSettings.BackColor = Color.White;
            frmDashboard.pnlSections.BackColor = Color.White;
            frmDashboard.pnlUsers.BackColor = Color.White;

            frmDashboard.btnMainPage.FlatAppearance.BorderColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnVisits.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnInventory.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnSettings.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnSections.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnUsers.FlatAppearance.BorderColor = Color.White;

            OpenForm<FrmMainPage>(frmDashboard.btnMainPage);
        }
        private void OpenPatientAdministrationForm(object sender, EventArgs e)
        {
            frmDashboard.btnMainPage.Image = Resources.main;
            frmDashboard.btnVisits.Image = Resources.hoverVisits;
            frmDashboard.btnInventory.Image = Resources.inventory;
            frmDashboard.btnSettings.Image = Resources.settings;
            frmDashboard.btnSections.Image = Resources.sections;
            frmDashboard.btnUsers.Image = Resources.users;

            frmDashboard.btnMainPage.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnVisits.ForeColor = Color.FromArgb(31, 43, 91);
            frmDashboard.btnInventory.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnSettings.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnSections.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnUsers.ForeColor = Color.FromArgb(142, 202, 230);

            frmDashboard.pnlMainPage.BackColor = Color.White;
            frmDashboard.pnlVisits.BackColor = Color.FromArgb(142, 202, 230);
            frmDashboard.pnlInventory.BackColor = Color.White;
            frmDashboard.pnlSettings.BackColor = Color.White;
            frmDashboard.pnlSections.BackColor = Color.White;
            frmDashboard.pnlUsers.BackColor = Color.White;

            frmDashboard.btnMainPage.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnVisits.FlatAppearance.BorderColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnInventory.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnSettings.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnSections.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnUsers.FlatAppearance.BorderColor = Color.White;

            OpenForm<FrmPatientAdministration>(frmDashboard.btnVisits);
        }
        private void OpenInventoryAdministrationForm(object sender, EventArgs e)
        {
            frmDashboard.btnMainPage.Image = Resources.main;
            frmDashboard.btnVisits.Image = Resources.visits;
            frmDashboard.btnInventory.Image = Resources.hoverInventory;
            frmDashboard.btnSettings.Image = Resources.settings;
            frmDashboard.btnSections.Image = Resources.sections;
            frmDashboard.btnUsers.Image = Resources.users;

            frmDashboard.btnMainPage.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnVisits.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnInventory.ForeColor = Color.FromArgb(31, 43, 91);
            frmDashboard.btnSettings.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnSections.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnUsers.ForeColor = Color.FromArgb(142, 202, 230);

            frmDashboard.pnlMainPage.BackColor = Color.White;
            frmDashboard.pnlVisits.BackColor = Color.White;
            frmDashboard.pnlInventory.BackColor = Color.FromArgb(142, 202, 230);
            frmDashboard.pnlSettings.BackColor = Color.White;
            frmDashboard.pnlSections.BackColor = Color.White;
            frmDashboard.pnlUsers.BackColor = Color.White;

            frmDashboard.btnMainPage.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnVisits.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnInventory.FlatAppearance.BorderColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnSettings.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnSections.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnUsers.FlatAppearance.BorderColor = Color.White;

            OpenForm<FrmInventoryAdministration>(frmDashboard.btnInventory);
        }
        private void OpenSettingsForm(object sender, EventArgs e)
        {
            frmDashboard.btnMainPage.Image = Resources.main;
            frmDashboard.btnVisits.Image = Resources.visits;
            frmDashboard.btnInventory.Image = Resources.inventory;
            frmDashboard.btnSettings.Image = Resources.hoverSettings;
            frmDashboard.btnSections.Image = Resources.sections;
            frmDashboard.btnUsers.Image = Resources.users;

            frmDashboard.btnMainPage.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnVisits.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnInventory.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnSettings.ForeColor = Color.FromArgb(31, 43, 91);
            frmDashboard.btnSections.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnUsers.ForeColor = Color.FromArgb(142, 202, 230);

            frmDashboard.pnlMainPage.BackColor = Color.White;
            frmDashboard.pnlVisits.BackColor = Color.White;
            frmDashboard.pnlInventory.BackColor = Color.White;
            frmDashboard.pnlSettings.BackColor = Color.FromArgb(142, 202, 230);
            frmDashboard.pnlSections.BackColor = Color.White;
            frmDashboard.pnlUsers.BackColor = Color.White;

            frmDashboard.btnMainPage.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnVisits.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnInventory.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnSettings.FlatAppearance.BorderColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnSections.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnUsers.FlatAppearance.BorderColor = Color.White;

            OpenForm<FrmSettings>(frmDashboard.btnSettings);
        }
        private void OpenSectionAdministrationForm(object sender, EventArgs e)
        {
            frmDashboard.btnMainPage.Image = Resources.main;
            frmDashboard.btnVisits.Image = Resources.visits;
            frmDashboard.btnInventory.Image = Resources.inventory;
            frmDashboard.btnSettings.Image = Resources.settings;
            frmDashboard.btnSections.Image = Resources.hoverSections;
            frmDashboard.btnUsers.Image = Resources.users;

            frmDashboard.btnMainPage.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnVisits.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnInventory.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnSettings.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnSections.ForeColor = Color.FromArgb(31, 43, 91);
            frmDashboard.btnUsers.ForeColor = Color.FromArgb(142, 202, 230);

            frmDashboard.pnlMainPage.BackColor = Color.White;
            frmDashboard.pnlVisits.BackColor = Color.White;
            frmDashboard.pnlInventory.BackColor = Color.White;
            frmDashboard.pnlSettings.BackColor = Color.White;
            frmDashboard.pnlSections.BackColor = Color.FromArgb(142, 202, 230);
            frmDashboard.pnlUsers.BackColor = Color.White;

            frmDashboard.btnMainPage.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnVisits.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnInventory.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnSettings.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnSections.FlatAppearance.BorderColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnUsers.FlatAppearance.BorderColor = Color.White;

            OpenForm<FrmSectionAdministration>(frmDashboard.btnSections);
        }
        private void OpenUserAdministrationForm(object sender, EventArgs e)
        {
            frmDashboard.btnMainPage.Image = Resources.main;
            frmDashboard.btnVisits.Image = Resources.visits;
            frmDashboard.btnInventory.Image = Resources.inventory;
            frmDashboard.btnSettings.Image = Resources.settings;
            frmDashboard.btnSections.Image = Resources.sections;
            frmDashboard.btnUsers.Image = Resources.hoverUsers;

            frmDashboard.btnMainPage.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnVisits.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnInventory.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnSettings.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnSections.ForeColor = Color.FromArgb(142, 202, 230);
            frmDashboard.btnUsers.ForeColor = Color.FromArgb(31, 43, 91);

            frmDashboard.pnlMainPage.BackColor = Color.White;
            frmDashboard.pnlVisits.BackColor = Color.White;
            frmDashboard.pnlInventory.BackColor = Color.White;
            frmDashboard.pnlSettings.BackColor = Color.White;
            frmDashboard.pnlSections.BackColor = Color.White;
            frmDashboard.pnlUsers.BackColor = Color.FromArgb(142, 202, 230);

            frmDashboard.btnMainPage.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnVisits.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnInventory.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnSettings.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnSections.FlatAppearance.BorderColor = Color.White;
            frmDashboard.btnUsers.FlatAppearance.BorderColor = Color.FromArgb(142, 202, 230);

            OpenForm<FrmUserAdministration>(frmDashboard.btnUsers);
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
                CommonMethods.DisposeOfCurrentUserData();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                frmDashboard.Dispose();
            }
        }
        private void CloseProgram(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar el programa directamente? Considere que se cerrará la sesión de manera automática", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CommonMethods.DisposeOfCurrentUserData();
                Environment.Exit(0);
            }
        }
        private void OpenForm<NewForm>(Button associatedBtn) where NewForm : Form, new()
        {
            Form form;
            form = frmDashboard.pnlContainer.Controls.OfType<NewForm>().FirstOrDefault();
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
                    frmDashboard.pnlContainer.Controls.Remove(currentForm);
                }
                currentForm = form;
                frmDashboard.pnlContainer.Controls.Add(form);
                frmDashboard.pnlContainer.Tag = form;
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
                frmDashboard.btnSections.Visible = false;
                frmDashboard.btnUsers.Visible = false;
            }
        }
        private string GetButtonText(Button btn)
        {
            if (btn == frmDashboard.btnMainPage) return "Página Principal";
            if (btn == frmDashboard.btnVisits) return "Visitas";
            if (btn == frmDashboard.btnInventory) return "Inventario";
            if (btn == frmDashboard.btnSettings) return "Configuración";
            if (btn == frmDashboard.btnSections) return "Secciones";
            if (btn == frmDashboard.btnUsers) return "Usuarios";
            if (btn == frmDashboard.btnLogout) return "Cerrar Sesión";
            return "";
        }
    }
}
