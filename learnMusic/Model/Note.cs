using System;
using System.Collections.Generic;
using System.Text;

namespace learnMusic.Model
{
    public class Note
    {
        private readonly string name;

        private NoteState state;

        private readonly decimal pitch;
        private readonly decimal[] midFrequencies = new decimal[]
        {
            261.63m, // Do4
            293.66m, // Re4
            329.63m, // Mi4
            349.23m, // Fa4
            392.00m, // Sol4
            440.00m, // La4
            493.88m  // Si4
        };  

        /// <summary>
        /// e.g. 440 HZ for middle A
        /// </summary>
        public decimal Pitch
        {
            get
            {
                switch (state)
                {
                    case NoteState.Flat:
                        return pitch - 20;
                    case NoteState.Sharp:
                        return pitch + 20;
                    default:
                        return pitch; ;
                }
                
            }
        }

        /// <summary>
        /// the Note name
        /// </summary>
        public string Name
        {
            get
            {
                switch (state)
                {
                    case NoteState.Flat:
                        return $"{name}♭";
                    case NoteState.Sharp:
                        return $"{name}#";
                    default:
                        return name;
                }
                
            }
        }

        /// <summary>
        /// Ctor #1: Italian notation
        /// </summary>
        public Note(NotesItalian name)
        {
            this.name = name.ToString();
            this.pitch = GetInitialPitch();
        }

        /// <summary>
        /// Ctor #2: Western notation
        /// </summary>
        public Note(NotesWestern name)
        {
            this.name = name.ToString();
            this.pitch = GetInitialPitch();
        }

        /// <summary>
        /// Flatten note
        /// </summary>
        public void Flatten()
        {
            state = NoteState.Flat;
        }

        /// <summary>
        /// Sharpen note
        /// </summary>
        public void Sharpen()
        {
            state = NoteState.Sharp;
        }

        /// <summary>
        /// Restore note to normal pitch
        /// </summary>
        public void Tonal()
        {
            state = NoteState.Tonal;
        }

        private decimal GetInitialPitch()
        {
            decimal pitch = 0m;
            switch (name)
            {
                case "Do": 
                    pitch = midFrequencies[0];
                    break;
                case "Re":
                    pitch = midFrequencies[1];
                    break;
                case "Mi":
                    pitch = midFrequencies[2];
                    break;
                case "Fa":
                    pitch = midFrequencies[3];
                    break;
                case "Sol":
                    pitch = midFrequencies[4];
                    break;
                case "La":
                    pitch = midFrequencies[5];
                    break;
                case "Si":
                    pitch = midFrequencies[6];
                    break;
            }

            return pitch;
        }
    }
}
