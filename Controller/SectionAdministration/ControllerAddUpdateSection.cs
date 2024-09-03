using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using HealthPortal.Model.DAO;
using HealthPortal.View.SectionAdministration;

namespace HealthPortal.Controller.SectionAdministration
{
    public class ControllerAddUpdateSection
    {
        //        FrmAddUpdateSection frmAddUpdateSection;
        //        int action, tabPage;
        //        private string specialty, academicSection, grade;
        //        public ControllerAddUpdateSection(FrmAddUpdateSection view, int action, int tabPage)
        //        {
        //            this.action = action;
        //            this.tabPage = tabPage;
        //            frmAddUpdateSection = view;
        //            frmAddUpdateSection.Load += new EventHandler(InitialCharge);
        //            VerifyTab();
        //            VerifyAction();
        //            frmAddUpdateSection.btnAgregarEspecialidad.Click += new EventHandler(NewSpecialty);
        //            frmAddUpdateSection.BtnAgregarSeccion.Click += new EventHandler(NewSection);
        //            frmAddUpdateSection.btnAgregarSeccionAcademica.Click += new EventHandler(NewAcademicSection);
        //        }
        //        private void VerifyTab()
        //        {
        //            if (tabPage == 0)
        //            {

        //                frmAddUpdateSection.TabControlRegistros.SelectedIndex = 0;
        //            }
        //            else if (tabPage == 1)
        //            {
        //                frmAddUpdateSection.TabControlRegistros.TabPages.Remove(frmAddUpdateSection.tabPageNewSection);
        //                frmAddUpdateSection.TabControlRegistros.TabPages.Remove(frmAddUpdateSection.tabPageNewspecialty);
        //                frmAddUpdateSection.TabControlRegistros.SelectedIndex = 1;
        //            }
        //            else if (tabPage == 2)
        //            {
        //                frmAddUpdateSection.TabControlRegistros.TabPages.Remove(frmAddUpdateSection.tabPageNewSctionAcademy);
        //                frmAddUpdateSection.TabControlRegistros.TabPages.Remove(frmAddUpdateSection.tabPageNewSection);
        //                frmAddUpdateSection.TabControlRegistros.SelectedIndex = 2;
        //            }
        //        }
        //        public ControllerAddUpdateSection(FrmAddUpdateSection view, int action, int Idspecialty, string specialty)
        //        {
        //            this.action = action;
        //            this.specialty = specialty;
        //            frmAddUpdateSection = view;
        //            frmAddUpdateSection.Load += new EventHandler(InitialCharge);
        //            frmAddUpdateSection.TabControlRegistros.SelectedIndex = 2;
        //            VerifyAction();
        //            ChargueValuespecialty(Idspecialty);
        //            frmAddUpdateSection.BtnActuzalizarspecialty.Click += new EventHandler(Updatespecialty);
        //        }
        //        public ControllerAddUpdateSection(FrmAddUpdateSection view, int action, int IdSeccion, string GrupoTecnico, string specialty, string grade, string SeccionAcademica)
        //        {
        //            this.action = action;
        //            frmAddUpdateSection = view;
        //            this.grade = grade;
        //            this.academicSection = SeccionAcademica;
        //            this.specialty = specialty;
        //            frmAddUpdateSection.Load += new EventHandler(InitialCharge);
        //            VerifyAction();
        //            ChargueValueSeccion(IdSeccion, GrupoTecnico);
        //            frmAddUpdateSection.BtnActualizarSeccion.Click += new EventHandler(UpdateSeccion);
        //        }
        //        public ControllerAddUpdateSection(FrmAddUpdateSection view, int action, int IdSeccionAcademica, string nombreSeccionAcademica, int num)
        //        {
        //            this.action = action;
        //            this.academicSection = nombreSeccionAcademica;
        //            frmAddUpdateSection = view;
        //            frmAddUpdateSection.Load += new EventHandler(InitialCharge);
        //            frmAddUpdateSection.TabControlRegistros.SelectedIndex = 1;
        //            VerifyAction();
        //            ChargueValueSeccionAcademica(IdSeccionAcademica);
        //            frmAddUpdateSection.btnActualizarSeccionAcademica.Click += new EventHandler(UpdateSeccionAcademica);
        //        }
        //        private void ChargueValuespecialty(int Idspecialty)
        //        {
        //            frmAddUpdateSection.txtId.Text = Idspecialty.ToString();
        //            frmAddUpdateSection.TabControlRegistros.TabPages.Remove(frmAddUpdateSection.tabPageNewSctionAcademy);
        //            frmAddUpdateSection.TabControlRegistros.TabPages.Remove(frmAddUpdateSection.tabPageNewSection);
        //        }
        //        private void ChargueValueSeccion(int IdSeccion, string GrupoTecnico)
        //        {
        //            frmAddUpdateSection.txtId.Text = IdSeccion.ToString();
        //            frmAddUpdateSection.txtGrupoTecnico.Texts = GrupoTecnico.ToString();
        //            frmAddUpdateSection.TabControlRegistros.TabPages.Remove(frmAddUpdateSection.tabPageNewSctionAcademy);
        //            frmAddUpdateSection.TabControlRegistros.TabPages.Remove(frmAddUpdateSection.tabPageNewspecialty);
        //        }
        //        private void ChargueValueSeccionAcademica(int IdSeccion)
        //        {
        //            frmAddUpdateSection.txtId.Text = IdSeccion.ToString();
        //            frmAddUpdateSection.TabControlRegistros.TabPages.Remove(frmAddUpdateSection.tabPageNewSection);
        //            frmAddUpdateSection.TabControlRegistros.TabPages.Remove(frmAddUpdateSection.tabPageNewspecialty);
        //        }

