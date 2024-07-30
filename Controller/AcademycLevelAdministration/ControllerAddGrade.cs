//*3*
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using RegistroPacientes.Models.DAO;
using RegistroPacientes.View.AcademycLevelAdministration;

namespace RegistroPacientes.Controller.AcademycLevelAdministration
{
    public class ControllerAddGrade
    {
        FrmAddGrades ObjAddGrade;
        int accion, TabPage;
        private string Especialidad, SeccionAcademcia, Grado;

        //******CONSTRUCTORES******

        //Constructor para abrir el apartado de agregar ya sea una Especialidad, Sección Academica o Sección en general
        public ControllerAddGrade(FrmAddGrades vista, int action, int tabPage)
        {
            this.accion = action;
            this.TabPage = tabPage;
            ObjAddGrade = vista;
            ObjAddGrade.Load += new EventHandler(InitialCharge);
            VerificarTabAction();
            VerificarAction();
            ObjAddGrade.btnAgregarEspecialidad.Click += new EventHandler(newEspecialidad);
            ObjAddGrade.BtnAgregarSeccion.Click += new EventHandler(newSeccion);
            ObjAddGrade.btnAgregarSeccionAcademica.Click += new EventHandler(newSeccionAcademica);
          
        }

        private void VerificarTabAction()
        {
            if (TabPage == 0)
            {
             
                ObjAddGrade.TabControlRegistros.SelectedIndex = 0;
            }
            else if (TabPage == 1) 
            {
                ObjAddGrade.TabControlRegistros.TabPages.Remove(ObjAddGrade.tabPageNewSection);
                ObjAddGrade.TabControlRegistros.TabPages.Remove(ObjAddGrade.tabPageNewEspecialidad);
                ObjAddGrade.TabControlRegistros.SelectedIndex = 1;
            }
            else if (TabPage == 2)
            {
                ObjAddGrade.TabControlRegistros.TabPages.Remove(ObjAddGrade.tabPageNewSctionAcademy);
                ObjAddGrade.TabControlRegistros.TabPages.Remove(ObjAddGrade.tabPageNewSection);
                ObjAddGrade.TabControlRegistros.SelectedIndex = 2;
            }
        }

        //Constructor para abrir el actualizar especialidades
        public ControllerAddGrade(FrmAddGrades vista, int action, int IdEspecialidad, string Especialidad)
        {
            this.accion = action;
            this.Especialidad = Especialidad;
            ObjAddGrade = vista;
            ObjAddGrade.Load += new EventHandler(InitialCharge);
            ObjAddGrade.TabControlRegistros.SelectedIndex = 2;
            VerificarAction();
            ChargueValueEspecialidad(IdEspecialidad);
            ObjAddGrade.BtnActuzalizarEspecialidad.Click += new EventHandler(UpdateEspecialidad);
   

        }

        //Constructor para abrir el actualizar secciones
        public ControllerAddGrade(FrmAddGrades vista, int action, int IdSeccion, string GrupoTecnico, string Especialidad, string Grado, string SeccionAcademica)
         {
            this.accion = action;
            ObjAddGrade = vista;
            this.Grado = Grado;
            this.SeccionAcademcia = SeccionAcademica;
            this.Especialidad = Especialidad;
            
            ObjAddGrade.Load += new EventHandler(InitialCharge);
            VerificarAction();
            ChargueValueSeccion(IdSeccion, GrupoTecnico);
            ObjAddGrade.BtnActualizarSeccion.Click += new EventHandler(UpdateSeccion);

        }

        //Controlador para abrir el actualizar seccion academica se le manda el apartado num para diferenciarlo de la vista que se abre al actualizar especialidades, pero este dato no se utiliza
        public ControllerAddGrade(FrmAddGrades vista, int action, int IdSeccionAcademica, string nombreSeccionAcademica, int num)
        {
            this.accion = action;
            this.SeccionAcademcia = nombreSeccionAcademica;
            ObjAddGrade = vista;
            ObjAddGrade.Load += new EventHandler(InitialCharge);
            ObjAddGrade.TabControlRegistros.SelectedIndex = 1;
            VerificarAction();
            ChargueValueSeccionAcademica(IdSeccionAcademica);
            ObjAddGrade.btnActualizarSeccionAcademica.Click += new EventHandler(UpdateSeccionAcademica);
        }

