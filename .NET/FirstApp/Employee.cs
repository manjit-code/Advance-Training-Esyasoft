using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Employee
    {
        public string id, name;
        public double basicSalary, hra, da, grossSalary;

        public Employee(string id, string name, double basicSalary)
        {
            this.id = id;
            this.name = name;
            this.basicSalary = basicSalary;

            hra = 0.1*basicSalary;
            da = 0.05*basicSalary;
            grossSalary = basicSalary + da + hra;
        }

        public void DisplayDetails()
        {
            
            System.Console.WriteLine($"Employee Details:\nID:{id}\nName:{name}\nBasic Salary:{basicSalary}\nHRA:{hra}\nDA:{da}\nGross Salary:{grossSalary}");
        }
    }
}
