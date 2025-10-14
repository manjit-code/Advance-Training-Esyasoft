using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class CsvIngestor : IDataIngestor
    {
        public string Name => "Csv";
        private readonly string[] _lines;
        private int _lineIndex = 0;

        public CsvIngestor(string[] lines)
        {
            _lines = lines;
        }

        public IEnumerable<(DateTime ts, int kwh)> ReadBatch(int count)
        {
            for (int i = 0; i < count && _lineIndex < _lines.Length; i++)
            {
                var parts = _lines[_lineIndex].Split(',');
                yield return (DateTime.Parse(parts[0]), int.Parse(parts[1]));
                _lineIndex++;
            }
        }

    }
}
