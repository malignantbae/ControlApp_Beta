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
    public partial class pnlRole : pnlSlider
    {
        RoleManagement ApiAccess = new RoleManagement();
        Role ObjRole = new Role();
        public pnlRole(Form owner) : base(owner)
        {
            InitializeComponent();
        }
        private void LoadDataGrid()
        {
            try
            {
                dgvRole.Rows.Clear();
                var ListRole = ApiAccess.RetrieveAllRole<Role>();
                foreach (Role element in ListRole)
                {
                    string[] RowRole;
                    RowRole = new string[] { element.ID_role.ToString(),element.Name_role
                        , element.Descrip_role};
                    dgvRole.Rows.Add(RowRole);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void CleanFields()
        {
            txtRolename.Text = "";
            txtRetrieveByName.Text = "";
            txtDescripRole.Text = "";
        }

        private bool Checkname(string pRoleName)
        {
            try
            {
                bool finded = false;
                ObjRole.Name_role = pRoleName;

                var ListRole = ApiAccess.RetrieveAllByNameRole<Role>(ObjRole);
                foreach (Role element in ListRole)
                {
                    if (element.Name_role == pRoleName)
                    {
                        finded = true;
                        if (finded == true)
                        {
                            break;
                        }
                    }
                }
                return finded;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
