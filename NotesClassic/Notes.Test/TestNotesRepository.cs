using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Notes.Test
{
    internal class TestNotesRepository : INotesRepository
    {
        public IList<Note> Notes = new List<Note>();

        public IList<Note> FindAll()
        {
            return Notes;
        }

        public void Insert(Note newNote)
        {
            Notes.Add(newNote);
        }

        public void Truncate()
        {
            Notes.Clear();
        }
    }
}