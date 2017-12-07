namespace ControlApp.OnPremises.Panels.Admin
{
    partial class pnlAdminArea
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
            this.txtRetrieveByName = new MetroFramework.Controls.MetroTextBox();
            this.lblRetrieve = new MetroFramework.Controls.MetroLabel();
            this.dgvArea = new MetroFramework.Controls.MetroGrid();
            this.btnUpdate = new MetroFramework.Controls.MetroTile();
            this.txtAreaname = new MetroFramework.Controls.MetroTextBox();
            this.mtlblArea = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnActivate = new MetroFramework.Controls.MetroTile();
            this.btnCreate = new MetroFramework.Controls.MetroTile();
            this.ID_AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA_STATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA_CREATYBY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA_UPDATEBY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA_CREATEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
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
            this.txtRetrieveByName.Location = new System.Drawing.Point(535, 69);
            this.txtRetrieveByName.MaxLength = 32767;
            this.txtRetrieveByName.Name = "txtRetrieveByName";
            this.txtRetrieveByName.PasswordChar = '\0';
            this.txtRetrieveByName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRetrieveByName.SelectedText = "";
            this.txtRetrieveByName.SelectionLength = 0;
            this.txtRetrieveByName.SelectionStart = 0;
            this.txtRetrieveByName.ShortcutsEnabled = true;
            this.txtRetrieveByName.Size = new System.Drawing.Size(135, 23);
            this.txtRetrieveByName.TabIndex = 23;
            this.txtRetrieveByName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtRetrieveByName.UseSelectable = true;
            this.txtRetrieveByName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRetrieveByName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRetrieveByName.TextChanged += new System.EventHandler(this.txtRetrieveByName_TextChanged);
            // 
            // lblRetrieve
            // 
            this.lblRetrieve.AutoSize = true;
            this.lblRetrieve.Location = new System.Drawing.Point(482, 73);
            this.lblRetrieve.Name = "lblRetrieve";
            this.lblRetrieve.Size = new System.Drawing.Size(47, 19);
            this.lblRetrieve.TabIndex = 28;
            this.lblRetrieve.Text = "Buscar";
            this.lblRetrieve.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvArea
            // 
            this.dgvArea.AllowUserToAddRows = false;
            this.dgvArea.AllowUserToDeleteRows = false;
            this.dgvArea.AllowUserToResizeRows = false;
            this.dgvArea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArea.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvArea.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_AREA,
            this.AREA_NAME,
            this.AREA_STATE,
            this.AREA_CREATYBY,
            this.AREA_UPDATEBY,
            this.AREA_CREATEDATE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArea.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArea.EnableHeadersVisualStyles = false;
            this.dgvArea.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvArea.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvArea.Location = new System.Drawing.Point(12, 98);
            this.dgvArea.Name = "dgvArea";
            this.dgvArea.ReadOnly = true;
            this.dgvArea.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArea.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArea.Size = new System.Drawing.Size(658, 332);
            this.dgvArea.TabIndex = 27;
            this.dgvArea.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvArea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArea_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveControl = null;
            this.btnUpdate.Location = new System.Drawing.Point(168, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 60);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAreaname
            // 
            // 
            // 
            // 
            this.txtAreaname.CustomButton.Image = null;
            this.txtAreaname.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtAreaname.CustomButton.Name = "";
            this.txtAreaname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAreaname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAreaname.CustomButton.TabIndex = 1;
            this.txtAreaname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAreaname.CustomButton.UseSelectable = true;
            this.txtAreaname.CustomButton.Visible = false;
            this.txtAreaname.Lines = new string[0];
            this.txtAreaname.Location = new System.Drawing.Point(77, 69);
            this.txtAreaname.MaxLength = 32767;
            this.txtAreaname.Name = "txtAreaname";
            this.txtAreaname.PasswordChar = '\0';
            this.txtAreaname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAreaname.SelectedText = "";
            this.txtAreaname.SelectionLength = 0;
            this.txtAreaname.SelectionStart = 0;
            this.txtAreaname.ShortcutsEnabled = true;
            this.txtAreaname.Size = new System.Drawing.Size(135, 23);
            this.txtAreaname.TabIndex = 22;
            this.txtAreaname.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAreaname.UseSelectable = true;
            this.txtAreaname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAreaname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtlblArea
            // 
            this.mtlblArea.AutoSize = true;
            this.mtlblArea.Location = new System.Drawing.Point(12, 73);
            this.mtlblArea.Name = "mtlblArea";
            this.mtlblArea.Size = new System.Drawing.Size(59, 19);
            this.mtlblArea.TabIndex = 26;
            this.mtlblArea.Text = "Nombre";
            this.mtlblArea.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.Location = new System.Drawing.Point(257, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 60);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Inactivar";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.ActiveControl = null;
            this.btnActivate.Location = new System.Drawing.Point(346, 3);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(83, 60);
            this.btnActivate.TabIndex = 30;
            this.btnActivate.Text = "Activar";
            this.btnActivate.UseSelectable = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.ActiveControl = null;
            this.btnCreate.Location = new System.Drawing.Point(79, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 60);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "Agregar";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // ID_AREA
            // 
            this.ID_AREA.FillWeight = 70F;
            this.ID_AREA.HeaderText = "ID";
            this.ID_AREA.Name = "ID_AREA";
            this.ID_AREA.ReadOnly = true;
            this.ID_AREA.Width = 50;
            // 
            // AREA_NAME
            // 
            this.AREA_NAME.HeaderText = "Area";
            this.AREA_NAME.Name = "AREA_NAME";
            this.AREA_NAME.ReadOnly = true;
            // 
            // AREA_STATE
            // 
            this.AREA_STATE.FillWeight = 60F;
            this.AREA_STATE.HeaderText = "Estado";
            this.AREA_STATE.Name = "AREA_STATE";
            this.AREA_STATE.ReadOnly = true;
            this.AREA_STATE.Width = 60;
            // 
            // AREA_CREATYBY
            // 
            this.AREA_CREATYBY.HeaderText = "Creado por";
            this.AREA_CREATYBY.Name = "AREA_CREATYBY";
            this.AREA_CREATYBY.ReadOnly = true;
            // 
            // AREA_UPDATEBY
            // 
            this.AREA_UPDATEBY.HeaderText = "Modificado por";
            this.AREA_UPDATEBY.Name = "AREA_UPDATEBY";
            this.AREA_UPDATEBY.ReadOnly = true;
            // 
            // AREA_CREATEDATE
            // 
            this.AREA_CREATEDATE.HeaderText = "Fecha de Creación";
            this.AREA_CREATEDATE.Name = "AREA_CREATEDATE";
            this.AREA_CREATEDATE.ReadOnly = true;
            // 
            // pnlAdminArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtRetrieveByName);
            this.Controls.Add(this.lblRetrieve);
            this.Controls.Add(this.dgvArea);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAreaname);
            this.Controls.Add(this.mtlblArea);
            this.Name = "pnlAdminArea";
            this.Size = new System.Drawing.Size(697, 574);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.pnlAdminArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtRetrieveByName;
        private MetroFramework.Controls.MetroLabel lblRetrieve;
        private MetroFramework.Controls.MetroGrid dgvArea;
        private MetroFramework.Controls.MetroTile btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtAreaname;
        private MetroFramework.Controls.MetroLabel mtlblArea;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnActivate;
        private MetroFramework.Controls.MetroTile btnCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_AREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA_STATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA_CREATYBY;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA_UPDATEBY;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA_CREATEDATE;
    }
}
