using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCP
{
    public partial class HostCard : UserControl
    {
        private DeviceConfig config;

        public event Action<DeviceConfig>? OnDeviceStart;

        public DeviceConfig DeviceConfig => config;
        public HostCard(DeviceConfig config)
        {
            InitializeComponent();
            this.config = config;

            labelDeviceName.Text = config.DeviceName;
            labelHostName.Text = config.HostName;
            labelIP.Text = config.DeviceIP;

            UpdateStatus(config.IsOnline);

            buttonStartDevice.Click += (s, e) => OnDeviceStart?.Invoke(config);
        }

        public void UpdateStatus(bool? isOnline)
        {
            if (isOnline.HasValue)
            {
                labelStatus.Text = isOnline.Value ? "Online" : "Offline";
                labelStatus.ForeColor = isOnline.Value ? Color.Green : Color.Red;
            }
            else
            {
                labelStatus.Text = "Unknown";
                labelStatus.ForeColor = Color.Gray;
            }
        }









        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void labelIP_Click(object sender, EventArgs e)
        {

        }
    }
}
