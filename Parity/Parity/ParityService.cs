using System;

namespace Parity.Library
{
    public class ParityService
    {
        public static bool IsEven(int number)
        {
            return number % 2 != 0;
        }

        public static bool IsOdd(int number)
        {
            return !IsEven(number);
        }
    }
}
