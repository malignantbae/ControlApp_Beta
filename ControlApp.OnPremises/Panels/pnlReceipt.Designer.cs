namespace ControlApp.OnPremises.Panels
{
    partial class pnlReceipt
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCreate = new MetroFramework.Controls.MetroTile();
            this.btnUpdate = new MetroFramework.Controls.MetroTile();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.txtTotalReceipt = new MetroFramework.Controls.MetroTextBox();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.lblCantidad = new MetroFramework.Controls.MetroLabel();
            this.txtNameCustomer = new MetroFramework.Controls.MetroTextBox();
            this.lblNameCustomer = new MetroFramework.Controls.MetroLabel();
            this.dgvReceipt = new MetroFramework.Controls.MetroGrid();
            this.ID_RECEIPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_CUSTOMER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_RECEIPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PRICE_TAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_RECEIPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRetrieveByName = new MetroFramework.Controls.MetroTextBox();
            this.lblRetrieve = new MetroFramework.Controls.MetroLabel();
            this.btnPrint = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.ActiveControl = null;
            this.btnCreate.Location = new System.Drawing.Point(96, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 60);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Agregar";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveControl = null;
            this.btnUpdate.Location = new System.Drawing.Point(185, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 60);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(45, 131);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 19);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total";
            this.lblTotal.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtTotalReceipt
            // 
            // 
            // 
            // 
            this.txtTotalReceipt.CustomButton.Image = null;
            this.txtTotalReceipt.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtTotalReceipt.CustomButton.Name = "";
            this.txtTotalReceipt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalReceipt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalReceipt.CustomButton.TabIndex = 1;
            this.txtTotalReceipt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalReceipt.CustomButton.UseSelectable = true;
            this.txtTotalReceipt.CustomButton.Visible = false;
            this.txtTotalReceipt.Lines = new string[0];
            this.txtTotalReceipt.Location = new System.Drawing.Point(96, 127);
            this.txtTotalReceipt.MaxLength = 32767;
            this.txtTotalReceipt.Name = "txtTotalReceipt";
            this.txtTotalReceipt.PasswordChar = '\0';
            this.txtTotalReceipt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalReceipt.SelectedText = "";
            this.txtTotalReceipt.SelectionLength = 0;
            this.txtTotalReceipt.SelectionStart = 0;
            this.txtTotalReceipt.ShortcutsEnabled = true;
            this.txtTotalReceipt.Size = new System.Drawing.Size(139, 23);
            this.txtTotalReceipt.TabIndex = 20;
            this.txtTotalReceipt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTotalReceipt.UseSelectable = true;
            this.txtTotalReceipt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalReceipt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(96, 98);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(139, 23);
            this.txtQuantity.TabIndex = 19;
            this.txtQuantity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(19, 102);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 19);
            this.lblCantidad.TabIndex = 18;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtNameCustomer
            // 
            // 
            // 
            // 
            this.txtNameCustomer.CustomButton.Image = null;
            this.txtNameCustomer.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtNameCustomer.CustomButton.Name = "";
            this.txtNameCustomer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameCustomer.CustomButton.TabIndex = 1;
            this.txtNameCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameCustomer.CustomButton.UseSelectable = true;
            this.txtNameCustomer.CustomButton.Visible = false;
            this.txtNameCustomer.Lines = new string[0];
            this.txtNameCustomer.Location = new System.Drawing.Point(96, 69);
            this.txtNameCustomer.MaxLength = 32767;
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.PasswordChar = '\0';
            this.txtNameCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameCustomer.SelectedText = "";
            this.txtNameCustomer.SelectionLength = 0;
            this.txtNameCustomer.SelectionStart = 0;
            this.txtNameCustomer.ShortcutsEnabled = true;
            this.txtNameCustomer.Size = new System.Drawing.Size(139, 23);
            this.txtNameCustomer.TabIndex = 17;
            this.txtNameCustomer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtNameCustomer.UseSelectable = true;
            this.txtNameCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = true;
            this.lblNameCustomer.Location = new System.Drawing.Point(32, 73);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(49, 19);
            this.lblNameCustomer.TabIndex = 16;
            this.lblNameCustomer.Text = "Cliente";
            this.lblNameCustomer.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.AllowUserToAddRows = false;
            this.dgvReceipt.AllowUserToDeleteRows = false;
            this.dgvReceipt.AllowUserToResizeRows = false;
            this.dgvReceipt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceipt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReceipt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_RECEIPT,
            this.NAME_CUSTOMER,
            this.QUANTITY,
            this.TOTAL_RECEIPT,
            this.ID_PRICE_TAG,
            this.UNIT_PRICE,
            this.DATE_RECEIPT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceipt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReceipt.EnableHeadersVisualStyles = false;
            this.dgvReceipt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvReceipt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvReceipt.Location = new System.Drawing.Point(19, 156);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.ReadOnly = true;
            this.dgvReceipt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceipt.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReceipt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceipt.Size = new System.Drawing.Size(631, 376);
            this.dgvReceipt.TabIndex = 15;
            this.dgvReceipt.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ID_RECEIPT
            // 
            this.ID_RECEIPT.HeaderText = "Número ";
            this.ID_RECEIPT.Name = "ID_RECEIPT";
            this.ID_RECEIPT.ReadOnly = true;
            // 
            // NAME_CUSTOMER
            // 
            this.NAME_CUSTOMER.HeaderText = "Cliente";
            this.NAME_CUSTOMER.Name = "NAME_CUSTOMER";
            this.NAME_CUSTOMER.ReadOnly = true;
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "Cantidad";
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ReadOnly = true;
            // 
            // TOTAL_RECEIPT
            // 
            this.TOTAL_RECEIPT.HeaderText = "Total";
            this.TOTAL_RECEIPT.Name = "TOTAL_RECEIPT";
            this.TOTAL_RECEIPT.ReadOnly = true;
            // 
            // ID_PRICE_TAG
            // 
            this.ID_PRICE_TAG.HeaderText = "ID_PRICE_TAG";
            this.ID_PRICE_TAG.Name = "ID_PRICE_TAG";
            this.ID_PRICE_TAG.ReadOnly = true;
            this.ID_PRICE_TAG.Visible = false;
            // 
            // UNIT_PRICE
            // 
            this.UNIT_PRICE.HeaderText = "UNIT_PRICE";
            this.UNIT_PRICE.Name = "UNIT_PRICE";
            this.UNIT_PRICE.ReadOnly = true;
            this.UNIT_PRICE.Visible = false;
            // 
            // DATE_RECEIPT
            // 
            this.DATE_RECEIPT.HeaderText = "Fecha";
            this.DATE_RECEIPT.Name = "DATE_RECEIPT";
            this.DATE_RECEIPT.ReadOnly = true;
            // 
            // txtRetrieveByName
            // 
            // 
            // 
            // 
            this.txtRetrieveByName.CustomButton.Image = null;
            this.txtRetrieveByName.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtRetrieveByName.CustomButton.Name = "";
            this.txtRetrieveByName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRetrieveByName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRetrieveByName.CustomButton.TabIndex = 1;
            this.txtRetrieveByName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRetrieveByName.CustomButton.UseSelectable = true;
            this.txtRetrieveByName.CustomButton.Visible = false;
            this.txtRetrieveByName.Lines = new string[0];
            this.txtRetrieveByName.Location = new System.Drawing.Point(542, 69);
            this.txtRetrieveByName.MaxLength = 32767;
            this.txtRetrieveByName.Name = "txtRetrieveByName";
            this.txtRetrieveByName.PasswordChar = '\0';
            this.txtRetrieveByName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRetrieveByName.SelectedText = "";
            this.txtRetrieveByName.SelectionLength = 0;
            this.txtRetrieveByName.SelectionStart = 0;
            this.txtRetrieveByName.ShortcutsEnabled = true;
            this.txtRetrieveByName.Size = new System.Drawing.Size(135, 23);
            this.txtRetrieveByName.TabIndex = 38;
            this.txtRetrieveByName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtRetrieveByName.UseSelectable = true;
            this.txtRetrieveByName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRetrieveByName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblRetrieve
            // 
            this.lblRetrieve.AutoSize = true;
            this.lblRetrieve.Location = new System.Drawing.Point(489, 73);
            this.lblRetrieve.Name = "lblRetrieve";
            this.lblRetrieve.Size = new System.Drawing.Size(47, 19);
            this.lblRetrieve.TabIndex = 39;
            this.lblRetrieve.Text = "Buscar";
            this.lblRetrieve.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveControl = null;
            this.btnPrint.Location = new System.Drawing.Point(274, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 60);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtRetrieveByName);
            this.Controls.Add(this.lblRetrieve);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotalReceipt);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtNameCustomer);
            this.Controls.Add(this.lblNameCustomer);
            this.Controls.Add(this.dgvReceipt);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnUpdate);
            this.Name = "pnlReceipt";
            this.Size = new System.Drawing.Size(697, 574);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.pnlReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnCreate;
        private MetroFramework.Controls.MetroTile btnUpdate;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroTextBox txtTotalReceipt;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroLabel lblCantidad;
        private MetroFramework.Controls.MetroTextBox txtNameCustomer;
        private MetroFramework.Controls.MetroLabel lblNameCustomer;
        private MetroFramework.Controls.MetroGrid dgvReceipt;
        private MetroFramework.Controls.MetroTextBox txtRetrieveByName;
        private MetroFramework.Controls.MetroLabel lblRetrieve;
        private MetroFramework.Controls.MetroTile btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_RECEIPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_CUSTOMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_RECEIPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRICE_TAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_RECEIPT;
    }
}
