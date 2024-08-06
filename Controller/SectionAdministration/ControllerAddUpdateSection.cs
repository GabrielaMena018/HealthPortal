using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using RegistroPacientes.Model.DAO;
using RegistroPacientes.View.SectionAdministration;

namespace RegistroPacientes.Controller.SectionAdministration
{
    public class ControllerAddUpdateSection
    {
        FrmAddUpdateSection objAddUpdateSection;
        int action, tabPage;
        private string Especialidad, SeccionAcademcia, Grado;
        public ControllerAddUpdateSection(FrmAddUpdateSection view, int action, int tabPage)
        {
            this.action = action;
            this.tabPage = tabPage;
            objAddUpdateSection = view;
            objAddUpdateSection.Load += new EventHandler(InitialCharge);
            VerifyTab();
            VerifyAction();
            objAddUpdateSection.btnAgregarEspecialidad.Click += new EventHandler(NewSpecialty);
            objAddUpdateSection.BtnAgregarSeccion.Click += new EventHandler(NewSection);
            objAddUpdateSection.btnAgregarSeccionAcademica.Click += new EventHandler(NewAcademicSection);
        }
        private void VerifyTab()
        {
            if (tabPage == 0)
            {

                objAddUpdateSection.TabControlRegistros.SelectedIndex = 0;
            }
            else if (tabPage == 1)
            {
                objAddUpdateSection.TabControlRegistros.TabPages.Remove(objAddUpdateSection.tabPageNewSection);
                objAddUpdateSection.TabControlRegistros.TabPages.Remove(objAddUpdateSection.tabPageNewEspecialidad);
                objAddUpdateSection.TabControlRegistros.SelectedIndex = 1;
            }
            else if (tabPage == 2)
            {
                objAddUpdateSection.TabControlRegistros.TabPages.Remove(objAddUpdateSection.tabPageNewSctionAcademy);
                objAddUpdateSection.TabControlRegistros.TabPages.Remove(objAddUpdateSection.tabPageNewSection);
                objAddUpdateSection.TabControlRegistros.SelectedIndex = 2;
            }
        }
        public ControllerAddUpdateSection(FrmAddUpdateSection view, int action, int IdEspecialidad, string Especialidad)
        {
            this.action = action;
            this.Especialidad = Especialidad;
            objAddUpdateSection = view;
            objAddUpdateSection.Load += new EventHandler(InitialCharge);
            objAddUpdateSection.TabControlRegistros.SelectedIndex = 2;
            VerifyAction();
            ChargueValueEspecialidad(IdEspecialidad);
            objAddUpdateSection.BtnActuzalizarEspecialidad.Click += new EventHandler(UpdateEspecialidad);
        }
        public ControllerAddUpdateSection(FrmAddUpdateSection view, int action, int IdSeccion, string GrupoTecnico, string Especialidad, string Grado, string SeccionAcademica)
        {
            this.action = action;
            objAddUpdateSection = view;
            this.Grado = Grado;
            this.SeccionAcademcia = SeccionAcademica;
            this.Especialidad = Especialidad;
            objAddUpdateSection.Load += new EventHandler(InitialCharge);
            VerifyAction();
            ChargueValueSeccion(IdSeccion, GrupoTecnico);
            objAddUpdateSection.BtnActualizarSeccion.Click += new EventHandler(UpdateSeccion);
        }
        public ControllerAddUpdateSection(FrmAddUpdateSection view, int action, int IdSeccionAcademica, string nombreSeccionAcademica, int num)
        {
            this.action = action;
            this.SeccionAcademcia = nombreSeccionAcademica;
            objAddUpdateSection = view;
            objAddUpdateSection.Load += new EventHandler(InitialCharge);
            objAddUpdateSection.TabControlRegistros.SelectedIndex = 1;
            VerifyAction();
            ChargueValueSeccionAcademica(IdSeccionAcademica);
            objAddUpdateSection.btnActualizarSeccionAcademica.Click += new EventHandler(UpdateSeccionAcademica);
        }
        private void ChargueValueEspecialidad(int IdEspecialidad)
        {
            objAddUpdateSection.txtId.Text = IdEspecialidad.ToString();
            objAddUpdateSection.TabControlRegistros.TabPages.Remove(objAddUpdateSection.tabPageNewSctionAcademy);
            objAddUpdateSection.TabControlRegistros.TabPages.Remove(objAddUpdateSection.tabPageNewSection);
        }
        private void ChargueValueSeccion(int IdSeccion, string GrupoTecnico)
        {
            objAddUpdateSection.txtId.Text = IdSeccion.ToString();
            objAddUpdateSection.txtGrupoTecnico.Texts = GrupoTecnico.ToString();
            objAddUpdateSection.TabControlRegistros.TabPages.Remove(objAddUpdateSection.tabPageNewSctionAcademy);
            objAddUpdateSection.TabControlRegistros.TabPages.Remove(objAddUpdateSection.tabPageNewEspecialidad);
        }
        private void ChargueValueSeccionAcademica(int IdSeccion)
        {
            objAddUpdateSection.txtId.Text = IdSeccion.ToString();
            objAddUpdateSection.TabControlRegistros.TabPages.Remove(objAddUpdateSection.tabPageNewSection);
            objAddUpdateSection.TabControlRegistros.TabPages.Remove(objAddUpdateSection.tabPageNewEspecialidad);
        }

