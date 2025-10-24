namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Quick Bill from Two Readings
            string meterSerial;
             double prevReading, currReading;

            Console.Write("Enter Meter Serial Number: ");
            meterSerial = Console.ReadLine();

            Console.Write("Enter Previous Meter Reading: ");
            prevReading = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Current Meter Reading: ");
            currReading = Convert.ToDouble(Console.ReadLine());

            if(prevReading < 0 || currReading < prevReading)
            {
                Console.WriteLine("Invalid Readings");
            }

            double units = currReading - prevReading;

            if (units <= 0)
            {
                Console.Error.WriteLine("Error computing Reading");
            }
            else
            {
                double energyCharge = units * 6.5;
                double tax = 0.05 * units;
                double total = energyCharge + tax;
                Console.WriteLine($"Meter {meterSerial} | Units: {units.ToString("0.##")} | Energy: {energyCharge.ToString("0.##")} | Tax(5%): {tax.ToString("0.##")} | Total: {total.ToString("0.##")}");
                if(units > 500)
                {
                    Console.WriteLine("High usage alert");
                }
            }
        }
    }
}
