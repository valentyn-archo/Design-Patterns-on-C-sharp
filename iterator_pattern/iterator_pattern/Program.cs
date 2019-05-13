using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BetsCollection collection = new BetsCollection();
            collection[0] = new Bet("Football");
            collection[1] = new Bet("Formula 1");
            collection[2] = new Bet("Chess");
            collection[3] = new Bet("Basketball");
            collection[4] = new Bet("MMA");

            BetsIterator iterator = collection.CreateIterator();

            Console.WriteLine("Collection of bets!\n-------------");

            for (Bet item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name + "\n-------------");
            }

            Console.ReadKey();
        }
    }
}
