using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class PeakHourRule: AlarmRule
    {
        private readonly double _peakThresold;

        public PeakHourRule(double peakThresold) : base("PeakHour")
        {
            _peakThresold = peakThresold;
        }

        public override bool IsTriggered(LoadProfileDay day)
        {
            return day.HourlyKwh.Any(load => load > _peakThresold);
        }

        public override string Message(LoadProfileDay day)
        {
            var peakHour = day.HourlyKwh
                .Select((load, index) => (load, index))
                .FirstOrDefault(x => x.load > _peakThresold);

            return $"{Name} triggered on {day.Date:yyyy-MM-dd} " +
                   $"(hour {peakHour.index}: {peakHour.load:F1} units)";
        }
    }
}
