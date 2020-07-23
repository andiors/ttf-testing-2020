using NUnit.Framework;
using Moq;

namespace Notes.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldAddANewNote()
        {
            Mock<INotesRepository> repository = new Mock<INotesRepository>();
            NotesService service = new NotesService(repository.Object);
            
            service.Add("titolo", "descrizione");

            // Verifica del comportamento
            repository.Verify(repo => repo.Insert(It.IsAny<Note>()));
        }
    }
}