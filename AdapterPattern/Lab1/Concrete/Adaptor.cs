using AdapterPattern.Lab1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Lab1.Concrete
{
    public class Adaptor : Uyarlayici, ITarget
    {
        public string Request(int i)
        {
            return $"Tamini Sonuc:{Math.Round(SpecialRequest(i, 3))}";
        }
    }
}
