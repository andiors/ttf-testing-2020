using System;
using System.Collections.Generic;
using System.Text;

namespace Notes
{
    public interface IClock
    {
        public DateTime Now();
    }
}
