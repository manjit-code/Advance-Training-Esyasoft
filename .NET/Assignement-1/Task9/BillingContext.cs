using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class BillingContext
    {
        public IBillingRule Rule { get; }
        public List<IRebate> Rebates { get; } = new();

        public BillingContext(IBillingRule rule)
        {
            Rule = rule;
        }

        public double Finalize(int units, int outageDays)
        {
            double total = Rule.Compute(units);
            double rebateTotal = 0;
            foreach (var r in Rebates)
            {
                rebateTotal += r.Apply(total, outageDays);
            }
            return total + rebateTotal;
        }
    }
}
