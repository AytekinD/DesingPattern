using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern
{
    public class Uye : IUye
    {

        public string Email { get; set; }
        public void Update(absUrun urun)
        {
            Console.WriteLine($"{urun.UrunAdi} fiyati  {urun.Fiyat.ToString("C2")} oldu. {Email} mail atildi.");
        }
    }
}
