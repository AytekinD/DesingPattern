using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class PremiumUser : IUser
    {
        private readonly IChatMediator _chatMediator;
        string name;

        public PremiumUser(IChatMediator chatMediator,string name)
        {
            this._chatMediator = chatMediator;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"<Premium:{name}> : {message}");
        }

        public void SendMessage(string message)
        {
            _chatMediator.SendMessage(message, this);
        }
    }
}
