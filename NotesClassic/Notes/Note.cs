using System;
using System.Collections.Generic;
using System.Text;

namespace Notes
{
    public class Note
    {
        public readonly string Title;
        public readonly string Description;
        public readonly DateTime CreationDate;

        public Note(string title, string description, DateTime creationDate)
        {
            this.Title = title;
            this.Description = description;
            CreationDate = creationDate;
        }
    }
}
