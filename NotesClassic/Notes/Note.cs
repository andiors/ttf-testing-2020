using System;
using System.Collections.Generic;
using System.Text;

namespace Notes
{
    public class Note
    {
        public readonly string Title;
        public readonly string Description;

        public Note(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
