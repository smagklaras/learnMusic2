using System;
using learnMusic.Model;


namespace learnMusic
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new MusicPlayer();
            player.PlayMusic();

            //Console.WriteLine($"Hello World!");


            
            //Console.WriteLine($"This is my 2nd note: {myOtherNote.Name}, freq: {myOtherNote.Pitch}");
        }

        
    }
}
