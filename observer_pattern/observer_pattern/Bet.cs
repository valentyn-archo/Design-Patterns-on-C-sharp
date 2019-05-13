using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    abstract class Bet
    {
        private double _coefficient;
        private List<IServer> _server = new List<IServer>();

        public Bet(double coefficient)
        {
            _coefficient = coefficient;
        }

        public void Attach(IServer server)
        {
            _server.Add(server);
        }

        public void Detach(IServer server)
        {
            _server.Remove(server);
        }

        public void Notify()
        {
            foreach (IServer server in _server)
            {
                server.Update(this);
            }

            Console.WriteLine("");
        }

        public double Coefficient
        {
            get { return _coefficient; }
            set
            {
                if (_coefficient != value)
                {
                    _coefficient = value;
                    Notify();
                }
            }
        }
    }
}
