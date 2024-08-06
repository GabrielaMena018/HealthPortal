using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using RegistroPacientes.Model.DAO;
using RegistroPacientes.View.SectionAdministration;

namespace RegistroPacientes.Controller.SectionAdministration
{
    internal class ControllerSectionAdministration
    {
        FrmSectionAdministration daoSectionAdministrationGrades;

        public ControllerSectionAdministration(FrmSectionAdministration view)
        {
            daoSectionAdministrationGrades = view;
            daoSectionAdministrationGrades.Load += new EventHandler(InitialCharge);
            daoSectionAdministrationGrades.btnNewGrade.Click += new EventHandler(NewGrade);
            daoSectionAdministrationGrades.toolStripActualizarEspecialidad.Click += new EventHandler(updateEspecialidad);
            daoSectionAdministrationGrades.toolStripActualizarSeccionAcademica.Click += new EventHandler(updateSeccionAcademica);
            daoSectionAdministrationGrades.toolStripDeleteSeccionAcademica.Click += new EventHandler(DeleteSeccionAcademica);
            daoSectionAdministrationGrades.toolStripEliminarEspecialidad.Click += new EventHandler(DeleteEspecialidad);
            daoSectionAdministrationGrades.cmsEliminarSeccion.Click += new EventHandler(DeleteSeccion);
            daoSectionAdministrationGrades.cmsActualizarSeccion.Click += new EventHandler(updateSeccion);
            daoSectionAdministrationGrades.btnNuevaEspecialidad.Click += new EventHandler(NewEspecialidad);
            daoSectionAdministrationGrades.BtnNuevaSecciónAcademica.Click += new EventHandler(NewSeccionAcademica);
            daoSectionAdministrationGrades.tabControlAdministrar.SelectedIndexChanged += new EventHandler(tabControl_SelectedIndexChanged);
            daoSectionAdministrationGrades.cmsVerSeccion.Click += new EventHandler(VerSeccion);


        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexTab = daoSectionAdministrationGrades.tabControlAdministrar.SelectedIndex;

            switch (indexTab)
            {
                case 0:
                    RefrescarDataAdminGrade();
                    break;
                case 1:
                    RefrescarDataAdminEspecalidades();
                    break;
                case 2:
                    RefrescarDataAdminSeccionesAcademicas();
                    break;
                default:
                    break;
            }
        }

        //acciones para la carga inicial
        private void InitialCharge(object sender, EventArgs e)
        {
            RefrescarDataAdminGrade();
            RefrescarDataAdminEspecalidades();
            RefrescarDataAdminSeccionesAcademicas();

            //Lenar combobox
            //Objeto de la clase DAOAdminUsuarios
            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();
            //Declarando nuevo DataSet para que obtenga los datos del metodo FillCombo
            DataSet dsGrados = daoSectionAdministration.FillCombo("tbGrados", "Secciones");

            //Llenar combobox tcmbGrado
            daoSectionAdministrationGrades.cmbGrado.DataSource = dsGrados.Tables["tbGrados"];
            daoSectionAdministrationGrades.cmbGrado.ValueMember = "IdGrado";
            daoSectionAdministrationGrades.cmbGrado.DisplayMember = "Grado";

            DataSet dsEspecialidad = daoSectionAdministration.FillCombo("tbEspecialidades", "Secciones");
            //Llenar combobox cmbEspecialidad
            daoSectionAdministrationGrades.cmbEspecialidad.DataSource = dsEspecialidad.Tables["tbEspecialidades"];
            daoSectionAdministrationGrades.cmbEspecialidad.ValueMember = "IdEspecialidad";
            daoSectionAdministrationGrades.cmbEspecialidad.DisplayMember = "Especialidad";

            DataSet dsSeccionAcademica = daoSectionAdministration.FillCombo("tbSeccionAcademica", "Secciones");
            //Llenar combobox cmbSeccionAcademica
            daoSectionAdministrationGrades.cmbSeccionAcademica.DataSource = dsSeccionAcademica.Tables["tbSeccionAcademica"];
            daoSectionAdministrationGrades.cmbSeccionAcademica.ValueMember = "IdSeccionAcademica";
            daoSectionAdministrationGrades.cmbSeccionAcademica.DisplayMember = "SeccionAcademica";
        }

        //Abrir el formulario FrmAddGrade con el numero de acción 1
        public void NewGrade(object sender, EventArgs e)
        {
            FrmAddUpdateSection openForm = new FrmAddUpdateSection(1, 0);
            openForm.ShowDialog();
            RefrescarDataAdminGrade();

        }

