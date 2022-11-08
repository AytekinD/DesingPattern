using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Creater
    {
        public MobileApplication FactoryMetod(AllMobileType OStype)
        {
            //Yip bildirimi icin abstract sinif kullaniyorz
            MobileApplication ma = null;

            switch (OStype)
            {
                case AllMobileType.Android:
                    ma = new Android();
                    break;
                case AllMobileType.IOS:
                    ma = new IPhone();
                    break;
                case AllMobileType.HArmonyOS:
                    ma = new HarmonyOS();
                    break;
                default:
                    break;
            }
            return ma;
        }
    }
}
