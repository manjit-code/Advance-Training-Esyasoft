using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class NoOutageRebate : IRebate
    {
        public string Code => "NO_OUTAGE";

        public double Apply(double currentTotal, int outageDays)
        {
            return outageDays == 0 ? currentTotal * -0.02 : 0;
        }
    }
}
