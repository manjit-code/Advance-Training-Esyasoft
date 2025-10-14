using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    public abstract class Event
    {
        public DateTime When { get; }
        public string MeterSerial { get; }

        protected Event(DateTime when, string meterSerial)
        {
            When = when;
            MeterSerial = meterSerial;
        }

        public abstract string Category { get; }
        public abstract int Severity { get; }

        public virtual string Describe()
        {
            return $"{When:yyyy-MM-dd HH:mm} [{Category}] {MeterSerial}";
        }
    }
}
