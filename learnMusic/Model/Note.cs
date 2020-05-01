using System;
using System.Collections.Generic;
using System.Text;

namespace learnMusic.Model
{
    public class Note
    {
        /// <summary>
        /// the note name
        /// </summary>
        private readonly string name;

        private decimal pitch;

        /// <summary>
        /// e.g. 440 HZ for middle A
        /// </summary>
        public decimal Pitch => pitch;

        /// <summary>
        /// the note name
        /// </summary>
        public string Name => name;

        public Note(NotesItalian name, decimal pitch)
        {
            this.name = name.ToString();
            this.pitch = pitch;
        }

        public Note(NotesWestern name, decimal pitch)
        {
            this.name = name.ToString();
            this.pitch = pitch;
        }
    }
}
