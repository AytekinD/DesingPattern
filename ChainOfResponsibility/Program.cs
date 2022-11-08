using ChainOfResponsibility.Abstract;
using ChainOfResponsibility.Concrete;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zincirin halkalarini Tanimliyoruz

            PlayerHandler mp3Player = new MP3Player();
            PlayerHandler mp4Player = new MP4();
            PlayerHandler aviPlayer = new AVIPlayer();

            //Zincirin halkalarini birbirine bagliyoruz
            mp3Player.SonrakiPlayerHandler = mp4Player;
            mp4Player.SonrakiPlayerHandler = aviPlayer;


            mp3Player.Play("test.avi");



        }
    }
}