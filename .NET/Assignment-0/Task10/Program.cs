namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] meters = new int[][]
            {
                new int[] {1, 0, 0, 5, 2, 0, 0},
                new int[] {0, 0, 0, 0, 0, 0, 0},
                new int[] {0, 4, 3, 0, 0, 0, 0}
            };

            string[] meterIds = { "MTR001", "MTR002", "MTR003" };

            for (int i = 0; i < meters.Length; i++)
            {
                int totalOutageHours = 0;
                bool invalidData = false;

                int j = 0;
                while (j < meters[i].Length)
                {
                    if (meters[i][j] < 0)
                    {
                        invalidData = true;
                        break;
                    }
                    totalOutageHours += meters[i][j];
                    j++;
                }

                if (invalidData)
                {
                    Console.WriteLine($"{meterIds[i]} | Invalid Data");
                    continue;
                }

                string action = "Monitor";
                if (totalOutageHours > 8)
                {
                    action = "Escalate to field team";
                }
                else if (totalOutageHours == 0)
                {
                    action = "Stable";
                }

                Console.WriteLine($"{meterIds[i]} | Outage Hours: {totalOutageHours} | Action: {action}");

            }
    }
    }
}
