using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public interface IBillingRule {
        public string category { get; set; }
        double Compute(int units); 
    }
}
