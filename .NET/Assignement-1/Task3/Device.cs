using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Device
    {
        public string Id;
        public DateTime InstalledOn;


        public Device(string Id, DateTime InstalledOn)
        {
            this.Id = Id;
            this.InstalledOn = InstalledOn;
        }

        public virtual void Describe()
        {
            Console.WriteLine($"Device Id: {Id} \n Installed: {InstalledOn}");
        }
    }
}