        //        //Verificar action
        //        public void VerifyAction()
        //        {
        //            if (action == 1)
        //            {
        //                frmAddUpdateSection.btnAgregarspecialty.Enabled = true;
        //                frmAddUpdateSection.BtnActuzalizarspecialty.Enabled = false;
        //                frmAddUpdateSection.btnAgregarSeccionAcademica.Enabled = true;
        //                frmAddUpdateSection.btnActualizarSeccionAcademica.Enabled = false;
        //                frmAddUpdateSection.cmbspecialtyExistente.Enabled = false;
        //                frmAddUpdateSection.BtnAgregarSeccion.Enabled = true;
        //                frmAddUpdateSection.BtnActualizarSeccion.Enabled = false;

        //            }
        //            else if (action == 2)
        //            {
        //                frmAddUpdateSection.lblRegistrarspecialty.Text = "Actualizar specialty";
        //                frmAddUpdateSection.lblNuevaspecialty.Text = "Nuevo Nombre de la specialty";
        //                frmAddUpdateSection.btnAgregarspecialty.Enabled = false;
        //                frmAddUpdateSection.BtnActuzalizarspecialty.Enabled = true;
        //                frmAddUpdateSection.cmbspecialtyExistente.Enabled = true;
        //                frmAddUpdateSection.lblRegistrarSeccionAcademica.Text = "Actualizar Sección Académica";
        //                frmAddUpdateSection.lblSeccionAcademica.Text = "Nuevo nombre de la Sección";
        //                frmAddUpdateSection.btnAgregarSeccionAcademica.Enabled = false;
        //                frmAddUpdateSection.btnActualizarSeccionAcademica.Enabled = true;
        //                frmAddUpdateSection.cmbSecionAcademicaExistente.Enabled = true;
        //                frmAddUpdateSection.lblRegistrarSeccion.Text = "Actualizar Sección";
        //                frmAddUpdateSection.BtnAgregarSeccion.Enabled = false;
        //                frmAddUpdateSection.BtnActualizarSeccion.Enabled = true;
        //            }
        //            else if (action == 3)
        //            {
        //                //Seccion
        //                frmAddUpdateSection.lblRegistrarSeccion.Text = "Ficha de la Sección";
        //                frmAddUpdateSection.Cmbgrade.Enabled = false;
        //                frmAddUpdateSection.cmbspecialty.Enabled = false;
        //                frmAddUpdateSection.CmbSeccionAcademica.Enabled = false;
        //                frmAddUpdateSection.txtGrupoTecnico.Enabled = false;
        //                frmAddUpdateSection.Cmbgrade.BackColor = Color.WhiteSmoke;
        //                frmAddUpdateSection.cmbspecialty.BackColor = Color.WhiteSmoke;
        //                frmAddUpdateSection.CmbSeccionAcademica.BackColor = Color.WhiteSmoke;
        //                frmAddUpdateSection.txtGrupoTecnico.BackColor = Color.WhiteSmoke;
        //                //Quita los tabsPages para que no se muestren
        //                frmAddUpdateSection.TabControlRegistros.TabPages.Remove(frmAddUpdateSection.tabPageNewSctionAcademy);
        //                frmAddUpdateSection.TabControlRegistros.TabPages.Remove(frmAddUpdateSection.tabPageNewspecialty);
        //            }
        //        }
        //        private void InitialCharge(object sender, EventArgs e)
        //        {
        //            //Objeto de la clase DAOAdminUsuarios
        //            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();
        //            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
        //            DataSet dsgrades = daoSectionAdministration.FillCombo("tbgrades", "Secciones");

