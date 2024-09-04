using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CustomPanel;
using HealthPortal.Model.DAO;
using HealthPortal.View.SectionAdministration;
using HealthPortal.View.UserAdministration;

namespace HealthPortal.Controller.SectionAdministration
{
    internal class ControllerSectionAdministration
    {
        FrmSectionAdministration frmSectionAdministration;
        int expanedFormWidth = 1370;
        int collapsedFormWidth = 1240;
        int buttonYCoordinate = 26;
        public ControllerSectionAdministration(FrmSectionAdministration view)
        {
            frmSectionAdministration = view;
            frmSectionAdministration.Load += new EventHandler(InitialCharge);
            frmSectionAdministration.Load += new EventHandler(ResizeControls);
            frmSectionAdministration.Resize += new EventHandler(ResizeControls);
            frmSectionAdministration.cmsAddGrade.Click += new EventHandler(AddGrade);
            //frmSectionAdministrationGrades.btnNewGrade.Click += new EventHandler(NewGrade);
            //frmSectionAdministrationGrades.toolStripActualizarEspecialidad.Click += new EventHandler(updateEspecialidad);
            //frmSectionAdministrationGrades.toolStripActualizarSeccionAcademica.Click += new EventHandler(updateSeccionAcademica);
            //frmSectionAdministrationGrades.toolStripDeleteSeccionAcademica.Click += new EventHandler(DeleteSeccionAcademica);
            //frmSectionAdministrationGrades.toolStripEliminarEspecialidad.Click += new EventHandler(DeleteEspecialidad);
            //frmSectionAdministrationGrades.cmsEliminarSeccion.Click += new EventHandler(DeleteSeccion);
            //frmSectionAdministrationGrades.cmsActualizarSeccion.Click += new EventHandler(updateSeccion);
            //frmSectionAdministrationGrades.btnNuevaEspecialidad.Click += new EventHandler(NewEspecialidad);
            //frmSectionAdministrationGrades.BtnNuevaSecciónAcademica.Click += new EventHandler(NewSeccionAcademica);
            frmSectionAdministration.tabAcademicLevel.SelectedIndexChanged += new EventHandler(TabControlSelectedIndexChanged);
            //frmSectionAdministrationGrades.cmsVerSeccion.Click += new EventHandler(VerSeccion);
        }
        private void TabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (frmSectionAdministration.tabAcademicLevel.SelectedIndex)
            {
                case 0:
                    RefreshSectionDataGridView();
                    break;
                case 1:
                    RefreshSpecialtyDataGridView();
                    break;
                case 2:
                    frmSectionAdministration.dgvAcademicLevelDisplay.ContextMenuStrip = frmSectionAdministration.cmsAcademicSection;
                    RefreshAcademicSectionDataGridView();
                    break;
                case 3:
                    frmSectionAdministration.dgvAcademicLevelDisplay.ContextMenuStrip = frmSectionAdministration.cmsGrade;
                    RefreshGradeDataGridView();
                    break;
                default:
                    break;
            }
        }
        private void ResizeControls(object sender, EventArgs e)
        {
            if (frmSectionAdministration.Width == expanedFormWidth)
            {
                frmSectionAdministration.panelCustom2.Width = 1288;
            }
            else if (frmSectionAdministration.Width == collapsedFormWidth)
            {
                frmSectionAdministration.panelCustom2.Width = 1166;
            }
            frmSectionAdministration.dgvAcademicLevelDisplay.Dock = DockStyle.Fill;
            SetDataGridViewColumnSize();
            frmSectionAdministration.Refresh();
        }
        private void InitialCharge(object sender, EventArgs e)
        {
            RefreshSectionDataGridView();
            // Llenar combobox
            // Objeto de la clase DAOAdminUsuarios
            DAOSectionAdministration dao = new DAOSectionAdministration();
            //Declarando nuevo DataSet para que obtenga los datos del metodo FillCombo
            //DataSet dsGrados = dao.FillCombo("tbGrados", "Secciones");

            ////Llenar combobox tcmbGrado
            //frmSectionAdministration.cmbGrado.DataSource = dsGrados.Tables["tbGrados"];
            //frmSectionAdministration.cmbGrado.ValueMember = "IdGrado";
            //frmSectionAdministration.cmbGrado.DisplayMember = "Grado";

            //DataSet dsEspecialidad = daoSectionAdministration.FillCombo("tbEspecialidades", "Secciones");
            ////Llenar combobox cmbEspecialidad
            //frmSectionAdministration.cmbEspecialidad.DataSource = dsEspecialidad.Tables["tbEspecialidades"];
            //frmSectionAdministration.cmbEspecialidad.ValueMember = "IdEspecialidad";
            //frmSectionAdministration.cmbEspecialidad.DisplayMember = "Especialidad";

            //DataSet dsSeccionAcademica = daoSectionAdministration.FillCombo("tbSeccionAcademica", "Secciones");
            ////Llenar combobox cmbSeccionAcademica
            //frmSectionAdministration.cmbSeccionAcademica.DataSource = dsSeccionAcademica.Tables["tbSeccionAcademica"];
            //frmSectionAdministration.cmbSeccionAcademica.ValueMember = "IdSeccionAcademica";
            //frmSectionAdministration.cmbSeccionAcademica.DisplayMember = "SeccionAcademica";
        }

