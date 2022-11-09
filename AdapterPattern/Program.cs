using AdapterPattern.Lab1.Abstract;
using AdapterPattern.Lab1.Concrete;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Lab1

            Uyarlayici uyarlayici= new Uyarlayici();
            Console.WriteLine(uyarlayici.SpecialRequest(5, 3));

            ITarget target = new Adaptor();
            Console.WriteLine(target.Request(5));

            #endregion

        }
    }
}