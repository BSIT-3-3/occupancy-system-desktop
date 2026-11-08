using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using Krypton.Toolkit;
using OccupancyMonitor.Forms;
using OccupancyMonitor.Models;
using OccupancyMonitor.Services;

namespace OccupancyMonitor
{
    public partial class MainForm : Form
    {
        private Dashboard _dashboard;
        private ucRoom _room;
        private uccDeviceManagement _deviceManagement;
        private ucUserProfile _userManagement;
        private readonly DeviceMonitoringService _deviceMonitoringService;
        private readonly string _accessToken;
        private readonly Timer _deviceMonitoringTimer;
        private bool _isRefreshingDeviceMonitoring;

        public MainForm(string accesstoken, ApiClient apiClient)

        {
            InitializeComponent();
            _accessToken = accesstoken;
            _deviceMonitoringService = new DeviceMonitoringService(apiClient);
            _deviceMonitoringTimer = new Timer { Interval = 30000 };
            _deviceMonitoringTimer.Tick += async (sender, args) => await RefreshDeviceMonitoringAsync();
            FormClosed += (sender, args) => _deviceMonitoringTimer.Stop();
            lblTotal.Text = "--";
            toolStripLabel2.Text = "--";
            lblInactive.Text = "--";
            lblConnection.Text = "Device status loading";
            _dashboard = new Dashboard();
            var roomService = new RoomService(apiClient);
            _room = new ucRoom(roomService, accesstoken);
            _deviceManagement = new uccDeviceManagement(new DeviceService(apiClient), roomService, accesstoken);
            UserService _userService = new UserService(apiClient);
            _userManagement = new ucUserProfile(_userService, accesstoken);
            ShowScreen(_dashboard);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            kbtnDashboard.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbtnDashboard.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbtnDashboard.OverrideFocus.Border.Draw = InheritBool.False;

            await RefreshDeviceMonitoringAsync();
            _deviceMonitoringTimer.Start();
        }

        private async Task RefreshDeviceMonitoringAsync()
        {
            if (_isRefreshingDeviceMonitoring || IsDisposed || Disposing)
            {
                return;
            }

            _isRefreshingDeviceMonitoring = true;
            try
            {
                DeviceMonitoringSummary summary = await _deviceMonitoringService.GetSummaryAsync(_accessToken);
                if (IsDisposed || Disposing)
                {
                    return;
                }
                if (!IsValidSummary(summary))
                {
                    throw new InvalidOperationException("The device monitoring response is incomplete or inconsistent.");
                }

                int registered = summary.registered_count.Value;
                int active = summary.active_count.Value;
                int online = summary.online_count.Value;
                int offline = summary.offline_count.Value;
                int unknown = summary.unknown_count.Value;

                lblTotal.Text = registered.ToString();
                toolStripLabel2.Text = active.ToString();
                lblInactive.Text = (registered - active).ToString();
                lblConnection.Text = string.Format(
                    "Online: {0} | Offline: {1} | Unknown: {2}", online, offline, unknown);
                lblConnection.ToolTipText = "Device connection state from the monitoring API";
            }
            catch (ApiResponseDeserializationException error)
            {
                LogDeviceMonitoringFailure(error, error.StatusCode, error.ResponseBody);
                ShowDeviceMonitoringUnavailable();
            }
            catch (ApiException error)
            {
                LogDeviceMonitoringFailure(error, error.StatusCode, error.ResponseBody);
                ShowDeviceMonitoringUnavailable();
            }
            catch (TaskCanceledException error)
            {
                LogDeviceMonitoringFailure(error);
                ShowDeviceMonitoringUnavailable();
            }
            catch (Exception error)
            {
                LogDeviceMonitoringFailure(error);
                ShowDeviceMonitoringUnavailable();
            }
            finally
            {
                _isRefreshingDeviceMonitoring = false;
            }
        }

        private void ShowDeviceMonitoringUnavailable()
        {
            if (IsDisposed || Disposing)
            {
                return;
            }

            lblTotal.Text = "--";
            toolStripLabel2.Text = "--";
            lblInactive.Text = "--";
            lblConnection.Text = "Device status unavailable";
            lblConnection.ToolTipText = "Could not load device status from the monitoring API";
        }

        private static void LogDeviceMonitoringFailure(
            Exception error,
            HttpStatusCode? statusCode = null,
            string responseBody = null)
        {
            string safeBody = string.IsNullOrWhiteSpace(responseBody)
                ? "<empty>"
                : Regex.Replace(
                    responseBody,
                    "(\\\"(?:access_token|refresh_token|token|password|device_key|authorization)\\\"\\s*:\\s*)\\\"[^\\\"]*\\\"",
                    "$1\\\"[REDACTED]\\\"",
                    RegexOptions.IgnoreCase);

            if (safeBody.Length > 2000)
            {
                safeBody = safeBody.Substring(0, 2000) + "…";
            }

            string status = statusCode.HasValue ? ((int)statusCode.Value).ToString() : "unavailable";
            string detail = error is ApiResponseDeserializationException && error.InnerException != null
                ? error.InnerException.GetType().Name + ": " + error.InnerException.Message
                : error.Message;

            Trace.TraceError(
                "Device monitoring summary request failed. ExceptionType={0}; Message={1}; HTTPStatus={2}; ResponseBody={3}",
                error.GetType().FullName,
                detail,
                status,
                safeBody);
        }

        private static bool IsValidSummary(DeviceMonitoringSummary summary)
        {
            if (summary == null ||
                !summary.registered_count.HasValue ||
                !summary.active_count.HasValue ||
                !summary.online_count.HasValue ||
                !summary.offline_count.HasValue ||
                !summary.unknown_count.HasValue)
            {
                return false;
            }

            int registered = summary.registered_count.Value;
            int active = summary.active_count.Value;
            int online = summary.online_count.Value;
            int offline = summary.offline_count.Value;
            int unknown = summary.unknown_count.Value;
            return registered >= 0 && active >= 0 && active <= registered &&
                online >= 0 && offline >= 0 && unknown >= 0 &&
                online + offline + unknown == active;
        }

        private void ShowScreen(UserControl screen)
        {
            foreach (UserControl currentScreen in plContent.Controls.OfType<UserControl>().ToList())
            {
                plContent.Controls.Remove(currentScreen);
            }

            screen.Dock = DockStyle.Fill;

            plContent.Controls.Add(screen);
            toolStrip1.BringToFront();
        }

        private void kbtnDashboard_Click(object sender, EventArgs e)
        {
            ShowScreen(_dashboard);
        }

        private void kplNavBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kBtnActiveEmergency_Click(object sender, EventArgs e)
        {

        }

        private void kbtnUserManagement_Click(object sender, EventArgs e)
        {
            ShowScreen(_userManagement);
        }

        private void btnRoomManagement_Click(object sender, EventArgs e)
        {
            ShowScreen(_room);
        }

        private async void btnDeviceManagement_Click(object sender, EventArgs e)
        {
            ShowScreen(_deviceManagement);
            await _deviceManagement.RefreshDataAsync();
        }
    }
}
