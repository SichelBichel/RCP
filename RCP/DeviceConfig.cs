using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCP
{
    public class DeviceConfig
    {
        public string HostName { get; set; } = "GenericServer";
        public string DeviceName { get; set; } = "NoName-Brand";
        public string MacAddress { get; set; } = "insert-mac-address";
        public string BroadcastAddress { get; set; } = "broadcast address";
        public string DeviceIP { get; set; } = "DeviceIP";
        public int Port { get; set; } = 9;
        public bool? IsOnline { get; set; } = null;
    }
}
