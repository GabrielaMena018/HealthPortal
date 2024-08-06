﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPacientes.Model.DAO;
using RegistroPacientes.Model.DTO;
using RegistroPacientes.View.InventoryAdministration;

namespace RegistroPacientes.Controller.InventoryAdministration
{
    internal class ControllerInventoryAdministration
    {
        FrmInventoryAdministration objInventoryAdministration;

        public ControllerInventoryAdministration(FrmInventoryAdministration vista)
        {
            objInventoryAdministration = vista;
            objInventoryAdministration.Load += new EventHandler(LoadData);
            //Evento click del boton
            objInventoryAdministration.btnNew.Click += new EventHandler(NewMedicineInventory);
            objInventoryAdministration.cmsUpdate.Click += new EventHandler(UpdateMedicineInventory);
            objInventoryAdministration.cmsDelete.Click += new EventHandler(DeleteMedicineInventory);
            objInventoryAdministration.btnSearch.Click += new EventHandler(SearchMedicineInventory);
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
            DAOInventoryAdministration daoInventoryAdministration = new DAOInventoryAdministration();
            //Declarando DataSet para que obtenga los datos del metodo GetInventory
            DataSet ds = daoInventoryAdministration.GetInventory();
            //Llenar DataGridView 
            objInventoryAdministration.dgvInventory.DataSource = ds.Tables["viewMedicamento"];
            objInventoryAdministration.dgvInventory.Columns[0].Width = 100;
            objInventoryAdministration.dgvInventory.Columns[1].Width = 100;
            objInventoryAdministration.dgvInventory.Columns[2].Width = 100;
            objInventoryAdministration.dgvInventory.Columns[3].Width = 100;
            objInventoryAdministration.dgvInventory.Columns[4].Width = 100;
            objInventoryAdministration.dgvInventory.Columns[5].Width = 100;
            objInventoryAdministration.dgvInventory.Columns[6].Width = 100;
            objInventoryAdministration.dgvInventory.Columns[7].Width = 100;
            objInventoryAdministration.dgvInventory.Columns[8].Width = 100;
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

        private void NewMedicineInventory(object sender, EventArgs e)
        {
            FrmAddUpdateMedicine openForm = new FrmAddUpdateMedicine(1);
            openForm.ShowDialog();
            RefreshData();
        }

        private void UpdateMedicineInventory(object sender, EventArgs e)
        {
            int pos = objInventoryAdministration.dgvInventory.CurrentRow.Index;
            int id;
            string nameMedicment, categoryMedicment, stock, description;
            DateTime expirationDate, income, exit;
            id = int.Parse(objInventoryAdministration.dgvInventory[0, pos].Value.ToString());
            nameMedicment = objInventoryAdministration.dgvInventory[1, pos].Value.ToString();
            description = objInventoryAdministration.dgvInventory[2, pos].Value.ToString();
            categoryMedicment = objInventoryAdministration.dgvInventory[3, pos].Value.ToString();
            expirationDate = DateTime.Parse(objInventoryAdministration.dgvInventory[4, pos].Value.ToString());
            income = DateTime.Parse(objInventoryAdministration.dgvInventory[5, pos].Value.ToString());
            exit = DateTime.Parse(objInventoryAdministration.dgvInventory[6, pos].Value.ToString());
            stock = objInventoryAdministration.dgvInventory[7, pos].Value.ToString();


            FrmAddUpdateMedicine openForm = new FrmAddUpdateMedicine(2, id, nameMedicment, categoryMedicment, expirationDate, stock, income, exit, description);
            openForm.ShowDialog();
            RefreshData();
        }

        private void DeleteMedicineInventory(object sender, EventArgs e)
        {
            int pos = objInventoryAdministration.dgvInventory.CurrentRow.Index;
            if ((MessageBox.Show($"¿Está seguro que desea eliminar al medicamento {objInventoryAdministration.dgvInventory[1, pos].Value.ToString()}? Considere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                DAOInventoryAdministration daoInventoryAdministration = new DAOInventoryAdministration();
                daoInventoryAdministration.IdMedicamento = int.Parse(objInventoryAdministration.dgvInventory[0, pos].Value.ToString());
                daoInventoryAdministration.IdEntradaSalida = int.Parse(objInventoryAdministration.dgvInventory[8, pos].Value.ToString());
                int returnedValue = daoInventoryAdministration.DeleteInventory();
                if (returnedValue == 1)
                {
                    MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                RefreshData();
            }
        }
        private void SearchMedicineInventory(object sender, EventArgs e)
        {
            DAOInventoryAdministration daoInventoryAdministration = new DAOInventoryAdministration();
            string search = objInventoryAdministration.txtSearch.Texts.Trim();
            DataSet ds = daoInventoryAdministration.SearchMedicineInventory(search);
            objInventoryAdministration.dgvInventory.DataSource = ds.Tables["viewMedicamento"];
        }
    }
}
