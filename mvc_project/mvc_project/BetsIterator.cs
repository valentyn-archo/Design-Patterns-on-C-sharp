using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_project
{
    public class BetsIterator : IBetsIterator
    {
        private BetsCollection _bets;
        private int _current = 0;
        private int _step = 1;

        public BetsIterator(BetsCollection bets)
        {
            this._bets = bets;
        }

        public Bet First()
        {
            _current = 0;
            return _bets[_current] as Bet;
        }

        public Bet Next()
        {
            _current += _step;
            if (!IsDone)
                return _bets[_current] as Bet;
            else
                return null;
        }

        public Bet CurrentBet
        {
            get { return _bets[_current] as Bet; }
        }

        public bool IsDone
        {
            get { return _current >= _bets.Count; }
        }
    }
}
