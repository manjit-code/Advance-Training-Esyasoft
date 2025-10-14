namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meter meter1 = new Meter("AP-0001", "Feeder-12", 15130);
            Meter meter2 = new Meter("AP-0021", "DTR-9", 9800);

            meter1.AddReading(100);
            meter2.AddReading(-100);

            meter1.Summary();
            meter2.Summary();
        }
    }
}
