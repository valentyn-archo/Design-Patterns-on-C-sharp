using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_abstract_fabric_bet
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app;
            BetAbstractFabric factory;
            factory = new FootballFactory();
            app = new Application(factory);
            app.makeBet();
            factory = new Formula1Factory();
            app = new Application(factory);
            app.makeBet();

            Console.ReadLine();
        }
    }
}