        public void NewEspecialidad(object sender, EventArgs e)
        {
            FrmAddUpdateSection openForm = new FrmAddUpdateSection(1, 2);
            openForm.ShowDialog();
            RefrescarDataAdminEspecalidades();
        }

        public void NewSeccionAcademica(object sender, EventArgs e)
        {
            FrmAddUpdateSection openForm = new FrmAddUpdateSection(1, 1);
            openForm.ShowDialog();
            RefrescarDataAdminSeccionesAcademicas();
        }

        //Actualizar
        public void updateEspecialidad(object sender, EventArgs e)
        {
            int pos = daoSectionAdministrationGrades.dataGridEspecialidades.CurrentRow.Index;
            int IdGrade;
            string nombreEspecialidad;
            IdGrade = int.Parse(daoSectionAdministrationGrades.dataGridEspecialidades[0, pos].Value.ToString());
            nombreEspecialidad = daoSectionAdministrationGrades.dataGridEspecialidades[1, pos].Value.ToString();
            FrmAddUpdateSection openFrom = new FrmAddUpdateSection(2, IdGrade, nombreEspecialidad);
            openFrom.ShowDialog();
            RefrescarDataAdminEspecalidades();
        }

        public void updateSeccion(object sender, EventArgs e)
        {
            int pos = daoSectionAdministrationGrades.GridAdminGrade.CurrentRow.Index;
            int IdSecion;
            string GrupoTecnico, Especialidad, Grado, SeccionAcademica;
            IdSecion = int.Parse(daoSectionAdministrationGrades.GridAdminGrade[0, pos].Value.ToString());
            GrupoTecnico = daoSectionAdministrationGrades.GridAdminGrade[1, pos].Value.ToString();
            Grado = daoSectionAdministrationGrades.GridAdminGrade[2, pos].Value.ToString();
            SeccionAcademica = daoSectionAdministrationGrades.GridAdminGrade[3, pos].Value.ToString();
            Especialidad = daoSectionAdministrationGrades.GridAdminGrade[4, pos].Value.ToString();
            FrmAddUpdateSection openFrom = new FrmAddUpdateSection(2, IdSecion, GrupoTecnico, Especialidad, Grado, SeccionAcademica);
            openFrom.ShowDialog();
            RefrescarDataAdminGrade();
        }

        public void updateSeccionAcademica(object sender, EventArgs e)
        {
            int pos = daoSectionAdministrationGrades.dataGridSeccionAcademica.CurrentRow.Index;
            int IdSeccionAcademica;
            string nombreSeccionAcademica;
            IdSeccionAcademica = int.Parse(daoSectionAdministrationGrades.dataGridSeccionAcademica[0, pos].Value.ToString());
            nombreSeccionAcademica = daoSectionAdministrationGrades.dataGridSeccionAcademica[1, pos].Value.ToString();
            FrmAddUpdateSection openFrom = new FrmAddUpdateSection(2, IdSeccionAcademica, nombreSeccionAcademica, 1);
            openFrom.ShowDialog();
            RefrescarDataAdminSeccionesAcademicas();
        }

