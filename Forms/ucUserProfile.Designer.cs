namespace OccupancyMonitor.Forms
{
    partial class ucUserProfile
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
            this.dgvUserManagement = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtUsername = new Krypton.Toolkit.KryptonTextBox();
            this.txtFullname = new Krypton.Toolkit.KryptonTextBox();
            this.cbRole = new Krypton.Toolkit.KryptonComboBox();
            this.cbStatus = new Krypton.Toolkit.KryptonComboBox();
            this.dtpCreatedAt = new Krypton.Toolkit.KryptonDateTimePicker();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserManagement
            // 
            this.dgvUserManagement.AllowUserToAddRows = false;
            this.dgvUserManagement.AllowUserToDeleteRows = false;
            this.dgvUserManagement.AllowUserToResizeColumns = false;
            this.dgvUserManagement.AllowUserToResizeRows = false;
            this.dgvUserManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.username,
            this.fullName,
            this.role,
            this.status,
            this.createdAt});
            this.dgvUserManagement.Location = new System.Drawing.Point(12, 84);
            this.dgvUserManagement.Name = "dgvUserManagement";
            this.dgvUserManagement.RowHeadersVisible = false;
            this.dgvUserManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserManagement.Size = new System.Drawing.Size(648, 459);
            this.dgvUserManagement.TabIndex = 0;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(34, 39);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(281, 27);
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.Rounding = 5F;
            this.kryptonTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Role:";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 137;
            this.kryptonComboBox1.IntegralHeight = false;
            this.kryptonComboBox1.Location = new System.Drawing.Point(402, 39);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(141, 25);
            this.kryptonComboBox1.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Rounding = 5F;
            this.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpCreatedAt);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.cbRole);
            this.groupBox1.Controls.Add(this.txtFullname);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(694, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 459);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Full Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Role:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Account Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Created At:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(276, 36);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(18, 365);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(276, 36);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(18, 417);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(276, 36);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(114, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(165, 25);
            this.txtUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateCommon.Border.Rounding = 2F;
            this.txtUsername.TabIndex = 5;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(114, 83);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(165, 25);
            this.txtFullname.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFullname.StateCommon.Border.Rounding = 2F;
            this.txtFullname.TabIndex = 13;
            // 
            // cbRole
            // 
            this.cbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.DropDownWidth = 137;
            this.cbRole.IntegralHeight = false;
            this.cbRole.Location = new System.Drawing.Point(114, 131);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(165, 23);
            this.cbRole.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbRole.StateCommon.ComboBox.Border.Rounding = 2F;
            this.cbRole.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbRole.TabIndex = 5;
            // 
            // cbStatus
            // 
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.DropDownWidth = 137;
            this.cbStatus.IntegralHeight = false;
            this.cbStatus.Location = new System.Drawing.Point(114, 177);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(165, 23);
            this.cbStatus.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbStatus.StateCommon.ComboBox.Border.Rounding = 2F;
            this.cbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbStatus.TabIndex = 14;
            // 
            // dtpCreatedAt
            // 
            this.dtpCreatedAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedAt.Location = new System.Drawing.Point(114, 269);
            this.dtpCreatedAt.Name = "dtpCreatedAt";
            this.dtpCreatedAt.Size = new System.Drawing.Size(165, 23);
            this.dtpCreatedAt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpCreatedAt.StateCommon.Border.Rounding = 2F;
            this.dtpCreatedAt.TabIndex = 15;
            // 
            // userId
            // 
            this.userId.HeaderText = "UserId";
            this.userId.Name = "userId";
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Full Name";
            this.fullName.Name = "fullName";
            // 
            // role
            // 
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // createdAt
            // 
            this.createdAt.HeaderText = "CreatedAt";
            this.createdAt.Name = "createdAt";
            // 
            // ucUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kryptonComboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.dgvUserManagement);
            this.Name = "ucUserProfile";
            this.Size = new System.Drawing.Size(1036, 559);
            this.Load += new System.EventHandler(this.ucUserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvUserManagement;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Krypton.Toolkit.KryptonDateTimePicker dtpCreatedAt;
        private Krypton.Toolkit.KryptonComboBox cbStatus;
        private Krypton.Toolkit.KryptonComboBox cbRole;
        private Krypton.Toolkit.KryptonTextBox txtFullname;
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
    }
}
