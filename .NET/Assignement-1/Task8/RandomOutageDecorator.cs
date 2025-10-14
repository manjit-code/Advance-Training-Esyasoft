using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class RandomOutageDecorator : IDataIngestor
    {
        private readonly IDataIngestor _wrappedIngestor;
        private readonly Random _random = new Random();

        public RandomOutageDecorator(IDataIngestor wrappedIngestor)
        {
            _wrappedIngestor = wrappedIngestor;
        }

        public string Name => $"{_wrappedIngestor.Name}+Outage";

        public IEnumerable<(DateTime ts, int kwh)> ReadBatch(int count)
        {
            foreach (var data in _wrappedIngestor.ReadBatch(count))
            {
                if (_random.Next(0, 5) == 0)
                {
                    yield return (data.ts, 0);
                }
                else
                {
                    yield return data;
                }
            }
        }
    }
}