        //        //Abrir el formulario FrmAddGrade con el numero de acción 1
        //        public void NewGrade(object sender, EventArgs e)
        //        {
        //            FrmAddUpdateSection openForm = new FrmAddUpdateSection(1, 0);
        //            openForm.ShowDialog();
        //            RefrescarDataAdminGrade();

        //        }
        private void AddGrade(object sender, EventArgs e)
        {
            MessageBox.Show("hola");
            FrmAddUpdateSection frmAddUpdateSection = new FrmAddUpdateSection(1, 3);
            frmAddUpdateSection.Show();
            RefreshGradeDataGridView();
        }

        //        public void NewEspecialidad(object sender, EventArgs e)
        //        {
        //            FrmAddUpdateSection openForm = new FrmAddUpdateSection(1, 2);
        //            openForm.ShowDialog();
        //            RefreshSpecialtyDataGridView();
        //        }

        //        public void NewSeccionAcademica(object sender, EventArgs e)
        //        {
        //            FrmAddUpdateSection openForm = new FrmAddUpdateSection(1, 1);
        //            openForm.ShowDialog();
        //            RefreshAcademicSectionDataGridView();
        //        }

        //        //Actualizar
        //        public void updateEspecialidad(object sender, EventArgs e)
        //        {
        //            int pos = daoSectionAdministrationGrades.dataGridEspecialidades.CurrentRow.Index;
        //            int IdGrade;
        //            string nombreEspecialidad;
        //            IdGrade = int.Parse(daoSectionAdministrationGrades.dataGridEspecialidades[0, pos].Value.ToString());
        //            nombreEspecialidad = daoSectionAdministrationGrades.dataGridEspecialidades[1, pos].Value.ToString();
        //            FrmAddUpdateSection openFrom = new FrmAddUpdateSection(2, IdGrade, nombreEspecialidad);
        //            openFrom.ShowDialog();
        //            RefreshSpecialtyDataGridView();
        //        }

        //        public void updateSeccion(object sender, EventArgs e)
        //        {
        //            int pos = daoSectionAdministrationGrades.GridAdminGrade.CurrentRow.Index;
        //            int IdSecion;
        //            string GrupoTecnico, Especialidad, Grado, SeccionAcademica;
        //            IdSecion = int.Parse(daoSectionAdministrationGrades.GridAdminGrade[0, pos].Value.ToString());
        //            GrupoTecnico = daoSectionAdministrationGrades.GridAdminGrade[1, pos].Value.ToString();
        //            Grado = daoSectionAdministrationGrades.GridAdminGrade[2, pos].Value.ToString();
        //            SeccionAcademica = daoSectionAdministrationGrades.GridAdminGrade[3, pos].Value.ToString();
        //            Especialidad = daoSectionAdministrationGrades.GridAdminGrade[4, pos].Value.ToString();
        //            FrmAddUpdateSection openFrom = new FrmAddUpdateSection(2, IdSecion, GrupoTecnico, Especialidad, Grado, SeccionAcademica);
        //            openFrom.ShowDialog();
        //            RefrescarDataAdminGrade();
        //        }

        //        public void updateSeccionAcademica(object sender, EventArgs e)
        //        {
        //            int pos = daoSectionAdministrationGrades.dataGridSeccionAcademica.CurrentRow.Index;
        //            int IdSeccionAcademica;
        //            string nombreSeccionAcademica;
        //            IdSeccionAcademica = int.Parse(daoSectionAdministrationGrades.dataGridSeccionAcademica[0, pos].Value.ToString());
        //            nombreSeccionAcademica = daoSectionAdministrationGrades.dataGridSeccionAcademica[1, pos].Value.ToString();
        //            FrmAddUpdateSection openFrom = new FrmAddUpdateSection(2, IdSeccionAcademica, nombreSeccionAcademica, 1);
        //            openFrom.ShowDialog();
        //            RefreshAcademicSectionDataGridView();
        //        }

        //        //Eliminat
        //        private void DeleteSeccionAcademica(object sender, EventArgs e)
        //        {
        //            int pos = daoSectionAdministrationGrades.dataGridSeccionAcademica.CurrentRow.Index;
        //            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {daoSectionAdministrationGrades.dataGridSeccionAcademica[0, pos].Value.ToString()} {daoSectionAdministrationGrades.dataGridSeccionAcademica[1, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //            {
        //                DAOSectionAdministration daoDelete = new DAOSectionAdministration();
        //                daoDelete.IdSeccionAcademica = int.Parse(daoSectionAdministrationGrades.dataGridSeccionAcademica[0, pos].Value.ToString());
        //                int ValorRetornado = daoDelete.DeleteAcademicSection();
        //                if (ValorRetornado == 1)
        //                {
        //                    MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    RefreshAcademicSectionDataGridView();
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //        }

