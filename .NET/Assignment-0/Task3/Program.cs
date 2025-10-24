﻿namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = {
            "2025-09-01,4.2,OK",
            "2025-09-02,5.0,OK",
            "2025-09-03,0.0,OUTAGE",
            "2025-09-04,3.8,OK",
            "2025-09-05,6.1,OK",
            "2025-09-06,2.5,TAMPER",
            "2025-09-07,5.4,OK"
        };

            double okSum = 0;
            int okCount = 0;
            int outageCount = 0;
            int tamperCount = 0;
            double maxKwh = 0;
            string maxDate = "";

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                double kwh = double.Parse(parts[1]);
                string status = parts[2];

                if (status == "OK")
                {
                    okSum += kwh;
                    okCount++;

                    if (kwh > maxKwh)
                    {
                        maxKwh = kwh;
                        maxDate = parts[0];
                    }
                }
                else if (status == "OUTAGE")
                {
                    outageCount++;
                }
                else if (status == "TAMPER")
                {
                    tamperCount++;
                }
            }

            double okAverage = okCount > 0 ? okSum / okCount : 0;

            Console.WriteLine($"OK: {okSum:F2} kWh (avg {okAverage:F2}) | OUTAGE: {outageCount} | TAMPER: {tamperCount}");
            Console.WriteLine($"Busiest OK day: {maxDate} with {maxKwh:F1} kWh");
        }
    }
}
