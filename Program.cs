using System;
using System.Windows.Forms;
using System.Net.Http;
using OccupancyMonitor.Forms;
using OccupancyMonitor.Services;

namespace OccupancyMonitor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var httpClient = new HttpClient
            {
                BaseAddress = new System.Uri("http://127.0.0.1:5000/")
            };
            var apiClient = new ApiClient(httpClient);
            Application.Run(new WindowsFormsApp1.frmLogin(apiClient));
        }
    }
}
