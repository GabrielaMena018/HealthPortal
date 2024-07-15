using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPacientes.Controller.Registro_Inventario;
namespace RegistroPacientes.View.Ineventario
{
    public partial class FrmAddInventory : Form
    {
        public FrmAddInventory( int accion)
        {
            InitializeComponent();
            ControllerAddInventory objAddInventory = new ControllerAddInventory(this, accion);
        }

        public FrmAddInventory(int accion, int id, string nameMedicment, string categoryMedicment, DateTime expirationDate, string stock, string income, string exit, string description)
        {
            InitializeComponent();
            ControllerAddInventory objaddInventory = new ControllerAddInventory(this, accion, id, nameMedicment, categoryMedicment, expirationDate, stock, income, exit, description);
        }
    }
}