        //Cargar Valores
        private void ChargueValueEspecialidad(int IdEspecialidad)
        {
            ObjAddGrade.txtId.Text = IdEspecialidad.ToString();
            ObjAddGrade.TabControlRegistros.TabPages.Remove(ObjAddGrade.tabPageNewSctionAcademy);
            ObjAddGrade.TabControlRegistros.TabPages.Remove(ObjAddGrade.tabPageNewSection);


        }

        private void ChargueValueSeccion(int IdSeccion, string GrupoTecnico)
        {
            ObjAddGrade.txtId.Text = IdSeccion.ToString();
            ObjAddGrade.txtGrupoTecnico.Texts = GrupoTecnico.ToString();
            ObjAddGrade.TabControlRegistros.TabPages.Remove(ObjAddGrade.tabPageNewSctionAcademy);
            ObjAddGrade.TabControlRegistros.TabPages.Remove(ObjAddGrade.tabPageNewEspecialidad);
            
        }

        private void ChargueValueSeccionAcademica(int IdSeccion)
        {
            ObjAddGrade.txtId.Text = IdSeccion.ToString();
            ObjAddGrade.TabControlRegistros.TabPages.Remove(ObjAddGrade.tabPageNewSection);
            ObjAddGrade.TabControlRegistros.TabPages.Remove(ObjAddGrade.tabPageNewEspecialidad);

        }

        //Verificar action
        public void VerificarAction() 
        {
            if (accion == 1)
            {
                ObjAddGrade.btnAgregarEspecialidad.Enabled = true;
                ObjAddGrade.BtnActuzalizarEspecialidad.Enabled = false;


                ObjAddGrade.btnAgregarSeccionAcademica.Enabled = true;
                ObjAddGrade.btnActualizarSeccionAcademica.Enabled = false;
                ObjAddGrade.cmbEspecialidadExistente.Enabled = false;


                ObjAddGrade.BtnAgregarSeccion.Enabled = true;
                ObjAddGrade.BtnActualizarSeccion.Enabled = false;
 
            }
            else if (accion == 2)
            {
                ObjAddGrade.lblRegistrarEspecialidad.Text = "Actualizar Especialidad";
                ObjAddGrade.lblNuevaEspecialidad.Text = "Nuevo Nombre de la Especialidad";
                ObjAddGrade.btnAgregarEspecialidad.Enabled = false;
                ObjAddGrade.BtnActuzalizarEspecialidad.Enabled = true;
                ObjAddGrade.cmbEspecialidadExistente.Enabled = true;

                ObjAddGrade.lblRegistrarSeccionAcademica.Text = "Actualizar Sección Académica";
                ObjAddGrade.lblSeccionAcademica.Text = "Nuevo nombre de la Sección";
                ObjAddGrade.btnAgregarSeccionAcademica.Enabled = false;
                ObjAddGrade.btnActualizarSeccionAcademica.Enabled = true;
                ObjAddGrade.cmbSecionAcademicaExistente.Enabled = true;

                ObjAddGrade.lblRegistrarSeccion.Text = "Actualizar Sección";
                ObjAddGrade.BtnAgregarSeccion.Enabled = false;
                ObjAddGrade.BtnActualizarSeccion.Enabled = true;

            }
            else if (accion == 3) 
            {
                //Seccion
                ObjAddGrade.lblRegistrarSeccion.Text = "Ficha de la Sección";
                ObjAddGrade.CmbGrado.Enabled = false;
                ObjAddGrade.cmbEspecialidad.Enabled = false;
                ObjAddGrade.CmbSeccionAcademica.Enabled = false;
                ObjAddGrade.txtGrupoTecnico.Enabled = false;
                ObjAddGrade.CmbGrado.BackColor = Color.WhiteSmoke;
                ObjAddGrade.cmbEspecialidad.BackColor = Color.WhiteSmoke;
                ObjAddGrade.CmbSeccionAcademica.BackColor = Color.WhiteSmoke;
                ObjAddGrade.txtGrupoTecnico.BackColor = Color.WhiteSmoke;

                //Quita los tabsPages para que no se muestren
                ObjAddGrade.TabControlRegistros.TabPages.Remove(ObjAddGrade.tabPageNewSctionAcademy);
                ObjAddGrade.TabControlRegistros.TabPages.Remove(ObjAddGrade.tabPageNewEspecialidad);
                
            }
        }

