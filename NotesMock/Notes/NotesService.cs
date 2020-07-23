using System;

namespace Notes
{
    public class NotesService : INotesService
    {
        private INotesRepository repository;
        private IClock clock;

        public NotesService(INotesRepository repository, IClock clock)
        {
            this.repository = repository;
            this.clock = clock;
        }

        public void Add(string title, string description)
        {
            repository.Insert(new Note(title, description, clock.Now()));
        }
    }
}
