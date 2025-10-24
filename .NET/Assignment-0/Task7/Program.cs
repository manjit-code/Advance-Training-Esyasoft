namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter meter category (DOMESTIC/COMMERCIAL/AGRICULTURE): ");
            string meterCategory = Console.ReadLine();

            Console.Write("Enter units consumed: ");
            int units = int.Parse(Console.ReadLine());

            double rate = 0;

            switch (meterCategory.ToUpper())
            {
                case "DOMESTIC":
                    rate = 6.0;
                    break;
                case "COMMERCIAL":
                    rate = 8.5;
                    break;
                case "AGRICULTURE":
                    rate = 3.0;
                    break;
                default:
                    Console.WriteLine("Unknown category. Check configuration.");
                    return;
            }

            double totalBill = units * rate;

            Console.WriteLine($"Category: {meterCategory} | Rate: ₹{rate} | Total Bill: ₹{totalBill:F2}");
        }
    }
}
