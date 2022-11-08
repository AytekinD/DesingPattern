using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern
{
    //Concrete Subject
    public class Urun : absUrun
    {
        public Urun(string UrunAdi, decimal urunFiyat) : base(UrunAdi, urunFiyat)
        {
        }
    }
}
