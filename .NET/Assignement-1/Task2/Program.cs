namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tariff
            Tariff t1 = new Tariff("DOMESTIC");
            Tariff t2 = new Tariff("COMMERCIAL", 1.3);
            Tariff t3 = new Tariff("AGRI", 20.0, 4.4);

            t1.ComputeBill(120);
            t2.ComputeBill(120);
            t3.ComputeBill(120);
        }
    }
}
