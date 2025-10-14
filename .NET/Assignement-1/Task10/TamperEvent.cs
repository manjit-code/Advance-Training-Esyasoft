using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class TamperEvent : Event
    {
        public string Code { get; }

        public TamperEvent(DateTime when, string meterSerial, string code) : base(when, meterSerial)
        {
            Code = code;
        }

        public override string Category => "TAMPER";
        public override int Severity => 5;

        public override string Describe()
        {
            return $"{base.Describe()} | Code: {Code} | Severity: {Severity}";
        }

    }
}
