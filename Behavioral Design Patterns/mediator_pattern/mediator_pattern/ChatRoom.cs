using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator_pattern
{
    public class ChatRoom
    {
        public static void showMessage(User user, string message)
        {
            Console.WriteLine(DateTime.Now + " [" + user.Name + "] : " + message);
        }
    }
}
