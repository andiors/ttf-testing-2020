using System;
using System.Collections.Generic;

namespace Notes
{
    public class NotesService : INotesService
    {
        private INotesRepository repository;
        private IClock clock;

        public NotesService(INotesRepository _repository, IClock _clock)
        {
            repository = _repository;
            clock = _clock;
        }

        public void Add(string title, string description)
        {
            Note note = new Note(title, description, clock.Now());
            repository.Insert(note);
        }

        public IList<Note> All()
        {
            return repository.FindAll();
        }

        public void Clear()
        {
            repository.Truncate();
        }
    }
}
