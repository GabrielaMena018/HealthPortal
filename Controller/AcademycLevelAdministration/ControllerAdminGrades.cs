//*3*
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using RegistroPacientes.Models.DAO;
using RegistroPacientes.View.AcademycLevelAdministration;

namespace RegistroPacientes.Controller.AcademycLevelAdministration
{
    internal class ControllerAdminGrades
    {
       FrmAdminGrades ObjAdminGrades;
        
        public  ControllerAdminGrades(FrmAdminGrades vista) 
        {
            ObjAdminGrades = vista;
            ObjAdminGrades.Load += new EventHandler(InitialCharge);
            ObjAdminGrades.btnNewGrade.Click += new EventHandler(NewGrade);
            ObjAdminGrades.toolStripActualizarEspecialidad.Click += new EventHandler(updateEspecialidad);
            ObjAdminGrades.toolStripActualizarSeccionAcademica.Click += new EventHandler(updateSeccionAcademica);
            ObjAdminGrades.toolStripDeleteSeccionAcademica.Click += new EventHandler(DeleteSeccionAcademica);
            ObjAdminGrades.toolStripEliminarEspecialidad.Click += new EventHandler(DeleteEspecialidad);
            ObjAdminGrades.cmsEliminarSeccion.Click += new EventHandler(DeleteSeccion);
            ObjAdminGrades.cmsActualizarSeccion.Click += new EventHandler(updateSeccion);
            ObjAdminGrades.btnNuevaEspecialidad.Click += new EventHandler(NewEspecialidad);
            ObjAdminGrades.BtnNuevaSecciónAcademica.Click += new EventHandler(NewSeccionAcademica);
            ObjAdminGrades.tabControlAdministrar.SelectedIndexChanged += new EventHandler(tabControl_SelectedIndexChanged);
            ObjAdminGrades.cmsVerSeccion.Click += new EventHandler(VerSeccion);

            
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexTab = ObjAdminGrades.tabControlAdministrar.SelectedIndex;

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
            DAOAdminGrades objAdmin = new DAOAdminGrades();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet dsGrados = objAdmin.LlenarCombo("tbGrados");

            //Llenar combobox tcmbGrado
            ObjAdminGrades.cmbGrado.DataSource = dsGrados.Tables["tbGrados"];
            ObjAdminGrades.cmbGrado.ValueMember = "IdGrado";
            ObjAdminGrades.cmbGrado.DisplayMember = "Grado";

            DataSet dsEspecialidad = objAdmin.LlenarCombo("tbEspecialidades");
            //Llenar combobox cmbEspecialidad
            ObjAdminGrades.cmbEspecialidad.DataSource = dsEspecialidad.Tables["tbEspecialidades"];
            ObjAdminGrades.cmbEspecialidad.ValueMember = "IdEspecialidad";
            ObjAdminGrades.cmbEspecialidad.DisplayMember = "Especialidad";

            DataSet dsSeccionAcademica = objAdmin.LlenarCombo("tbSeccionAcademica");
            //Llenar combobox cmbSeccionAcademica
            ObjAdminGrades.cmbSeccionAcademica.DataSource = dsSeccionAcademica.Tables["tbSeccionAcademica"];
            ObjAdminGrades.cmbSeccionAcademica.ValueMember = "IdSeccionAcademica";
            ObjAdminGrades.cmbSeccionAcademica.DisplayMember = "SeccionAcademica";
        }

        //Abrir el formulario FrmAddGrade con el numero de acción 1
        public void NewGrade(object sender, EventArgs e)
        {
            FrmAddGrades openForm = new FrmAddGrades(1,0);
            openForm.ShowDialog();
            RefrescarDataAdminGrade();

        }

        public void NewEspecialidad(object sender, EventArgs e)
        {
            FrmAddGrades openForm = new FrmAddGrades(1, 2);
            openForm.ShowDialog();
            RefrescarDataAdminEspecalidades();
        }

        public void NewSeccionAcademica(object sender, EventArgs e)
        {
            FrmAddGrades openForm = new FrmAddGrades(1, 1);
            openForm.ShowDialog();
            RefrescarDataAdminSeccionesAcademicas();
        }

        //Actualizar
        public void updateEspecialidad(object sender, EventArgs e) 
        {
            int pos = ObjAdminGrades.dataGridEspecialidades.CurrentRow.Index;
            int IdGrade;
            string nombreEspecialidad;
            IdGrade = int.Parse(ObjAdminGrades.dataGridEspecialidades[0, pos].Value.ToString());
            nombreEspecialidad = ObjAdminGrades.dataGridEspecialidades[1,pos].Value.ToString();
           FrmAddGrades openFrom = new FrmAddGrades(2, IdGrade, nombreEspecialidad);
            openFrom.ShowDialog();
            RefrescarDataAdminEspecalidades();
        }

        public void updateSeccion(object sender, EventArgs e)
        {
            int pos = ObjAdminGrades.GridAdminGrade.CurrentRow.Index;
            int IdSecion;
            string GrupoTecnico, Especialidad, Grado, SeccionAcademica;
            IdSecion = int.Parse(ObjAdminGrades.GridAdminGrade[0, pos].Value.ToString());
            GrupoTecnico = ObjAdminGrades.GridAdminGrade[1, pos].Value.ToString();
            Grado = ObjAdminGrades.GridAdminGrade[2,pos].Value.ToString();
            SeccionAcademica = ObjAdminGrades.GridAdminGrade[3, pos].Value.ToString();
            Especialidad = ObjAdminGrades.GridAdminGrade[4, pos].Value.ToString();
            FrmAddGrades openFrom = new FrmAddGrades(2, IdSecion, GrupoTecnico, Especialidad, Grado, SeccionAcademica);
            openFrom.ShowDialog();
            RefrescarDataAdminGrade();
        }

