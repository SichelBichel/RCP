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
        public static void SendMagicPacket(string macAddress, string broadcastIP = "192.168.1.255", int port = 9)
        {
            macAddress = Regex.Replace(macAddress, "[-:]", "");
            if (macAddress.Length != 12)
            {
                throw new ArgumentException("Invalid MAC address format.");
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
