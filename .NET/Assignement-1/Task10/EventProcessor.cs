using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class EventProcessor
    {
        public static void PrintTopSevere(IEnumerable<Event> events, int topN)
        {
            var topEvents = events.OrderByDescending(e => e.Severity).ThenByDescending(e => e.When).Take(topN);
            foreach (var ev in topEvents)
            {
                Console.WriteLine(ev.Describe());
            }
        }
    }
}
