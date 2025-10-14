using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal interface IRebate
    {
        string Code { get; }
        double Apply(double currentTotal, int outageDays);

    }
}
