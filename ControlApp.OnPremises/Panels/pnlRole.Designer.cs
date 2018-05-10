namespace ControlApp.OnPremises.Panels
{
    partial class pnlRole
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
            this.mtRole = new MetroFramework.Controls.MetroTabControl();
            this.tabRole = new MetroFramework.Controls.MetroTabPage();
            this.txtDescripRole = new MetroFramework.Controls.MetroTextBox();
            this.lblDescrip_Role = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnRefresh = new MetroFramework.Controls.MetroTile();
            this.btnCreate = new MetroFramework.Controls.MetroTile();
            this.btnUpdate = new MetroFramework.Controls.MetroTile();
            this.txtRetrieveByName = new MetroFramework.Controls.MetroTextBox();
            this.lblRetrieve = new MetroFramework.Controls.MetroLabel();
            this.dgvRole = new MetroFramework.Controls.MetroGrid();
            this.ID_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIP_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRolename = new MetroFramework.Controls.MetroTextBox();
            this.lblName_Role = new MetroFramework.Controls.MetroLabel();
            this.mtRole.SuspendLayout();
            this.tabRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.SuspendLayout();
            // 
            // mtRole
            // 
            this.mtRole.Controls.Add(this.tabRole);
            this.mtRole.Location = new System.Drawing.Point(0, 0);
            this.mtRole.Name = "mtRole";
            this.mtRole.SelectedIndex = 0;
            this.mtRole.Size = new System.Drawing.Size(697, 571);
            this.mtRole.TabIndex = 1;
            this.mtRole.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtRole.UseSelectable = true;
            // 
            // tabRole
            // 
            this.tabRole.Controls.Add(this.txtDescripRole);
            this.tabRole.Controls.Add(this.lblDescrip_Role);
            this.tabRole.Controls.Add(this.btnDelete);
            this.tabRole.Controls.Add(this.btnRefresh);
            this.tabRole.Controls.Add(this.btnCreate);
            this.tabRole.Controls.Add(this.btnUpdate);
            this.tabRole.Controls.Add(this.txtRetrieveByName);
            this.tabRole.Controls.Add(this.lblRetrieve);
            this.tabRole.Controls.Add(this.dgvRole);
            this.tabRole.Controls.Add(this.txtRolename);
            this.tabRole.Controls.Add(this.lblName_Role);
            this.tabRole.HorizontalScrollbarBarColor = true;
            this.tabRole.HorizontalScrollbarHighlightOnWheel = false;
            this.tabRole.HorizontalScrollbarSize = 10;
            this.tabRole.Location = new System.Drawing.Point(4, 38);
            this.tabRole.Name = "tabRole";
            this.tabRole.Size = new System.Drawing.Size(689, 529);
            this.tabRole.TabIndex = 0;
            this.tabRole.Text = "Roles";
            this.tabRole.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabRole.VerticalScrollbarBarColor = true;
            this.tabRole.VerticalScrollbarHighlightOnWheel = false;
            this.tabRole.VerticalScrollbarSize = 10;
            // 
            // txtDescripRole
            // 
            // 
            // 
            // 
            this.txtDescripRole.CustomButton.Image = null;
            this.txtDescripRole.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtDescripRole.CustomButton.Name = "";
            this.txtDescripRole.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescripRole.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripRole.CustomButton.TabIndex = 1;
            this.txtDescripRole.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripRole.CustomButton.UseSelectable = true;
            this.txtDescripRole.CustomButton.Visible = false;
            this.txtDescripRole.Lines = new string[0];
            this.txtDescripRole.Location = new System.Drawing.Point(90, 113);
            this.txtDescripRole.MaxLength = 32767;
            this.txtDescripRole.Name = "txtDescripRole";
            this.txtDescripRole.PasswordChar = '\0';
            this.txtDescripRole.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripRole.SelectedText = "";
            this.txtDescripRole.SelectionLength = 0;
            this.txtDescripRole.SelectionStart = 0;
            this.txtDescripRole.ShortcutsEnabled = true;
            this.txtDescripRole.Size = new System.Drawing.Size(154, 23);
            this.txtDescripRole.TabIndex = 35;
            this.txtDescripRole.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDescripRole.UseSelectable = true;
            this.txtDescripRole.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripRole.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDescrip_Role
            // 
            this.lblDescrip_Role.AutoSize = true;
            this.lblDescrip_Role.Location = new System.Drawing.Point(8, 117);
            this.lblDescrip_Role.Name = "lblDescrip_Role";
            this.lblDescrip_Role.Size = new System.Drawing.Size(76, 19);
            this.lblDescrip_Role.TabIndex = 36;
            this.lblDescrip_Role.Text = "Descripción";
            this.lblDescrip_Role.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            // dgvRole
            // 
            this.dgvRole.AllowUserToAddRows = false;
            this.dgvRole.AllowUserToDeleteRows = false;
            this.dgvRole.AllowUserToResizeRows = false;
            this.dgvRole.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRole.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRole.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ROLE,
            this.NAME_ROLE,
            this.DESCRIP_ROLE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRole.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRole.EnableHeadersVisualStyles = false;
            this.dgvRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvRole.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvRole.Location = new System.Drawing.Point(-4, 172);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.ReadOnly = true;
            this.dgvRole.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRole.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRole.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRole.Size = new System.Drawing.Size(697, 358);
            this.dgvRole.TabIndex = 27;
            this.dgvRole.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ID_ROLE
            // 
            this.ID_ROLE.HeaderText = "ID_ROLE";
            this.ID_ROLE.Name = "ID_ROLE";
            this.ID_ROLE.ReadOnly = true;
            this.ID_ROLE.Visible = false;
            // 
            // NAME_ROLE
            // 
            this.NAME_ROLE.HeaderText = "Rol";
            this.NAME_ROLE.Name = "NAME_ROLE";
            this.NAME_ROLE.ReadOnly = true;
            // 
            // DESCRIP_ROLE
            // 
            this.DESCRIP_ROLE.HeaderText = "Descripción ";
            this.DESCRIP_ROLE.Name = "DESCRIP_ROLE";
            this.DESCRIP_ROLE.ReadOnly = true;
            this.DESCRIP_ROLE.Width = 115;
            // 
            // txtRolename
            // 
            // 
            // 
            // 
            this.txtRolename.CustomButton.Image = null;
            this.txtRolename.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtRolename.CustomButton.Name = "";
            this.txtRolename.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRolename.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRolename.CustomButton.TabIndex = 1;
            this.txtRolename.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRolename.CustomButton.UseSelectable = true;
            this.txtRolename.CustomButton.Visible = false;
            this.txtRolename.Lines = new string[0];
            this.txtRolename.Location = new System.Drawing.Point(90, 84);
            this.txtRolename.MaxLength = 32767;
            this.txtRolename.Name = "txtRolename";
            this.txtRolename.PasswordChar = '\0';
            this.txtRolename.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRolename.SelectedText = "";
            this.txtRolename.SelectionLength = 0;
            this.txtRolename.SelectionStart = 0;
            this.txtRolename.ShortcutsEnabled = true;
            this.txtRolename.Size = new System.Drawing.Size(154, 23);
            this.txtRolename.TabIndex = 22;
            this.txtRolename.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtRolename.UseSelectable = true;
            this.txtRolename.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRolename.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblName_Role
            // 
            this.lblName_Role.AutoSize = true;
            this.lblName_Role.Location = new System.Drawing.Point(8, 88);
            this.lblName_Role.Name = "lblName_Role";
            this.lblName_Role.Size = new System.Drawing.Size(59, 19);
            this.lblName_Role.TabIndex = 26;
            this.lblName_Role.Text = "Nombre";
            this.lblName_Role.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pnlRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtRole);
            this.Name = "pnlRole";
            this.Size = new System.Drawing.Size(697, 571);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtRole.ResumeLayout(false);
            this.tabRole.ResumeLayout(false);
            this.tabRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtRole;
        private MetroFramework.Controls.MetroTabPage tabRole;
        private MetroFramework.Controls.MetroTextBox txtRetrieveByName;
        private MetroFramework.Controls.MetroLabel lblRetrieve;
        private MetroFramework.Controls.MetroGrid dgvRole;
        private MetroFramework.Controls.MetroTextBox txtRolename;
        private MetroFramework.Controls.MetroLabel lblName_Role;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnRefresh;
        private MetroFramework.Controls.MetroTile btnCreate;
        private MetroFramework.Controls.MetroTile btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtDescripRole;
        private MetroFramework.Controls.MetroLabel lblDescrip_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIP_ROLE;
    }
}
