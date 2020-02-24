using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    interface IServer
    {
        void Update(Bet bet);
    }
}
