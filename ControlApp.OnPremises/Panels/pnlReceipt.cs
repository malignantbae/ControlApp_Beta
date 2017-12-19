﻿using System;
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
    public partial class pnlReceipt : pnlSlider

    {
        ReceiptManagement ApiAccess = new ReceiptManagement(); //ApiAcces Of Class
        PricetagManagement ApiAccess_PriceTag = new PricetagManagement(); //ApiAccess Aux
        //Object instance
        Receipt ObjReceipt = new Receipt();
        Price_tag ObjPrice_Tag = new Price_tag();
        string pIdSession = MystaticValues.IdSession;
        //Global Variables
        int gIdPrice_Tag = 0; 
        decimal gUnit_Price = 0;
        public pnlReceipt(Form owner) : base(owner)
        {
            InitializeComponent();
            this.StyleManager.Update();
            txtTotalReceipt.Enabled = false;
        }
        public void CleanFields()
        {
            txtNameCustomer.Text = "";
            txtQuantity.Text = "";
            txtRetrieveByName.Text = "";
        }
        public void LoadDataGrid()
        {
            try
            {
                dgvReceipt.Rows.Clear();
                var ListReceipt = ApiAccess.RetrieveAllReceipt<Receipt>();
                foreach (Receipt element in ListReceipt)
                {
                    string[] RowPrice;
                    RowPrice = new string[] { element.ID_Receipt.ToString(), element.Customer_name,
                         element.Quantity.ToString(), element.Total_Receipt.ToString(), element.ID_Price_tag.ToString(),
                         element.Unit_Price.ToString(), element.Date_receipt.ToString() };
                    dgvReceipt.Rows.Add(RowPrice);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void LoadPriceTag()
        {
            try
            {
                var ListPricetag = ApiAccess_PriceTag.RetrieveAllPriceTag<Price_tag>();
                foreach (Price_tag element in ListPricetag)
                {
                    gIdPrice_Tag = element.ID_Price_Tag;
                    gUnit_Price = element.Total_Price;
                }   
            }
            catch (Exception)
            {
                throw;
            }
           
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string NameCustomer = txtNameCustomer.Text;
            string Quantity = txtQuantity.Text;
            if (string.IsNullOrEmpty(NameCustomer.Trim()))
            {
                MetroMessageBox.Show(this, "El Cliente -" + NameCustomer + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameCustomer.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Quantity.Trim()))
            {
                MetroMessageBox.Show(this, "La Cantidad -" + Quantity  + "- no es Valida. \n Favor Digite un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }
            try
            {
                
                ObjReceipt.Customer_name = NameCustomer;
                ObjReceipt.Quantity = Convert.ToInt32(Quantity);
                ObjReceipt.Unit_Price = gUnit_Price;
                ObjReceipt.ID_Price_tag = gIdPrice_Tag;
                ObjReceipt.IdSession = pIdSession;
                ApiAccess.CreateReceipt(ObjReceipt);
            }
            catch (Exception)
            {

                throw;
            }
            LoadDataGrid();
            CleanFields();
        }
        private void pnlReceipt_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            LoadPriceTag();
            btnPrint.Enabled = false;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text == "")
            {
                txtTotalReceipt.Text = "";
            }
            else
            {
                int Quantity = Convert.ToInt32(txtQuantity.Text);
                txtTotalReceipt.Text = (Quantity * gUnit_Price).ToString();
            }
        }
    }
}