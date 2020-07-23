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

        public Note Update(Note noteToUpdate, string newTitle, string newDescription)
        {
            if(noteToUpdate != null)
            {
                Note updatedNote = new Note(newTitle, newDescription, noteToUpdate.CreationDate);
                noteToUpdate = updatedNote;
            }

            return noteToUpdate;
        }
    }
}
