using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollection e = new UserCollection();
            e.Attach(new User("Valentyn", 5807, 12));
            e.Attach(new User("Oleg", 1007, 4));
            e.Attach(new User("Valentyn", 15811, 21));

            Console.WriteLine("Our site is giving the bonus to a total amount of cash on the balance...\n");
            e.Accept(new TotalCashVisitor());

            Console.ReadKey();
        }
    }
}
