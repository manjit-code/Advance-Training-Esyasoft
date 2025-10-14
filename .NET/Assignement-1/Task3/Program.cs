namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meter myMeter = new Meter("AP-0001", new DateTime(2024-07-01), 3);
            Gateway myGateway = new Gateway("GW-11", new DateTime(2025 - 01 - 10), "10.0.5.21");

            var myDevice = new Device[] {myMeter, myGateway};
            foreach (var device in myDevice)
            {
                device.Describe();
            }
        }
    }
}
