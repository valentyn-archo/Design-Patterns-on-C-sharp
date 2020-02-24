using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade_pattern_bet
{
    public class BetMaker
    {
        private Bet football;
        private Bet chess;
        private Bet politic;

        public BetMaker()
        {
            football = new Football();
            chess = new Chess();
            politic = new Politic();
        }

        public void makeBetFootball()
        {
            football.makeBet();
        }
        public void makeBetChess()
        {
            chess.makeBet();
        }
        public void makeBetPolitic()
        {
            politic.makeBet();
        }
    }
}
