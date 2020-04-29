using System;
using learnMusic.Model;


namespace learnMusic
{
    class Program
    {
        static void Main(string[] args)
        {
            var myNote = new Note("G", 134.2m);
            var myOtherNote = new Note("F", 240.3m);
            
            Console.WriteLine($"Hello World!");
            Console.WriteLine($"This is my 1st note: {myNote.Name}, freq: {myNote.Pitch}");
            Console.WriteLine($"This is my 2nd note: {myOtherNote.Name}, freq: {myOtherNote.Pitch}");
        }
    }
}
