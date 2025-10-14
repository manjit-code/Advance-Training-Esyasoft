using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Gateway: Device
    {
        public string IpAddress;

        // Constructor
        public Gateway(string Id, DateTime InstalledOn, string IpAddress) : base(Id, InstalledOn) { 
            this.IpAddress = IpAddress;
        }
        public override void Describe()
        {
            Console.WriteLine($"Gateway Id:{Id} | Installed: {InstalledOn} | IP: {IpAddress}");
        }
    }
}
