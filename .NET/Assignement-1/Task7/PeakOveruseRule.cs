using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class PeakOveruseRule : AlarmRule
    {
        private readonly int _threshold;

        public PeakOveruseRule(int threshold) : base("PeakOveruse")
        {
            _threshold = threshold;
        }

        public override bool IsTriggered(LoadProfileDay day)
        {
            return day.Total > _threshold;
        }
    }

}
