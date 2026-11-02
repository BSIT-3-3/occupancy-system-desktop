namespace OccupancyMonitor.Forms
{
    partial class frmRegister
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
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtfullname2 = new System.Windows.Forms.TextBox();
            this.bntregister2 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtusername2 = new System.Windows.Forms.TextBox();
            this.txtpassword2 = new System.Windows.Forms.TextBox();
            this.txtconfirmpassword2 = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new Krypton.Toolkit.KryptonCheckBox();
            this.chkShowPassword1 = new Krypton.Toolkit.KryptonCheckBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 50);
            this.label6.TabIndex = 0;
            this.label6.Text = "ROOM WATCH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(267, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Room Occupancy and Notification System";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(275, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(297, 28);
            this.label12.TabIndex = 2;
            this.label12.Text = "Administrator Registration";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(247, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(351, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Create a new account to access the administrator portal";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(227, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Full Name *";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(227, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 19);
            this.label15.TabIndex = 5;
            this.label15.Text = "Username / Email";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(227, 330);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 19);
            this.label16.TabIndex = 6;
            this.label16.Text = "Password";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(227, 393);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 19);
            this.label17.TabIndex = 7;
            this.label17.Text = "Confirm Password *";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtfullname2
            // 
            this.txtfullname2.Location = new System.Drawing.Point(231, 227);
            this.txtfullname2.Multiline = true;
            this.txtfullname2.Name = "txtfullname2";
            this.txtfullname2.Size = new System.Drawing.Size(367, 31);
            this.txtfullname2.TabIndex = 8;
            // 
            // bntregister2
            // 
            this.bntregister2.BackColor = System.Drawing.SystemColors.Highlight;
            this.bntregister2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntregister2.Location = new System.Drawing.Point(280, 461);
            this.bntregister2.Name = "bntregister2";
            this.bntregister2.Size = new System.Drawing.Size(254, 36);
            this.bntregister2.TabIndex = 12;
            this.bntregister2.Text = "REGISTER";
            this.bntregister2.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(262, 499);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(295, 16);
            this.label18.TabIndex = 13;
            this.label18.Text = "Already have an account? <a href=\'#\'>Log in</a>\r\n";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txtusername2
            // 
            this.txtusername2.Location = new System.Drawing.Point(231, 288);
            this.txtusername2.Multiline = true;
            this.txtusername2.Name = "txtusername2";
            this.txtusername2.Size = new System.Drawing.Size(367, 31);
            this.txtusername2.TabIndex = 14;
            // 
            // txtpassword2
            // 
            this.txtpassword2.Location = new System.Drawing.Point(231, 352);
            this.txtpassword2.Name = "txtpassword2";
            this.txtpassword2.Size = new System.Drawing.Size(367, 20);
            this.txtpassword2.TabIndex = 15;
            this.txtpassword2.UseSystemPasswordChar = true;
            this.txtpassword2.TextChanged += new System.EventHandler(this.txtpassword2_TextChanged);
            // 
            // txtconfirmpassword2
            // 
            this.txtconfirmpassword2.Location = new System.Drawing.Point(231, 415);
            this.txtconfirmpassword2.Name = "txtconfirmpassword2";
            this.txtconfirmpassword2.Size = new System.Drawing.Size(367, 20);
            this.txtconfirmpassword2.TabIndex = 16;
            this.txtconfirmpassword2.UseSystemPasswordChar = true;
            this.txtconfirmpassword2.TextChanged += new System.EventHandler(this.txtconfirmpassword2_TextChanged);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.Location = new System.Drawing.Point(231, 378);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(108, 20);
            this.chkShowPassword.TabIndex = 17;
            this.chkShowPassword.Values.Text = "Show Password";
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // chkShowPassword1
            // 
            this.chkShowPassword1.Location = new System.Drawing.Point(231, 441);
            this.chkShowPassword1.Name = "chkShowPassword1";
            this.chkShowPassword1.Size = new System.Drawing.Size(108, 20);
            this.chkShowPassword1.TabIndex = 18;
            this.chkShowPassword1.Values.Text = "Show Password";
            // 
            // frmRegister
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(833, 633);
            this.Controls.Add(this.chkShowPassword1);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.txtconfirmpassword2);
            this.Controls.Add(this.txtpassword2);
            this.Controls.Add(this.txtusername2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.bntregister2);
            this.Controls.Add(this.txtfullname2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Name = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button bntRegister;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtfullname2;
        private System.Windows.Forms.Button bntregister2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtusername2;
        private System.Windows.Forms.TextBox txtpassword2;
        private System.Windows.Forms.TextBox txtconfirmpassword2;
        private Krypton.Toolkit.KryptonCheckBox chkShowPassword;
        private Krypton.Toolkit.KryptonCheckBox chkShowPassword1;
    }
}