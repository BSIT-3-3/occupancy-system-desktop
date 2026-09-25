namespace OccupancyMonitor
{
    partial class MainForm
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
            this.kplNavBar = new Krypton.Toolkit.KryptonPanel();
            this.kbtnDashboard = new Krypton.Toolkit.KryptonButton();
            this.kpl = new Krypton.Toolkit.KryptonPanel();
            this.tsTop = new System.Windows.Forms.ToolStrip();
            this.plContent = new System.Windows.Forms.Panel();
            this.ktBtnRoom = new Krypton.Toolkit.KryptonButton();
            this.kBtnActiveEmergency = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kplNavBar)).BeginInit();
            this.kplNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpl)).BeginInit();
            this.kpl.SuspendLayout();
            this.SuspendLayout();
            // 
            // kplNavBar
            // 
            this.kplNavBar.Controls.Add(this.kBtnActiveEmergency);
            this.kplNavBar.Controls.Add(this.ktBtnRoom);
            this.kplNavBar.Controls.Add(this.kbtnDashboard);
            this.kplNavBar.Controls.Add(this.kpl);
            this.kplNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.kplNavBar.Location = new System.Drawing.Point(0, 0);
            this.kplNavBar.Name = "kplNavBar";
            this.kplNavBar.Size = new System.Drawing.Size(202, 647);
            this.kplNavBar.TabIndex = 4;
            this.kplNavBar.Paint += new System.Windows.Forms.PaintEventHandler(this.kplNavBar_Paint);
            // 
            // kbtnDashboard
            // 
            this.kbtnDashboard.CausesValidation = false;
            this.kbtnDashboard.Location = new System.Drawing.Point(0, 105);
            this.kbtnDashboard.Name = "kbtnDashboard";
            this.kbtnDashboard.Size = new System.Drawing.Size(199, 45);
            this.kbtnDashboard.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kbtnDashboard.StateCommon.Border.Rounding = 0F;
            this.kbtnDashboard.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.kbtnDashboard.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnDashboard.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnDashboard.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.kbtnDashboard.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnDashboard.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.kbtnDashboard.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kbtnDashboard.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnDashboard.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnDashboard.StateTracking.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.kbtnDashboard.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.kbtnDashboard.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kbtnDashboard.StateTracking.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kbtnDashboard.StateTracking.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.kbtnDashboard.StateTracking.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnDashboard.StateTracking.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnDashboard.StateTracking.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnDashboard.StateTracking.Content.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.kbtnDashboard.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnDashboard.StateTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.None;
            this.kbtnDashboard.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnDashboard.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnDashboard.TabIndex = 6;
            this.kbtnDashboard.Values.Text = "Dashboard";
            this.kbtnDashboard.Click += new System.EventHandler(this.kbtnDashboard_Click);
            // 
            // kpl
            // 
            this.kpl.Controls.Add(this.label3);
            this.kpl.Controls.Add(this.label2);
            this.kpl.Controls.Add(this.label1);
            this.kpl.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpl.Location = new System.Drawing.Point(0, 0);
            this.kpl.Name = "kpl";
            this.kpl.Size = new System.Drawing.Size(202, 124);
            this.kpl.TabIndex = 0;
            // 
            // tsTop
            // 
            this.tsTop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTop.Location = new System.Drawing.Point(202, 0);
            this.tsTop.Name = "tsTop";
            this.tsTop.Size = new System.Drawing.Size(1123, 25);
            this.tsTop.TabIndex = 5;
            this.tsTop.Text = "toolStrip1";
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.Location = new System.Drawing.Point(202, 25);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(1123, 622);
            this.plContent.TabIndex = 6;
            // 
            // ktBtnRoom
            // 
            this.ktBtnRoom.CausesValidation = false;
            this.ktBtnRoom.Location = new System.Drawing.Point(0, 180);
            this.ktBtnRoom.Name = "ktBtnRoom";
            this.ktBtnRoom.Size = new System.Drawing.Size(199, 45);
            this.ktBtnRoom.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktBtnRoom.StateCommon.Border.Rounding = 0F;
            this.ktBtnRoom.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.ktBtnRoom.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ktBtnRoom.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ktBtnRoom.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.ktBtnRoom.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktBtnRoom.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.ktBtnRoom.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.ktBtnRoom.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ktBtnRoom.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ktBtnRoom.StateTracking.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.ktBtnRoom.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.ktBtnRoom.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.ktBtnRoom.StateTracking.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.ktBtnRoom.StateTracking.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.ktBtnRoom.StateTracking.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ktBtnRoom.StateTracking.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ktBtnRoom.StateTracking.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ktBtnRoom.StateTracking.Content.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.ktBtnRoom.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ktBtnRoom.StateTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.None;
            this.ktBtnRoom.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ktBtnRoom.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ktBtnRoom.TabIndex = 7;
            this.ktBtnRoom.Values.Text = "Room";
            this.ktBtnRoom.Click += new System.EventHandler(this.ktBtnRoom_Click);
            // 
            // kBtnActiveEmergency
            // 
            this.kBtnActiveEmergency.AutoSize = true;
            this.kBtnActiveEmergency.CausesValidation = false;
            this.kBtnActiveEmergency.Location = new System.Drawing.Point(0, 231);
            this.kBtnActiveEmergency.Name = "kBtnActiveEmergency";
            this.kBtnActiveEmergency.Size = new System.Drawing.Size(199, 57);
            this.kBtnActiveEmergency.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kBtnActiveEmergency.StateCommon.Border.Rounding = 0F;
            this.kBtnActiveEmergency.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.kBtnActiveEmergency.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kBtnActiveEmergency.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kBtnActiveEmergency.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.kBtnActiveEmergency.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnActiveEmergency.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.kBtnActiveEmergency.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kBtnActiveEmergency.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kBtnActiveEmergency.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kBtnActiveEmergency.StateTracking.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.kBtnActiveEmergency.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.kBtnActiveEmergency.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kBtnActiveEmergency.StateTracking.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kBtnActiveEmergency.StateTracking.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.kBtnActiveEmergency.StateTracking.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kBtnActiveEmergency.StateTracking.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kBtnActiveEmergency.StateTracking.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kBtnActiveEmergency.StateTracking.Content.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.kBtnActiveEmergency.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kBtnActiveEmergency.StateTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.None;
            this.kBtnActiveEmergency.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kBtnActiveEmergency.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kBtnActiveEmergency.TabIndex = 8;
            this.kBtnActiveEmergency.Values.Text = "Active Emergency";
            this.kBtnActiveEmergency.Click += new System.EventHandler(this.kBtnActiveEmergency_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Room Watch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Admin Portal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Main";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 647);
            this.Controls.Add(this.plContent);
            this.Controls.Add(this.tsTop);
            this.Controls.Add(this.kplNavBar);
            this.Name = "MainForm";
            this.Text = "X";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kplNavBar)).EndInit();
            this.kplNavBar.ResumeLayout(false);
            this.kplNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpl)).EndInit();
            this.kpl.ResumeLayout(false);
            this.kpl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonPanel kplNavBar;
        private Krypton.Toolkit.KryptonPanel kpl;
        private System.Windows.Forms.ToolStrip tsTop;
        private Krypton.Toolkit.KryptonButton kbtnDashboard;
        private System.Windows.Forms.Panel plContent;
        private Krypton.Toolkit.KryptonButton ktBtnRoom;
        private Krypton.Toolkit.KryptonButton kBtnActiveEmergency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

