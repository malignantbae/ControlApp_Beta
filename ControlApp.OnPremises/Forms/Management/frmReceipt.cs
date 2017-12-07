using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlApp.OnPremises
{
    public partial class frmReceipt : MetroFramework.Forms.MetroForm
    {
        public frmReceipt()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            frmReceipt frm = new frmReceipt();
            //frm.Text = "";
            frm.ControlBox = false;
        }
    }
}
