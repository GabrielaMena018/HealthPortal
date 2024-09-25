using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPortal.Model.DTO
{
    internal class DTOCategoryAdministration : dbContext
    {
        private string medicineCategory;
        private int categoryID;

        public string MedicineCategory { get => medicineCategory; set => medicineCategory = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
    }
}