        //Eliminat
        private void DeleteSeccionAcademica(object sender, EventArgs e)
        {
            int pos = daoSectionAdministrationGrades.dataGridSeccionAcademica.CurrentRow.Index;
            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {daoSectionAdministrationGrades.dataGridSeccionAcademica[0, pos].Value.ToString()} {daoSectionAdministrationGrades.dataGridSeccionAcademica[1, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOSectionAdministration daoDelete = new DAOSectionAdministration();
                daoDelete.IdSeccionAcademica = int.Parse(daoSectionAdministrationGrades.dataGridSeccionAcademica[0, pos].Value.ToString());
                int ValorRetornado = daoDelete.DeleteSeccionAcademica();
                if (ValorRetornado == 1)
                {
                    MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarDataAdminSeccionesAcademicas();
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteEspecialidad(object sender, EventArgs e)
        {
            int pos = daoSectionAdministrationGrades.dataGridEspecialidades.CurrentRow.Index;
            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {daoSectionAdministrationGrades.dataGridEspecialidades[0, pos].Value.ToString()} {daoSectionAdministrationGrades.dataGridEspecialidades[1, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOSectionAdministration daoDelete = new DAOSectionAdministration();
                daoDelete.IdEspecialidad = int.Parse(daoSectionAdministrationGrades.dataGridEspecialidades[0, pos].Value.ToString());
                int ValorRetornado = daoDelete.DeleteEspecialidad();
                if (ValorRetornado == 1)
                {
                    MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarDataAdminSeccionesAcademicas();
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefrescarDataAdminEspecalidades();
        }

        private void DeleteSeccion(object sender, EventArgs e)
        {
            int pos = daoSectionAdministrationGrades.GridAdminGrade.CurrentRow.Index;
            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {daoSectionAdministrationGrades.GridAdminGrade[1, pos].Value.ToString()} {daoSectionAdministrationGrades.GridAdminGrade[2, pos].Value.ToString()} {daoSectionAdministrationGrades.GridAdminGrade[3, pos].Value.ToString()} {daoSectionAdministrationGrades.GridAdminGrade[4, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOSectionAdministration daoDelete = new DAOSectionAdministration();
                daoDelete.IdSeccion = int.Parse(daoSectionAdministrationGrades.GridAdminGrade[0, pos].Value.ToString());
                int ValorRetornado = daoDelete.DeleteSeccion();
                if (ValorRetornado == 1)
                {
                    MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarDataAdminSeccionesAcademicas();
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefrescarDataAdminGrade();
        }

        public void RefrescarDataAdminGrade()
        {
            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = daoSectionAdministration.AdminGrade();
            //Llenar DataGridView
            daoSectionAdministrationGrades.GridAdminGrade.DataSource = ds.Tables["ViewGradoSeccion"];
            daoSectionAdministrationGrades.GridAdminGrade.Columns[0].HeaderText = "Id Sección";
            daoSectionAdministrationGrades.GridAdminGrade.Columns[1].HeaderText = "Grupo Técnico";
            daoSectionAdministrationGrades.GridAdminGrade.Columns[2].HeaderText = "Grado";
            daoSectionAdministrationGrades.GridAdminGrade.Columns[3].HeaderText = "Sección Académica";
            daoSectionAdministrationGrades.GridAdminGrade.Columns[4].HeaderText = "Especialidades";


        }

        public void RefrescarDataAdminEspecalidades()
        {
            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = daoSectionAdministration.AdminEspecialidades();
            //Llenar DataGridView
            daoSectionAdministrationGrades.dataGridEspecialidades.DataSource = ds.Tables["ViewEspecialidades"];
            daoSectionAdministrationGrades.dataGridEspecialidades.Columns[0].HeaderText = "Id Especialidad";
            daoSectionAdministrationGrades.dataGridEspecialidades.Columns[1].HeaderText = "Nombre de la especialidad";

        }

        public void RefrescarDataAdminSeccionesAcademicas()
        {
            DAOSectionAdministration daoSectionAdministration = new DAOSectionAdministration();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = daoSectionAdministration.AdminSeccionesAcademicas();
            //Llenar DataGridView
            daoSectionAdministrationGrades.dataGridSeccionAcademica.DataSource = ds.Tables["ViewSeccionesAcademicas"];
            daoSectionAdministrationGrades.GridAdminGrade.Columns[0].HeaderText = "Id Sección Academica";
            daoSectionAdministrationGrades.GridAdminGrade.Columns[1].HeaderText = "Sección Académica";

        }


        public void VerSeccion(object sender, EventArgs e)
        {
            int pos = daoSectionAdministrationGrades.GridAdminGrade.CurrentRow.Index;
            int IdSecion;
            string GrupoTecnico, Especialidad, Grado, SeccionAcademica;
            IdSecion = int.Parse(daoSectionAdministrationGrades.GridAdminGrade[0, pos].Value.ToString());
            GrupoTecnico = daoSectionAdministrationGrades.GridAdminGrade[1, pos].Value.ToString();
            Grado = daoSectionAdministrationGrades.GridAdminGrade[2, pos].Value.ToString();
            SeccionAcademica = daoSectionAdministrationGrades.GridAdminGrade[3, pos].Value.ToString();
            Especialidad = daoSectionAdministrationGrades.GridAdminGrade[4, pos].Value.ToString();
            FrmAddUpdateSection openFrom = new FrmAddUpdateSection(3, IdSecion, GrupoTecnico, Especialidad, Grado, SeccionAcademica);
            openFrom.ShowDialog();
            RefrescarDataAdminGrade();
        }

    }
}