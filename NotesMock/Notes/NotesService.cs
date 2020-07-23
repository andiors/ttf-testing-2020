using System;

namespace Notes
{
    public class NotesService : INotesService
    {
        private INotesRepository repository;

        public NotesService(INotesRepository repository)
        {
            this.repository = repository;
        }

        public void Add(string title, string description)
        {
            repository.Insert(new Note());
        }
    }
}