        public void updateSeccionAcademica(object sender, EventArgs e)
        {
            int pos = ObjAdminGrades.dataGridSeccionAcademica.CurrentRow.Index;
            int IdSeccionAcademica;
            string nombreSeccionAcademica;
            IdSeccionAcademica = int.Parse(ObjAdminGrades.dataGridSeccionAcademica[0, pos].Value.ToString());
            nombreSeccionAcademica = ObjAdminGrades.dataGridSeccionAcademica[1, pos].Value.ToString();
            FrmAddGrades openFrom = new FrmAddGrades(2,IdSeccionAcademica, nombreSeccionAcademica, 1);
            openFrom.ShowDialog();
            RefrescarDataAdminSeccionesAcademicas();
        } 

        //Eliminat
        private void DeleteSeccionAcademica(object sender, EventArgs e)
        {
            int pos = ObjAdminGrades.dataGridSeccionAcademica.CurrentRow.Index;
            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {ObjAdminGrades.dataGridSeccionAcademica[0, pos].Value.ToString()} {ObjAdminGrades.dataGridSeccionAcademica[1, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOAdminGrades daoDelete = new DAOAdminGrades();
                daoDelete.IdSeccionAcademica = int.Parse(ObjAdminGrades.dataGridSeccionAcademica[0, pos].Value.ToString());
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
            int pos = ObjAdminGrades.dataGridEspecialidades.CurrentRow.Index;
            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {ObjAdminGrades.dataGridEspecialidades[0, pos].Value.ToString()} {ObjAdminGrades.dataGridEspecialidades[1, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOAdminGrades daoDelete = new DAOAdminGrades();
                daoDelete.IdEspecialidad = int.Parse(ObjAdminGrades.dataGridEspecialidades[0, pos].Value.ToString());
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
            int pos = ObjAdminGrades.GridAdminGrade.CurrentRow.Index;
            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {ObjAdminGrades.GridAdminGrade[1, pos].Value.ToString()} {ObjAdminGrades.GridAdminGrade[2, pos].Value.ToString()} {ObjAdminGrades.GridAdminGrade[3, pos].Value.ToString()} {ObjAdminGrades.GridAdminGrade[4, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOAdminGrades daoDelete = new DAOAdminGrades();
                daoDelete.IdSeccion = int.Parse(ObjAdminGrades.GridAdminGrade[0, pos].Value.ToString());
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
            DAOAdminGrades objAdmin = new DAOAdminGrades();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = objAdmin.AdminGrade();
            //Llenar DataGridView
           ObjAdminGrades.GridAdminGrade.DataSource = ds.Tables["ViewGradoSeccion"];
            ObjAdminGrades.GridAdminGrade.Columns[0].HeaderText = "Id Sección";
            ObjAdminGrades.GridAdminGrade.Columns[1].HeaderText = "Grupo Técnico";
            ObjAdminGrades.GridAdminGrade.Columns[2].HeaderText = "Grado";
            ObjAdminGrades.GridAdminGrade.Columns[3].HeaderText = "Sección Académica";
            ObjAdminGrades.GridAdminGrade.Columns[4].HeaderText = "Especialidades";


        }

        public void RefrescarDataAdminEspecalidades()
        {
            DAOAdminGrades objAdmin = new DAOAdminGrades();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = objAdmin.AdminEspecialidades();
            //Llenar DataGridView
            ObjAdminGrades.dataGridEspecialidades.DataSource = ds.Tables["ViewEspecialidades"];
            ObjAdminGrades.dataGridEspecialidades.Columns[0].HeaderText = "Id Especialidad";
            ObjAdminGrades.dataGridEspecialidades.Columns[1].HeaderText = "Nombre de la especialidad";

        }

        public void RefrescarDataAdminSeccionesAcademicas()
        {
            DAOAdminGrades objAdmin = new DAOAdminGrades();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = objAdmin.AdminSeccionesAcademicas();
            //Llenar DataGridView
            ObjAdminGrades.dataGridSeccionAcademica.DataSource = ds.Tables["ViewSeccionesAcademicas"];
            ObjAdminGrades.GridAdminGrade.Columns[0].HeaderText = "Id Sección Academica";
            ObjAdminGrades.GridAdminGrade.Columns[1].HeaderText = "Sección Académica";

        }


        public void VerSeccion(object sender, EventArgs e)
        {
            int pos = ObjAdminGrades.GridAdminGrade.CurrentRow.Index;
            int IdSecion;
            string GrupoTecnico, Especialidad, Grado, SeccionAcademica;
            IdSecion = int.Parse(ObjAdminGrades.GridAdminGrade[0, pos].Value.ToString());
            GrupoTecnico = ObjAdminGrades.GridAdminGrade[1, pos].Value.ToString();
            Grado = ObjAdminGrades.GridAdminGrade[2, pos].Value.ToString();
            SeccionAcademica = ObjAdminGrades.GridAdminGrade[3, pos].Value.ToString();
            Especialidad = ObjAdminGrades.GridAdminGrade[4, pos].Value.ToString();
            FrmAddGrades openFrom = new FrmAddGrades(3, IdSecion, GrupoTecnico, Especialidad, Grado, SeccionAcademica);
            openFrom.ShowDialog();
            RefrescarDataAdminGrade();
        }

    }
}
