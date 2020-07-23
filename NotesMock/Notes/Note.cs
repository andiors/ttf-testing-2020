using System;
using System.Collections.Generic;
using System.Text;

namespace Notes
{
    public class Note
    {
        public readonly string title;
        public readonly string description;
        public readonly DateTime creationDate;

        public Note(string title, string description, DateTime creationDate)
        {
            this.title = title;
            this.description = description;
            this.creationDate = creationDate;
        }

        public override bool Equals(object obj)
        {
            return obj is Note note &&
                title == note.title &&
                description == note.description;
        }
        
        public override int GetHashCode()
        {
            return HashCode.Combine(title, description);
        }
    }
}