        //Verificar action
        public void VerifyAction()
        {
            if (action == 1)
            {
                objAddUpdateSection.btnAgregarEspecialidad.Enabled = true;
                objAddUpdateSection.BtnActuzalizarEspecialidad.Enabled = false;
                objAddUpdateSection.btnAgregarSeccionAcademica.Enabled = true;
                objAddUpdateSection.btnActualizarSeccionAcademica.Enabled = false;
                objAddUpdateSection.cmbEspecialidadExistente.Enabled = false;
                objAddUpdateSection.BtnAgregarSeccion.Enabled = true;
                objAddUpdateSection.BtnActualizarSeccion.Enabled = false;

            }
            else if (action == 2)
            {
                objAddUpdateSection.lblRegistrarEspecialidad.Text = "Actualizar Especialidad";
                objAddUpdateSection.lblNuevaEspecialidad.Text = "Nuevo Nombre de la Especialidad";
                objAddUpdateSection.btnAgregarEspecialidad.Enabled = false;
                objAddUpdateSection.BtnActuzalizarEspecialidad.Enabled = true;
                objAddUpdateSection.cmbEspecialidadExistente.Enabled = true;
                objAddUpdateSection.lblRegistrarSeccionAcademica.Text = "Actualizar Sección Académica";
                objAddUpdateSection.lblSeccionAcademica.Text = "Nuevo nombre de la Sección";
                objAddUpdateSection.btnAgregarSeccionAcademica.Enabled = false;
                objAddUpdateSection.btnActualizarSeccionAcademica.Enabled = true;
                objAddUpdateSection.cmbSecionAcademicaExistente.Enabled = true;
                objAddUpdateSection.lblRegistrarSeccion.Text = "Actualizar Sección";
                objAddUpdateSection.BtnAgregarSeccion.Enabled = false;
                objAddUpdateSection.BtnActualizarSeccion.Enabled = true;
            }
            else if (action == 3)
            {
                //Seccion
                objAddUpdateSection.lblRegistrarSeccion.Text = "Ficha de la Sección";
                objAddUpdateSection.CmbGrado.Enabled = false;
                objAddUpdateSection.cmbEspecialidad.Enabled = false;
                objAddUpdateSection.CmbSeccionAcademica.Enabled = false;
                objAddUpdateSection.txtGrupoTecnico.Enabled = false;
                objAddUpdateSection.CmbGrado.BackColor = Color.WhiteSmoke;
                objAddUpdateSection.cmbEspecialidad.BackColor = Color.WhiteSmoke;
                objAddUpdateSection.CmbSeccionAcademica.BackColor = Color.WhiteSmoke;
                objAddUpdateSection.txtGrupoTecnico.BackColor = Color.WhiteSmoke;
                //Quita los tabsPages para que no se muestren
                objAddUpdateSection.TabControlRegistros.TabPages.Remove(objAddUpdateSection.tabPageNewSctionAcademy);
                objAddUpdateSection.TabControlRegistros.TabPages.Remove(objAddUpdateSection.tabPageNewEspecialidad);
            }
        }
        private void InitialCharge(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet dsGrados = daoSectionAdministration.FillCombo("tbGrados", "Secciones");

            //Llenar combobox tcmbGrado
            objAddUpdateSection.CmbGrado.DataSource = dsGrados.Tables["tbGrados"];
            objAddUpdateSection.CmbGrado.ValueMember = "IdGrado";
            objAddUpdateSection.CmbGrado.DisplayMember = "Grado";

            DataSet dsEspecialidad = daoSectionAdministration.FillCombo("tbEspecialidades", "Secciones");
            //Llenar combobox cmbEspecialidad
            objAddUpdateSection.cmbEspecialidad.DataSource = dsEspecialidad.Tables["tbEspecialidades"];
            objAddUpdateSection.cmbEspecialidad.ValueMember = "IdEspecialidad";
            objAddUpdateSection.cmbEspecialidad.DisplayMember = "Especialidad";


            DataSet dsSeccionAcademica = daoSectionAdministration.FillCombo("tbSeccionAcademica", "Secciones");
            //Llenar combobox cmbSeccionAcademica
            objAddUpdateSection.CmbSeccionAcademica.DataSource = dsSeccionAcademica.Tables["tbSeccionAcademica"];
            objAddUpdateSection.CmbSeccionAcademica.ValueMember = "IdSeccionAcademica";
            objAddUpdateSection.CmbSeccionAcademica.DisplayMember = "SeccionAcademica";

            //Llenar el combo box de especialidad existente
            objAddUpdateSection.cmbEspecialidadExistente.DataSource = dsEspecialidad.Tables["tbEspecialidades"];
            objAddUpdateSection.cmbEspecialidadExistente.ValueMember = "IdEspecialidad";
            objAddUpdateSection.cmbEspecialidadExistente.DisplayMember = "Especialidad";

            //Lenar el combobox de Seccion Academica Existente 
            objAddUpdateSection.cmbSecionAcademicaExistente.DataSource = dsSeccionAcademica.Tables["tbSeccionAcademica"];
            objAddUpdateSection.cmbSecionAcademicaExistente.ValueMember = "IdSeccionAcademica";
            objAddUpdateSection.cmbSecionAcademicaExistente.DisplayMember = "SeccionAcademica";
            if (action == 2 || action == 3)
            {
                objAddUpdateSection.cmbEspecialidad.Text = Especialidad;
                objAddUpdateSection.CmbGrado.Text = Grado;
                objAddUpdateSection.CmbSeccionAcademica.Text = SeccionAcademcia;
            }
        }

