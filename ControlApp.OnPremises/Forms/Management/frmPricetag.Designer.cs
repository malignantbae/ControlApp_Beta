namespace ControlApp.OnPremises.Forms
{
    partial class frmPricetag
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabfrmRecibos = new System.Windows.Forms.TabControl();
            this.tabcreateReceipt = new System.Windows.Forms.TabPage();
            this.lblPrice_tag = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtTotalReceipt = new System.Windows.Forms.TextBox();
            this.lblTotalReceipt = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtNReceipt = new System.Windows.Forms.TextBox();
            this.lblNReceipt = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.tabupdateReceipt = new System.Windows.Forms.TabPage();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.tabfrmRecibos.SuspendLayout();
            this.tabcreateReceipt.SuspendLayout();
            this.tabupdateReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // tabfrmRecibos
            // 
            this.tabfrmRecibos.Controls.Add(this.tabcreateReceipt);
            this.tabfrmRecibos.Controls.Add(this.tabupdateReceipt);
            this.tabfrmRecibos.Location = new System.Drawing.Point(36, 29);
            this.tabfrmRecibos.Name = "tabfrmRecibos";
            this.tabfrmRecibos.SelectedIndex = 0;
            this.tabfrmRecibos.Size = new System.Drawing.Size(514, 289);
            this.tabfrmRecibos.TabIndex = 11;
            this.tabfrmRecibos.Tag = "";
            // 
            // tabcreateReceipt
            // 
            this.tabcreateReceipt.Controls.Add(this.lblPrice_tag);
            this.tabcreateReceipt.Controls.Add(this.txtQuantity);
            this.tabcreateReceipt.Controls.Add(this.lblQuantity);
            this.tabcreateReceipt.Controls.Add(this.btnPrint);
            this.tabcreateReceipt.Controls.Add(this.txtTotalReceipt);
            this.tabcreateReceipt.Controls.Add(this.lblTotalReceipt);
            this.tabcreateReceipt.Controls.Add(this.txtCustomer);
            this.tabcreateReceipt.Controls.Add(this.lblCustomer);
            this.tabcreateReceipt.Controls.Add(this.txtNReceipt);
            this.tabcreateReceipt.Controls.Add(this.lblNReceipt);
            this.tabcreateReceipt.Controls.Add(this.txtDate);
            this.tabcreateReceipt.Controls.Add(this.lblDate);
            this.tabcreateReceipt.Location = new System.Drawing.Point(4, 22);
            this.tabcreateReceipt.Name = "tabcreateReceipt";
            this.tabcreateReceipt.Padding = new System.Windows.Forms.Padding(3);
            this.tabcreateReceipt.Size = new System.Drawing.Size(506, 263);
            this.tabcreateReceipt.TabIndex = 1;
            this.tabcreateReceipt.Text = "Registro Recibos";
            this.tabcreateReceipt.UseVisualStyleBackColor = true;
            // 
            // lblPrice_tag
            // 
            this.lblPrice_tag.AutoSize = true;
            this.lblPrice_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice_tag.Location = new System.Drawing.Point(225, 141);
            this.lblPrice_tag.Name = "lblPrice_tag";
            this.lblPrice_tag.Size = new System.Drawing.Size(73, 16);
            this.lblPrice_tag.TabIndex = 32;
            this.lblPrice_tag.Text = "Cantidad * ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(119, 126);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 31);
            this.txtQuantity.TabIndex = 31;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(12, 141);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 16);
            this.lblQuantity.TabIndex = 30;
            this.lblQuantity.Text = "Cantidad";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(119, 200);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 50);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "Guardar e Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // txtTotalReceipt
            // 
            this.txtTotalReceipt.Location = new System.Drawing.Point(119, 163);
            this.txtTotalReceipt.Multiline = true;
            this.txtTotalReceipt.Name = "txtTotalReceipt";
            this.txtTotalReceipt.Size = new System.Drawing.Size(100, 31);
            this.txtTotalReceipt.TabIndex = 28;
            // 
            // lblTotalReceipt
            // 
            this.lblTotalReceipt.AutoSize = true;
            this.lblTotalReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReceipt.Location = new System.Drawing.Point(12, 178);
            this.lblTotalReceipt.Name = "lblTotalReceipt";
            this.lblTotalReceipt.Size = new System.Drawing.Size(79, 16);
            this.lblTotalReceipt.TabIndex = 27;
            this.lblTotalReceipt.Text = "Monto Total";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(119, 89);
            this.txtCustomer.Multiline = true;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(214, 31);
            this.txtCustomer.TabIndex = 26;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(12, 104);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(101, 16);
            this.lblCustomer.TabIndex = 25;
            this.lblCustomer.Text = "Nombre Cliente";
            // 
            // txtNReceipt
            // 
            this.txtNReceipt.Location = new System.Drawing.Point(119, 52);
            this.txtNReceipt.Multiline = true;
            this.txtNReceipt.Name = "txtNReceipt";
            this.txtNReceipt.Size = new System.Drawing.Size(100, 31);
            this.txtNReceipt.TabIndex = 24;
            // 
            // lblNReceipt
            // 
            this.lblNReceipt.AutoSize = true;
            this.lblNReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNReceipt.Location = new System.Drawing.Point(12, 67);
            this.lblNReceipt.Name = "lblNReceipt";
            this.lblNReceipt.Size = new System.Drawing.Size(69, 16);
            this.lblNReceipt.TabIndex = 23;
            this.lblNReceipt.Text = "N- Recibo";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(119, 15);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 31);
            this.txtDate.TabIndex = 22;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 16);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Fecha";
            // 
            // tabupdateReceipt
            // 
            this.tabupdateReceipt.Controls.Add(this.btnDestroy);
            this.tabupdateReceipt.Controls.Add(this.textBox1);
            this.tabupdateReceipt.Controls.Add(this.label1);
            this.tabupdateReceipt.Controls.Add(this.dgvReceipt);
            this.tabupdateReceipt.Location = new System.Drawing.Point(4, 22);
            this.tabupdateReceipt.Name = "tabupdateReceipt";
            this.tabupdateReceipt.Padding = new System.Windows.Forms.Padding(3);
            this.tabupdateReceipt.Size = new System.Drawing.Size(506, 263);
            this.tabupdateReceipt.TabIndex = 2;
            this.tabupdateReceipt.Text = "Modificar Recibos";
            this.tabupdateReceipt.UseVisualStyleBackColor = true;
            // 
            // btnDestroy
            // 
            this.btnDestroy.Location = new System.Drawing.Point(193, 226);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(100, 31);
            this.btnDestroy.TabIndex = 30;
            this.btnDestroy.Text = "Anular Recibo";
            this.btnDestroy.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 226);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "N- Recibo";
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Location = new System.Drawing.Point(6, 6);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.Size = new System.Drawing.Size(495, 214);
            this.dgvReceipt.TabIndex = 0;
            // 
            // frmPricetag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 440);
            this.Controls.Add(this.tabfrmRecibos);
            this.Name = "frmPricetag";
            this.Text = "frmPricetag";
            this.tabfrmRecibos.ResumeLayout(false);
            this.tabcreateReceipt.ResumeLayout(false);
            this.tabcreateReceipt.PerformLayout();
            this.tabupdateReceipt.ResumeLayout(false);
            this.tabupdateReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabfrmRecibos;
        private System.Windows.Forms.TabPage tabcreateReceipt;
        private System.Windows.Forms.Label lblPrice_tag;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtTotalReceipt;
        private System.Windows.Forms.Label lblTotalReceipt;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtNReceipt;
        private System.Windows.Forms.Label lblNReceipt;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TabPage tabupdateReceipt;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReceipt;
    }
}