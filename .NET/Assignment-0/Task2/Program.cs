namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            int[] daily = { 4, 5, 6, 0, 7, 8, 5 };

            int total = 0;
            int maxUsage = daily[0];
            int maxDay = 1;
            int outageCount = 0;
            int minUsage = int.MaxValue;
            int minDay = 1;

            for (int i = 0; i < daily.Length; i++)
            {
                total += daily[i];

                if (daily[i] > maxUsage)
                {
                    maxUsage = daily[i];
                    maxDay = i + 1;
                }

                if (daily[i] == 0)
                {
                    outageCount++;
                }

                if (daily[i] > 0 && daily[i] < minUsage)
                {
                    minUsage = daily[i];
                    minDay = i + 1;
                }
            }

            double average = (double)total / daily.Length;

            Console.WriteLine($"Total: {total} kWh | Avg: {average:F2} kWh | Max: {maxUsage} kWh (Day {maxDay}) | Outages: {outageCount}");
            Console.WriteLine($"Min: {minUsage} kWh (Day {minDay})");
        }
    }
}
