using NUnit.Framework;
using System.Collections.Generic;

namespace Notes.Test
{
    internal class TestNotesRepository : INotesRepository
    {
        public IList<Note> Notes = new List<Note>();

        public void Insert(Note newNote)
        {
            Notes.Add(newNote);
        }
    }
}