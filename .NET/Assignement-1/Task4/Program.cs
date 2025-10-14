namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var seededRandom = new Random();
            var myList = new List<IReadable>
            {
                new DlmsMeter("AP-0001 ", seededRandom),
                new ModemGateway("GW-21", seededRandom)
            };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Polling: {i + 1}");
                foreach (var device in myList)
                {
                    Console.WriteLine($"  {device.SourceId} -> {device.ReadKwh()}");
                }
                Console.WriteLine();
            }
        }
    }
}
