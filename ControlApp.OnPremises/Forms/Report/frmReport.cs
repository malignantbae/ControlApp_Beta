using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlApp.OnPremises.Forms.Report
{
    public partial class frmReport : MetroFramework.Forms.MetroForm
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            this.reportViewer.RefreshReport();
        }
    }
}