        //        private void DeleteEspecialidad(object sender, EventArgs e)
        //        {
        //            int pos = daoSectionAdministrationGrades.dataGridEspecialidades.CurrentRow.Index;
        //            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {daoSectionAdministrationGrades.dataGridEspecialidades[0, pos].Value.ToString()} {daoSectionAdministrationGrades.dataGridEspecialidades[1, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //            {
        //                DAOSectionAdministration daoDelete = new DAOSectionAdministration();
        //                daoDelete.IdEspecialidad = int.Parse(daoSectionAdministrationGrades.dataGridEspecialidades[0, pos].Value.ToString());
        //                int ValorRetornado = daoDelete.DeleteSpecialty();
        //                if (ValorRetornado == 1)
        //                {
        //                    MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    RefreshAcademicSectionDataGridView();
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //            RefreshSpecialtyDataGridView();
        //        }

        //        private void DeleteSeccion(object sender, EventArgs e)
        //        {
        //            int pos = daoSectionAdministrationGrades.GridAdminGrade.CurrentRow.Index;
        //            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {daoSectionAdministrationGrades.GridAdminGrade[1, pos].Value.ToString()} {daoSectionAdministrationGrades.GridAdminGrade[2, pos].Value.ToString()} {daoSectionAdministrationGrades.GridAdminGrade[3, pos].Value.ToString()} {daoSectionAdministrationGrades.GridAdminGrade[4, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //            {
        //                DAOSectionAdministration daoDelete = new DAOSectionAdministration();
        //                daoDelete.IdSeccion = int.Parse(daoSectionAdministrationGrades.GridAdminGrade[0, pos].Value.ToString());
        //                int ValorRetornado = daoDelete.DeleteSection();
        //                if (ValorRetornado == 1)
        //                {
        //                    MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    RefreshAcademicSectionDataGridView();
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //            RefrescarDataAdminGrade();
        //        }

        private void RefreshSectionDataGridView()
        {
            DAOSectionAdministration dao = new DAOSectionAdministration();
            DataSet ds = dao.RetrieveSectionData();
            // Llenar DataGridView
            frmSectionAdministration.dgvAcademicLevelDisplay.DataSource = ds.Tables["viewGradoSeccion"];
            SetDataGridViewColumnSize();
        }
        private void RefreshSpecialtyDataGridView()
        {
            DAOSectionAdministration dao = new DAOSectionAdministration();
            DataSet ds = dao.RetrieveSpecialtyData();
            // Llenar DataGridView
            frmSectionAdministration.dgvAcademicLevelDisplay.DataSource = ds.Tables["viewEspecialidades"];
            SetDataGridViewColumnSize();
        }
        private void RefreshAcademicSectionDataGridView()
        {
            DAOSectionAdministration dao = new DAOSectionAdministration();
            DataSet ds = dao.RetrieveAcademicSectionData();
            //Llenar DataGridView
            frmSectionAdministration.dgvAcademicLevelDisplay.DataSource = ds.Tables["viewSeccionesAcademicas"];
            SetDataGridViewColumnSize();

        }
        private void RefreshGradeDataGridView()
        {
            DAOSectionAdministration dao = new DAOSectionAdministration();
            DataSet ds = dao.RetrieveGradeData();
            frmSectionAdministration.dgvAcademicLevelDisplay.DataSource = ds.Tables["viewGrados"];
            SetDataGridViewColumnSize();
        }


        //        public void VerSeccion(object sender, EventArgs e)
        //        {
        //            int pos = daoSectionAdministrationGrades.GridAdminGrade.CurrentRow.Index;
        //            int IdSecion;
        //            string GrupoTecnico, Especialidad, Grado, SeccionAcademica;
        //            IdSecion = int.Parse(daoSectionAdministrationGrades.GridAdminGrade[0, pos].Value.ToString());
        //            GrupoTecnico = daoSectionAdministrationGrades.GridAdminGrade[1, pos].Value.ToString();
        //            Grado = daoSectionAdministrationGrades.GridAdminGrade[2, pos].Value.ToString();
        //            SeccionAcademica = daoSectionAdministrationGrades.GridAdminGrade[3, pos].Value.ToString();
        //            Especialidad = daoSectionAdministrationGrades.GridAdminGrade[4, pos].Value.ToString();
        //            FrmAddUpdateSection openFrom = new FrmAddUpdateSection(3, IdSecion, GrupoTecnico, Especialidad, Grado, SeccionAcademica);
        //            openFrom.ShowDialog();
        //            RefrescarDataAdminGrade();
        //        }
        private void SetDataGridViewColumnSize()
        {
            frmSectionAdministration.dgvAcademicLevelDisplay.Columns[0].Width = 32;
        }
    }
}