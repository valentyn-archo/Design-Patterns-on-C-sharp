using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator_pattern
{
    public class User
    {
        private string name;

        public User(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void sendMessage(string message)
        {
            ChatRoom.showMessage(this, message);
        }
    }
}
