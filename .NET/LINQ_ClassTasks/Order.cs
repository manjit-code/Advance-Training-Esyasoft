using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ClassTasks
{
    internal class Order
    {
        // new Order{ OrderId=1001, CustomerId=1, Amount=2500, OrderDate=new DateTime(2025,5,12)},
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int Amount { get; set; }

        public DateTime OrderDate { get; set; }

    }
}
