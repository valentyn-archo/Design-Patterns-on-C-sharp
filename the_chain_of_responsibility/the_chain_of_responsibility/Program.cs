using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_chain_of_responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver server = new Server();
            Approver maks = new Admin();
            Approver valentyn = new HeadAdmin();

            server.SetSupervisor(maks);
            maks.SetSupervisor(valentyn);

            Bet p = new Bet("on best player", "Football", "Real Madrid", 7000);
            server.ProcessRequest(p);

            p = new Bet("on best player", "Chess", "Kasparov", 2000000);
            server.ProcessRequest(p);

            p = new Bet("on team", "Politic", "Grycenko", 26000);
            server.ProcessRequest(p);

            p = new Bet("on team", "Formula 1", "Maccini", 30000);
            server.ProcessRequest(p);
            
            Console.ReadKey();
        }
    }
}
