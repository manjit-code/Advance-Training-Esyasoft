namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dayWithHighs = new LoadProfileDay(new DateTime(2025, 10, 1), new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 });
            var dayWithOutage = new LoadProfileDay(new DateTime(2025, 10, 2), new int[] { 1, 2, 3, 0, 0, 0, 0, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 });

            var overuseRule = new PeakOveruseRule(100);
            var outageRule = new SustainedOutageRule(4);

            if (overuseRule.IsTriggered(dayWithHighs))
            {
                Console.WriteLine(overuseRule.Message(dayWithHighs));
            }

            if (outageRule.IsTriggered(dayWithOutage))
            {
                Console.WriteLine(outageRule.Message(dayWithOutage));
            }
            Console.WriteLine();
        }
    }
}
