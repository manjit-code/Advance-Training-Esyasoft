using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class AgricultureRule: IBillingRule
    {
        public String category { get; set; } = "AGRICULTURE";
        public double Compute(int units)
        {
            return (3.0 * units + 0);
        }
    }
}
