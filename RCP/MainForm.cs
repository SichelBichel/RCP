using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Xml.Serialization;

namespace RCP
{
    public partial class MainForm : Form
    {
        private List<DeviceConfig> devices = new();
        private CancellationTokenSource statusCts;
        public MainForm()
        {
            InitializeComponent();
            PostInit();
            flowPanelDevices.AutoScroll = true;
            flowPanelDevices.HorizontalScroll.Enabled = false;
            flowPanelDevices.HorizontalScroll.Visible = false;
            flowPanelDevices.VerticalScroll.Visible = true;
            flowPanelDevices.VerticalScroll.Enabled = true;
            flowPanelDevices.AutoScrollMinSize = new Size(0, flowPanelDevices.Height + 1);
        }

        private async Task PostInit()
        {
            try
            {
                await Task.Delay(250);
                buttonReloadConfig_Click(null, null);
                StartBackgroundStatusPolling();
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
                MessageBox.Show($"{filePath} not found, Generating...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CreateDefaultConfig();
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


        private DeviceConfig CreateDefaultConfig()
        {
            try
            {
                var defaultDevice = new DeviceConfig
                {
                    HostName = "HostName",
                    DeviceName = "DeviceName",
                    MacAddress = "127.0.0.1",
                    BroadcastAddress = "127.0.0.255",
                    DeviceIP = "127.0.0.1",
                    Port = 9,
                };

                var defaultDevices = new List<DeviceConfig> { defaultDevice };

                XmlSerializer serializer = new XmlSerializer(typeof(List<DeviceConfig>));
                using FileStream stream = new FileStream("DeviceConfig.xml", FileMode.Create);
                serializer.Serialize(stream, defaultDevices);
                awaitCFGEN();
                return defaultDevice;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception while generating new CFG: {ex.Message}", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private async Task awaitCFGEN()
        {
            await Task.Delay(250);
            buttonReloadConfig_Click(null, null);
        }

        private async void StartBackgroundStatusPolling()
        {
            statusCts = new CancellationTokenSource();
            while (!statusCts.Token.IsCancellationRequested)
            {
                foreach (Control control in flowPanelDevices.Controls)
                {
                    if (control is HostCard card)
                    {
                        var device = card.DeviceConfig;
                        _ = UpdateServerStatusAsync(device, card);
                    }
                }

                await Task.Delay(1000, statusCts.Token); // Wait 1 second
            }
        }





        private void inputStartServer(object sender, EventArgs e)
        {
            //WakeOnLan.SendMagicPacket("94-57-A5-6C-E5-82", "192.168.1.255", 9);
        }

        private void urlOpened(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://rehoga-interactive.com/";

            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void flowPanelDevices_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void inputHelpButton(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("help.txt") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
