namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMadiator();

            IUser ali = new BasicUser(chatMediator, "Ali");
            IUser veli = new PremiumUser(chatMediator, "Veli");
            IUser ayse = new BasicUser(chatMediator, "Ayse");
            IUser fatma = new PremiumUser(chatMediator, "Fatma");

            chatMediator.AddUser(ali);
            chatMediator.AddUser(veli);
            chatMediator.AddUser(ayse);
            chatMediator.AddUser(fatma);

            //Mesaj Gondermek isteginde
            ali.SendMessage("Naber!!");

            Console.ReadLine();


        }
    }
}