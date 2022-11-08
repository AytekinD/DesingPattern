using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Lab2
{
    public class SingletonClass
    {
        private static SingletonClass _singletonClass;

        private SingletonClass()
        {

        }

        public static SingletonClass SingletonObject
        {
            get
            {
                if (_singletonClass == null)
                {
                    _singletonClass = new SingletonClass();
                }
                return _singletonClass;
            }
            
        }

    }
}
