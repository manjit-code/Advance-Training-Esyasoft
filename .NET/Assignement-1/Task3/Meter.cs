using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Meter: Device
    {
        public int PhaseCount;

        public Meter(string Id, DateTime InstalledOn, int PhaseCount) : base(Id, InstalledOn){
            this.PhaseCount = PhaseCount;
        }

        public override void Describe()
        {
            Console.WriteLine($"Meter Id:{Id} | Installed: {InstalledOn} | Phases Count: {PhaseCount}");
        }
    }
}
