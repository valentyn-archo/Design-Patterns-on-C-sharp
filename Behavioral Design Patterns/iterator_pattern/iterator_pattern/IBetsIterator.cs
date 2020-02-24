using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_pattern
{
    interface IBetsIterator
    {
        Bet First();
        Bet Next();
        bool IsDone { get; }
        Bet CurrentBet { get; }
    }
}
