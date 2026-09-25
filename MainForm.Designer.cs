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
            ((System.ComponentModel.ISupportInitialize)(this.kplNavBar)).BeginInit();
            this.kplNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpl)).BeginInit();
            this.SuspendLayout();
            // 
            // kplNavBar
            // 
            this.kplNavBar.Controls.Add(this.ktBtnRoom);
            this.kplNavBar.Controls.Add(this.kbtnDashboard);
            this.kplNavBar.Controls.Add(this.kpl);
            this.kplNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.kplNavBar.Location = new System.Drawing.Point(0, 0);
            this.kplNavBar.Name = "kplNavBar";
            this.kplNavBar.Size = new System.Drawing.Size(187, 647);
            this.kplNavBar.TabIndex = 4;
            // 
            // kbtnDashboard
            // 
            this.kbtnDashboard.CausesValidation = false;
            this.kbtnDashboard.Location = new System.Drawing.Point(0, 123);
            this.kbtnDashboard.Name = "kbtnDashboard";
            this.kbtnDashboard.Size = new System.Drawing.Size(187, 45);
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
            this.kpl.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpl.Location = new System.Drawing.Point(0, 0);
            this.kpl.Name = "kpl";
            this.kpl.Size = new System.Drawing.Size(187, 124);
            this.kpl.TabIndex = 0;
            // 
            // tsTop
            // 
            this.tsTop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTop.Location = new System.Drawing.Point(187, 0);
            this.tsTop.Name = "tsTop";
            this.tsTop.Size = new System.Drawing.Size(1138, 25);
            this.tsTop.TabIndex = 5;
            this.tsTop.Text = "toolStrip1";
            // 
            // plContent
            // 
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.Location = new System.Drawing.Point(187, 25);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(1138, 622);
            this.plContent.TabIndex = 6;
            // 
            // ktBtnRoom
            // 
            this.ktBtnRoom.CausesValidation = false;
            this.ktBtnRoom.Location = new System.Drawing.Point(3, 174);
            this.ktBtnRoom.Name = "ktBtnRoom";
            this.ktBtnRoom.Size = new System.Drawing.Size(187, 45);
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
            ((System.ComponentModel.ISupportInitialize)(this.kpl)).EndInit();
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
    }
}

