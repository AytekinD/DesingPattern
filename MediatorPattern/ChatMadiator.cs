using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ChatMadiator : IChatMediator
    {
        List<IUser> _users;
        public ChatMadiator()
        {
            _users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message,IUser sender)
        {
            foreach (var user in _users)
            {
                //gonderici kendi mesajini almasin
                if (user != sender)
                {
                    user.ReceiveMessage(message);
                }
            }
        }
    }
}
