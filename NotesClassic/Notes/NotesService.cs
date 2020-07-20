using System;
using System.Collections.Generic;

namespace Notes
{
    public class NotesService : INotesService
    {
        private INotesRepository repository;

        public NotesService(INotesRepository _repository)
        {
            repository = _repository;
        }

        public void Add(string title, string description)
        {
            Note note = new Note(title, description);
            repository.Insert(note);
        }

        public IList<Note> All()
        {
            return new List<Note>();
        }
    }
}
