namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var billingRules = new List<IBillingRule>
            {
                new DomesticRule(), new CommercialRule(), new AgricultureRule()
            };

            foreach (var billingRule in billingRules)
            {
                Console.WriteLine($"{billingRule.category} -> ₹{billingRule.Compute(120)}");
            }
        }
    }
}
