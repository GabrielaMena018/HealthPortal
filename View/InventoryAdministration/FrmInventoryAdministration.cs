using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPacientes.Controller;
using RegistroPacientes.Controller.InventoryAdministration;

namespace RegistroPacientes.View.InventoryAdministration
{
    public partial class FrmInventoryAdministration : Form
    {
        public FrmInventoryAdministration()
        {
            InitializeComponent();
            ControllerInventoryAdministration control = new ControllerInventoryAdministration(this);
        }
    }
}