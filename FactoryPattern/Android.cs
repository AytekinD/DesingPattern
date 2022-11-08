using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Android : MobileApplication
    {
        public override void Platform()
        {
            Console.WriteLine("Bu uygulama android icin calismaktadir.");
        }
    }
}
