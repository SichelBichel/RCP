namespace RCR
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void inputStartServer(object sender, EventArgs e)
        {
            WakeOnLan.SendMagicPacket("94-57-A5-6C-E5-82", "192.168.1.255", 9);
        }
    }
}
