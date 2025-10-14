using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal interface IReadable
    {
        int ReadKwh();             // returns delta since last poll
        string SourceId { get; }
    }
}
