using System;
using System.Collections.Generic;
using System.Text;

namespace learnMusic.Model
{
    public class Note
    {
        private const int MinOctave     = 1;
        private const int MaxOctave     = 8;
        private const int InitialOctave = 4;

        private readonly string name;

        private NoteState state;
        
        private int currentOctave = 4;

        private readonly decimal pitch;
        private static readonly decimal[] midFrequencies = new decimal[]
        {
            261.63m, // Do4
            293.66m, // Re4
            329.63m, // Mi4
            349.23m, // Fa4
            392.00m, // Sol4
            440.00m, // La4
            493.88m  // Si4
        };

        public int Octave => currentOctave;

        /// <summary>
        /// e.g. 440 HZ for middle A
        /// </summary>
        public decimal Pitch
        {
            get
            {
                var currentPitch = CalculateOctavePitch(pitch);
                switch (state)
                {
                    case NoteState.Flat:
                        return ModifyPitch(currentPitch, -20);
                    case NoteState.Sharp:
                        return ModifyPitch(currentPitch, 20);
                    default:
                        return currentPitch; 
                }
                
            }
        }

        private decimal CalculateOctavePitch(decimal pitch)
        {
            int step = (currentOctave - InitialOctave);
            decimal newPitch = pitch + (step * 180);
            return newPitch;
        }

        private decimal ModifyPitch(decimal pitch, int value)
        {
            return pitch + value;
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
            this.pitch = GetInitialPitch(this.name);
        }

        /// <summary>
        /// Ctor #2: Western notation
        /// </summary>
        public Note(NotesWestern name)
        {
            this.name  = name.ToString();
            this.pitch = GetInitialPitch(this.name);
        }

        /// <summary>
        /// Flatten note
        /// </summary>
        public void Flatten()
        {
            state = NoteState.Flat;
        }

        /// <summary>
        /// Flatten note
        /// </summary>
        public void OctaveUp()
        {
            if (currentOctave < MaxOctave)
            {
                currentOctave++;
            }
        }

        /// <summary>
        /// Flatten note
        /// </summary>
        public void OctaveDown()
        {
            if (currentOctave > MinOctave)
            {
                currentOctave--;
            }
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

        
        private static decimal GetInitialPitch(string noteName)
        {
            decimal pitch = 0m;
            switch (noteName)
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
