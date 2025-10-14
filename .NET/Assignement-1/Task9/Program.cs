namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var billingContext = new BillingContext(new CommercialRule());
            billingContext.Rebates.Add(new NoOutageRebate());
            billingContext.Rebates.Add(new HighUsageRebate());

            var units = 620;
            int outageDays = 0;
            double subtotal = billingContext.Rule.Compute(units);
            double finalTotal = billingContext.Finalize(units, outageDays);
            Console.WriteLine($"Subtotal: ₹ {subtotal:N2}");
            Console.WriteLine($"Rebates: {string.Join(" | ", billingContext.Rebates.Select(r => r.Code))}");
            Console.WriteLine($"Final: ₹ {finalTotal:N2}");
            Console.WriteLine();

        }
    }
}
