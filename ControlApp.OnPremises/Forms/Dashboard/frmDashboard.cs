using ControlApp.OnPremises.Panels;
using ControlApp.OnPremises.Panels.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlApp.OnPremises.Forms.Dashboard
{
    public partial class frmDashboard : MetroFramework.Forms.MetroForm 
    {
        public frmDashboard()
        {
            InitializeComponent();
          

        }

      
        private void mtAdmArea_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlAdminArea _pnlAdminArea = new pnlAdminArea(this);
            this.metroPanel2.Controls.Add(_pnlAdminArea);
            //_pnlAdminArea.Closed += _pnlarea_Closed;
            //_pnlAdminArea.Shown += _pnlarea_Shown;
            _pnlAdminArea.swipe();
            //mtReceipt.Enabled = false;
        }

    
        private void mtReceipt_Click(object sender, EventArgs e)
        {
            //this.Style = MetroFramework.MetroColorStyle.Lime;
            //mtCustomer.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel2.Controls.Clear();
            pnlReceipt _pnlReceipt = new pnlReceipt(this);
            this.metroPanel2.Controls.Add(_pnlReceipt);
            _pnlReceipt.swipe();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            metroPanel1.BackColor = Color.DeepSkyBlue;
        }

        private void mtArea_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlArea _pnlArea = new pnlArea(this);
            this.metroPanel2.Controls.Add(_pnlArea);
            _pnlArea.swipe();
            //mtReceipt.Enabled = false;
        }

        private void mtPriceTag_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlPriceTag _pnlPriceTag = new pnlPriceTag(this);
            this.metroPanel2.Controls.Add(_pnlPriceTag);
            _pnlPriceTag.swipe();
        }

        private void mtAdPrecios_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlAdminPriceTag _pnlPriceTag = new pnlAdminPriceTag(this);
            this.metroPanel2.Controls.Add(_pnlPriceTag);
            _pnlPriceTag.swipe();
        }

        private void mtAdmReceipt_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlAdminReceipt _pnlAdminReceipt = new pnlAdminReceipt(this);
            this.metroPanel2.Controls.Add(_pnlAdminReceipt);
            _pnlAdminReceipt.swipe();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlUser _pnlUser = new pnlUser(this);
            this.metroPanel2.Controls.Add(_pnlUser);
            _pnlUser.swipe();
        }

        private void btnDpto_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlDepartament _pnlDepartament = new pnlDepartament(this);
            this.metroPanel2.Controls.Add(_pnlDepartament);
            _pnlDepartament.swipe();
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlPosition _pnlPosition = new pnlPosition(this);
            this.metroPanel2.Controls.Add(_pnlPosition);
            _pnlPosition.swipe();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlRole _pnlRole = new pnlRole(this);
            this.metroPanel2.Controls.Add(_pnlRole);
            _pnlRole.swipe();
        }
    }
}
