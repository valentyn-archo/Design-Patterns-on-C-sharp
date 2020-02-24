using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mediator_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User valentyn = new User("Valentyn");
            User ivan = new User("Ivan");

            valentyn.sendMessage("Hi Ivan! It`s a nice day to make bets!");
            Thread.Sleep(2000);
            ivan.sendMessage("Hello! Valentyn! I agree with you!");
            Thread.Sleep(1000);
            ivan.sendMessage("I made one on football...");
            Thread.Sleep(4000);
            valentyn.sendMessage("Nice! Good luck :D");

            Console.ReadLine();

        }
    }
}
