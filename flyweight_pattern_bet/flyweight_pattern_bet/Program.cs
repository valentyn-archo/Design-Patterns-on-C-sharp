using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight_pattern_bet
{
    class Program
    {
        private static String[] name = new String[] { "Football", "Formula 1", "Chess", "Politic", "Rally" };
        private static String[] type = new String[] { "best player bet", "percent bet" };
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; ++i)
            {
                BetImpl bet = (BetImpl)BetFactory.getBet(getRandomName());
                bet.setType(getRandomType());
                bet.setAmount(getRandomAmount());
                bet.makeBet();
            }

            Console.ReadLine();
        }

        public static Random random = new Random();
        private static String getRandomName()
        {
            return name[(int)(random.NextDouble() * name.Length)];
        }

        private static String getRandomType()
        {
            return type[(int)(random.NextDouble() * type.Length)];
        }

        private static int getRandomAmount()
        {
            return (int)(random.NextDouble() * 10000);
        }
    }
}
