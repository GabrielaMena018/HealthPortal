using HealthPortal.View.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.View;
using HealthPortal.View.UserAdministration;
using HealthPortal.View.SectionAdministration;

namespace HealthPortal.Controller.Dashboard
{
    public class ControllerDashboard
    {
        FrmDashboard ObjDashboard;
        Form currentForm;
        bool SiderBarExpand = true;
        int ComputerHeight = Screen.PrimaryScreen.Bounds.Height;
        int computerWidth = Screen.PrimaryScreen.Bounds.Width;
      
        public ControllerDashboard(FrmDashboard View)
        {
            
            ObjDashboard = View;
            ObjDashboard.StpHealthPortal.Click += new EventHandler(AbrirFormularioAdminPacientes);
            ObjDashboard.BtnPatience.Click += new EventHandler(AbrirFormularioAdminPacientes);
            ObjDashboard.btnMenu.Click += new EventHandler(buttonExpandCollapse_Click);
            ObjDashboard.BtnPicPaciente.Click += new EventHandler(AbrirFormularioAdminPacientes);
            ObjDashboard.BtnAdminUser.Click += new EventHandler(AbrirFormularioUserAdministration);
            ObjDashboard.BtnPicAdminUser.Click += new EventHandler(AbrirFormularioUserAdministration);
            ObjDashboard.BtnPicAdminUser.Click += new EventHandler(AbrirFormularioUserAdministration);
            ObjDashboard.BtnAdminGrados.Click += new EventHandler(AbrirFormularioAdminGrades);
            ObjDashboard.BtnPicAdminGrades.Click += new EventHandler(AbrirFormularioAdminGrades);


        }

        private void AbrirFormularioAdminGrades(object sender, EventArgs e)
        {
            AbrirFormulario<FrmSectionAdministration>();
        }

        public void AdminPatience(object sende, EventArgs e)
        {
            FrmPatientAdministration openForm = new FrmPatientAdministration();
            openForm.ShowDialog();
        }

        private void AbrirFormularioAdminPacientes(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPatientAdministration>();
        }

        private void AbrirFormularioUserAdministration(object sender, EventArgs e)
        {
            AbrirFormulario<FrmUserAdministration>();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            //Se declara objeto de tipo Form llamada formulario
            Form formulario;
            //Se guarda en el panel contenedor del formulario principal todos los controles del formulario que desea abrir <MiForm> posteriormente se guarda todo en el objeto de tipo formulario
            formulario = ObjDashboard.PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
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
                    ObjDashboard.PanelContenedor.Controls.Remove(currentForm);
                }
                //Se establece como nuevo formulario actual el formulario que se está abriendo
                currentForm = formulario;
                //Se agregan los controles del nuevo formulario al panel contenedor
                ObjDashboard.PanelContenedor.Controls.Add(formulario);
                //Tag es una propiedad genérica disponible para la mayoría de los controles en aplicaciones .NET, incluyendo los paneles.
                ObjDashboard.PanelContenedor.Tag = formulario;
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
        private void CerrarForm(object sender, EventArgs e)
        {
            //Se cierra el formulario actual para mostrar el nuevo formulario
            currentForm.Close();
            //Se eliminan del panel contenedor todos los controles del formulario que se cerrará
            ObjDashboard.PanelContenedor.Controls.Remove(currentForm);
        }

        private void buttonExpandCollapse_Click(object sender, EventArgs e)
        {
            ObjDashboard.sidebar.Width = (ObjDashboard.MaximumSize.Width + ComputerHeight);
           

            SiderBarExpand = !SiderBarExpand;
            ObjDashboard.flowButtons.Width = ObjDashboard.sidebar.Width;

            if (SiderBarExpand)
            {
                ObjDashboard.sidebar.Width = ObjDashboard.sidebar.MinimumSize.Width;
                ObjDashboard.sidebarTimer.Stop();
            }
            else
            {
                ObjDashboard.sidebar.Width = ObjDashboard.sidebar.MaximumSize.Width;
                ObjDashboard.sidebarTimer.Start();
            }
        }

        private void SliderTime_Tick(object sender, EventArgs e)
        {
            if (SiderBarExpand)
            {
                
                if (ObjDashboard.sidebar.Width > ObjDashboard.sidebar.MinimumSize.Width)     
                {
                    ObjDashboard.sidebar.Width -= 10;
                }
                else 
                {
                   ObjDashboard.sidebarTimer.Stop ();
                }
            }
            else
            {
                
                if (ObjDashboard.sidebar.Width < ObjDashboard.sidebar.MaximumSize.Width)
                {
                    ObjDashboard.sidebar.Width += 10;
                }
                else
                {
                    ObjDashboard.sidebarTimer.Stop();
                }
            }
        }

     
    }  
}
