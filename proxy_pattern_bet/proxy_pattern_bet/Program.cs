using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy_pattern_bet
{
    class Program
    {
        static void Main(string[] args)
        {
            UserAvatar userAvatar = new ProxyUserAvatar("valik.jpg");

            userAvatar.display();
            Console.WriteLine("");

            userAvatar.display();

            Console.ReadLine();
        }
    }
}
