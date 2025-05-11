using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RCP
{
    public static class WakeOnLan
    {
        public static void SendMagicPacket(string macAddress, string broadcastIP, int port)
        {
            macAddress = Regex.Replace(macAddress, "[-:]", "");
            if (macAddress.Length != 12)
            {
                MessageBox.Show("MAC-Address is in Wrong format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IPAddress.TryParse(broadcastIP, out _))
            {
                MessageBox.Show("Broadcast-Address is in Wrong format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (port < 1 || port > 65535)
            {
                MessageBox.Show("Port out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] macBytes = new byte[6];
            for (int i = 0; i < 6; i++)
                macBytes[i] = Convert.ToByte(macAddress.Substring(i * 2, 2), 16);

            byte[] packet = new byte[102];
            for (int i = 0; i < 6; i++)
                packet[i] = 0xFF;
            for (int i = 1; i <= 16; i++)
                Buffer.BlockCopy(macBytes, 0, packet, i * 6, 6);

            using (UdpClient client = new UdpClient())
            {
                client.EnableBroadcast = true;
                client.Send(packet, packet.Length, new IPEndPoint(IPAddress.Parse(broadcastIP), port));
            }

            Console.WriteLine($"Magic packet sent to {macAddress} on {broadcastIP}:{port}");
        }
    }
}
