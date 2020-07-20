using NUnit.Framework;
using Notes;
using System.Linq;
using System.Collections.Generic;

namespace Notes.Test
{
    public class NotesService_Test
    {
        TestNotesRepository repository;
        NotesService service;

        [SetUp]
        public void Setup()
        {
            repository = new TestNotesRepository();
            service = new NotesService(repository);
        }

        [Test]
        public void ShouldAdd_ANewNote()
        {
            service.Add("Titolo", "Descrizione");

            Assert.That(repository.Notes, Has.Count.EqualTo(1));
        }

        [Test]
        public void AddedNote_ShouldContains_TitleAndDescription()
        {
            service.Add("Titolo", "Descrizione");

            Note note = repository.Notes.First();
            
            Assert.That(note.Title, Is.EqualTo("Titolo"));
            Assert.That(note.Description, Is.EqualTo("Descrizione"));
        }

        [Test]
        public void ShouldReturn_EmptyList_BeforeAddANote()
        {
            IList<Note> notes = service.All();

            Assert.That(notes, Is.Empty);
        }

        [Test]
        public void ShouldReturn_AListOfAddedNotes()
        {
            service.Add("titolo 1", "descrizione 1");
            service.Add("titolo 2", "descrizione 2");

            IList<Note> notes = service.All();
            Assert.That(notes, Has.Count.EqualTo(2));

        }
    }
}