using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class HarmonyOS : MobileApplication
    {
        public override void Platform()
        {
            Console.WriteLine("Bu uygulama huawei icin calismaktadir.");
        }
    }
}