        //Craga Inicial
        private void InitialCharge(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminGrades objAdmin = new DAOAdminGrades();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet dsGrados = objAdmin.LlenarCombo("tbGrados");

            //Llenar combobox tcmbGrado
            ObjAddGrade.CmbGrado.DataSource = dsGrados.Tables["tbGrados"];
            ObjAddGrade.CmbGrado.ValueMember = "IdGrado";
            ObjAddGrade.CmbGrado.DisplayMember = "Grado";

            DataSet dsEspecialidad = objAdmin.LlenarCombo("tbEspecialidades");
            //Llenar combobox cmbEspecialidad
            ObjAddGrade.cmbEspecialidad.DataSource = dsEspecialidad.Tables["tbEspecialidades"];
            ObjAddGrade.cmbEspecialidad.ValueMember = "IdEspecialidad";
            ObjAddGrade.cmbEspecialidad.DisplayMember = "Especialidad";


            DataSet dsSeccionAcademica = objAdmin.LlenarCombo("tbSeccionAcademica");
            //Llenar combobox cmbSeccionAcademica
            ObjAddGrade.CmbSeccionAcademica.DataSource = dsSeccionAcademica.Tables["tbSeccionAcademica"];
            ObjAddGrade.CmbSeccionAcademica.ValueMember = "IdSeccionAcademica";
            ObjAddGrade.CmbSeccionAcademica.DisplayMember = "SeccionAcademica";

            //Llenar el combo box de especialidad existente
            ObjAddGrade.cmbEspecialidadExistente.DataSource = dsEspecialidad.Tables["tbEspecialidades"];
            ObjAddGrade.cmbEspecialidadExistente.ValueMember = "IdEspecialidad";
            ObjAddGrade.cmbEspecialidadExistente.DisplayMember = "Especialidad";

            //Lenar el combobox de Seccion Academica Existente 
            ObjAddGrade.cmbSecionAcademicaExistente.DataSource = dsSeccionAcademica.Tables["tbSeccionAcademica"];
            ObjAddGrade.cmbSecionAcademicaExistente.ValueMember = "IdSeccionAcademica";
            ObjAddGrade.cmbSecionAcademicaExistente.DisplayMember = "SeccionAcademica";
            if (accion == 2 || accion == 3)
            {
                ObjAddGrade.cmbEspecialidad.Text = Especialidad;
                ObjAddGrade.CmbGrado.Text = Grado;
                ObjAddGrade.CmbSeccionAcademica.Text = SeccionAcademcia;
            }
        }

