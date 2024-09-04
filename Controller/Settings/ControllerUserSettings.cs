using HealthPortal.View.SectionAdministration;
using HealthPortal.View.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HealthPortal.Controller.Settings
{
    internal class ControllerUserSettings
    {
        FrmUserSettings frmUserSettings;
        int expandedFormWidth = 1090;
        public ControllerUserSettings(FrmUserSettings view)
        {
            frmUserSettings = view;
            frmUserSettings.Resize += new EventHandler(ResizeControls);
        }
        private void ResizeControls(object sender, EventArgs e)
        {
            if (frmUserSettings.Width == expandedFormWidth)
            {
                frmUserSettings.panel2.Location = new Point(48, 120);
            }
            else
            {
                frmUserSettings.panel2.Location = new Point(0, 120);
            }
            frmUserSettings.Refresh();
            MessageBox.Show(frmUserSettings.panel2.Location.X.ToString());
        }
    }
}
