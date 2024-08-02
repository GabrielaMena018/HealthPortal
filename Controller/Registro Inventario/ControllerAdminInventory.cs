using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPacientes.Models.DAO;
using RegistroPacientes.Models.DTO;
using RegistroPacientes.View.Ineventario;

namespace RegistroPacientes.Controller.Registro_Inventario
{
    internal class ControllerAdminInventory
    {
        FrmAdminInventary objAdminInventory;

        public ControllerAdminInventory(FrmAdminInventary vista)
        {
            objAdminInventory = vista;
            objAdminInventory.Load += new EventHandler(LoadData);
            //Evento click del boton
            objAdminInventory.btnNew.Click += new EventHandler(NewInventory);
            objAdminInventory.cmsUpdate.Click += new EventHandler(UpdateInventory);
            objAdminInventory.cmsDelete.Click += new EventHandler(DeleteInventory);
            //objAdminInventory.cmsView.Click += new EventHandler();
            //DataGridView
            //objAdminInventory.dgvInventory.CellPainting += new DataGridViewCellPaintingEventHandler(FormatoColumnaGrid);
        }

        public void LoadData(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            //Objeto de la clase DAOAdminInventory
            DAOAdminInventory objAdmin = new DAOAdminInventory();
            //Declarando DataSet para que obtenga los datos del metodo GetInventory
            DataSet ds = objAdmin.GetInventory();
            //Llenar DataGridView 
            objAdminInventory.dgvInventory.DataSource = ds.Tables["ViewMedicamento"];
            objAdminInventory.dgvInventory.Columns[0].HeaderText = "ID Medicamento";
            objAdminInventory.dgvInventory.Columns[0].Width = 100;
            objAdminInventory.dgvInventory.Columns[1].HeaderText = "Nombre";
            objAdminInventory.dgvInventory.Columns[1].Width = 100;
            objAdminInventory.dgvInventory.Columns[2].HeaderText = "Descripción";
            objAdminInventory.dgvInventory.Columns[2].Width = 100;
            objAdminInventory.dgvInventory.Columns[3].HeaderText = "Categoria";
            objAdminInventory.dgvInventory.Columns[3].Width = 100;
            objAdminInventory.dgvInventory.Columns[4].HeaderText = "Fecha de vencimiento";
            objAdminInventory.dgvInventory.Columns[4].Width = 100;
            objAdminInventory.dgvInventory.Columns[5].HeaderText = "Fecha de Ingreso";
            objAdminInventory.dgvInventory.Columns[5].Width = 100;
            objAdminInventory.dgvInventory.Columns[6].HeaderText = "Hora de Entrada";
            objAdminInventory.dgvInventory.Columns[6].Width = 100;
            objAdminInventory.dgvInventory.Columns[7].HeaderText = "Cantidad en existencia";
            objAdminInventory.dgvInventory.Columns[7].Width = 100;
            objAdminInventory.dgvInventory.Columns[8].HeaderText = "Id de la entrada";
            objAdminInventory.dgvInventory.Columns[8].Width = 100;
        }

        #region Código para generar columnas de editar y eliminar
        //public void GenerarColumnaEliminarDataGrid()
        //{
        //    DataGridViewButtonColumn btnClmDel = new DataGridViewButtonColumn();
        //    btnClmDel.Name = "Eliminar";
        //    ObjAdminUser.dgvIventory.Columns.Add(btnClmDel);
        //}
        //public void GenerarColumnaEditarDataGrid()
        //{
        //    DataGridViewButtonColumn btnClmEdit = new DataGridViewButtonColumn();
        //    btnClmEdit.Name = "Editar";
        //    ObjAdminUser.dgvPersonas.Columns.Add(btnClmEdit);
        //}
        //public void FormatoColumnaGrid(Object sender, DataGridViewCellPaintingEventArgs e)
        //{
        //    if (e.ColumnIndex >= 0 && ObjAdminUser.dgvPersonas.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
        //    {
        //        e.Paint(e.CellBounds, DataGridViewPaintParts.All);
        //        DataGridViewButtonCell celboton = ObjAdminUser.dgvPersonas.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
        //        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"../../../Resources/Trash.ico");
        //        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
        //        ObjAdminUser.dgvPersonas.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
        //        ObjAdminUser.dgvPersonas.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;
        //        e.Handled = true;
        //    }
        //    else if (e.ColumnIndex >= 0 && ObjAdminUser.dgvPersonas.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
        //    {
        //        e.Paint(e.CellBounds, DataGridViewPaintParts.All);
        //        DataGridViewButtonCell celboton = ObjAdminUser.dgvPersonas.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
        //        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"../../../Resources/Refresh.ico");
        //        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
        //        ObjAdminUser.dgvPersonas.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
        //        ObjAdminUser.dgvPersonas.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;
        //        e.Handled = true;
        //    }
        //}
        #endregion

        private void NewInventory(object sender, EventArgs e)
        {
            FrmAddInventory openForm = new FrmAddInventory(1);
            openForm.ShowDialog();
            RefreshData();
        }

        private void UpdateInventory(object sender, EventArgs e)
        {
            int pos = objAdminInventory.dgvInventory.CurrentRow.Index;
            MessageBox.Show(objAdminInventory.dgvInventory[1, pos].Value.ToString());
            MessageBox.Show(objAdminInventory.dgvInventory[7, pos].Value.ToString());
            int id;
            string nameMedicment, categoryMedicment, stock ,description;
            DateTime expirationDate, income, exit;
            id =                  int.Parse(objAdminInventory.dgvInventory[0,pos].Value.ToString());
            MessageBox.Show("" + id);
            nameMedicment =                 objAdminInventory.dgvInventory[1,pos].Value.ToString();
            description =                   objAdminInventory.dgvInventory[2,pos].Value.ToString();
            categoryMedicment =             objAdminInventory.dgvInventory[3, pos].Value.ToString();
            expirationDate = DateTime.Parse(objAdminInventory.dgvInventory[4, pos].Value.ToString());
            income =         DateTime.Parse(objAdminInventory.dgvInventory[5, pos].Value.ToString());
            exit =           DateTime.Parse(objAdminInventory.dgvInventory[6, pos].Value.ToString());
            stock =                         objAdminInventory.dgvInventory[7, pos].Value.ToString();


            FrmAddInventory openForm = new FrmAddInventory(2, id, nameMedicment, categoryMedicment,expirationDate, stock, income, exit,description);
            openForm.ShowDialog();
            RefreshData();
        }

        private void DeleteInventory(object sender, EventArgs e)
        {
            int pos = objAdminInventory.dgvInventory.CurrentRow.Index;
            if ((MessageBox.Show($"¿Esta seguro que desea elimar el: {objAdminInventory.dgvInventory[1, pos].Value.ToString()} {objAdminInventory.dgvInventory[2, pos].Value.ToString()}.Considere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                DAOAdminInventory daoDelete = new DAOAdminInventory();
                daoDelete.IdMedicamento = int.Parse(objAdminInventory.dgvInventory[0,pos].Value.ToString());
                daoDelete.IdEntradaSalida = int.Parse(objAdminInventory.dgvInventory[8,pos].Value.ToString());  
                int returnedValue = daoDelete.DeleteInventory();
                MessageBox.Show(returnedValue.ToString());
                if (returnedValue == 1)
                {
                    MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefreshData();
        }

    }
}
