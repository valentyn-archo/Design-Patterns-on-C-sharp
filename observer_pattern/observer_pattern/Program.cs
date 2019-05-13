using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Football, bets on Real Madrid\n");
            Football football = new Football(1.82);
            football.Attach(new Server("Valentyn", 1.70));
            football.Attach(new Server("Oleg", 1.80));
            football.Attach(new Server("Max", 1.56));

            football.Coefficient = 1.79;
            football.Coefficient = 1.84;
            football.Coefficient = 1.69;
            football.Coefficient = 1.73;

            Console.ReadKey();
        }
    }
}
