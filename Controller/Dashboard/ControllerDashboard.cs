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
        static FrmDashboard frmDashboard; // Variable estática para almacenar la instancia del formulario principal del dashboard.
        Form currentForm; // Guarda una referencia al formulario actualmente abierto en el panel contenedor.
        Button currentButton; // Guarda el botón actualmente seleccionado.
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping; // Diccionario para mapear botones con sus imágenes normales y de hover.

        // Constructor del controlador que se asocia al formulario principal (FrmDashboard).
        public ControllerDashboard(FrmDashboard view)
        {
            // Se inicializan las variables de ancho y alto de la pantalla en CurrentUserData.
            CurrentUserData.ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            CurrentUserData.ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            frmDashboard = view; // Se asigna el formulario de vista (dashboard) a la variable.

            // Asocia el método `InitialLoad` al evento Load del formulario, para configurar cosas al cargar la interfaz.
            frmDashboard.Load += new EventHandler(InitialLoad);

            // Se inicializa el diccionario con los botones del dashboard y sus imágenes respectivas.
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

            // Aquí conectamos el botón del menú para expandir/colapsar la barra lateral.
            frmDashboard.btnMenu.Click += new EventHandler(MorphSideBar);

            // Aquí manejamos la apertura de los formularios dentro del panel contenedor.
            frmDashboard.btnMainPage.Click += new EventHandler(OpenMainPageForm);
            frmDashboard.btnVisits.Click += new EventHandler(OpenPatientAdministrationForm);
            frmDashboard.btnInventory.Click += new EventHandler(OpenInventoryAdministrationForm);
            frmDashboard.btnSettings.Click += new EventHandler(OpenSettingsForm);
            frmDashboard.btnSections.Click += new EventHandler(OpenSectionAdministrationForm);
            frmDashboard.btnUsers.Click += new EventHandler(OpenUserAdministrationForm);

            // Cambiamos la imagen del botón cuando el ratón pasa por encima (MouseEnter).
            frmDashboard.btnMenu.MouseEnter += new EventHandler(MouseEnterControl);
            frmDashboard.btnMainPage.MouseEnter += new EventHandler(MouseEnterControl);
            frmDashboard.btnVisits.MouseEnter += new EventHandler(MouseEnterControl);
            frmDashboard.btnInventory.MouseEnter += new EventHandler(MouseEnterControl);
            frmDashboard.btnSettings.MouseEnter += new EventHandler(MouseEnterControl);
            frmDashboard.btnSections.MouseEnter += new EventHandler(MouseEnterControl);
            frmDashboard.btnUsers.MouseEnter += new EventHandler(MouseEnterControl);
            frmDashboard.btnLogout.MouseEnter += new EventHandler(MouseEnterControl);

            // Restauramos la imagen del botón cuando el ratón sale de la zona (MouseLeave).
            frmDashboard.btnMenu.MouseLeave += new EventHandler(MouseLeaveControl);
            frmDashboard.btnMainPage.MouseLeave += new EventHandler(MouseLeaveControl);
            frmDashboard.btnVisits.MouseLeave += new EventHandler(MouseLeaveControl);
            frmDashboard.btnInventory.MouseLeave += new EventHandler(MouseLeaveControl);
            frmDashboard.btnSettings.MouseLeave += new EventHandler(MouseLeaveControl);
            frmDashboard.btnSections.MouseLeave += new EventHandler(MouseLeaveControl);
            frmDashboard.btnUsers.MouseLeave += new EventHandler(MouseLeaveControl);
            frmDashboard.btnLogout.MouseLeave += new EventHandler(MouseLeaveControl);

            // Asociamos el botón de logout para cerrar la sesión.
            frmDashboard.btnLogout.Click += new EventHandler(Logout);

            // Manejamos el evento de cierre del formulario para limpiar correctamente cuando se cierra la aplicación.
            frmDashboard.FormClosing += new FormClosingEventHandler(CloseProgram);
        }

        // Método que alterna el modo de pantalla completa o normal.
        static public void ToggleFullScreen(object sender, EventArgs e)
        {
            // Si ya estamos en pantalla completa, cambia a modo ventana normal.
            if (CurrentUserData.FullScreen)
            {
                frmDashboard.FormBorderStyle = FormBorderStyle.None;
                frmDashboard.WindowState = FormWindowState.Normal;
                frmDashboard.Size = new Size((int)(CurrentUserData.ScreenWidth * .75), (int)(CurrentUserData.ScreenHeight * .75)); // Tamaño del 75% de la pantalla.
                frmDashboard.Location = new Point((CurrentUserData.ScreenWidth - frmDashboard.Width) / 2, (CurrentUserData.ScreenHeight - frmDashboard.Height) / 2); // Centrar la ventana.
                frmDashboard.Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, frmDashboard.Width, frmDashboard.Height, 20, 20)); // Borde redondeado.
            }
            else
            {
                // Si no estamos en pantalla completa, entonces entramos a pantalla completa.
                frmDashboard.FormBorderStyle = FormBorderStyle.None;
                frmDashboard.WindowState = FormWindowState.Normal;

                // Se ajusta al área de trabajo disponible (sin incluir la barra de tareas).
                Rectangle screenArea = Screen.PrimaryScreen.WorkingArea;
                frmDashboard.Size = new Size(screenArea.Width, screenArea.Height);
                frmDashboard.Location = new Point(screenArea.Left, screenArea.Top);

                // Se elimina el borde redondeado cuando está en pantalla completa.
                frmDashboard.Region = new Region(new Rectangle(0, 0, frmDashboard.Width, frmDashboard.Height));
            }

            // Llama al método para redimensionar los controles.
            ResizeControls(2);

            // Alterna la variable de estado de pantalla completa.
            CurrentUserData.FullScreen = !CurrentUserData.FullScreen;

            // Refresca la interfaz para aplicar los cambios visuales.
            frmDashboard.Invalidate();
            frmDashboard.Refresh();
        }

        // Método que inicializa el formulario la primera vez que se carga.
        private void InitialLoad(object sender, EventArgs e)
        {
            // Se ajusta el tamaño del formulario al 75% de la pantalla.
            frmDashboard.Size = new Size((int)(CurrentUserData.ScreenWidth * .75), (int)(CurrentUserData.ScreenHeight * .75));

            CurrentUserData.IsSideBarExpanded = true; // Se inicializa la barra lateral como expandida.
            CheckUserAccessRole(); // Verifica los permisos del usuario según su rol.

            // Se establece un borde redondeado en la ventana.
            frmDashboard.Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, frmDashboard.Width, frmDashboard.Height, 20, 20));
        }

        // Método que expande o colapsa la barra lateral del dashboard.
        private void MorphSideBar(object sender, EventArgs e)
        {
            // Cambia el ancho de las columnas en el TableLayoutPanel del dashboard dependiendo si está expandida o no.
            frmDashboard.tlpDashboard.ColumnStyles[0].Width = CurrentUserData.IsSideBarExpanded ? 9.86f : 18.42f; // Barra lateral.
            frmDashboard.tlpDashboard.ColumnStyles[1].Width = CurrentUserData.IsSideBarExpanded ? 90.14f : 81.58f; // Contenido principal.

            // Llama al método para ajustar los controles según el estado de la barra lateral.
            ResizeControls(1);

            // Refresca el panel contenedor para aplicar los cambios.
            frmDashboard.pnlContainer.Refresh();
            frmDashboard.pnlContainer.Invalidate();

            // Alterna el estado de la barra lateral.
            CurrentUserData.IsSideBarExpanded = !CurrentUserData.IsSideBarExpanded;
        }

        // Método que redimensiona los controles dentro del formulario.
        static private void ResizeControls(int procedure)
        {
            // Ajusta el ancho de los paneles dentro del formulario para que coincidan con el panel lateral.
            foreach (Panel pnl in new Panel[] { frmDashboard.pnlMenu, frmDashboard.flpTabs, frmDashboard.pnlMainPage, frmDashboard.pnlVisits, frmDashboard.pnlInventory, frmDashboard.pnlSettings, frmDashboard.pnlSections, frmDashboard.pnlUsers, frmDashboard.pnlLogout })
            {
                pnl.Width = frmDashboard.pnlSidebar.Width;
            }

            // Ajusta las columnas dentro del TableLayoutPanel del menú principal.
            frmDashboard.tlpMenu.ColumnStyles[0].SizeType = SizeType.Percent;
            frmDashboard.tlpMenu.ColumnStyles[0].Width = CurrentUserData.IsSideBarExpanded ? 30.67f : 40.35f;

            frmDashboard.tlpMenu.ColumnStyles[1].SizeType = SizeType.Percent;
            frmDashboard.tlpMenu.ColumnStyles[1].Width = CurrentUserData.IsSideBarExpanded ? 42.66f : 23.30f;

            frmDashboard.tlpMenu.ColumnStyles[2].SizeType = SizeType.Percent;
            frmDashboard.tlpMenu.ColumnStyles[2].Width = CurrentUserData.IsSideBarExpanded ? 26.67f : 36.35f;

            // Ajusta las columnas de los formularios (MainPage, Visits, Inventory, etc.) de manera uniforme.
            foreach (TableLayoutPanel tlp in new TableLayoutPanel[] { frmDashboard.tlpMainPage, frmDashboard.tlpVisits, frmDashboard.tlpInventory, frmDashboard.tlpSettings, frmDashboard.tlpSections, frmDashboard.tlpUsers })
            {
                foreach (ColumnStyle style in tlp.ColumnStyles)
                {
                    style.SizeType = SizeType.Percent;
                    style.Width = 50f; // Cada columna toma el 50% del ancho disponible.
                }
            }
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
        private void CloseProgram(object sender, EventArgs e)
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
        static private string GetButtonText(Button btn)
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
