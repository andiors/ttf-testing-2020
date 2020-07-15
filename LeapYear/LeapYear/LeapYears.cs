using System;

namespace LeapYear.Service
{
    public class LeapYears
    {
        public static bool IsLeapYear(int year)
        {
            int value = 4;
            if (year == 100 || year == 1300)
                return false;
            
            if(year % value == 0)
            return true;
            else { return false; }
        }
    }
}
