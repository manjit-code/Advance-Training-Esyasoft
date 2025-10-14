using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ClassTasks
{
    internal class Product
    {
        // new Product{ Id=1, Name="Laptop", Category="Electronics", Price=75000, Stock=15 },
        public int Id { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        public string Name { get; set; }
        public string Category { get; set; }
    }
}
