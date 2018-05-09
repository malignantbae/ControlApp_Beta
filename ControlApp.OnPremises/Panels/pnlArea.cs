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
    public partial class pnlArea : pnlSlider
    {
        AreaManagement ApiAccess = new AreaManagement();
        Area ObjArea = new Area();
        string pIdSession = MystaticValues.IdSession;
        public pnlArea(Form owner) : base(owner)
        {
            InitializeComponent();
            this.StyleManager.Update();
        }
        public void CleanFields()
        {
            txtAreaname.Text = "";
            txtRetrieveByName.Text  = "";
        }
        private void LoadDataGrid()
        {
            try
            {
                dgvArea.Rows.Clear();
                var ListArea = ApiAccess.RetrieveAllArea<Area>();
                foreach (Area element in ListArea)
                {
                    string[] RowArea;
                    RowArea = new string[] { element.ID_Area.ToString(), element.Area_name };
                    dgvArea.Rows.Add(RowArea);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        private void pnlArea_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            btnUpdate.Enabled = false;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string AreaName = txtAreaname.Text;
            if (Checkname(AreaName) == true || AreaName.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this,"El Nombre -" + AreaName + "- no es Valido. \n Favor Digite un Nombre Valido","Error en Validación",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtAreaname.Focus();
            }
            else
            {
                try
                {
                    ObjArea.Area_name = AreaName;
                    ObjArea.IdSession = pIdSession;
                    ApiAccess.CreateArea(ObjArea);
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
            string AreaName = txtAreaname.Text;
            if (AreaName.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Nombre -" + AreaName + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAreaname.Focus();
            }
            else
            {
                try
                {
                    int Row = dgvArea.CurrentRow.Index;
                    ObjArea.ID_Area = Convert.ToInt32(dgvArea[0, Row].Value);
                    ObjArea.IdSession = pIdSession;
                    ObjArea.Area_name = txtAreaname.Text;
                    ApiAccess.UpdateArea(ObjArea);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            CleanFields();
            LoadDataGrid();
        }
        private void dgvArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Row = dgvArea.CurrentRow.Index;
                txtAreaname.Text = dgvArea[1, Row].Value.ToString();
                btnUpdate.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void txtRetrieveByName_TextChanged(object sender, EventArgs e)
        {
            if(txtRetrieveByName.Text == "")
            {
                LoadDataGrid();
                CleanFields();
            }
            else
            {
                try
                {
                    dgvArea.Rows.Clear();
                    ObjArea.Area_name = txtRetrieveByName.Text;
                    var ListArea = ApiAccess.RetrieveAllByNameArea<Area>(ObjArea);
                    foreach (Area element in ListArea)
                    {
                        string[] RowArea;
                        RowArea = new string[] { element.ID_Area.ToString(), element.Area_name };
                        dgvArea.Rows.Add(RowArea);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }
        private bool Checkname(string pAreaName)
        {
            try
            {
                bool finded = false;
                ObjArea.Area_name = pAreaName;
                var ListArea = ApiAccess.RetrieveAllByNameArea<Area>(ObjArea);
                foreach (Area element in ListArea)
                {
                    if (element.Area_name == pAreaName)
                    {
                        finded = true;
                        if(finded == true)
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CleanFields();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Row = dgvArea.CurrentRow.Index;
            string AreaName = dgvArea[1, Row].Value.ToString();
            if (dgvArea[1, Row].Value == null)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar Al menos Algún Valor para Inactivar. \n Favor Intentelo Nuevamente", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvArea.Focus();
                return;
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Eliminar el Area de: " + AreaName + "?", "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        ObjArea.ID_Area = Convert.ToInt32(dgvArea[0, Row].Value);
                        ObjArea.IdSession = pIdSession;
                        ApiAccess.DeleteArea(ObjArea);
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
    }
}
