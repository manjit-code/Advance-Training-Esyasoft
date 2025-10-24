namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] meters = new int[][]
        {
            new[] { 4, 5, 0, 0, 6, 7, 3 },
            new[] { 2, 2, 2, 2, 2, 2, 2 },
            new[] { 9, 1, 1, 1, 1, 1, 1 }
        };

            string[] ids = { "A-1001", "B-2001", "C-3001" };

            int globalMax = 0;
            string globalMeter = "";
            int globalDay = 0;

            for (int i = 0; i < meters.Length; i++)
            {
                int total = 0;
                bool peakAlert = false;
                bool sustainedOutage = false;
                bool underutilization = false;

                for (int j = 0; j < meters[i].Length; j++)
                {
                    total += meters[i][j];

                    if (meters[i][j] > 8)
                    {
                        peakAlert = true;
                    }

                    if (meters[i][j] > globalMax)
                    {
                        globalMax = meters[i][j];
                        globalMeter = ids[i];
                        globalDay = j + 1;
                    }

                    if (j > 0 && meters[i][j] == 0 && meters[i][j - 1] == 0)
                    {
                        sustainedOutage = true;
                    }
                }

                double average = (double)total / meters[i].Length;
                if (average < 2.0)
                {
                    underutilization = true;
                }

                Console.WriteLine($"{ids[i]} | Total:{total} Avg:{average:F2} | Peak:{(peakAlert ? "Yes" : "No")} | SustainedOutage:{(sustainedOutage ? "Yes" : "No")} | Underutilization:{(underutilization ? "Yes" : "No")}");
            }

            Console.WriteLine($"Highest Day: {globalMax} kWh | Meter: {globalMeter} | Day: {globalDay}");
        }
    }
}
