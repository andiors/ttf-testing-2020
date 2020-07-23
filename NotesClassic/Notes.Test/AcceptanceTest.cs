using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Test
{
    public class AcceptanceTest
    {
        [Test]
        public void ShouldRetrieve_AListOfNotes()
        {
            Clock clock = new Clock();
            TestNotesRepository repository = new TestNotesRepository();
            NotesService service = new NotesService(repository, clock);
        }
    }
}
