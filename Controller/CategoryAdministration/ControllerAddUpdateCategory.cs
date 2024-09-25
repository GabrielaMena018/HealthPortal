using HealthPortal.Model.DAO;
using HealthPortal.View.CategoryAdministration;
using HealthPortal.View.InventoryAdministration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.CategoryAdministration
{
    internal class ControllerAddUpdateCategory
    {
        FrmAddUpdateCategory frmAddUpdateCategory;
        private int Action;
        private string medicineCategory;
        public ControllerAddUpdateCategory(FrmAddUpdateCategory view, int action)
        {
            frmAddUpdateCategory = view;
            Action = action;
            CheckAction();
            frmAddUpdateCategory.btnAdd.Click += new EventHandler(AddNewCategory);
            frmAddUpdateCategory.btnExitAddUpdateCategory.Click += new EventHandler(CloseForm);

        }

        public ControllerAddUpdateCategory(FrmAddUpdateCategory view, int action, int id, string medicineCategory)
        {
            frmAddUpdateCategory = view;
            Action = action;
            CheckAction();
            ChargeValues(id, medicineCategory);
            frmAddUpdateCategory.btnUpdate.Click += new EventHandler(UpdateCategory);
            frmAddUpdateCategory.btnExitAddUpdateCategory.Click += new EventHandler(CloseForm);
        }

        public void AddNewCategory(object sender, EventArgs e)
        {
            DAOCategoryAdministration dao = new DAOCategoryAdministration();
            dao.MedicineCategory = frmAddUpdateCategory.txtMedicineCategory.Texts.Trim();
            if (string.IsNullOrEmpty(frmAddUpdateCategory.txtMedicineCategory.Texts))
            {
                MessageBox.Show("Favor rellenar el campo vacio", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int returnedValue = dao.RegisterCategory();
                if (returnedValue == 1)
                {
                    MessageBox.Show("Los datos se han ingresado correctamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Desea continuar con la inserción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmAddUpdateCategory.Close();
                        FrmAddUpdateCategory openForm = new FrmAddUpdateCategory(1);
                        openForm.ShowDialog();
                        
                    }
                    else
                    {
                        frmAddUpdateCategory.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No se pudieron ingresar los datos", "Procedimiento interrumpido", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }



        }

        private void UpdateCategory(object sender, EventArgs e)
        {
            DAOCategoryAdministration dao = new DAOCategoryAdministration();
            dao.MedicineCategory = frmAddUpdateCategory.txtMedicineCategory.Texts.Trim();
            dao.CategoryID = int.Parse(frmAddUpdateCategory.txtID.Text.Trim());
            MessageBox.Show($"{frmAddUpdateCategory.txtID.Text}");
            if (string.IsNullOrEmpty(frmAddUpdateCategory.txtMedicineCategory.Texts) )
            {
                MessageBox.Show("Favor rellenar el campo vacio", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int returnedValue = dao.UpdateCategory();
                 if (returnedValue == 1)
                 {
                     MessageBox.Show("Los datos se han ingresado correctamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAddUpdateCategory.Close();
                 }
                 else
                 {
                     MessageBox.Show("No se pudieron ingresar los datos", "Procedimiento interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
            }
            
        }

        private void CloseForm(object sender, EventArgs e)
        {
            frmAddUpdateCategory.Dispose();
        }

        private void ChargeValues(int id, string medicineCategory)
        {
            frmAddUpdateCategory.txtID.Text = id.ToString(); 
            frmAddUpdateCategory.txtMedicineCategory.Texts = medicineCategory;
        }

        public void CheckAction()
        {
            if (Action == 1)
            {
                frmAddUpdateCategory.btnAdd.Visible = true;
                frmAddUpdateCategory.btnUpdate.Visible = false;
            }
            else if (Action == 2)
            {
                
                frmAddUpdateCategory.btnAdd.Visible = false;
                frmAddUpdateCategory.btnUpdate.Visible = true;
                frmAddUpdateCategory.lblTitle.Text = "Actualizar Categoría";
            }
        }
    }
}
