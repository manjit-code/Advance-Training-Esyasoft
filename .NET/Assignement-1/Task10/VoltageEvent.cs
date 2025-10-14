using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class VoltageEvent : Event
    {
        public double Voltage { get; }

        public VoltageEvent(DateTime when, string meterSerial, double voltage) : base(when, meterSerial)
        {
            Voltage = voltage;
        }

        public override string Category => "VOLTAGE";
        public override int Severity => 2;

        public override string Describe()
        {
            return $"{base.Describe()} | V: {Voltage} | Severity: {Severity}";
        }
    }
}
