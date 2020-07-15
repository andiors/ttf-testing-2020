using System;

namespace LeapYear.Service
{
    public class LeapYears
    {
        public static bool IsLeapYear(int year)
        {
            int value = 4;

            if(year == 0)
            { throw new NullReferenceException(); }
            
            if (year % 400 == 0)
                return true;
            else if ((year % 100 == 0) && (year % value == 0))
                return false;
            else 
                return true;
        }
    }
}
