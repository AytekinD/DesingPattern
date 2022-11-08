namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Creater creater = new Creater();
            MobileApplication androidApp = creater.FactoryMetod(AllMobileType.Android);
            MobileApplication iosApp = creater.FactoryMetod(AllMobileType.IOS);
            MobileApplication huaweiApp = creater.FactoryMetod(AllMobileType.HArmonyOS);

            androidApp.Platform();
            iosApp.Platform();
            huaweiApp.Platform();



        }
    }
}