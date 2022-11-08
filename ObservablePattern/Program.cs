namespace ObservablePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ilk olarak subject nesnemiz
            absUrun Iphone = new Urun("IPhone", 20000);
            Iphone.TakipListesi.Add(new Uye() { Email = "ali@gmail.com" });
            Iphone.TakipListesi.Add(new Uye() { Email = "veli@gmail.com" });
            Iphone.TakipListesi.Add(new Uye() { Email = "ayse@gmail.com" });
            Iphone.TakipListesi.Add(new Uye() { Email = "fatma@gmail.com" });

            Iphone.Fiyat = 18000;
        }
    }
}