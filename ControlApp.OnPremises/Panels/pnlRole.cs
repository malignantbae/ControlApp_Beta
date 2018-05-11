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
        string pIdSession = MystaticValues.IdSession;
        public pnlRole(Form owner) : base(owner)
        {
            InitializeComponent();
            LoadDataGrid();
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
        private bool CheckFields()
        {
            bool finded = false;
            string RoleName = txtRolename.Text;
            string DescripRole = txtDescripRole.Text;
            if (Checkname(RoleName) == true || RoleName.Trim() == string.Empty)
            {
                finded = true;
            }
            if (DescripRole.Trim() == string.Empty)
            {

                finded = true;
            }
            return finded;
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
            string RoleName = txtRolename.Text;
            string DescripRole = txtDescripRole.Text;

            if (CheckFields() == true)
            {
                MetroMessageBox.Show(this, "Debe completar todos los campos", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    ObjRole.Name_role = RoleName;
                    ObjRole.Descrip_role = DescripRole;
                    ObjRole.CreateBy = pIdSession;
                    ApiAccess.CreateRole(ObjRole);
                }
                catch (Exception)
                {
                    throw;
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string RoleName = txtRolename.Text;
            string DescripRole = txtDescripRole.Text;

            if (CheckFields() == true)
            {
                MetroMessageBox.Show(this, "Debe completar todos los campos", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    int Row = dgvRole.CurrentRow.Index;
                    ObjRole.ID_role = Convert.ToInt32(dgvRole[0, Row].Value);
                    ObjRole.Name_role = RoleName;
                    ObjRole.Descrip_role = DescripRole;
                    ObjRole.UpdateBy = pIdSession;
                    ApiAccess.UpdateRole(ObjRole);
                }
                catch (Exception)
                {
                    throw;
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Row = dgvRole.CurrentRow.Index;
            string RoleName = dgvRole[1, Row].Value.ToString();
            if (dgvRole[1, Row].Value == null)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar Al menos Algún Valor para Eliminar. \n Favor Intentelo Nuevamente", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvRole.Focus();
                return;
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Eliminar el Rol de: " + RoleName + "?", "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        ObjRole.ID_role = Convert.ToInt32(dgvRole[0, Row].Value);
                        ObjRole.UpdateBy = pIdSession;
                        ApiAccess.DeleteRole(ObjRole);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    CleanFields();
                    LoadDataGrid();
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CleanFields();
            LoadDataGrid();
        }
        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Row = dgvRole.CurrentRow.Index;
                txtRolename.Text = dgvRole[1, Row].Value.ToString();
                txtDescripRole.Text = dgvRole[2, Row].Value.ToString();
                btnUpdate.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void txtRetrieveByName_TextChanged(object sender, EventArgs e)
        {
            if (txtRetrieveByName.Text == "")
            {
                LoadDataGrid();
                CleanFields();
            }
            else
            {
                try
                {
                    dgvRole.Rows.Clear();
                    ObjRole.Name_role = txtRetrieveByName.Text;
                    var ListRole = ApiAccess.RetrieveAllByNameRole<Role>(ObjRole);
                    foreach (Role element in ListRole)
                    {
                        string[] RowRole;
                        RowRole = new string[] {element.ID_role.ToString(),element.Name_role
                        , element.Descrip_role };
                        dgvRole.Rows.Add(RowRole);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}