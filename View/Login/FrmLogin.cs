using RegistroPacientes.Controller.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegistroPacientes.View.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

        }

        private void boxUsername_TextChanged(object sender, EventArgs e)
        {
            BoxUsername.AutoSize = true;
            BoxUsername.Multiline = true;   
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userpic_Click(object sender, EventArgs e)
        {

        }

        private void lockpic_Click(object sender, EventArgs e)
        {

        }
    }
}
