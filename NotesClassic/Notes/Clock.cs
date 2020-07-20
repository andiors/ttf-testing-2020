using System;
using System.Collections.Generic;
using System.Text;

namespace Notes
{
    public class Clock : IClock
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