        //            //Llenar combobox tcmbgrade
        //            frmAddUpdateSection.Cmbgrade.DataSource = dsgrades.Tables["tbgrades"];
        //            frmAddUpdateSection.Cmbgrade.ValueMember = "Idgrade";
        //            frmAddUpdateSection.Cmbgrade.DisplayMember = "grade";

        //            DataSet dsspecialty = daoSectionAdministration.FillCombo("tbspecialtyes", "Secciones");
        //            //Llenar combobox cmbspecialty
        //            frmAddUpdateSection.cmbspecialty.DataSource = dsspecialty.Tables["tbspecialtyes"];
        //            frmAddUpdateSection.cmbspecialty.ValueMember = "Idspecialty";
        //            frmAddUpdateSection.cmbspecialty.DisplayMember = "specialty";


        //            DataSet dsSeccionAcademica = daoSectionAdministration.FillCombo("tbSeccionAcademica", "Secciones");
        //            //Llenar combobox cmbSeccionAcademica
        //            frmAddUpdateSection.CmbSeccionAcademica.DataSource = dsSeccionAcademica.Tables["tbSeccionAcademica"];
        //            frmAddUpdateSection.CmbSeccionAcademica.ValueMember = "IdSeccionAcademica";
        //            frmAddUpdateSection.CmbSeccionAcademica.DisplayMember = "SeccionAcademica";

        //            //Llenar el combo box de especialidad existente
        //            frmAddUpdateSection.cmbspecialtyExistente.DataSource = dsspecialty.Tables["tbspecialtyes"];
        //            frmAddUpdateSection.cmbspecialtyExistente.ValueMember = "Idspecialty";
        //            frmAddUpdateSection.cmbspecialtyExistente.DisplayMember = "specialty";

        //            //Lenar el combobox de Seccion Academica Existente 
        //            frmAddUpdateSection.cmbSecionAcademicaExistente.DataSource = dsSeccionAcademica.Tables["tbSeccionAcademica"];
        //            frmAddUpdateSection.cmbSecionAcademicaExistente.ValueMember = "IdSeccionAcademica";
        //            frmAddUpdateSection.cmbSecionAcademicaExistente.DisplayMember = "SeccionAcademica";
        //            if (action == 2 || action == 3)
        //            {
        //                frmAddUpdateSection.cmbspecialty.Text = specialty;
        //                frmAddUpdateSection.Cmbgrade.Text = grade;
        //                frmAddUpdateSection.CmbSeccionAcademica.Text = academicSection;
        //            }
        //        }

        //        //Agregar Nuevas secciones, especialidades y secciones academicasd
        //        private void NewAcademicSection(object sender, EventArgs e)
        //        {
        //            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();

        //            daoSectionAdministration.SeccionAcademica = frmAddUpdateSection.txtNuevaSeccionAcademica.Texts;
        //            int retorno = daoSectionAdministration.AddSpecialty();
        //            if (retorno == 1)
        //            {
        //                MessageBox.Show("Datos ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else
        //            {
        //                MessageBox.Show("No se pudieron ingresar los datos", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }

        //        private void NewSpecialty(object sender, EventArgs e)
        //        {
        //            //Enviar los datos de los componentes del DTO
        //            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();

        //            daoSectionAdministration.specialty = frmAddUpdateSection.txtNuevaspecialty.Texts;
        //            int retorno = daoSectionAdministration.AddSpecialty();
        //            if (retorno == 1)
        //            {
        //                MessageBox.Show("Datos ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else
        //            {
        //                MessageBox.Show("No se pudieron ingresar los datos", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }

