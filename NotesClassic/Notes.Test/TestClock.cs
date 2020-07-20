using System;

namespace Notes.Test
{
    internal class TestClock : IClock
    {
        public DateTime Now()
        {
            return new DateTime(2000, 12, 25);
        }
    }
}