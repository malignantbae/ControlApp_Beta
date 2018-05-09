using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlApp.Entities.Objects;
using ControlApp.ApiCore.Management;
using MetroFramework;
using static ControlApp.OnPremises.Program;

namespace ControlApp.OnPremises.Panels
{
    public partial class pnlUser : pnlSlider
    {
        public pnlUser(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
