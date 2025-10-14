namespace CollegeApp.Model
{
    public class DerivedClass2 : IMyInterface
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Derived Class 2.");
        }
    }
}
