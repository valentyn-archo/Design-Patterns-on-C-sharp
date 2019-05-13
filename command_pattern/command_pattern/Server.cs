using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_pattern
{
    public class Server
    {
        public Server()
        {
        }
        public void Invoke(Bet bet)
        {
            Console.WriteLine("Processing.......");
            bet.Execute();
        }
    }
}
