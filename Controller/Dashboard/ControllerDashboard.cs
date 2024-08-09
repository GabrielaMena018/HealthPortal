using HealthPortal.View.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.View.PatientAdministration;
using HealthPortal.View.UserAdministration;
using HealthPortal.View.SectionAdministration;
using HealthPortal.View.InventoryAdministration;
using HealthPortal.Helper;
using HealthPortal.View.Login;

namespace HealthPortal.Controller.Dashboard
{
    public class ControllerDashboard
    {
        FrmDashboard objDashboard;
        Form currentForm;
        CommonMethods commonMethods = new CommonMethods();
        bool sideBarExpand = true;
        int computerHeight = Screen.PrimaryScreen.Bounds.Height;
        int computerWidth = Screen.PrimaryScreen.Bounds.Width;
      
        public ControllerDashboard(FrmDashboard view)
        {
            objDashboard = view;
            objDashboard.Load += new EventHandler(InitialChargue);

            // PatientAdministration
            objDashboard.tsrPatientAdministration.Click += new EventHandler(OpenFormPatientAdministration);
            objDashboard.btnPatientAdministrationImg.Click += new EventHandler(OpenFormPatientAdministration);
            objDashboard.btnPatientAdministration.Click += new EventHandler(OpenFormPatientAdministration);

            // InventoryAdministration
            objDashboard.tsrInventoryAdministration.Click += new EventHandler(OpenFormInventoryAdministration);
            objDashboard.btnInventoryAdministration.Click += new EventHandler(OpenFormInventoryAdministration);
            objDashboard.btnInventoryAdministrationImg.Click += new EventHandler(OpenFormInventoryAdministration);

            // UserAdministration
            objDashboard.tsrUserAdminsitration.Click += new EventHandler(OpenFormUserAdministration);
            objDashboard.btnUserAdministrationImg.Click += new EventHandler(OpenFormUserAdministration);
            objDashboard.btnUserAdministration.Click += new EventHandler(OpenFormUserAdministration);

            // SectionAdministration
            objDashboard.tsrSectionAdministration.Click += new EventHandler(OpenFormSectionAdministration);
            objDashboard.btnSectionAdministrationImg.Click += new EventHandler(OpenFormSectionAdministration);
            objDashboard.btnSectionAdministration.Click += new EventHandler(OpenFormSectionAdministration);

            // Logout
            // Al que lea esto le mando un abrazo, atentamente Juan del 8 de agosto de 2024 a las 12:58 de la madrugada
            objDashboard.btnLogout.Click += new EventHandler(Logout);
            objDashboard.btnLogoutImg.Click += new EventHandler(Logout);

            // Sidebar del Dashboard
            objDashboard.btnMenu.Click += new EventHandler(buttonExpandCollapse_Click);
        }

        private void InitialChargue(object sender, EventArgs e)
        {
            CheckRolUser();
        }

        private void OpenFormPatientAdministration(object sender, EventArgs e)
        {
            OpenForm<FrmPatientAdministration>();
        }
        private void OpenFormInventoryAdministration(object sender, EventArgs e)
        {
            OpenForm<FrmInventoryAdministration>();
        }
        private void OpenFormUserAdministration(object sender, EventArgs e)
        {
            OpenForm<FrmUserAdministration>();
        }
        private void OpenFormSectionAdministration(object sender, EventArgs e)
        {
            OpenForm<FrmSectionAdministration>();
        }
        //public void PatientAdministration(object sende, EventArgs e)
        //{
        //    FrmPatientAdministration openForm = new FrmPatientAdministration();
        //    openForm.ShowDialog();
        //}
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
        private void OpenForm<MiForm>() where MiForm : Form, new()
        {
            //Se declara objeto de tipo Form llamada formulario
            Form formulario;
            //Se guarda en el panel contenedor del formulario principal todos los controles del formulario que desea abrir <MiForm> posteriormente se guarda todo en el objeto de tipo formulario
            formulario = objDashboard.PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            //Si el formulario no existe se procederá a crearlo de lo contrario solo se traerá al frente (ver clausula else)
            if (formulario == null)
            {
                //Se define un nuevo formulario para guardarse como nuevo objeto MiForm
                formulario = new MiForm();
                //Se especifica que el formulario debe mostrarse como ventana
                formulario.TopLevel = false;
                //Se eliminan los bordes del formulario
                formulario.FormBorderStyle = FormBorderStyle.None;
                //Se establece que se abrira en todo el espacio del formulario padre
                formulario.Dock = DockStyle.Fill;
                //Se le asigna una opacidad de 0.75
                formulario.Opacity = 0.75;
                //Se evalua el formulario actual para verificar si es nulo
                if (currentForm != null)
                {
                    //Se cierra el formulario actual para mostrar el nuevo formulario
                    currentForm.Close();
                    //Se eliminan del panel contenedor todos los controles del formulario que se cerrará
                    objDashboard.PanelContenedor.Controls.Remove(currentForm);
                }
                //Se establece como nuevo formulario actual el formulario que se está abriendo
                currentForm = formulario;
                //Se agregan los controles del nuevo formulario al panel contenedor
                objDashboard.PanelContenedor.Controls.Add(formulario);
                //Tag es una propiedad genérica disponible para la mayoría de los controles en aplicaciones .NET, incluyendo los paneles.
                objDashboard.PanelContenedor.Tag = formulario;
                //Se muestra el formulario en el panel contenedor
                formulario.Show();
                //Se trae al frente el formulario armado
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForm(object sender, EventArgs e)
        {
            //Se cierra el formulario actual para mostrar el nuevo formulario
            currentForm.Close();
            //Se eliminan del panel contenedor todos los controles del formulario que se cerrará
            objDashboard.PanelContenedor.Controls.Remove(currentForm);
        }

        private void buttonExpandCollapse_Click(object sender, EventArgs e)
        {
            objDashboard.sidebar.Width = (objDashboard.MaximumSize.Width + computerHeight);
           

            sideBarExpand = !sideBarExpand;
            objDashboard.flowButtons.Width = objDashboard.sidebar.Width;

            if (sideBarExpand)
            {
                objDashboard.sidebar.Width = objDashboard.sidebar.MinimumSize.Width;
                objDashboard.sidebarTimer.Stop();
            }
            else
            {
                objDashboard.sidebar.Width = objDashboard.sidebar.MaximumSize.Width;
                objDashboard.sidebarTimer.Start();
            }
        }

        private void SliderTime_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                
                if (objDashboard.sidebar.Width > objDashboard.sidebar.MinimumSize.Width)     
                {
                    objDashboard.sidebar.Width -= 10;
                }
                else 
                {
                   objDashboard.sidebarTimer.Stop ();
                }
            }
            else
            {
                
                if (objDashboard.sidebar.Width < objDashboard.sidebar.MaximumSize.Width)
                {
                    objDashboard.sidebar.Width += 10;
                }
                else
                {
                    objDashboard.sidebarTimer.Stop();
                }
            }
        }

        private void CheckRolUser() 
        {
            if (CurrentUserData.RoleId == 2)
            {
                objDashboard.btnSectionAdministration.Visible = false;
                objDashboard.btnSectionAdministrationImg.Visible = false;
                objDashboard.btnUserAdministration.Visible = false;
                objDashboard.btnUserAdministrationImg.Visible = false;
            }
        }

     
    }  
}