        //        }

        //        private void NewSection(object sender, EventArgs e)
        //        {
        //            //Enviar los datos de los componentes del DTO
        //            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();

        //            daoSectionAdministration.Idgrade = (int)frmAddUpdateSection.Cmbgrade.SelectedValue;
        //            daoSectionAdministration.Idspecialty = (int)frmAddUpdateSection.cmbspecialty.SelectedValue;
        //            daoSectionAdministration.IdSeccionAcademica = (int)frmAddUpdateSection.CmbSeccionAcademica.SelectedValue;
        //            daoSectionAdministration.GrupoTecnico = frmAddUpdateSection.txtGrupoTecnico.Texts;
        //            int retorno = daoSectionAdministration.AddSection();
        //            if (retorno == 1)
        //            {
        //                MessageBox.Show("Datos ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else
        //            {
        //                MessageBox.Show("No se pudieron ingresar los datos", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }

        //        //Actualizar
        //        private void Updatespecialty(object sender, EventArgs e)
        //        {

        //            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();

        //            daoSectionAdministration.Idspecialty = int.Parse(frmAddUpdateSection.txtId.Text.Trim());
        //            daoSectionAdministration.specialty = frmAddUpdateSection.txtNuevaspecialty.Texts.Trim();

        //            int valorRetornado = daoSectionAdministration.UpdateSpecialty();
        //            if (valorRetornado == 1)
        //            {
        //                MessageBox.Show("Los datos han sido actualizado exitosamente",
        //                           "Proceso completado",
        //                           MessageBoxButtons.OK,
        //                           MessageBoxIcon.Information);
        //            }
        //            else if (valorRetornado == 0)
        //            {
        //                MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
        //                             "Proceso interrumpido",
        //                             MessageBoxButtons.OK,
        //                             MessageBoxIcon.Error);
        //            }


        //        }

        //        private void UpdateSeccionAcademica(object sender, EventArgs e)
        //        {
        //            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();

        //            daoSectionAdministration.IdSeccionAcademica = int.Parse(frmAddUpdateSection.txtId.Text.Trim());
        //            daoSectionAdministration.SeccionAcademica = frmAddUpdateSection.txtNuevaSeccionAcademica.Texts.Trim();

        //            int valorRetornado = daoSectionAdministration.UpdateAcademicSection();
        //            if (valorRetornado == 1)
        //            {
        //                MessageBox.Show("Los datos han sido actualizado exitosamente",
        //                           "Proceso completado",
        //                           MessageBoxButtons.OK,
        //                           MessageBoxIcon.Information);
        //            }
        //            else if (valorRetornado == 0)
        //            {
        //                MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
        //                             "Proceso interrumpido",
        //                             MessageBoxButtons.OK,
        //                             MessageBoxIcon.Error);
        //            }
        //        }

        //        private void UpdateSeccion(object sender, EventArgs e)
        //        {
        //            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();

        //            daoSectionAdministration.IdSeccion = int.Parse(frmAddUpdateSection.txtId.Text.Trim());
        //            daoSectionAdministration.GrupoTecnico = frmAddUpdateSection.txtGrupoTecnico.Texts.Trim();
        //            daoSectionAdministration.Idspecialty = (int)(frmAddUpdateSection.cmbspecialty.SelectedValue);
        //            daoSectionAdministration.Idgrade = (int)(frmAddUpdateSection.Cmbgrade.SelectedValue);
        //            daoSectionAdministration.IdSeccionAcademica = (int)(frmAddUpdateSection.CmbSeccionAcademica.SelectedValue);

        //            int valorRetornado = daoSectionAdministration.UpdateSection();
        //            if (valorRetornado == 1)
        //            {
        //                MessageBox.Show("Los datos han sido actualizado exitosamente",
        //                           "Proceso completado",
        //                           MessageBoxButtons.OK,
        //                           MessageBoxIcon.Information);
        //            }
        //            else if (valorRetornado == 0)
        //            {
        //                MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
        //                             "Proceso interrumpido",
        //                             MessageBoxButtons.OK,
        //                             MessageBoxIcon.Error);
        //            }
        //        }

    }
}