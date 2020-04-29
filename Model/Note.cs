using System;
using System.Collections.Generic;
using System.Text;

namespace learnMusic.Model
{
    class Note
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

        public Note(string name, decimal pitch)
        {
            this.name = name;
            this.pitch = pitch;
        }
    }
}
