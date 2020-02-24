using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    class Server : IServer
    {
        private string _name;
        private Bet _bet;
        private double _coefficient;

        public Server(string name, double coefficient)
        {
            _name = name;
            _coefficient = coefficient;
        }

        public void Update(Bet bet)
        {
            Console.WriteLine("Notified: {0}, that" + " coefficient change to {1}.", _name, bet.Coefficient);
            if (bet.Coefficient < _coefficient)
            {
                Console.WriteLine(_name + " wants to add some money on " + bet.GetType().Name + "!");
            }
        }
    }
}
