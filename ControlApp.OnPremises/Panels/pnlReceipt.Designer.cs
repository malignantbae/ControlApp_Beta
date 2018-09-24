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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCreate = new MetroFramework.Controls.MetroTile();
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
            this.CASH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHANGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_RECEIPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRetrieveByName = new MetroFramework.Controls.MetroTextBox();
            this.lblRetrieve = new MetroFramework.Controls.MetroLabel();
            this.btnPrint = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnCleanFields = new MetroFramework.Controls.MetroTile();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.mtPrincipal = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.lblStock = new MetroFramework.Controls.MetroLabel();
            this.txtStock = new MetroFramework.Controls.MetroTextBox();
            this.btnStock = new MetroFramework.Controls.MetroTile();
            this.txtCambio = new MetroFramework.Controls.MetroTextBox();
            this.lblCambio = new MetroFramework.Controls.MetroLabel();
            this.txtCash = new MetroFramework.Controls.MetroTextBox();
            this.lblCash = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new MetroFramework.Controls.MetroTile();
            this.btnLoadRpt = new MetroFramework.Controls.MetroTile();
            this.lblEnd = new MetroFramework.Controls.MetroLabel();
            this.lblBegin = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.mtPrincipal.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.ActiveControl = null;
            this.btnCreate.Location = new System.Drawing.Point(3, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 60);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Agregar";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(46, 138);
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
            this.txtTotalReceipt.Location = new System.Drawing.Point(92, 134);
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
            this.txtTotalReceipt.TextChanged += new System.EventHandler(this.txtTotalReceipt_TextChanged);
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
            this.txtQuantity.Location = new System.Drawing.Point(92, 105);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(139, 23);
            this.txtQuantity.TabIndex = 2;
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
            this.lblCantidad.Location = new System.Drawing.Point(20, 109);
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
            this.txtNameCustomer.Location = new System.Drawing.Point(92, 76);
            this.txtNameCustomer.MaxLength = 32767;
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.PasswordChar = '\0';
            this.txtNameCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameCustomer.SelectedText = "";
            this.txtNameCustomer.SelectionLength = 0;
            this.txtNameCustomer.SelectionStart = 0;
            this.txtNameCustomer.ShortcutsEnabled = true;
            this.txtNameCustomer.Size = new System.Drawing.Size(139, 23);
            this.txtNameCustomer.TabIndex = 1;
            this.txtNameCustomer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtNameCustomer.UseSelectable = true;
            this.txtNameCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = true;
            this.lblNameCustomer.Location = new System.Drawing.Point(28, 80);
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
            this.CASH,
            this.CHANGE,
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
            this.dgvReceipt.Location = new System.Drawing.Point(3, 221);
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
            this.dgvReceipt.Size = new System.Drawing.Size(660, 290);
            this.dgvReceipt.TabIndex = 15;
            this.dgvReceipt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvReceipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceipt_CellClick);
            // 
            // ID_RECEIPT
            // 
            this.ID_RECEIPT.HeaderText = "Número ";
            this.ID_RECEIPT.Name = "ID_RECEIPT";
            this.ID_RECEIPT.ReadOnly = true;
            this.ID_RECEIPT.Width = 55;
            // 
            // NAME_CUSTOMER
            // 
            this.NAME_CUSTOMER.HeaderText = "Cliente";
            this.NAME_CUSTOMER.Name = "NAME_CUSTOMER";
            this.NAME_CUSTOMER.ReadOnly = true;
            this.NAME_CUSTOMER.Width = 70;
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "Cantidad";
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ReadOnly = true;
            this.QUANTITY.Width = 65;
            // 
            // TOTAL_RECEIPT
            // 
            this.TOTAL_RECEIPT.HeaderText = "Total";
            this.TOTAL_RECEIPT.Name = "TOTAL_RECEIPT";
            this.TOTAL_RECEIPT.ReadOnly = true;
            this.TOTAL_RECEIPT.Width = 75;
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
            // CASH
            // 
            this.CASH.HeaderText = "Efectivo";
            this.CASH.Name = "CASH";
            this.CASH.ReadOnly = true;
            // 
            // CHANGE
            // 
            this.CHANGE.HeaderText = "Cambio";
            this.CHANGE.Name = "CHANGE";
            this.CHANGE.ReadOnly = true;
            // 
            // DATE_RECEIPT
            // 
            this.DATE_RECEIPT.HeaderText = "Fecha";
            this.DATE_RECEIPT.Name = "DATE_RECEIPT";
            this.DATE_RECEIPT.ReadOnly = true;
            this.DATE_RECEIPT.Width = 130;
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
            this.txtRetrieveByName.Location = new System.Drawing.Point(531, 6);
            this.txtRetrieveByName.MaxLength = 32767;
            this.txtRetrieveByName.Name = "txtRetrieveByName";
            this.txtRetrieveByName.PasswordChar = '\0';
            this.txtRetrieveByName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRetrieveByName.SelectedText = "";
            this.txtRetrieveByName.SelectionLength = 0;
            this.txtRetrieveByName.SelectionStart = 0;
            this.txtRetrieveByName.ShortcutsEnabled = true;
            this.txtRetrieveByName.Size = new System.Drawing.Size(135, 23);
            this.txtRetrieveByName.TabIndex = 5;
            this.txtRetrieveByName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtRetrieveByName.UseSelectable = true;
            this.txtRetrieveByName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRetrieveByName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRetrieveByName.TextChanged += new System.EventHandler(this.txtRetrieveByName_TextChanged);
            // 
            // lblRetrieve
            // 
            this.lblRetrieve.AutoSize = true;
            this.lblRetrieve.Location = new System.Drawing.Point(475, 10);
            this.lblRetrieve.Name = "lblRetrieve";
            this.lblRetrieve.Size = new System.Drawing.Size(47, 19);
            this.lblRetrieve.TabIndex = 39;
            this.lblRetrieve.Text = "Buscar";
            this.lblRetrieve.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveControl = null;
            this.btnPrint.Location = new System.Drawing.Point(92, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 60);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.Location = new System.Drawing.Point(181, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 60);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Anular";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCleanFields
            // 
            this.btnCleanFields.ActiveControl = null;
            this.btnCleanFields.Location = new System.Drawing.Point(270, 6);
            this.btnCleanFields.Name = "btnCleanFields";
            this.btnCleanFields.Size = new System.Drawing.Size(83, 60);
            this.btnCleanFields.TabIndex = 55;
            this.btnCleanFields.Text = "Refrescar";
            this.btnCleanFields.UseSelectable = true;
            this.btnCleanFields.Click += new System.EventHandler(this.btnCleanFields_Click);
            // 
            // mtPrincipal
            // 
            this.mtPrincipal.Controls.Add(this.metroTabPage1);
            this.mtPrincipal.Controls.Add(this.metroTabPage2);
            this.mtPrincipal.Location = new System.Drawing.Point(3, 3);
            this.mtPrincipal.Name = "mtPrincipal";
            this.mtPrincipal.SelectedIndex = 0;
            this.mtPrincipal.Size = new System.Drawing.Size(674, 549);
            this.mtPrincipal.TabIndex = 56;
            this.mtPrincipal.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtPrincipal.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.Controls.Add(this.lblStock);
            this.metroTabPage1.Controls.Add(this.txtStock);
            this.metroTabPage1.Controls.Add(this.btnStock);
            this.metroTabPage1.Controls.Add(this.txtCambio);
            this.metroTabPage1.Controls.Add(this.lblCambio);
            this.metroTabPage1.Controls.Add(this.txtCash);
            this.metroTabPage1.Controls.Add(this.lblCash);
            this.metroTabPage1.Controls.Add(this.dgvReceipt);
            this.metroTabPage1.Controls.Add(this.txtRetrieveByName);
            this.metroTabPage1.Controls.Add(this.lblRetrieve);
            this.metroTabPage1.Controls.Add(this.btnCleanFields);
            this.metroTabPage1.Controls.Add(this.lblTotal);
            this.metroTabPage1.Controls.Add(this.btnDelete);
            this.metroTabPage1.Controls.Add(this.txtTotalReceipt);
            this.metroTabPage1.Controls.Add(this.btnCreate);
            this.metroTabPage1.Controls.Add(this.txtQuantity);
            this.metroTabPage1.Controls.Add(this.btnPrint);
            this.metroTabPage1.Controls.Add(this.lblCantidad);
            this.metroTabPage1.Controls.Add(this.txtNameCustomer);
            this.metroTabPage1.Controls.Add(this.lblNameCustomer);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(666, 507);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Recibos";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroGrid1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(237, 72);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(429, 143);
            this.metroPanel1.TabIndex = 63;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 66);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(429, 78);
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(475, 39);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(66, 19);
            this.lblStock.TabIndex = 62;
            this.lblStock.Text = "Inventario";
            this.lblStock.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtStock
            // 
            // 
            // 
            // 
            this.txtStock.CustomButton.Image = null;
            this.txtStock.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtStock.CustomButton.Name = "";
            this.txtStock.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStock.CustomButton.TabIndex = 1;
            this.txtStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStock.CustomButton.UseSelectable = true;
            this.txtStock.CustomButton.Visible = false;
            this.txtStock.Enabled = false;
            this.txtStock.Lines = new string[0];
            this.txtStock.Location = new System.Drawing.Point(547, 35);
            this.txtStock.MaxLength = 32767;
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStock.SelectedText = "";
            this.txtStock.SelectionLength = 0;
            this.txtStock.SelectionStart = 0;
            this.txtStock.ShortcutsEnabled = true;
            this.txtStock.Size = new System.Drawing.Size(119, 23);
            this.txtStock.TabIndex = 61;
            this.txtStock.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtStock.UseSelectable = true;
            this.txtStock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnStock
            // 
            this.btnStock.ActiveControl = null;
            this.btnStock.Location = new System.Drawing.Point(359, 6);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(93, 60);
            this.btnStock.Style = MetroFramework.MetroColorStyle.Red;
            this.btnStock.TabIndex = 60;
            this.btnStock.Text = "Cerrar Stock";
            this.btnStock.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnStock.UseSelectable = true;
            this.btnStock.Visible = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // txtCambio
            // 
            // 
            // 
            // 
            this.txtCambio.CustomButton.Image = null;
            this.txtCambio.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtCambio.CustomButton.Name = "";
            this.txtCambio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCambio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCambio.CustomButton.TabIndex = 1;
            this.txtCambio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCambio.CustomButton.UseSelectable = true;
            this.txtCambio.CustomButton.Visible = false;
            this.txtCambio.Enabled = false;
            this.txtCambio.Lines = new string[0];
            this.txtCambio.Location = new System.Drawing.Point(92, 192);
            this.txtCambio.MaxLength = 32767;
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.PasswordChar = '\0';
            this.txtCambio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCambio.SelectedText = "";
            this.txtCambio.SelectionLength = 0;
            this.txtCambio.SelectionStart = 0;
            this.txtCambio.ShortcutsEnabled = true;
            this.txtCambio.Size = new System.Drawing.Size(139, 23);
            this.txtCambio.TabIndex = 59;
            this.txtCambio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCambio.UseSelectable = true;
            this.txtCambio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCambio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(30, 196);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(56, 19);
            this.lblCambio.TabIndex = 58;
            this.lblCambio.Text = "Cambio";
            this.lblCambio.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtCash
            // 
            // 
            // 
            // 
            this.txtCash.CustomButton.Image = null;
            this.txtCash.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtCash.CustomButton.Name = "";
            this.txtCash.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCash.CustomButton.TabIndex = 1;
            this.txtCash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCash.CustomButton.UseSelectable = true;
            this.txtCash.CustomButton.Visible = false;
            this.txtCash.Enabled = false;
            this.txtCash.Lines = new string[0];
            this.txtCash.Location = new System.Drawing.Point(92, 163);
            this.txtCash.MaxLength = 32767;
            this.txtCash.Name = "txtCash";
            this.txtCash.PasswordChar = '\0';
            this.txtCash.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCash.SelectedText = "";
            this.txtCash.SelectionLength = 0;
            this.txtCash.SelectionStart = 0;
            this.txtCash.ShortcutsEnabled = true;
            this.txtCash.Size = new System.Drawing.Size(139, 23);
            this.txtCash.TabIndex = 3;
            this.txtCash.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCash.UseSelectable = true;
            this.txtCash.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCash.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(28, 167);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(54, 19);
            this.lblCash.TabIndex = 56;
            this.lblCash.Text = "Efectivo";
            this.lblCash.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.dtEnd);
            this.metroTabPage2.Controls.Add(this.dtBegin);
            this.metroTabPage2.Controls.Add(this.btnRefresh);
            this.metroTabPage2.Controls.Add(this.btnLoadRpt);
            this.metroTabPage2.Controls.Add(this.lblEnd);
            this.metroTabPage2.Controls.Add(this.lblBegin);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(666, 507);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Reportes";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(92, 102);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(168, 20);
            this.dtEnd.TabIndex = 21;
            // 
            // dtBegin
            // 
            this.dtBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBegin.Location = new System.Drawing.Point(92, 76);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(168, 20);
            this.dtBegin.TabIndex = 20;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveControl = null;
            this.btnRefresh.Location = new System.Drawing.Point(92, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 60);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseSelectable = true;
            // 
            // btnLoadRpt
            // 
            this.btnLoadRpt.ActiveControl = null;
            this.btnLoadRpt.Location = new System.Drawing.Point(3, 3);
            this.btnLoadRpt.Name = "btnLoadRpt";
            this.btnLoadRpt.Size = new System.Drawing.Size(83, 60);
            this.btnLoadRpt.TabIndex = 14;
            this.btnLoadRpt.Text = "Generar";
            this.btnLoadRpt.UseSelectable = true;
            this.btnLoadRpt.Click += new System.EventHandler(this.btnLoadRpt_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(3, 103);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(64, 19);
            this.lblEnd.TabIndex = 5;
            this.lblEnd.Text = "Fecha Fin";
            this.lblEnd.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Location = new System.Drawing.Point(3, 77);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(77, 19);
            this.lblBegin.TabIndex = 3;
            this.lblBegin.Text = "Fecha Inicio";
            this.lblBegin.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pnlReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtPrincipal);
            this.Name = "pnlReceipt";
            this.Size = new System.Drawing.Size(683, 574);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.pnlReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.mtPrincipal.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnCreate;
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
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnCleanFields;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroTabControl mtPrincipal;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private MetroFramework.Controls.MetroTile btnRefresh;
        private MetroFramework.Controls.MetroTile btnLoadRpt;
        private MetroFramework.Controls.MetroLabel lblEnd;
        private MetroFramework.Controls.MetroLabel lblBegin;
        private MetroFramework.Controls.MetroTextBox txtCambio;
        private MetroFramework.Controls.MetroLabel lblCambio;
        private MetroFramework.Controls.MetroTextBox txtCash;
        private MetroFramework.Controls.MetroLabel lblCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_RECEIPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_CUSTOMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_RECEIPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRICE_TAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CASH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHANGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_RECEIPT;
        private MetroFramework.Controls.MetroTile btnStock;
        private MetroFramework.Controls.MetroLabel lblStock;
        private MetroFramework.Controls.MetroTextBox txtStock;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}
