namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var events = new List<Event>
            {
            new VoltageEvent(new DateTime(2025, 10, 5, 18, 0, 0), "AP-0001", 184.5),
            new OutageEvent(new DateTime(2025, 10, 5, 22, 10, 0), "AP-0003", 95),
            new VoltageEvent(new DateTime(2025, 10, 6, 8, 30, 0), "AP-0001", 240.2),
            new TamperEvent(new DateTime(2025, 10, 6, 9, 20, 0), "AP-0007", "MISMATCH"),
            new VoltageEvent(new DateTime(2025, 10, 5, 19, 0, 0), "AP-0001", 192.1),
            new OutageEvent(new DateTime(2025, 10, 6, 5, 0, 0), "AP-0003", 120),
            new TamperEvent(new DateTime(2025, 10, 6, 9, 10, 0), "AP-0007", "COVER_OPEN"),
            new OutageEvent(new DateTime(2025, 10, 5, 22, 10, 0), "AP-0004", 45)
            };

            EventProcessor.PrintTopSevere(events, 3);

        }
    }
}
