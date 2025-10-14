using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class HighUsageRebate : IRebate
    {
        public string Code => "HIGH_USAGE";

        public double Apply(double currentTotal, int outageDays)
        {
            return (currentTotal > 500) ? currentTotal * -0.03 : 0;
        }

    }
}
