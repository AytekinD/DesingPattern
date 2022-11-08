using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class IPhone : MobileApplication
    {
        public override void Platform()
        {
            Console.WriteLine("Bu uygulama IOS icin calismaktadir.");
        }
    }
}
