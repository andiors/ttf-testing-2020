using System;
using System.Collections.Generic;
using System.Text;

namespace Notes
{
    public interface INotesService
    {
        void Add(string title, string description);
        IList<Note> All();
        void Clear();
    }
}
