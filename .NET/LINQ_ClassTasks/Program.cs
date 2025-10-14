using LINQ_ClassTasks;
using System.Runtime.CompilerServices;
using static System.Formats.Asn1.AsnWriter;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LINQ_ClassTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var employees = new List<Employee>

            {

                new Employee{ Id=1, Name="Ravi", Department="IT", Salary=85000, Experience=5, Location="Bangalore"},

                new Employee{ Id=2, Name="Priya", Department="HR", Salary=52000, Experience=4, Location="Pune"},

                new Employee{ Id=3, Name="Kiran", Department="Finance", Salary=73000, Experience=6, Location="Hyderabad"},

                new Employee{ Id=4, Name="Asha", Department="IT", Salary=95000, Experience=8, Location="Bangalore"},

                new Employee{ Id=5, Name="Vijay", Department="Marketing", Salary=68000, Experience=5, Location="Mumbai"},

                new Employee{ Id=6, Name="Deepa", Department="HR", Salary=61000, Experience=7, Location="Delhi"},

                new Employee{ Id=7, Name="Arjun", Department="Finance", Salary=82000, Experience=9, Location="Bangalore"},

                new Employee{ Id=8, Name="Sneha", Department="IT", Salary=78000, Experience=4, Location="Pune"},

                new Employee{ Id=9, Name="Rohit", Department="Marketing", Salary=90000, Experience=10, Location="Delhi"},

                new Employee{ Id=10, Name="Meena", Department="Finance", Salary=66000, Experience=3, Location="Mumbai"}

            };

            // 1.Display all employees working in the IT department.
            var itEmployees = employees.Where(e => e.Department == "IT");
            foreach(var employee in itEmployees)
            {
                Console.WriteLine(employee.Name);
            }
            Console.WriteLine();

            // 2.List names and salaries of employees who earn more than 70,000.
            var emp1 = employees.Where(e => e.Salary > 70000);
            foreach (var employee in emp1)
            {
                Console.WriteLine($"{employee.Name} : {employee.Salary}");
            }
            Console.WriteLine();

            //3.Find all employees located in Bangalore.
            var emp2 = employees.Where(e => e.Location == "Bangalore");
            foreach (var employee in emp2)
            {
                Console.WriteLine($"{employee.Name}");
            }
            Console.WriteLine();


            //4.Display employees having more than 5 years of experience.
            var emp3 = employees.Where(e => e.Experience > 5);
            foreach (var employee in emp3)
            {
                Console.WriteLine($"{employee.Name}");
            }
            Console.WriteLine();


            //5.Show names of employees and their salaries in ascending order of salary.
            var emp4 = employees.OrderBy(e => e.Salary);
            foreach (var employee in emp4)
            {
                Console.WriteLine($"{employee.Salary} : {employee.Name}");
            }
            Console.WriteLine();

            //6.Group employees by location and count how many employees are in each location.
            var emp5 = employees.GroupBy(e => e.Location);
            foreach (var employee in emp5)
            {
                Console.WriteLine($"{employee.Key} : {(employee.Key).Length}");
            }
            Console.WriteLine();

            //7.Display employees whose salary is above the average salary.
            var avgSalary = employees.Average(e => e.Salary);
            var emp6 = employees.Where(e => e.Salary > avgSalary);
            foreach (var employee in emp6)
            {
                Console.WriteLine($"{employee.Name} : {employee.Salary}");
            }
            Console.WriteLine();


            //8.Show top 3 highest - paid employees.
            var emp7 = employees.OrderByDescending(e => e.Salary).ToList();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{emp7[i].Name} : {emp7[i].Salary}");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------\n");

            //----------------------------------------------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------------------------------------------

            //Product Data

            var products = new List<Product>

            {

                new Product{ Id=1, Name="Laptop", Category="Electronics", Price=75000, Stock=15 },

                new Product{ Id=2, Name="Smartphone", Category="Electronics", Price=55000, Stock=25 },

                new Product{ Id=3, Name="Tablet", Category="Electronics", Price=30000, Stock=10 },

                new Product{ Id=4, Name="Headphones", Category="Accessories", Price=2000, Stock=100 },

                new Product{ Id=5, Name="Shirt", Category="Fashion", Price=1500, Stock=50 },

                new Product{ Id=6, Name="Jeans", Category="Fashion", Price=2200, Stock=30 },

                new Product{ Id=7, Name="Shoes", Category="Fashion", Price=3500, Stock=20 },

                new Product{ Id=8, Name="Refrigerator", Category="Appliances", Price=45000, Stock=8 },

                new Product{ Id=9, Name="Washing Machine", Category="Appliances", Price=38000, Stock=6 },

                new Product{ Id=10, Name="Microwave", Category="Appliances", Price=12000, Stock=12 }

            };

            //1.Display all products with stock less than 20.
            var product1 = products.Where(p => p.Stock < 20);
            foreach(var product in product1)
            {
                Console.WriteLine(product.Name);
            }
            Console.WriteLine();

            //2.Show all products belonging to the “Fashion” category.
            var product2 = products.Where(p => p.Category == "Fashion");
            foreach (var product in product2)
            {
                Console.WriteLine(product.Name);
            }
            Console.WriteLine();

            //3.Display product names and prices where price is greater than 10,000.
            var product3 = products.Where(p => p.Price > 10000);
            foreach (var product in product3)
            {
                Console.WriteLine($"{product.Name} : {product.Price}");
            }
            Console.WriteLine();

            //4.List all product names sorted by price(descending).
            var product4 = products.OrderByDescending(p => p.Price);
            foreach (var product in product4)
            {
                Console.WriteLine($"{product.Name}");
            }
            Console.WriteLine();

            //5.Find the most expensive product in each category.
            var product5 = products.GroupBy(p => p.Category);
            foreach (var product in product5)
            {
                var temp = product.First(p => p.Price == product.Max(px => px.Price));
                Console.WriteLine($"{product.Key} : {temp.Name} : {temp.Price}");
            }
            Console.WriteLine();

            //6.Show total stock per category.
            foreach (var product in product5)
            {
                Console.WriteLine($"{product.Key} : {(product.Key).Length}");
            }
            Console.WriteLine();

            //7.Display products whose name starts with ‘S’.
            var product6 = products.Where(p => p.Name.StartsWith('S'));
            foreach (var product in product6)
            {
                Console.WriteLine($"{product.Name}");
            }
            Console.WriteLine();

            //8.Show average price of products in each category.
            foreach (var product in product5)
            {
                Console.WriteLine($"{product.Key} : {(product).Average(p => p.Price)}");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------\n");

            //----------------------------------------------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------------------------------------------

            //Student Data

            var students = new List<Student>

            {

                new Student{ Id=1, Name="Asha", Course="C#", Marks=92, City="Bangalore"},

                new Student{ Id=2, Name="Ravi", Course="Java", Marks=85, City="Pune"},

                new Student{ Id=3, Name="Sneha", Course="Python", Marks=78, City="Hyderabad"},

                new Student{ Id=4, Name="Kiran", Course="C#", Marks=88, City="Delhi"},

                new Student{ Id=5, Name="Meena", Course="Python", Marks=95, City="Bangalore"},

                new Student{ Id=6, Name="Vijay", Course="C#", Marks=82, City="Chennai"},

                new Student{ Id=7, Name="Deepa", Course="Java", Marks=91, City="Mumbai"},

                new Student{ Id=8, Name="Arjun", Course="Python", Marks=89, City="Hyderabad"},

                new Student{ Id=9, Name="Priya", Course="C#", Marks=97, City="Pune"},

                new Student{ Id=10, Name="Rohit", Course="Java", Marks=74, City="Delhi"}

            };

            //1.Find the highest scorer in each course.
            var studentList1 = students.GroupBy(x => x.Course);
            foreach (var student in studentList1)
            {
                var topper = student.First(s => s.Marks == (student.Max(s => s.Marks)));
                Console.WriteLine($"{student.Key} : {topper.Name} : {topper.Marks}");
            }
            Console.WriteLine();

            //2.Display average marks of all students city-wise.
            var studentList2 = students.GroupBy(x => x.City);
            foreach (var student in studentList2)
            {
                var  avgPerCity = student.Average(s => s.Marks);
                Console.WriteLine($"{student.Key} : {avgPerCity}");
            }
            Console.WriteLine();

            //3.Display names and marks of students ranked by marks.
            var studentList3 = students.OrderByDescending(x => x.Marks).ToList();
            for(int i = 0; i < studentList3.Count; i++)
            {
                Console.WriteLine($"{i+1}. {studentList3[i].Name}: {studentList3[i].Marks}");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------\n");

            //----------------------------------------------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------------------------------------------

            //Order Data

            var orders = new List<Order>

            {

                new Order{ OrderId=1001, CustomerId=1, Amount=2500, OrderDate=new DateTime(2025,5,12)},

                new Order{ OrderId=1002, CustomerId=2, Amount=1800, OrderDate=new DateTime(2025,5,13)},

                new Order{ OrderId=1003, CustomerId=1, Amount=4500, OrderDate=new DateTime(2025,5,20)},

                new Order{ OrderId=1004, CustomerId=3, Amount=6700, OrderDate=new DateTime(2025,6,01)},

                new Order{ OrderId=1005, CustomerId=4, Amount=2500, OrderDate=new DateTime(2025,6,02)},

                new Order{ OrderId=1006, CustomerId=2, Amount=5600, OrderDate=new DateTime(2025,6,10)},

                new Order{ OrderId=1007, CustomerId=5, Amount=3100, OrderDate=new DateTime(2025,6,12)},

                new Order{ OrderId=1008, CustomerId=3, Amount=7100, OrderDate=new DateTime(2025,7,01)},

                new Order{ OrderId=1009, CustomerId=4, Amount=4200, OrderDate=new DateTime(2025,7,05)},

                new Order{ OrderId=1010, CustomerId=5, Amount=2900, OrderDate=new DateTime(2025,7,10)}

            };

            //1.Find total order amount per month.
            var orderList1 = orders.GroupBy(x => x.OrderDate.Month);
            foreach(var order in orderList1)
            {
                Console.WriteLine($"{order.Key} : {order.Sum(o => o.Amount)}");
            }
            Console.WriteLine();    

            //2.Show the customer who spent the most in total.
            var orderList2 = orders.GroupBy(x => x.CustomerId);
            var maxSpend = 0;
            var maxSpendCustomerId = -1;
            foreach(var order in orderList2)
            {
                var tempSum = order.Sum(x => x.Amount);
                if(tempSum > maxSpend)
                {
                    maxSpend = tempSum;
                    maxSpendCustomerId = order.Key;
                }
            }
            Console.WriteLine($"Id:{maxSpendCustomerId}\n : total Spend: {maxSpend}");
            Console.WriteLine();

            //3.Display orders grouped by customer and show total amount spent.
            foreach (var order in orderList2)
            {
                var tempSum = order.Sum(x => x.Amount);
                Console.WriteLine($"{order.Key}: {tempSum}");
            }
            Console.WriteLine();

            //4.Display the top 2 orders with the highest amount.
            var orderList3 = orders.OrderByDescending(x => x.Amount).ToList();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{i + 1}. {orderList3[i].OrderId} : {orderList3[i].Amount}");
            }
        }
    }
}
