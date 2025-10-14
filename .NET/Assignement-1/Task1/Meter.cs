using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Meter
    {
        public string MeterSerial, Location;
        public DateTime InstalledOn;
        public int LastReadingKwh;

        public Meter(string MeterSerial, string Location, int LastReadingKwh) { 
            this.MeterSerial = MeterSerial;
            this.Location = Location;
            this.LastReadingKwh = LastReadingKwh;
            InstalledOn = DateTime.Now;
        }
        public void AddReading(int deltaKwh)
        {
            if (deltaKwh > 0)
            {
                LastReadingKwh += deltaKwh;
                Console.WriteLine("Added Reading Request.");
            }
            else
            {
                Console.WriteLine("Invalid Add Reading Request ! Please Insert Positive Readings Only");
            }
        }
        public string Summary()
        {
            Console.WriteLine($"SERIAL: {MeterSerial} | Location: {Location} | Reading: {LastReadingKwh}");
            return $"SERIAL: {MeterSerial} | Location: {Location} | Reading: {LastReadingKwh}";
        }
    }
}
