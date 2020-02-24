using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_pattern
{
    class BetMemento
    {
        public TimeSpan Time { get; private set; }

        public BetMemento(TimeSpan time)
        {
            this.Time = time;
        }
    }
}
