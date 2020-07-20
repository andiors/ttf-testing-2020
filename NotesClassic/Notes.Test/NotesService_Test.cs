using NUnit.Framework;
using Notes;
using System.Linq;

namespace Notes.Test
{
    public class NotesService_Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldAdd_ANewNote()
        {
            TestNotesRepository repository = new TestNotesRepository();
            NotesService service = new NotesService(repository);
            service.Add("Titolo", "Descrizione");

            Assert.That(repository.Notes, Has.Count.EqualTo(1));
        }

        [Test]
        public void AddedNote_ShouldContains_TitleAndDescription()
        {
            TestNotesRepository repository = new TestNotesRepository();
            NotesService service = new NotesService(repository);
            service.Add("Titolo", "Descrizione");

            Note note = repository.Notes.First();
            
            Assert.That(note.Title, Is.EqualTo("Titolo"));
            Assert.That(note.Description, Is.EqualTo("Descrizione"));
        }
    }
}