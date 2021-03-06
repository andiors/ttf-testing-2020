using NUnit.Framework;
using Notes;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Notes.Test
{
    public class NotesService_Test
    {
        TestNotesRepository repository;
        TestClock clock;
        NotesService service;

        [SetUp]
        public void Setup()
        {
            repository = new TestNotesRepository();
            clock = new TestClock();
            service = new NotesService(repository, clock);
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
        public void AddedNote_ShouldContainsCreationDate()
        {
            service.Add("titolo", "descrizione");
            Note note = repository.Notes.First();
            Assert.That(note.CreationDate, Is.EqualTo(clock.Now()));
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

        [Test]
        public void ShouldClear_AllAddedNotes()
        {
            service.Add("titolo 1", "descrizione 1");
            service.Add("titolo 2", "descrizione 2");

            service.Clear();

            IList<Note> notes = service.All();
            Assert.That(notes, Is.Empty);

        }

        [Test]
        public void ShouldClear_AllAddedNotes_UsingRepository()
        {
            // Inizializzazione dello stato iniziale prima di effettuare il test
            List<Note> repositoryNotes = new List<Note>();
            repositoryNotes.Add(new Note("titolo 1", "descrizione 1", DateTime.Now));
            repositoryNotes.Add(new Note("titolo 2", "descrizione 2", DateTime.Now));
            repository.Notes = repositoryNotes;
           
            // Esecuzione di un'operazione che vogliamo testare - uno statement
            service.Clear();

            // Asserzione - 1 o pi� statement
            Assert.That(repository.Notes, Is.Empty);
        }

        [Test]
        public void Should_UpdateANote()
        {
            List<Note> repositoryNote = new List<Note>();
            repositoryNote.Add(new Note("titolo 1", "descrizione 1", DateTime.Now));
            repositoryNote.Add(new Note("titolo 2", "descrizione 2", DateTime.Now));
            repository.Notes = repositoryNote;

            service.Update(repository.Notes[0], "title 1", "descrizione 1");
            
            Assert.That(repository.Notes[0].Title, Is.EqualTo("title 1"));
        }

    }
}