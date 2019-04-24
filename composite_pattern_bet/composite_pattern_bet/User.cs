using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite_pattern_bet
{
    class User
    {
        private String name;
        private ArrayList includedBets = new ArrayList();

        public User(String name)
        {
            this.name = name;
        }

        public void add(Object obj)
        {
            includedBets.Add(obj);
        }

        public void ls()
        {
            Console.WriteLine(CompositeDemo.compositeBuilder + "----------------------------------------------------------------------\nUser: "
                    + name + "\n----------------------------------------------------------------------");
            CompositeDemo.compositeBuilder.Append("   ");
            foreach (Object obj in includedBets)
            {
                String name = obj.ToString();
                if (name.Equals("User"))
                {
                    ((User)obj).ls();
                }
                else
                {
                    ((Bet)obj).ls();
                }
            }
            CompositeDemo.compositeBuilder.Length = CompositeDemo.compositeBuilder.Length - 3;
        }
    }
}
