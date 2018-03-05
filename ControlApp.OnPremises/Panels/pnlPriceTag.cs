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
using System.Globalization;
using System.Text.RegularExpressions;

namespace ControlApp.OnPremises.Panels
{
    public partial class pnlPriceTag : pnlSlider
    {
        PricetagManagement ApiAccess = new PricetagManagement();
        Price_tag ObjPrice = new Price_tag();
        string pIdSession = MystaticValues.IdSession;
        public pnlPriceTag(Form owner) : base(owner)
        {
            InitializeComponent();
            this.StyleManager.Update();
        }
        public void CleanFields()
        {
            txtPriceTag.Text = "";
            txtDescripPrice.Text = "";
        }
        public void LoadDataGrid()
        {
            try
            {
                dgvPriceTag.Rows.Clear();
                var ListPricetag = ApiAccess.RetrieveAllPriceTag<Price_tag>();
                foreach (Price_tag element in ListPricetag)
                {
                    string[] RowPrice;
                    RowPrice = new string[] { element.ID_Price_Tag.ToString(), element.Descrip_Price ,element.Total_Price.ToString()};
                    dgvPriceTag.Rows.Add(RowPrice);
                } 
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void pnlPriceTag_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            btnUpdate.Enabled = false;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string DescripPrice = txtDescripPrice.Text;
            string PriceTag = txtPriceTag.Text;
            if (string.IsNullOrEmpty(DescripPrice.Trim()))
            {
                MetroMessageBox.Show(this, "La Descripción -" + DescripPrice + "- no es Valida. \n Favor Digite una Descripción Valida", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripPrice.Focus();
                return;
            }
            if (string.IsNullOrEmpty(PriceTag.Trim()))
            {
                MetroMessageBox.Show(this, "El Precio -" + PriceTag + "- no es Valido. \n Favor Digite un Precio Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripPrice.Focus();
                return;
            }
            else
            {
                try
                {
                    ObjPrice.Descrip_Price = DescripPrice;
                    ObjPrice.Total_Price = Convert.ToDecimal(PriceTag);
                    ObjPrice.IdSession = pIdSession;
                    ApiAccess.CreatePriceTag(ObjPrice);
                }
                catch (Exception)
                {

                    throw;
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private bool CheckPrice(string pPrice)
        {
            try
            {
                bool finded = false;
                ObjPrice.Descrip_Price = pPrice;
                var ListPrice = ApiAccess.RetrieveAllByNameDescrip<Price_tag>(ObjPrice);
                foreach (Price_tag element in ListPrice)
                {
                    if (element.Descrip_Price == pPrice)
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string DescripPrice = txtDescripPrice.Text;
            string PriceTag = txtPriceTag.Text;
            if (string.IsNullOrEmpty(DescripPrice.Trim()))
            {
                MetroMessageBox.Show(this, "La Descripción -" + DescripPrice + "- no es Valida. \n Favor Digite una Descripción Valida", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripPrice.Focus();
                return;
            }
            if (string.IsNullOrEmpty(PriceTag.Trim()))
            {
                MetroMessageBox.Show(this, "El Precio -" + PriceTag + "- no es Valido. \n Favor Digite un Precio Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripPrice.Focus();
                return;
            }
            try
            {
                int Row = dgvPriceTag.CurrentRow.Index;
                ObjPrice.ID_Price_Tag = Convert.ToInt32(dgvPriceTag[0, Row].Value);
                ObjPrice.Descrip_Price = DescripPrice;
                ObjPrice.IdSession = pIdSession;
                ObjPrice.Total_Price = Convert.ToDecimal(txtPriceTag.Text);
                ApiAccess.UpdatePriceTag(ObjPrice);
            }
            catch (Exception)
            {

                throw;
            }
            CleanFields();
            LoadDataGrid();
        }
        private void txtPriceTag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (Regex.IsMatch(
                 txtPriceTag.Text,
                 "^\\d*\\.\\d{2}$"))
                    e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;

        }
        private void dgvPriceTag_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Row = dgvPriceTag.CurrentRow.Index;
                txtPriceTag.Text = dgvPriceTag[2, Row].Value.ToString();
                txtDescripPrice.Text = dgvPriceTag[1, Row].Value.ToString();
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
                    dgvPriceTag.Rows.Clear();
                    ObjPrice.Descrip_Price = txtRetrieveByName.Text;
                    var ListPrice = ApiAccess.RetrieveAllByNameDescrip<Price_tag>(ObjPrice);
                    foreach (Price_tag element in ListPrice)
                    {
                        string[] RowPrice;
                        RowPrice = new string[] { element.ID_Price_Tag.ToString(), element.Descrip_Price, element.Total_Price.ToString()};
                        dgvPriceTag.Rows.Add(RowPrice);
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
