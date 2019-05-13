using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_pattern
{
    class Bet
    {
        private string name;

        public Bet(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
