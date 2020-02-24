using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_pattern
{
    class BetHistory
    {
        public Stack<BetMemento> History { get; private set; }
        public BetHistory()
        {
            History = new Stack<BetMemento>();
        }
    }
}
