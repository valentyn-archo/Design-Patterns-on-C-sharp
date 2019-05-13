using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            
            BetOnFootballStart betOnFootballStart = new BetOnFootballStart();
            server.Invoke(betOnFootballStart);
            BetOnFootballEnd betOnFootballEnd = new BetOnFootballEnd();
            server.Invoke(betOnFootballEnd);

            BetOnFormula1Start betOnFormula1Start = new BetOnFormula1Start();
            server.Invoke(betOnFormula1Start);
            BetOnFormula1End betOnFormula1End = new BetOnFormula1End();
            server.Invoke(betOnFormula1End);

            Console.ReadLine();
        }
    }
}
