using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Lab1.Concrete
{
    public class Uyarlayici
    {
        public double SpecialRequest(double a, double b)
        {
            return a / b;
        }
    }
}
