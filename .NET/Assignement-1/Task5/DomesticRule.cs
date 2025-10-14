using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class DomesticRule: IBillingRule
    {
        public String category { get; set; } = "DOMESTIC";


        public double Compute(int units)
        {
            return (6.0 * units + 50);
        }
    }
}
