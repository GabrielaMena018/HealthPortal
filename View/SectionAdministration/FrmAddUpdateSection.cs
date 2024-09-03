using HealthPortal.Controller.SectionAdministration;
using HealthPortal.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HealthPortal.View.SectionAdministration
{
    public partial class FrmAddUpdateSection : Form
    {
        public FrmAddUpdateSection(int action, int tabPage)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //ControllerAddUpdateSection control = new ControllerAddUpdateSection(this, action, tabPage);
        }

        private void grpGrade_Enter(object sender, EventArgs e)
        {

        }
        //public FrmAddUpdateSection(int action, int specialtyID, string specialty)
        //{
        //    InitializeComponent();
        //    ControllerAddUpdateSection control = new ControllerAddUpdateSection(this, action, specialtyID, specialty);
        //}
        //public FrmAddUpdateSection(int action, int sectionID, string technicalGroup, string specialty, string grade, string academicSection)
        //{
        //    InitializeComponent();
        //    ControllerAddUpdateSection control = new ControllerAddUpdateSection(this, action, sectionID, technicalGroup, specialty, grade, academicSection);
        //}
        //public FrmAddUpdateSection(int action, int sectionID, string academicSection, int num)
        //{
        //    InitializeComponent();
        //    ControllerAddUpdateSection control = new ControllerAddUpdateSection(this, action, sectionID, academicSection, num);
        //}
    }
}
