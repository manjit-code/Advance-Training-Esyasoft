using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class DlmsMeter: IReadable
    {
        public string SourceId { get; }
        private Random random;

        public DlmsMeter(string sourceId, Random random = null)
        {
            this.SourceId = sourceId;
            this.random = random ?? new Random();
        }

        public int ReadKwh()
        {
            return random.Next(1, 11);
        }
    }
}
