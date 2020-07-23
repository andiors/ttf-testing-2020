using NUnit.Framework;
using Moq;
using System;

namespace Notes.Test
{
    public class Tests
    {
        private Mock<INotesRepository> repository;
        private Mock<IClock> clock;
        private NotesService service;

        [SetUp]
        public void Setup()
        {
            repository = new Mock<INotesRepository>();
            clock = new Mock<IClock>();
            service = new NotesService(repository.Object, clock.Object);
        }

        [Test]
        public void ShouldAddANewNote()
        {
            service.Add("titolo", "descrizione");

            // Verifica del comportamento
            repository.Verify(repo => repo.Insert(It.IsAny<Note>()));
        }

        [Test]
        public void AddedNote_ShouldContainsTitleAndDescription()
        {
            Note expectedNote = new Note("titolo", "descrizione", DateTime.Now);
            
            service.Add("titolo", "descrizione");

            repository.Verify(repo => repo.Insert(expectedNote));
        }

        [Test]
        public void AddedNote_ShouldContainCreationDate()
        {
            clock.SetReturnsDefault<DateTime>(new DateTime(2000, 12, 25));
            
            DateTime expectedCreationDate = new DateTime(2000, 12, 25);
            service.Add("titolo", "descrizione");

            repository.Verify(repo =>
            repo.Insert(It.Is<Note>(note =>
            note.creationDate == expectedCreationDate)));
        }
    }
}