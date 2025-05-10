using System.Net.NetworkInformation;
using System.Xml.Serialization;

namespace RCP
{
    public partial class MainForm : Form
    {
        private List<DeviceConfig> devices = new();
        public MainForm()
        {
            InitializeComponent();
        }

        private async Task PostInit()
        {
            try
            {
                await Task.Delay(250);
                buttonReloadConfig_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error");
            }

        }

        private void PopulateDeviceCards()
        {
            flowPanelDevices.Controls.Clear();
            foreach (var server in devices)
            {
                server.IsOnline = null;
                var card = new HostCard(server);
                card.OnDeviceStart += StartDevice;
                flowPanelDevices.Controls.Add(card);

                _ = UpdateServerStatusAsync(server, card);
            }
        }

        private void StartDevice(DeviceConfig config)
        {
            WakeOnLan.SendMagicPacket(config.MacAddress, config.BroadcastAddress, config.Port);
        }

        private async Task UpdateServerStatusAsync(DeviceConfig server, HostCard card)
        {
            bool isOnline = await CheckPingAsync(server);
            server.IsOnline = isOnline;

            Invoke(() =>
            {
                card.UpdateStatus(isOnline);
            });
        }

        private async Task<bool> CheckPingAsync(DeviceConfig config)
        {
            try
            {
                using Ping ping = new Ping();
                PingReply reply = await ping.SendPingAsync(config.DeviceIP, 1000);

                return reply.Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }



        private void buttonReloadConfig_Click(object sender, EventArgs e)
        {
            string filePath = "DeviceConfig.xml";
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"{filePath} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<DeviceConfig>));
                using FileStream stream = new FileStream(filePath, FileMode.Open);
                var loaded = (List<DeviceConfig>?)serializer.Deserialize(stream);

                if (loaded != null)
                {
                    devices = loaded;
                    PopulateDeviceCards();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loading error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }












        private void inputStartServer(object sender, EventArgs e)
        {
            WakeOnLan.SendMagicPacket("94-57-A5-6C-E5-82", "192.168.1.255", 9);
        }
    }
}
