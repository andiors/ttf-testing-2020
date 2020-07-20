using System;

namespace Notes
{
    public class NotesService : INotesService
    {
        private INotesRepository repository;

        public NotesService(INotesRepository _repository)
        {
            this.repository = _repository;
        }

        public void Add(string title, string description)
        {
            Note note = new Note(title, description);
            repository.Insert(note);
        }
    }
}