        //Agregar Nuevas secciones, especialidades y secciones academicasd
        private void NewAcademicSection(object sender, EventArgs e)
        {
            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();

            daoSectionAdministration.SeccionAcademica = objAddUpdateSection.txtNuevaSeccionAcademica.Texts;
            int retorno = daoSectionAdministration.AddSpecialty();
            if (retorno == 1)
            {
                MessageBox.Show("Datos ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron ingresar los datos", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewSpecialty(object sender, EventArgs e)
        {
            //Enviar los datos de los componentes del DTO
            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();

            daoSectionAdministration.Especialidad = objAddUpdateSection.txtNuevaEspecialidad.Texts;
            int retorno = daoSectionAdministration.AddSpecialty();
            if (retorno == 1)
            {
                MessageBox.Show("Datos ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron ingresar los datos", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NewSection(object sender, EventArgs e)
        {
            //Enviar los datos de los componentes del DTO
            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();

            daoSectionAdministration.IdGrado = (int)objAddUpdateSection.CmbGrado.SelectedValue;
            daoSectionAdministration.IdEspecialidad = (int)objAddUpdateSection.cmbEspecialidad.SelectedValue;
            daoSectionAdministration.IdSeccionAcademica = (int)objAddUpdateSection.CmbSeccionAcademica.SelectedValue;
            daoSectionAdministration.GrupoTecnico = objAddUpdateSection.txtGrupoTecnico.Texts;
            int retorno = daoSectionAdministration.AddSection();
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

            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();

            daoSectionAdministration.IdEspecialidad = int.Parse(objAddUpdateSection.txtId.Text.Trim());
            daoSectionAdministration.Especialidad = objAddUpdateSection.txtNuevaEspecialidad.Texts.Trim();

            int valorRetornado = daoSectionAdministration.UpdateSpecialty();
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
            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();

            daoSectionAdministration.IdSeccionAcademica = int.Parse(objAddUpdateSection.txtId.Text.Trim());
            daoSectionAdministration.SeccionAcademica = objAddUpdateSection.txtNuevaSeccionAcademica.Texts.Trim();

            int valorRetornado = daoSectionAdministration.UpdateAcademicSection();
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
            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();

            daoSectionAdministration.IdSeccion = int.Parse(objAddUpdateSection.txtId.Text.Trim());
            daoSectionAdministration.GrupoTecnico = objAddUpdateSection.txtGrupoTecnico.Texts.Trim();
            daoSectionAdministration.IdEspecialidad = (int)(objAddUpdateSection.cmbEspecialidad.SelectedValue);
            daoSectionAdministration.IdGrado = (int)(objAddUpdateSection.CmbGrado.SelectedValue);
            daoSectionAdministration.IdSeccionAcademica = (int)(objAddUpdateSection.CmbSeccionAcademica.SelectedValue);

            int valorRetornado = daoSectionAdministration.UpdateSection();
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