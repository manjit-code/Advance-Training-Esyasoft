using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class SustainedOutageRule : AlarmRule
    {
        private readonly int _minConsecutive;

        public SustainedOutageRule(int min) : base("SustainedOutage")
        {
            _minConsecutive = min;
        }

        public override bool IsTriggered(LoadProfileDay day)
        {
            int consecutiveZeros = 0;
            foreach (var kwh in day.HourlyKwh)
            {
                if (kwh == 0)
                {
                    consecutiveZeros++;
                    if (consecutiveZeros >= _minConsecutive)
                    {
                        return true;
                    }
                }
                else
                {
                    consecutiveZeros = 0;
                }
            }
            return false;
        }
    }

}
