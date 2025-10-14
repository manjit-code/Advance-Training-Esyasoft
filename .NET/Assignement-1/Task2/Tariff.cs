using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Tariff
    {
        public string Name;
        public double RatePerKwh, FixedCharge;

        public Tariff(string name)
        {
            Name = name;
            RatePerKwh = 6.0;
            FixedCharge = 50;
        }

        bool ValidateFixedCharge(double fixedCharge)
        {
            return fixedCharge >= 0;
        }

        bool ValidateRate(double rate)
        {
            return rate > 0;
        }
        public Tariff(string name, double rate)
        {
            if (!ValidateRate(rate))
            {
                Console.WriteLine("Invalid Rate !!");
                return;
            }
            Name = name;
            RatePerKwh = rate;
            FixedCharge = 50;
        }
        public Tariff(string name, double rate, double fixedCharge)
        {
            if (!ValidateRate(rate) || !ValidateFixedCharge(fixedCharge))
            {
                Console.WriteLine("Invalid Rate OR Fixed Charge !!");
                return;
            }
            Name = name;
            RatePerKwh = rate;
            FixedCharge = fixedCharge;
        }

        public double ComputeBill(int units)
        {
            double calculatedValue = units*RatePerKwh + FixedCharge;
            Console.WriteLine($"{Name} : {calculatedValue}");
            return calculatedValue;
        }
    }
}