        //Agregar Nuevas secciones, especialidades y secciones academicasd
        private void newSeccionAcademica(object sender, EventArgs e) 
        {
            DAOAdminGrades DAOInsertSeccionAcademica = new DAOAdminGrades();

            DAOInsertSeccionAcademica.SeccionAcademica1 = ObjAddGrade.txtNuevaSeccionAcademica.Texts;
            int retorno = DAOInsertSeccionAcademica.InsertEspecialidad();
            if (retorno == 1)
            {
                MessageBox.Show("Datos ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron ingresar los datos", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newEspecialidad(object sender, EventArgs e)
        {
            //Enviar los datos de los componentes del DTO
            DAOAdminGrades DAOInsertEsepialidad = new DAOAdminGrades();

            DAOInsertEsepialidad.Especialidad1 = ObjAddGrade.txtNuevaEspecialidad.Texts;
            int retorno = DAOInsertEsepialidad.InsertEspecialidad();
            if (retorno == 1)
            {
                MessageBox.Show("Datos ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron ingresar los datos", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void newSeccion(object sender, EventArgs e) 
        {
            //Enviar los datos de los componentes del DTO
            DAOAdminGrades DAOInsertSeccion = new DAOAdminGrades();

            DAOInsertSeccion.IdGrado = (int)ObjAddGrade.CmbGrado.SelectedValue;
            DAOInsertSeccion.IdEspecialidad = (int)ObjAddGrade.cmbEspecialidad.SelectedValue;
            DAOInsertSeccion.IdSeccionAcademica = (int)ObjAddGrade.CmbSeccionAcademica.SelectedValue;
            DAOInsertSeccion.GrupoTecnico = ObjAddGrade.txtGrupoTecnico.Texts;
            int retorno = DAOInsertSeccion.InsertSecion();
            if (retorno == 1)
            {
                MessageBox.Show("Datos ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron ingresar los datos", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Actualizar
        private void UpdateEspecialidad(object sender, EventArgs e)
        {
            
            DAOAdminGrades DaoUpdateEspecialidad = new DAOAdminGrades();

            DaoUpdateEspecialidad.IdEspecialidad = int.Parse(ObjAddGrade.txtId.Text.Trim());
            DaoUpdateEspecialidad.Especialidad1 = ObjAddGrade.txtNuevaEspecialidad.Texts.Trim();

            int valorRetornado = DaoUpdateEspecialidad.UpdateEspecialidad();
            if (valorRetornado == 1)
            {
                MessageBox.Show("Los datos han sido actualizado exitosamente",
                           "Proceso completado",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            }
            else if (valorRetornado == 0) 
            {
                MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
                             "Proceso interrumpido",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }

            
        }

        private void UpdateSeccionAcademica(object sender, EventArgs e) 
        {
            DAOAdminGrades DaoUpdateSeccionAcademica = new DAOAdminGrades();

            DaoUpdateSeccionAcademica.IdSeccionAcademica = int.Parse(ObjAddGrade.txtId.Text.Trim());
            DaoUpdateSeccionAcademica.SeccionAcademica1 = ObjAddGrade.txtNuevaSeccionAcademica.Texts.Trim();

            int valorRetornado = DaoUpdateSeccionAcademica.UpdateSeccionAcademica();
            if (valorRetornado == 1)
            {
                MessageBox.Show("Los datos han sido actualizado exitosamente",
                           "Proceso completado",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            }
            else if (valorRetornado == 0)
            {
                MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
                             "Proceso interrumpido",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
        }

        private void UpdateSeccion(object sender, EventArgs e)
        {
            DAOAdminGrades DaoUpdateSeccion = new DAOAdminGrades();

            DaoUpdateSeccion.IdSeccion = int.Parse(ObjAddGrade.txtId.Text.Trim());
            DaoUpdateSeccion.GrupoTecnico = ObjAddGrade.txtGrupoTecnico.Texts.Trim();
            DaoUpdateSeccion.IdEspecialidad = (int)(ObjAddGrade.cmbEspecialidad.SelectedValue);
            DaoUpdateSeccion.IdGrado = (int)(ObjAddGrade.CmbGrado.SelectedValue);
            DaoUpdateSeccion.IdSeccionAcademica = (int)(ObjAddGrade.CmbSeccionAcademica.SelectedValue);

            int valorRetornado = DaoUpdateSeccion.UpdateSeccion();
            if (valorRetornado == 1)
            {
                MessageBox.Show("Los datos han sido actualizado exitosamente",
                           "Proceso completado",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            }
            else if (valorRetornado == 0)
            {
                MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
                             "Proceso interrumpido",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
        }

    }
}
