using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class OutageEvent : Event
    {
        public double DurationMinutes { get; }

        public OutageEvent(DateTime when, string meterSerial, double durationMinutes) : base(when, meterSerial)
        {
            DurationMinutes = durationMinutes;
        }

        public override string Category => "OUTAGE";
        public override int Severity => 3;

        public override string Describe()
        {
            return $"{base.Describe()} | Duration: {DurationMinutes} min | Severity: {Severity}";
        }
    }
}
