using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UI3AssistanceRequests
{
    public partial class AssistanceRequestsForm : Form
    {
        private readonly Color sidebarColor = Color.FromArgb(13, 65, 49);
        private readonly Color green = Color.FromArgb(22, 105, 73);
        private readonly Color ink = Color.FromArgb(28, 36, 34);
        private readonly List<AssistanceRequest> requests = new List<AssistanceRequest>();
        private AssistanceRequest selectedRequest;

        public AssistanceRequestsForm()
        {
            InitializeComponent();
            BuildSampleData();

            searchBox.TextChanged += delegate { ApplyFilter(); };
            statusFilter.SelectedIndexChanged += delegate { ApplyFilter(); };
            grid.CellClick += delegate(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0) SelectRequest(e.RowIndex);
            };
            acknowledgeButton.Click += delegate { UpdateStatus("In Progress"); };
            resolveButton.Click += delegate { UpdateStatus("Resolved"); };

            RefreshDashboard();
            if (grid.Rows.Count > 0) SelectRequest(0);
        }

        private void BuildSampleData()
        {
            requests.Add(new AssistanceRequest { RequestId = "REQ-0147", Room = "Room 204", Subject = "Device not responding", RequestedBy = "Abala", CreatedAt = new DateTime(2026, 10, 24, 10, 32, 0), Description = "Device not responding.", Status = "Pending" });
            requests.Add(new AssistanceRequest { RequestId = "REQ-0146", Room = "Room 201", Subject = "Screen display issue", RequestedBy = "Bautista", CreatedAt = new DateTime(2026, 10, 24, 10, 18, 0), Description = "The room display is not showing the latest information.", Status = "Pending" });
            requests.Add(new AssistanceRequest { RequestId = "REQ-0145", Room = "Room 103", Subject = "No device connection", RequestedBy = "Cruz", CreatedAt = new DateTime(2026, 10, 24, 9, 57, 0), Description = "The room device appears offline.", Status = "In Progress" });
            requests.Add(new AssistanceRequest { RequestId = "REQ-0144", Room = "Room 305", Subject = "History/log not loading", RequestedBy = "Dela Rosa", CreatedAt = new DateTime(2026, 10, 24, 9, 40, 0), Description = "The device history page is not loading.", Status = "Pending" });
            requests.Add(new AssistanceRequest { RequestId = "REQ-0143", Room = "Room 102", Subject = "Unable to access monitoring", RequestedBy = "Garcia", CreatedAt = new DateTime(2026, 10, 24, 9, 21, 0), Description = "Unable to open the monitoring screen.", Status = "Resolved" });
            requests.Add(new AssistanceRequest { RequestId = "REQ-0142", Room = "Room 207", Subject = "Sensor reading concern", RequestedBy = "Lim", CreatedAt = new DateTime(2026, 10, 24, 8, 55, 0), Description = "Please check the room sensor reading.", Status = "In Progress" });
        }

        private void RefreshDashboard()
        {
            totalValue.Text = requests.Count.ToString();
            pendingValue.Text = requests.Count(r => r.Status == "Pending").ToString();
            progressValue.Text = requests.Count(r => r.Status == "In Progress").ToString();
            resolvedValue.Text = requests.Count(r => r.Status == "Resolved").ToString();
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (grid == null) return;
            string term = searchBox.Text.Trim().ToLowerInvariant();
            string status = statusFilter.SelectedItem == null ? "All Status" : statusFilter.SelectedItem.ToString();

            var filtered = requests.Where(r =>
                (status == "All Status" || r.Status == status) &&
                (term.Length == 0 || r.RequestId.ToLowerInvariant().Contains(term) ||
                 r.Room.ToLowerInvariant().Contains(term) || r.Subject.ToLowerInvariant().Contains(term) ||
                 r.RequestedBy.ToLowerInvariant().Contains(term))).ToList();

            grid.Rows.Clear();
            foreach (var r in filtered)
            {
                int row = grid.Rows.Add(r.RequestId, r.Room, r.Subject, r.Status);
                grid.Rows[row].Tag = r;
            }

            if (grid.Rows.Count > 0)
            {
                grid.Rows[0].Selected = true;
                SelectRequest(0);
            }
            else
            {
                selectedRequest = null;
                ClearDetails();
            }
        }

        private void SelectRequest(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= grid.Rows.Count) return;
            selectedRequest = grid.Rows[rowIndex].Tag as AssistanceRequest;
            if (selectedRequest == null) return;

            detailId.Text = selectedRequest.RequestId;
            detailRoom.Text = selectedRequest.Room;
            detailBy.Text = selectedRequest.RequestedBy;
            detailDate.Text = selectedRequest.CreatedAt.ToString("MMM dd, yyyy hh:mm tt");
            detailSubject.Text = selectedRequest.Subject;
            detailDescription.Text = selectedRequest.Description;
            detailStatus.Text = selectedRequest.Status;

            if (selectedRequest.Status == "Resolved")
            {
                detailStatus.BackColor = Color.FromArgb(220, 244, 229);
                detailStatus.ForeColor = Color.FromArgb(18, 117, 72);
            }
            else if (selectedRequest.Status == "In Progress")
            {
                detailStatus.BackColor = Color.FromArgb(226, 240, 253);
                detailStatus.ForeColor = Color.FromArgb(25, 94, 160);
            }
            else
            {
                detailStatus.BackColor = Color.FromArgb(255, 242, 205);
                detailStatus.ForeColor = Color.FromArgb(140, 80, 0);
            }

            updateBox.Text = selectedRequest.StaffUpdate ?? "";
            acknowledgeButton.Enabled = selectedRequest.Status == "Pending";
            resolveButton.Enabled = selectedRequest.Status != "Resolved";
        }

        private void ClearDetails()
        {
            detailId.Text = detailRoom.Text = detailBy.Text = detailDate.Text = detailSubject.Text = detailDescription.Text = "-";
            detailStatus.Text = "No selection";
            updateBox.Text = "";
            acknowledgeButton.Enabled = false;
            resolveButton.Enabled = false;
        }

        private void UpdateStatus(string newStatus)
        {
            if (selectedRequest == null) return;

            if (newStatus == "Resolved" && String.IsNullOrWhiteSpace(updateBox.Text))
            {
                MessageBox.Show("Maglagay muna ng action/update bago i-resolve ang request.",
                    "Action required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateBox.Focus();
                return;
            }

            selectedRequest.Status = newStatus;
            selectedRequest.StaffUpdate = updateBox.Text.Trim();
            RefreshDashboard();

            MessageBox.Show("Na-update ang request sa status na: " + newStatus + Environment.NewLine +
                "DEMO MODE: local sample data lamang ang nabago. Hindi pa ito ipinapadala sa backend.",
                "Request updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
