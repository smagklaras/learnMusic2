using System;
using System.Collections.Generic;
using System.Text;

namespace learnMusic.Model
{
    public class MusicPlayer
    {
        public void PlayMusic()
        {
            var myNote = new Note(NotesItalian.Do);
            Console.WriteLine($"This is my 1st note: {myNote.Name}, freq: {myNote.Pitch}");
            
            myNote.Sharpen();
            Console.WriteLine($"This is my 1st note sharpened: {myNote.Name}, freq: {myNote.Pitch}");

            myNote.Flatten();
            Console.WriteLine($"This is my 1st note flattened: {myNote.Name}, freq: {myNote.Pitch}");

            myNote.Tonal();
            Console.WriteLine($"This is my 1st note tonal on octave {myNote.Octave}: {myNote.Name}, freq: {myNote.Pitch}");

            myNote.OctaveUp();
            Console.WriteLine($"This is my 1st note tonal on octave {myNote.Octave}: {myNote.Name}, freq: {myNote.Pitch}");

            myNote.OctaveDown();
            myNote.OctaveDown();
            Console.WriteLine($"This is my 1st note tonal on octave {myNote.Octave}: {myNote.Name}, freq: {myNote.Pitch}");

            var myOtherNote = new Note(NotesWestern.F);
            Console.WriteLine($"This is my 2nd note: {myOtherNote.Name}, freq: {myOtherNote.Pitch}");

        }
    }
}
