namespace CollegeApp.Model
{
    public class DerivedClass3 : IMyInterface
    {
        public void Print(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("Derived Class 3.");
        }
    }
}
