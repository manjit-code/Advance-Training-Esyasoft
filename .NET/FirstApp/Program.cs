using System.Xml.Linq;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const int a = 1;
            //Console.WriteLine("Enter Full Name:");
            //string fullName = Console.ReadLine();

            //Console.WriteLine("Enter Phone Number:");
            //string phNumber = Console.ReadLine();

            ////phNumber = phNumber.Replace('/', '-');
            ////fullName = fullName.Insert(0, "Mr.");

            //Console.WriteLine(fullName);
            //Console.WriteLine(phNumber);
            //Console.WriteLine(fullName.Substring(3));
            //Console.ReadKey(); // Keeps application in running state

            //-------------------------------------------------------------------

            // if- else if - else
            //Console.WriteLine("eNTER aGE:");
            //int age = Convert.ToInt16(Console.ReadLine());

            //if(age > 18)
            //{
            //    Console.WriteLine("Masti Khatam");
            //}
            //else if(age == 18)
            //{
            //    Console.WriteLine("Thodasa masti karle");
            //}
            //else
            //{
            //    Console.WriteLine("MAJE KAR");
            //}

            //-------------------------------------------------------------------

            //Single Line If-else:
            //string message = (age >= 18) ? "Can Vote" : "Can't vote";
            //Console.WriteLine(message);

            //-------------------------------------------------------------------
            //Console.WriteLine("eNTER yOUR nAME:");
            //string name;

            //while (true)
            //{
            //    name = Console.ReadLine();

            //    if (name == null || name == "")
            //    {
            //        Console.WriteLine("Please Enter Your Name: ");
            //    }
            //    else
            //    {
            //        //Console.WriteLine("Your Name is " + name);
            //        Console.WriteLine($"Your Name is {name}");
            //        break;
            //    }
            //}

            //-------------------------------------------------------------------

            //switch : It is faster than if-else if - else
            // In switch we cant use logical operator 

            //Console.Write("Enter Day: ");
            //string day = Console.ReadLine();

            //switch (day)
            //{
            //    case "Monday":
            //        Console.WriteLine(day);
            //        break;

            //    case "Tuesday":
            //        Console.WriteLine(day);
            //        break;

            //    case "Wednesday":
            //        Console.WriteLine(day);
            //        break;

            //    case "Thursday":
            //        Console.WriteLine(day);
            //        break;

            //    case "Friday":
            //        Console.WriteLine(day);
            //        break;

            //    case "Saturday":
            //        Console.WriteLine(day);
            //        break;

            //    case "Sunday":
            //        Console.WriteLine(day);
            //        break;
            //    default:
            //        Console.WriteLine("Ho gaya mrutyu");
            //        break;
            //}

            //-------------------------------------------------------------------
            //Taks - I : Student Marks Calculator
            //string studentName;
            //int mark1, mark2, mark3, mark4, mark5;

            //Console.WriteLine("Enter Student Name: ");
            //studentName = Console.ReadLine();

            //Console.WriteLine("Enter 5 subjects marks: ");
            //mark1 = Convert.ToInt32(Console.ReadLine());
            //mark2 = Convert.ToInt32(Console.ReadLine());
            //mark3 = Convert.ToInt32(Console.ReadLine());
            //mark4 = Convert.ToInt32(Console.ReadLine());
            //mark5 = Convert.ToInt32(Console.ReadLine());

            //int totalMarks = mark1 + mark2 + mark3 + mark4 + mark5;
            //double avgMark = (double)totalMarks / 5.0;
            //double percent = (totalMarks*100)/500;

            //Console.WriteLine($"Studnet name is {studentName}");
            //Console.WriteLine($"Total marks is {totalMarks}");
            //Console.WriteLine($"Average mark is {avgMark}");
            //Console.WriteLine($"Total Percentage is {percent}%");


            ////-------------------------------------------------------------------
            ////Taks - II : Simple Salary Computation
            //Console.WriteLine("Enter Employee Name: ");
            //string empName = Console.ReadLine();

            //double basicSalary, hra, da, tax, gross, netSalary;
            //Console.WriteLine("Enter Basic Salary: ");
            //basicSalary = Convert.ToDouble(Console.ReadLine());
            //hra = basicSalary * 0.2;
            //da = basicSalary * 0.1;
            //gross = basicSalary + hra + da;
            //tax = gross * 0.08;
            //netSalary = basicSalary - tax;

            //Console.WriteLine($"Employee Name is {empName}\n Basic Salary is {Math.Round(basicSalary,2)}\n HRA is {hra}\n  DA is {Math.Round(da,2)}\n  gross is {Math.Round(gross,2)}\n  tax is {Math.Round(tax,2)}\n  net salary is {Math.Round(netSalary,2)}\n");

            ////-------------------------------------------------------------------
            ////Taks - III : Currency Converter
            //Console.WriteLine("Enter INR amount: ");
            //double inr, usd, eur;
            //inr = Convert.ToDouble(Console.ReadLine());
            //usd = inr / 83.0;
            //eur = inr / 95.5;

            //Console.WriteLine($"INR: {inr} \n USD: {usd} \n EUR: {eur}");


            ////-------------------------------------------------------------------
            ////Taks - IV : Time Converter
            //Console.WriteLine("Enter time in minutes: ");
            //int totalminutes, hours, minutes;
            //totalminutes = Convert.ToInt32(Console.ReadLine());

            //hours = totalminutes / 60;
            //minutes = totalminutes % 60;

            //Console.WriteLine(totalminutes);
            //Console.WriteLine(hours);
            //Console.WriteLine(minutes);


            //-------------------------------------------------------------------
            //Nested For Loop
            //int row, col;
            //Console.Write("Enter row: ");
            //row = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter columns: ");
            //col = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter symbol: ");
            //String symbol = Console.ReadLine();

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        Console.Write($"{symbol} ");
            //    }
            //    Console.WriteLine();
            //}


            //-------------------------------------------------------------------
            // Array
            //string[] bikes = new string[10];
            //bikes[0] = "hero honda";


            //-------------------------------------------------------------------

            // Task - I
            //Console.WriteLine("Task 1: Table of squares and cubes for numbers 1 to 10");
            //int start = 1, end = 10;
            //Console.WriteLine("N Square Cube");
            //for (int n = start; n <= end; n++)
            //{
            //    Console.WriteLine($"{n}, {n * n}, {n * n * n}");
            //}
            //Console.WriteLine();


            //// Task - II
            //Console.WriteLine("Task 2: Perfect numbers between 1 and 1000");
            //start = 1; end = 1000;
            //for (int n = Math.Max(2, start); n <= end; n++)
            //{
            //    int sum = 1;
            //    int limit = (int)Math.Sqrt(n);
            //    for (int d = 2; d <= limit; d++)
            //    {
            //        if (n % d == 0)
            //        {
            //            sum += d;
            //            int other = n / d;
            //            if (other != d) sum += other;
            //        }
            //    }
            //    if (n == 1) sum = 0;
            //    if (sum == n) Console.WriteLine(n);
            //}
            //Console.WriteLine();

            //// Task - III
            //Console.WriteLine("Task 3: Hourglass pattern");
            //int rows = 5;
            //for(int i = 0; i <= rows/2; i++)
            //{
            //    for (int j = 0; j < i; j++) Console.Write(" ");
            //    for (int j = 0; j < rows-2*i; j++) Console.Write("*");
            //    Console.WriteLine();
            //}

            //Console.WriteLine();


            //// Task - IV
            //Console.WriteLine("Task 4: Palindromic number pyramid");
            //rows = 5;
            //for (int r = 1; r <= rows; r++)
            //{
            //    for (int i = 0; i < rows - r; i++) Console.Write(" ");
            //    for (int i = 1; i <= r; i++) Console.Write(i);
            //    for (int i = r - 1; i >= 1; i--) Console.Write(i);
            //    Console.WriteLine();
            //}
            //Console.WriteLine();


            //// Task - V
            //Console.WriteLine("Task 5: Triangle with alternate numbers");
            //rows = 5;
            //for (int r = 1; r <= rows; r++)
            //{
            //    for (int c = 1; c <= r; c++)
            //    {
            //        int val = ((r + c) % 2 == 1) ? 1 : 0;
            //        Console.Write(val);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //// Task - VI
            //Console.WriteLine("Task 6: Armstrong numbers between 100 and 999");
            //start = 100;
            //end = 999;
            //for (int n = Math.Max(0, start); n <= end; n++)
            //{
            //    int temp = n;
            //    int sum = 0;
            //    int digits = n.ToString().Length;
            //    while (temp > 0)
            //    {
            //        int d = temp % 10;
            //        sum += (int)Math.Pow(d, digits);
            //        temp /= 10;
            //    }
            //    if (sum == n) Console.WriteLine(n);
            //}
            //Console.WriteLine();

            //// Task - VII
            //Console.WriteLine("Task 7: Print Fibonacci series in reverse order");
            //int sz = 5;
            ////n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[sz];
            //arr[0] = 0;
            //arr[1] = 1;
            //for (int i = 2; i < sz; i++) arr[i] = arr[i - 1] + arr[i - 2];
            //for (int i = sz - 1; i >= 0; i--) Console.Write($"{arr[i]} ");
            //Console.WriteLine("\n");

            //// Task - VIII
            //Console.WriteLine("Task 8: Zigzag star pattern (height = 4) ");
            //string[] zigzag = new string[] { "    *       *\r\n  * *     * *\r\n*   *   *   *\r\n*     * *     *" };
            //foreach (var zig in zigzag) Console.WriteLine(zig);
            ////rows = 4;
            ////for (int i = 0; i < rows; i++)
            ////{
            ////    int star = 0;
            ////    // space
            ////    for (int j = 0; j < rows - 1 - i; j++) Console.Write(" ");
            ////    // star
            ////    if(star <= i) Console.WriteLine("*");
            ////    //space
            ////    for (int j = 0; j < rows - 1 - i; j++) Console.Write(" ");
            ////    //star
            ////    Console.Write("*");
            ////}


            //Console.WriteLine();


            //// Task - IX
            //Console.WriteLine("Task 9: Count the total digits in a number using a loop.");
            //int num = 1999;
            ////num = Convert.ToInt32(Console.ReadLine());
            //int cnt, tempNum;
            //cnt = 0;
            //tempNum = num;
            //while (tempNum > 0)
            //{
            //    int d = tempNum % 10;
            //    cnt++;
            //    tempNum /= 10;
            //}
            //Console.WriteLine($"Total digits in {num} is {cnt}");
            //Console.WriteLine();


            //// Task - X
            //Console.WriteLine("Task 10: Diamond pattern with numbers");
            //int midHeight = 5;
            ////midHeight = Convert.ToInt32(Console.ReadLine());
            //tempNum = midHeight;
            //int row = 1;
            //while (tempNum > 0)
            //{
            //    for (int i = 0; i < midHeight - row; i++) Console.Write(" ");
            //    for (int i = 1; i <= row; i++) Console.Write(i);
            //    for (int i = row - 1; i > 0; i--) Console.Write(i);
            //    tempNum--;
            //    row++;
            //    Console.WriteLine();
            //}
            //row = 1;
            //tempNum = midHeight;
            //while (tempNum > 0)
            //{
            //    for (int i = 0; i < row; i++) Console.Write(" ");
            //    for (int i = 1; i <= midHeight-row; i++) Console.Write(i);
            //    for (int i = midHeight-1-row; i > 0; i--) Console.Write(i);
            //    tempNum--;
            //    row++;
            //    Console.WriteLine();
            //}



            // -----------------------------------------------------------------------------------
            // Constructor
            // static class-> cann't create object of any static class
            //human manjit = new human("manjit", 23);
            //manjit.sleep();

            // Task - I : lIBRARY MANAGEMENT SYSTEM
            //Book harryPotter = new Book("121CH12", "Harry Potter Mystry", "Ninja Samosa", false);
            //harryPotter.DisplayBookDetails();
            //harryPotter.IssueBook();
            //harryPotter.DisplayBookDetails();
            //harryPotter.ReturnBook();
            //harryPotter.DisplayBookDetails();
            //Console.WriteLine();

            // Task - II : Movie Ticket Booking System
            //Movie sultan = new Movie("Sultan", 300, 9);
            //sultan.DisplayAvailableSeats();
            //sultan.BookSeats(10);
            //sultan.DisplayAvailableSeats();
            //sultan.CancelSeats(4);
            //sultan.DisplayAvailableSeats();
            //Console.WriteLine();

            // Task - III : Static Member and Method Practice
            //Company emp1 = new Company("Manjit", "25EST101");
            //Company emp2 = new Company("Anurag", "25EST201");
            //Company emp3 = new Company("Uday", "25EST311");
            //Company.DisplayCompanyName();
            //Console.WriteLine();

            // Task - IV : Employee Salary Management
            //Employee abhinav = new Employee("121ME0408", "Abhinav Kumar", 95000.0);
            //abhinav.DisplayDetails();
            //Console.WriteLine();


            // -----------------------------------------------------------------------------------
            // encapsulation

            BankAccount account = new BankAccount();

            account.Deposit(1000);
            account.Withdraw(200);
            account.Withdraw(1000);

            // ❌ Not allowed — balance is private
            // account.balance = 5000;  // Compile-time error

            // ✅ Read allowed (through property)
            Console.WriteLine($"Final Balance: ₹{account.Balance}");
        }
    }
}