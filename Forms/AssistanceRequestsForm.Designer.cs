namespace UI3AssistanceRequests
{
    partial class AssistanceRequestsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.FlowLayoutPanel statsPanel;
        private System.Windows.Forms.Panel totalCard;
        private System.Windows.Forms.Panel pendingCard;
        private System.Windows.Forms.Panel progressCard;
        private System.Windows.Forms.Panel resolvedCard;
        private System.Windows.Forms.Label totalCaption;
        private System.Windows.Forms.Label pendingCaption;
        private System.Windows.Forms.Label progressCaption;
        private System.Windows.Forms.Label resolvedCaption;
        private System.Windows.Forms.Label totalValue;
        private System.Windows.Forms.Label pendingValue;
        private System.Windows.Forms.Label progressValue;
        private System.Windows.Forms.Label resolvedValue;
        private System.Windows.Forms.Panel requestListPanel;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label requestListTitle;
        private System.Windows.Forms.Label requestDetailsTitle;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox statusFilter;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label detailStatus;
        private System.Windows.Forms.Label detailIdCaption;
        private System.Windows.Forms.Label detailRoomCaption;
        private System.Windows.Forms.Label detailByCaption;
        private System.Windows.Forms.Label detailDateCaption;
        private System.Windows.Forms.Label detailSubjectCaption;
        private System.Windows.Forms.Label descriptionCaption;
        private System.Windows.Forms.Label detailId;
        private System.Windows.Forms.Label detailRoom;
        private System.Windows.Forms.Label detailBy;
        private System.Windows.Forms.Label detailDate;
        private System.Windows.Forms.Label detailSubject;
        private System.Windows.Forms.Label detailDescription;
        private System.Windows.Forms.Label updateCaption;
        private System.Windows.Forms.TextBox updateBox;
        private System.Windows.Forms.Button acknowledgeButton;
        private System.Windows.Forms.Button resolveButton;
        private System.Windows.Forms.Label navDashboard;
        private System.Windows.Forms.Label navDevices;
        private System.Windows.Forms.Label navRooms;
        private System.Windows.Forms.Label navAssistance;
        private System.Windows.Forms.Label navBroadcast;
        private System.Windows.Forms.Label navReports;
        private System.Windows.Forms.Label navSettings;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.brandLabel = new System.Windows.Forms.Label();
            this.navDashboard = new System.Windows.Forms.Label();
            this.navDevices = new System.Windows.Forms.Label();
            this.navRooms = new System.Windows.Forms.Label();
            this.navAssistance = new System.Windows.Forms.Label();
            this.navBroadcast = new System.Windows.Forms.Label();
            this.navReports = new System.Windows.Forms.Label();
            this.navSettings = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.headingLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.totalCard = new System.Windows.Forms.Panel();
            this.totalCaption = new System.Windows.Forms.Label();
            this.totalValue = new System.Windows.Forms.Label();
            this.pendingCard = new System.Windows.Forms.Panel();
            this.pendingCaption = new System.Windows.Forms.Label();
            this.pendingValue = new System.Windows.Forms.Label();
            this.progressCard = new System.Windows.Forms.Panel();
            this.progressCaption = new System.Windows.Forms.Label();
            this.progressValue = new System.Windows.Forms.Label();
            this.resolvedCard = new System.Windows.Forms.Panel();
            this.resolvedCaption = new System.Windows.Forms.Label();
            this.resolvedValue = new System.Windows.Forms.Label();
            this.requestListPanel = new System.Windows.Forms.Panel();
            this.requestListTitle = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.statusFilter = new System.Windows.Forms.ComboBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.requestDetailsTitle = new System.Windows.Forms.Label();
            this.detailStatus = new System.Windows.Forms.Label();
            this.detailIdCaption = new System.Windows.Forms.Label();
            this.detailRoomCaption = new System.Windows.Forms.Label();
            this.detailByCaption = new System.Windows.Forms.Label();
            this.detailDateCaption = new System.Windows.Forms.Label();
            this.detailSubjectCaption = new System.Windows.Forms.Label();
            this.detailId = new System.Windows.Forms.Label();
            this.detailRoom = new System.Windows.Forms.Label();
            this.detailBy = new System.Windows.Forms.Label();
            this.detailDate = new System.Windows.Forms.Label();
            this.detailSubject = new System.Windows.Forms.Label();
            this.descriptionCaption = new System.Windows.Forms.Label();
            this.detailDescription = new System.Windows.Forms.Label();
            this.updateCaption = new System.Windows.Forms.Label();
            this.updateBox = new System.Windows.Forms.TextBox();
            this.acknowledgeButton = new System.Windows.Forms.Button();
            this.resolveButton = new System.Windows.Forms.Button();
            this.sidebarPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            this.totalCard.SuspendLayout();
            this.pendingCard.SuspendLayout();
            this.progressCard.SuspendLayout();
            this.resolvedCard.SuspendLayout();
            this.requestListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.detailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AssistanceRequestsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 248);
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(1120, 760);
            this.Name = "AssistanceRequestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BE-2 | Assistance Requests";
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(13, 65, 49);
            this.sidebarPanel.Controls.Add(this.brandLabel);
            this.sidebarPanel.Controls.Add(this.navDashboard);
            this.sidebarPanel.Controls.Add(this.navDevices);
            this.sidebarPanel.Controls.Add(this.navRooms);
            this.sidebarPanel.Controls.Add(this.navAssistance);
            this.sidebarPanel.Controls.Add(this.navBroadcast);
            this.sidebarPanel.Controls.Add(this.navReports);
            this.sidebarPanel.Controls.Add(this.navSettings);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(238, 900);
            this.sidebarPanel.TabIndex = 0;
            // 
            // brandLabel
            // 
            this.brandLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.brandLabel.ForeColor = System.Drawing.Color.White;
            this.brandLabel.Location = new System.Drawing.Point(22, 22);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(200, 58);
            this.brandLabel.TabIndex = 0;
            this.brandLabel.Text = "◈  BE-2\r\n    Device Monitoring";
            // 
            // navDashboard
            // 
            this.navDashboard.BackColor = System.Drawing.Color.FromArgb(13, 65, 49);
            this.navDashboard.ForeColor = System.Drawing.Color.White;
            this.navDashboard.Location = new System.Drawing.Point(10, 115);
            this.navDashboard.Name = "navDashboard";
            this.navDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.navDashboard.Size = new System.Drawing.Size(218, 42);
            this.navDashboard.TabIndex = 1;
            this.navDashboard.Text = "⌂   Dashboard";
            this.navDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navDevices
            // 
            this.navDevices.ForeColor = System.Drawing.Color.White;
            this.navDevices.Location = new System.Drawing.Point(10, 168);
            this.navDevices.Name = "navDevices";
            this.navDevices.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.navDevices.Size = new System.Drawing.Size(218, 42);
            this.navDevices.TabIndex = 2;
            this.navDevices.Text = "▣   Devices";
            this.navDevices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navRooms
            // 
            this.navRooms.ForeColor = System.Drawing.Color.White;
            this.navRooms.Location = new System.Drawing.Point(10, 221);
            this.navRooms.Name = "navRooms";
            this.navRooms.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.navRooms.Size = new System.Drawing.Size(218, 42);
            this.navRooms.TabIndex = 3;
            this.navRooms.Text = "▤   Rooms";
            this.navRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navAssistance
            // 
            this.navAssistance.BackColor = System.Drawing.Color.FromArgb(40, 112, 83);
            this.navAssistance.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.navAssistance.ForeColor = System.Drawing.Color.White;
            this.navAssistance.Location = new System.Drawing.Point(10, 274);
            this.navAssistance.Name = "navAssistance";
            this.navAssistance.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.navAssistance.Size = new System.Drawing.Size(218, 42);
            this.navAssistance.TabIndex = 4;
            this.navAssistance.Text = "◉   Assistance Requests";
            this.navAssistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navBroadcast
            // 
            this.navBroadcast.ForeColor = System.Drawing.Color.White;
            this.navBroadcast.Location = new System.Drawing.Point(10, 327);
            this.navBroadcast.Name = "navBroadcast";
            this.navBroadcast.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.navBroadcast.Size = new System.Drawing.Size(218, 42);
            this.navBroadcast.TabIndex = 5;
            this.navBroadcast.Text = "◇   Emergency Broadcast";
            this.navBroadcast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navReports
            // 
            this.navReports.ForeColor = System.Drawing.Color.White;
            this.navReports.Location = new System.Drawing.Point(10, 380);
            this.navReports.Name = "navReports";
            this.navReports.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.navReports.Size = new System.Drawing.Size(218, 42);
            this.navReports.TabIndex = 6;
            this.navReports.Text = "▥   Reports";
            this.navReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navSettings
            // 
            this.navSettings.ForeColor = System.Drawing.Color.White;
            this.navSettings.Location = new System.Drawing.Point(10, 465);
            this.navSettings.Name = "navSettings";
            this.navSettings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.navSettings.Size = new System.Drawing.Size(218, 42);
            this.navSettings.TabIndex = 7;
            this.navSettings.Text = "⚙   Settings";
            this.navSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.userLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(238, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1202, 66);
            this.topPanel.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(28, 36, 34);
            this.userLabel.Location = new System.Drawing.Point(872, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(330, 66);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "●   Miguel     Desktop Developer     ▾";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(247, 249, 248);
            this.contentPanel.Controls.Add(this.headingLabel);
            this.contentPanel.Controls.Add(this.subtitleLabel);
            this.contentPanel.Controls.Add(this.statsPanel);
            this.contentPanel.Controls.Add(this.requestListPanel);
            this.contentPanel.Controls.Add(this.detailsPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(238, 66);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.contentPanel.Size = new System.Drawing.Size(1202, 834);
            this.contentPanel.TabIndex = 2;
            // 
            // headingLabel
            // 
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.headingLabel.ForeColor = System.Drawing.Color.Black;
            this.headingLabel.Location = new System.Drawing.Point(28, 20);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(600, 42);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "◉  Assistance Requests";
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(75, 83, 80);
            this.subtitleLabel.Location = new System.Drawing.Point(31, 65);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(650, 28);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "Verify and handle assistance requests from rooms.";
            // 
            // statsPanel
            // 
            this.statsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.statsPanel.Controls.Add(this.totalCard);
            this.statsPanel.Controls.Add(this.pendingCard);
            this.statsPanel.Controls.Add(this.progressCard);
            this.statsPanel.Controls.Add(this.resolvedCard);
            this.statsPanel.Location = new System.Drawing.Point(28, 112);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(1140, 104);
            this.statsPanel.TabIndex = 2;
            this.statsPanel.WrapContents = false;
            // 
            // totalCard
            // 
            this.totalCard.BackColor = System.Drawing.Color.FromArgb(232, 246, 238);
            this.totalCard.Controls.Add(this.totalCaption);
            this.totalCard.Controls.Add(this.totalValue);
            this.totalCard.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.totalCard.Name = "totalCard";
            this.totalCard.Size = new System.Drawing.Size(270, 88);
            this.totalCard.TabIndex = 0;
            // 
            // totalCaption
            // 
            this.totalCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.totalCaption.ForeColor = System.Drawing.Color.FromArgb(72, 82, 77);
            this.totalCaption.Location = new System.Drawing.Point(16, 13);
            this.totalCaption.Name = "totalCaption";
            this.totalCaption.Size = new System.Drawing.Size(230, 20);
            this.totalCaption.TabIndex = 0;
            this.totalCaption.Text = "TOTAL REQUESTS";
            // 
            // totalValue
            // 
            this.totalValue.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.totalValue.ForeColor = System.Drawing.Color.FromArgb(22, 105, 73);
            this.totalValue.Location = new System.Drawing.Point(16, 32);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(230, 42);
            this.totalValue.TabIndex = 1;
            this.totalValue.Text = "0";
            // 
            // pendingCard
            // 
            this.pendingCard.BackColor = System.Drawing.Color.FromArgb(255, 247, 225);
            this.pendingCard.Controls.Add(this.pendingCaption);
            this.pendingCard.Controls.Add(this.pendingValue);
            this.pendingCard.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.pendingCard.Name = "pendingCard";
            this.pendingCard.Size = new System.Drawing.Size(270, 88);
            this.pendingCard.TabIndex = 1;
            // 
            // pendingCaption
            // 
            this.pendingCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.pendingCaption.ForeColor = System.Drawing.Color.FromArgb(72, 82, 77);
            this.pendingCaption.Location = new System.Drawing.Point(16, 13);
            this.pendingCaption.Name = "pendingCaption";
            this.pendingCaption.Size = new System.Drawing.Size(230, 20);
            this.pendingCaption.TabIndex = 0;
            this.pendingCaption.Text = "PENDING";
            // 
            // pendingValue
            // 
            this.pendingValue.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.pendingValue.ForeColor = System.Drawing.Color.FromArgb(160, 100, 0);
            this.pendingValue.Location = new System.Drawing.Point(16, 32);
            this.pendingValue.Name = "pendingValue";
            this.pendingValue.Size = new System.Drawing.Size(230, 42);
            this.pendingValue.TabIndex = 1;
            this.pendingValue.Text = "0";
            // 
            // progressCard
            // 
            this.progressCard.BackColor = System.Drawing.Color.FromArgb(232, 242, 252);
            this.progressCard.Controls.Add(this.progressCaption);
            this.progressCard.Controls.Add(this.progressValue);
            this.progressCard.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.progressCard.Name = "progressCard";
            this.progressCard.Size = new System.Drawing.Size(270, 88);
            this.progressCard.TabIndex = 2;
            // 
            // progressCaption
            // 
            this.progressCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.progressCaption.ForeColor = System.Drawing.Color.FromArgb(72, 82, 77);
            this.progressCaption.Location = new System.Drawing.Point(16, 13);
            this.progressCaption.Name = "progressCaption";
            this.progressCaption.Size = new System.Drawing.Size(230, 20);
            this.progressCaption.TabIndex = 0;
            this.progressCaption.Text = "IN PROGRESS";
            // 
            // progressValue
            // 
            this.progressValue.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.progressValue.ForeColor = System.Drawing.Color.FromArgb(25, 94, 160);
            this.progressValue.Location = new System.Drawing.Point(16, 32);
            this.progressValue.Name = "progressValue";
            this.progressValue.Size = new System.Drawing.Size(230, 42);
            this.progressValue.TabIndex = 1;
            this.progressValue.Text = "0";
            // 
            // resolvedCard
            // 
            this.resolvedCard.BackColor = System.Drawing.Color.FromArgb(225, 245, 234);
            this.resolvedCard.Controls.Add(this.resolvedCaption);
            this.resolvedCard.Controls.Add(this.resolvedValue);
            this.resolvedCard.Margin = new System.Windows.Forms.Padding(0);
            this.resolvedCard.Name = "resolvedCard";
            this.resolvedCard.Size = new System.Drawing.Size(270, 88);
            this.resolvedCard.TabIndex = 3;
            // 
            // resolvedCaption
            // 
            this.resolvedCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.resolvedCaption.ForeColor = System.Drawing.Color.FromArgb(72, 82, 77);
            this.resolvedCaption.Location = new System.Drawing.Point(16, 13);
            this.resolvedCaption.Name = "resolvedCaption";
            this.resolvedCaption.Size = new System.Drawing.Size(230, 20);
            this.resolvedCaption.TabIndex = 0;
            this.resolvedCaption.Text = "RESOLVED";
            // 
            // resolvedValue
            // 
            this.resolvedValue.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.resolvedValue.ForeColor = System.Drawing.Color.FromArgb(18, 117, 72);
            this.resolvedValue.Location = new System.Drawing.Point(16, 32);
            this.resolvedValue.Name = "resolvedValue";
            this.resolvedValue.Size = new System.Drawing.Size(230, 42);
            this.resolvedValue.TabIndex = 1;
            this.resolvedValue.Text = "0";
            // 
            // requestListPanel
            // 
            this.requestListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left))));
            this.requestListPanel.BackColor = System.Drawing.Color.White;
            this.requestListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestListPanel.Controls.Add(this.requestListTitle);
            this.requestListPanel.Controls.Add(this.searchBox);
            this.requestListPanel.Controls.Add(this.statusFilter);
            this.requestListPanel.Controls.Add(this.grid);
            this.requestListPanel.Location = new System.Drawing.Point(28, 235);
            this.requestListPanel.Name = "requestListPanel";
            this.requestListPanel.Size = new System.Drawing.Size(690, 555);
            this.requestListPanel.TabIndex = 3;
            // 
            // requestListTitle
            // 
            this.requestListTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.requestListTitle.Location = new System.Drawing.Point(20, 16);
            this.requestListTitle.Name = "requestListTitle";
            this.requestListTitle.Size = new System.Drawing.Size(250, 30);
            this.requestListTitle.TabIndex = 0;
            this.requestListTitle.Text = "Request List";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchBox.Location = new System.Drawing.Point(20, 58);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(365, 25);
            this.searchBox.TabIndex = 1;
            // 
            // statusFilter
            // 
            this.statusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusFilter.FormattingEnabled = true;
            this.statusFilter.Items.AddRange(new object[] { "All Status", "Pending", "In Progress", "Resolved" });
            this.statusFilter.Location = new System.Drawing.Point(400, 58);
            this.statusFilter.Name = "statusFilter";
            this.statusFilter.Size = new System.Drawing.Size(265, 25);
            this.statusFilter.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersHeight = 38;
            this.grid.Location = new System.Drawing.Point(18, 105);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 55;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(650, 420);
            this.grid.TabIndex = 3;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(246, 248, 247);
            this.grid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(28, 36, 34);
            this.grid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grid.GridColor = System.Drawing.Color.FromArgb(231, 235, 233);
            this.grid.Columns.Add("id", "REQUEST ID");
            this.grid.Columns.Add("room", "ROOM");
            this.grid.Columns.Add("subject", "SUBJECT");
            this.grid.Columns.Add("status", "STATUS");
            this.grid.Columns[0].FillWeight = 82;
            this.grid.Columns[1].FillWeight = 72;
            this.grid.Columns[2].FillWeight = 135;
            this.grid.Columns[3].FillWeight = 75;
            // 
            // detailsPanel
            // 
            this.detailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsPanel.BackColor = System.Drawing.Color.White;
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsPanel.Controls.Add(this.requestDetailsTitle);
            this.detailsPanel.Controls.Add(this.detailStatus);
            this.detailsPanel.Controls.Add(this.detailIdCaption);
            this.detailsPanel.Controls.Add(this.detailRoomCaption);
            this.detailsPanel.Controls.Add(this.detailByCaption);
            this.detailsPanel.Controls.Add(this.detailDateCaption);
            this.detailsPanel.Controls.Add(this.detailSubjectCaption);
            this.detailsPanel.Controls.Add(this.detailId);
            this.detailsPanel.Controls.Add(this.detailRoom);
            this.detailsPanel.Controls.Add(this.detailBy);
            this.detailsPanel.Controls.Add(this.detailDate);
            this.detailsPanel.Controls.Add(this.detailSubject);
            this.detailsPanel.Controls.Add(this.descriptionCaption);
            this.detailsPanel.Controls.Add(this.detailDescription);
            this.detailsPanel.Controls.Add(this.updateCaption);
            this.detailsPanel.Controls.Add(this.updateBox);
            this.detailsPanel.Controls.Add(this.acknowledgeButton);
            this.detailsPanel.Controls.Add(this.resolveButton);
            this.detailsPanel.Location = new System.Drawing.Point(738, 235);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(430, 555);
            this.detailsPanel.TabIndex = 4;
            // 
            // requestDetailsTitle
            // 
            this.requestDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.requestDetailsTitle.Location = new System.Drawing.Point(20, 16);
            this.requestDetailsTitle.Name = "requestDetailsTitle";
            this.requestDetailsTitle.Size = new System.Drawing.Size(250, 30);
            this.requestDetailsTitle.TabIndex = 0;
            this.requestDetailsTitle.Text = "Request Details";
            // 
            // detailStatus
            // 
            this.detailStatus.BackColor = System.Drawing.Color.FromArgb(255, 242, 205);
            this.detailStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.detailStatus.ForeColor = System.Drawing.Color.FromArgb(140, 80, 0);
            this.detailStatus.Location = new System.Drawing.Point(300, 17);
            this.detailStatus.Name = "detailStatus";
            this.detailStatus.Size = new System.Drawing.Size(105, 29);
            this.detailStatus.TabIndex = 1;
            this.detailStatus.Text = "Pending";
            this.detailStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // detail captions and values
            // 
            this.detailIdCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.detailIdCaption.ForeColor = System.Drawing.Color.FromArgb(93, 103, 98);
            this.detailIdCaption.Location = new System.Drawing.Point(22, 68);
            this.detailIdCaption.Name = "detailIdCaption";
            this.detailIdCaption.Size = new System.Drawing.Size(130, 18);
            this.detailIdCaption.Text = "REQUEST ID";
            this.detailRoomCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.detailRoomCaption.ForeColor = System.Drawing.Color.FromArgb(93, 103, 98);
            this.detailRoomCaption.Location = new System.Drawing.Point(22, 107);
            this.detailRoomCaption.Name = "detailRoomCaption";
            this.detailRoomCaption.Size = new System.Drawing.Size(130, 18);
            this.detailRoomCaption.Text = "ROOM";
            this.detailByCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.detailByCaption.ForeColor = System.Drawing.Color.FromArgb(93, 103, 98);
            this.detailByCaption.Location = new System.Drawing.Point(22, 146);
            this.detailByCaption.Name = "detailByCaption";
            this.detailByCaption.Size = new System.Drawing.Size(130, 18);
            this.detailByCaption.Text = "REQUESTED BY";
            this.detailDateCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.detailDateCaption.ForeColor = System.Drawing.Color.FromArgb(93, 103, 98);
            this.detailDateCaption.Location = new System.Drawing.Point(22, 185);
            this.detailDateCaption.Name = "detailDateCaption";
            this.detailDateCaption.Size = new System.Drawing.Size(130, 18);
            this.detailDateCaption.Text = "DATE & TIME";
            this.detailSubjectCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.detailSubjectCaption.ForeColor = System.Drawing.Color.FromArgb(93, 103, 98);
            this.detailSubjectCaption.Location = new System.Drawing.Point(22, 224);
            this.detailSubjectCaption.Name = "detailSubjectCaption";
            this.detailSubjectCaption.Size = new System.Drawing.Size(130, 18);
            this.detailSubjectCaption.Text = "SUBJECT";
            this.detailId.Location = new System.Drawing.Point(158, 68);
            this.detailId.Name = "detailId";
            this.detailId.Size = new System.Drawing.Size(245, 22);
            this.detailId.Text = "-";
            this.detailRoom.Location = new System.Drawing.Point(158, 107);
            this.detailRoom.Name = "detailRoom";
            this.detailRoom.Size = new System.Drawing.Size(245, 22);
            this.detailRoom.Text = "-";
            this.detailBy.Location = new System.Drawing.Point(158, 146);
            this.detailBy.Name = "detailBy";
            this.detailBy.Size = new System.Drawing.Size(245, 22);
            this.detailBy.Text = "-";
            this.detailDate.Location = new System.Drawing.Point(158, 185);
            this.detailDate.Name = "detailDate";
            this.detailDate.Size = new System.Drawing.Size(245, 22);
            this.detailDate.Text = "-";
            this.detailSubject.Location = new System.Drawing.Point(158, 224);
            this.detailSubject.Name = "detailSubject";
            this.detailSubject.Size = new System.Drawing.Size(245, 22);
            this.detailSubject.Text = "-";
            // 
            // description
            // 
            this.descriptionCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.descriptionCaption.ForeColor = System.Drawing.Color.FromArgb(93, 103, 98);
            this.descriptionCaption.Location = new System.Drawing.Point(22, 263);
            this.descriptionCaption.Name = "descriptionCaption";
            this.descriptionCaption.Size = new System.Drawing.Size(220, 20);
            this.descriptionCaption.Text = "REQUEST DESCRIPTION";
            this.detailDescription.BackColor = System.Drawing.Color.FromArgb(246, 248, 247);
            this.detailDescription.Location = new System.Drawing.Point(22, 286);
            this.detailDescription.Name = "detailDescription";
            this.detailDescription.Padding = new System.Windows.Forms.Padding(10);
            this.detailDescription.Size = new System.Drawing.Size(380, 55);
            this.detailDescription.Text = "-";
            // 
            // update
            // 
            this.updateCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.updateCaption.Location = new System.Drawing.Point(22, 357);
            this.updateCaption.Name = "updateCaption";
            this.updateCaption.Size = new System.Drawing.Size(200, 20);
            this.updateCaption.Text = "ACTION / UPDATE";
            this.updateBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.updateBox.Location = new System.Drawing.Point(22, 382);
            this.updateBox.Multiline = true;
            this.updateBox.Name = "updateBox";
            this.updateBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.updateBox.Size = new System.Drawing.Size(380, 72);
            this.updateBox.TabIndex = 1;
            // 
            // acknowledgeButton
            // 
            this.acknowledgeButton.BackColor = System.Drawing.Color.White;
            this.acknowledgeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acknowledgeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(22, 105, 73);
            this.acknowledgeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.acknowledgeButton.ForeColor = System.Drawing.Color.FromArgb(22, 105, 73);
            this.acknowledgeButton.Location = new System.Drawing.Point(22, 474);
            this.acknowledgeButton.Name = "acknowledgeButton";
            this.acknowledgeButton.Size = new System.Drawing.Size(180, 40);
            this.acknowledgeButton.TabIndex = 2;
            this.acknowledgeButton.Text = "Acknowledge";
            this.acknowledgeButton.UseVisualStyleBackColor = false;
            // 
            // resolveButton
            // 
            this.resolveButton.BackColor = System.Drawing.Color.FromArgb(22, 105, 73);
            this.resolveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resolveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.resolveButton.ForeColor = System.Drawing.Color.White;
            this.resolveButton.Location = new System.Drawing.Point(215, 474);
            this.resolveButton.Name = "resolveButton";
            this.resolveButton.Size = new System.Drawing.Size(187, 40);
            this.resolveButton.TabIndex = 3;
            this.resolveButton.Text = "Resolve";
            this.resolveButton.UseVisualStyleBackColor = false;
            // 
            // final layout
            // 
            this.sidebarPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.statsPanel.ResumeLayout(false);
            this.totalCard.ResumeLayout(false);
            this.pendingCard.ResumeLayout(false);
            this.progressCard.ResumeLayout(false);
            this.resolvedCard.ResumeLayout(false);
            this.requestListPanel.ResumeLayout(false);
            this.requestListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
