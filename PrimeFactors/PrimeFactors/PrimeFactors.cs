using System;
using System.Collections.Generic;

namespace PrimeFactor.Service
{
    public class PrimeFactors
    {
        public static List<int> Calculate(int number)
        {
            List<int> list = new List<int>();
            if (number != 1)
                list.Add(number);
            
            return list;
        }
    }
}
