namespace ControlApp.OnPremises.Panels.Admin
{
    partial class pnlPosition
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtPosition = new MetroFramework.Controls.MetroTabControl();
            this.tabPosition = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.lblDescrip_Pst = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnRefresh = new MetroFramework.Controls.MetroTile();
            this.btnCreate = new MetroFramework.Controls.MetroTile();
            this.btnUpdate = new MetroFramework.Controls.MetroTile();
            this.txtRetrieveByName = new MetroFramework.Controls.MetroTextBox();
            this.lblRetrieve = new MetroFramework.Controls.MetroLabel();
            this.dgvPst = new MetroFramework.Controls.MetroGrid();
            this.lblArea_Id = new MetroFramework.Controls.MetroLabel();
            this.ID_PST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_PST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIP_PST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.lblName_Pst = new MetroFramework.Controls.MetroLabel();
            this.cbArea_Id = new MetroFramework.Controls.MetroComboBox();
            this.mtPosition.SuspendLayout();
            this.tabPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPst)).BeginInit();
            this.SuspendLayout();
            // 
            // mtPosition
            // 
            this.mtPosition.Controls.Add(this.tabPosition);
            this.mtPosition.Location = new System.Drawing.Point(0, 0);
            this.mtPosition.Name = "mtPosition";
            this.mtPosition.SelectedIndex = 0;
            this.mtPosition.Size = new System.Drawing.Size(697, 571);
            this.mtPosition.TabIndex = 2;
            this.mtPosition.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtPosition.UseSelectable = true;
            // 
            // tabPosition
            // 
            this.tabPosition.Controls.Add(this.cbArea_Id);
            this.tabPosition.Controls.Add(this.metroTextBox2);
            this.tabPosition.Controls.Add(this.lblName_Pst);
            this.tabPosition.Controls.Add(this.metroTextBox1);
            this.tabPosition.Controls.Add(this.lblDescrip_Pst);
            this.tabPosition.Controls.Add(this.btnDelete);
            this.tabPosition.Controls.Add(this.btnRefresh);
            this.tabPosition.Controls.Add(this.btnCreate);
            this.tabPosition.Controls.Add(this.btnUpdate);
            this.tabPosition.Controls.Add(this.txtRetrieveByName);
            this.tabPosition.Controls.Add(this.lblRetrieve);
            this.tabPosition.Controls.Add(this.dgvPst);
            this.tabPosition.Controls.Add(this.lblArea_Id);
            this.tabPosition.HorizontalScrollbarBarColor = true;
            this.tabPosition.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPosition.HorizontalScrollbarSize = 10;
            this.tabPosition.Location = new System.Drawing.Point(4, 38);
            this.tabPosition.Name = "tabPosition";
            this.tabPosition.Size = new System.Drawing.Size(689, 529);
            this.tabPosition.TabIndex = 0;
            this.tabPosition.Text = "Cargos";
            this.tabPosition.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabPosition.VerticalScrollbarBarColor = true;
            this.tabPosition.VerticalScrollbarHighlightOnWheel = false;
            this.tabPosition.VerticalScrollbarSize = 10;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(90, 148);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(200, 23);
            this.metroTextBox1.TabIndex = 35;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDescrip_Pst
            // 
            this.lblDescrip_Pst.AutoSize = true;
            this.lblDescrip_Pst.Location = new System.Drawing.Point(8, 152);
            this.lblDescrip_Pst.Name = "lblDescrip_Pst";
            this.lblDescrip_Pst.Size = new System.Drawing.Size(76, 19);
            this.lblDescrip_Pst.TabIndex = 36;
            this.lblDescrip_Pst.Text = "Descripción";
            this.lblDescrip_Pst.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.Location = new System.Drawing.Point(179, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 60);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseSelectable = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveControl = null;
            this.btnRefresh.Location = new System.Drawing.Point(268, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 60);
            this.btnRefresh.TabIndex = 33;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseSelectable = true;
            // 
            // btnCreate
            // 
            this.btnCreate.ActiveControl = null;
            this.btnCreate.Location = new System.Drawing.Point(1, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 60);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "Agregar";
            this.btnCreate.UseSelectable = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveControl = null;
            this.btnUpdate.Location = new System.Drawing.Point(90, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 60);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseSelectable = true;
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
            this.txtRetrieveByName.Location = new System.Drawing.Point(551, 84);
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
            // 
            // lblRetrieve
            // 
            this.lblRetrieve.AutoSize = true;
            this.lblRetrieve.Location = new System.Drawing.Point(498, 88);
            this.lblRetrieve.Name = "lblRetrieve";
            this.lblRetrieve.Size = new System.Drawing.Size(47, 19);
            this.lblRetrieve.TabIndex = 28;
            this.lblRetrieve.Text = "Buscar";
            this.lblRetrieve.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvPst
            // 
            this.dgvPst.AllowUserToAddRows = false;
            this.dgvPst.AllowUserToDeleteRows = false;
            this.dgvPst.AllowUserToResizeRows = false;
            this.dgvPst.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvPst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPst.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PST,
            this.Area,
            this.NAME_PST,
            this.DESCRIP_PST});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPst.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPst.EnableHeadersVisualStyles = false;
            this.dgvPst.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPst.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvPst.Location = new System.Drawing.Point(-4, 177);
            this.dgvPst.Name = "dgvPst";
            this.dgvPst.ReadOnly = true;
            this.dgvPst.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPst.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPst.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPst.Size = new System.Drawing.Size(697, 353);
            this.dgvPst.TabIndex = 27;
            this.dgvPst.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblArea_Id
            // 
            this.lblArea_Id.AutoSize = true;
            this.lblArea_Id.Location = new System.Drawing.Point(8, 94);
            this.lblArea_Id.Name = "lblArea_Id";
            this.lblArea_Id.Size = new System.Drawing.Size(37, 19);
            this.lblArea_Id.TabIndex = 26;
            this.lblArea_Id.Text = "Area";
            this.lblArea_Id.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ID_PST
            // 
            this.ID_PST.HeaderText = "ID_PST";
            this.ID_PST.Name = "ID_PST";
            this.ID_PST.ReadOnly = true;
            this.ID_PST.Visible = false;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // NAME_PST
            // 
            this.NAME_PST.HeaderText = "Nombre";
            this.NAME_PST.Name = "NAME_PST";
            this.NAME_PST.ReadOnly = true;
            this.NAME_PST.Width = 115;
            // 
            // DESCRIP_PST
            // 
            this.DESCRIP_PST.HeaderText = "Descripción";
            this.DESCRIP_PST.Name = "DESCRIP_PST";
            this.DESCRIP_PST.ReadOnly = true;
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(90, 119);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(200, 23);
            this.metroTextBox2.TabIndex = 37;
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblName_Pst
            // 
            this.lblName_Pst.AutoSize = true;
            this.lblName_Pst.Location = new System.Drawing.Point(8, 123);
            this.lblName_Pst.Name = "lblName_Pst";
            this.lblName_Pst.Size = new System.Drawing.Size(59, 19);
            this.lblName_Pst.TabIndex = 38;
            this.lblName_Pst.Text = "Nombre";
            this.lblName_Pst.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbArea_Id
            // 
            this.cbArea_Id.FormattingEnabled = true;
            this.cbArea_Id.ItemHeight = 23;
            this.cbArea_Id.Location = new System.Drawing.Point(90, 84);
            this.cbArea_Id.Name = "cbArea_Id";
            this.cbArea_Id.Size = new System.Drawing.Size(200, 29);
            this.cbArea_Id.TabIndex = 39;
            this.cbArea_Id.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbArea_Id.UseSelectable = true;
            // 
            // pnlPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtPosition);
            this.Name = "pnlPosition";
            this.Size = new System.Drawing.Size(697, 571);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtPosition.ResumeLayout(false);
            this.tabPosition.ResumeLayout(false);
            this.tabPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtPosition;
        private MetroFramework.Controls.MetroTabPage tabPosition;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel lblDescrip_Pst;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnRefresh;
        private MetroFramework.Controls.MetroTile btnCreate;
        private MetroFramework.Controls.MetroTile btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtRetrieveByName;
        private MetroFramework.Controls.MetroLabel lblRetrieve;
        private MetroFramework.Controls.MetroGrid dgvPst;
        private MetroFramework.Controls.MetroLabel lblArea_Id;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel lblName_Pst;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PST;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_PST;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIP_PST;
        private MetroFramework.Controls.MetroComboBox cbArea_Id;
    }
}
