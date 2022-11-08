using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Abstract
{
    public abstract class PlayerHandler
    {
        protected PlayerHandler _SonrakiPlayerHandler;
        public PlayerHandler SonrakiPlayerHandler { set { _SonrakiPlayerHandler = value; } }
        public abstract void Play(string filepath);
          

    }
}
