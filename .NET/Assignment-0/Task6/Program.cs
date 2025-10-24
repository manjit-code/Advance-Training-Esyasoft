namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter previous reading: ");
            int prevReading = int.Parse(Console.ReadLine());

            Console.Write("Enter current reading: ");
            int currReading = int.Parse(Console.ReadLine());

            int consumption = currReading - prevReading;

            Console.WriteLine($"Net Consumption: {consumption} kWh");

            if (consumption < 0)
            {
                Console.WriteLine("Invalid reading");
            }
            else if (consumption == 0)
            {
                Console.WriteLine("Possible outage");
            }
            else if (consumption > 500)
            {
                Console.WriteLine("High consumption alert!");
            }
            else if (consumption > 100 && consumption < 500)
            {
                Console.WriteLine("Normal usage");
            }
            else
            {
                Console.WriteLine("Low usage");
            }
        }
    }
}
