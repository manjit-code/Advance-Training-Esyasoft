using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Company
    {
        public static string companyName = "Esyasoft Holdings";
        public string employeeName, employeeId;

        public Company(string employeeName,string employeeId)
        {
            this.employeeName = employeeName;
            this.employeeId = employeeId;
        }

        public static void DisplayCompanyName()
        {
            Console.WriteLine(companyName); 
        }
    }
}
