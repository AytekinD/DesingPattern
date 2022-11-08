using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class BasicUser : IUser
    {
        private readonly IChatMediator _chatMediator;
        string name;

        public BasicUser(IChatMediator chatMediator,string name)
        {
            this._chatMediator = chatMediator;
            this.name = name;

        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"<Basic:{name}> : {message}");
        }

        public void SendMessage(string message)
        {
            _chatMediator.SendMessage(message, this);
        }
    }
}
