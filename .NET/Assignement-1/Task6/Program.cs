namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hourly = { 2, 4, 4,5,6,6,7,8,3,9, 1,2,5,7,9,10, 12, 2, 4, 4, 5, 6, 6, 7 };
            var myLoadProfile = new LoadProfileDay(new DateTime(), hourly);

            Console.WriteLine($"{myLoadProfile.Date.ToString("yyyy-MM-dd")} | Total: {myLoadProfile.Total} Kwh | PeakHour:{myLoadProfile.PeakHour}");
        }
    }
}
