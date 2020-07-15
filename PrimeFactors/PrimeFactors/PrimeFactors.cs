using System;
using System.Collections.Generic;

namespace PrimeFactor.Service
{
    public class PrimeFactors
    {
        public static List<int> Calculate(int number)
        {
            List<int> list = new List<int>();
            if (number == 2)
                list.Add(2);
            
            return list;
        }
    }
}
