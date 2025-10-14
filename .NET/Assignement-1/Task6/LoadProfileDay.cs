using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class LoadProfileDay
    {
        public DateTime Date { get; }
        public int[] HourlyKwh { get; } // length 24
        public LoadProfileDay(DateTime date, int[] hourly)
        {
            // clone array; validate length == 24; values >= 0
            if(hourly.Length != 24)
            {
                Console.WriteLine("Invalid hourly array Provided");
                return;
            }
            HourlyKwh = hourly;
            Date = date;
        }
        public int Total => HourlyKwh.Sum();
        public int PeakHour
        {
            get
            {
                return Array.IndexOf(HourlyKwh, HourlyKwh.Max()) + 1;
            }
        }
    }
}
