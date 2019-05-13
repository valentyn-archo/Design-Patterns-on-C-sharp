using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_pattern
{
    class User : Element
    {
        public string Name { get; set; }
        public double TotalCash { get; set; }
        public int TotalWinningGames { get; set; }

        public User(string name, double totalCash, int totalWinningGames)
        {
            Name = name;
            TotalCash = totalCash;
            TotalWinningGames = totalWinningGames;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
