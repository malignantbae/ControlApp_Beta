namespace ControlApp.OnPremises.Forms.Dashboard
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnReceipt = new MetroFramework.Controls.MetroTile();
            this.mtPriceTag = new MetroFramework.Controls.MetroTile();
            this.mtAdPrecios = new MetroFramework.Controls.MetroTile();
            this.mtArea = new MetroFramework.Controls.MetroTile();
            this.mtAdmArea = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mtAdmReceipt = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroPanel1.Controls.Add(this.mtAdmReceipt);
            this.metroPanel1.Controls.Add(this.btnReceipt);
            this.metroPanel1.Controls.Add(this.mtAdPrecios);
            this.metroPanel1.Controls.Add(this.mtPriceTag);
            this.metroPanel1.Controls.Add(this.mtArea);
            this.metroPanel1.Controls.Add(this.mtAdmArea);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 574);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnReceipt
            // 
            this.btnReceipt.ActiveControl = null;
            this.btnReceipt.Location = new System.Drawing.Point(0, 468);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(200, 89);
            this.btnReceipt.TabIndex = 4;
            this.btnReceipt.Text = "Recibos";
            this.btnReceipt.UseSelectable = true;
            this.btnReceipt.Click += new System.EventHandler(this.mtReceipt_Click);
            // 
            // mtPriceTag
            // 
            this.mtPriceTag.ActiveControl = null;
            this.mtPriceTag.Location = new System.Drawing.Point(0, 278);
            this.mtPriceTag.Name = "mtPriceTag";
            this.mtPriceTag.Size = new System.Drawing.Size(200, 89);
            this.mtPriceTag.TabIndex = 8;
            this.mtPriceTag.Text = "Precios";
            this.mtPriceTag.UseSelectable = true;
            this.mtPriceTag.Click += new System.EventHandler(this.mtPriceTag_Click);
            // 
            // mtAdPrecios
            // 
            this.mtAdPrecios.ActiveControl = null;
            this.mtAdPrecios.Location = new System.Drawing.Point(0, 183);
            this.mtAdPrecios.Name = "mtAdPrecios";
            this.mtAdPrecios.Size = new System.Drawing.Size(200, 89);
            this.mtAdPrecios.TabIndex = 7;
            this.mtAdPrecios.Text = "Ad Precios";
            this.mtAdPrecios.UseSelectable = true;
            this.mtAdPrecios.Click += new System.EventHandler(this.mtAdPrecios_Click);
            // 
            // mtArea
            // 
            this.mtArea.ActiveControl = null;
            this.mtArea.Location = new System.Drawing.Point(0, 88);
            this.mtArea.Name = "mtArea";
            this.mtArea.Size = new System.Drawing.Size(200, 89);
            this.mtArea.TabIndex = 5;
            this.mtArea.Text = "Areas";
            this.mtArea.UseSelectable = true;
            this.mtArea.Click += new System.EventHandler(this.mtArea_Click);
            // 
            // mtAdmArea
            // 
            this.mtAdmArea.ActiveControl = null;
            this.mtAdmArea.Location = new System.Drawing.Point(0, 3);
            this.mtAdmArea.Name = "mtAdmArea";
            this.mtAdmArea.Size = new System.Drawing.Size(200, 79);
            this.mtAdmArea.TabIndex = 3;
            this.mtAdmArea.Text = "Ad Areas";
            this.mtAdmArea.UseSelectable = true;
            this.mtAdmArea.Click += new System.EventHandler(this.mtAdmArea_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(220, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(697, 574);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtAdmReceipt
            // 
            this.mtAdmReceipt.ActiveControl = null;
            this.mtAdmReceipt.Location = new System.Drawing.Point(0, 373);
            this.mtAdmReceipt.Name = "mtAdmReceipt";
            this.mtAdmReceipt.Size = new System.Drawing.Size(200, 89);
            this.mtAdmReceipt.TabIndex = 9;
            this.mtAdmReceipt.Text = "Ad Recibos";
            this.mtAdmReceipt.UseSelectable = true;
            this.mtAdmReceipt.Click += new System.EventHandler(this.mtAdmReceipt_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 654);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.IsMdiContainer = true;
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile mtAdmArea;
        private MetroFramework.Controls.MetroTile mtAdPrecios;
        private MetroFramework.Controls.MetroTile mtArea;
        private MetroFramework.Controls.MetroTile btnReceipt;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTile mtPriceTag;
        private MetroFramework.Controls.MetroTile mtAdmReceipt;
    }
}