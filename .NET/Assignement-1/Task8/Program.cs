namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ingestor = new RandomOutageDecorator(new DlmsIngestor());
            foreach (var item in ingestor.ReadBatch(10))
            {
                Console.WriteLine($"[{ingestor.Name}] {item.ts:yyyy-MM-dd HH:mm} -> {item.kwh}");
            }
            Console.WriteLine();

        }
    }
}
