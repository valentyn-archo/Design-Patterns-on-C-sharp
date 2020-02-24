using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_project
{
    public interface IBetsIterator
    {
        Bet First();
        Bet Next();
        bool IsDone { get; }
        Bet CurrentBet { get; }
    }
}
