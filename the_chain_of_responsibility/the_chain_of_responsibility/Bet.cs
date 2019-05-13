using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_chain_of_responsibility
{
    class Bet
    {
        public Bet(string type, string name, string team, double amount)
        {
            Type = type;
            Name = name;
            Team = team;
            Amount = amount;

            Console.WriteLine("\nBet request:\n" + "   type: " + type + "\n" + "   name: " + name +
                "\n"+ "   team: " + team + "\n" + "   amount: " + amount + " $");
        }

        public string Type { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public double Amount { get; set; }
    }
}
