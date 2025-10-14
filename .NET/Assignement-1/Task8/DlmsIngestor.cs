using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class DlmsIngestor : IDataIngestor
    {
        public string Name => "Dlms";
        private readonly Random _random = new Random();
        private DateTime _lastReadTime;

        public DlmsIngestor()
        {
            _lastReadTime = DateTime.Today.AddHours(1);
        }

        public IEnumerable<(DateTime ts, int kwh)> ReadBatch(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return (_lastReadTime, _random.Next(1, 6));
                _lastReadTime = _lastReadTime.AddHours(1);
            }
        }

    }
}
