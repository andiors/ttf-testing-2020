using System;
using System.Collections.Generic;
using System.Text;

namespace Notes
{
    public interface INotesRepository
    {
        void Insert(Note newNote);
        IList<Note> FindAll();
    }
}
