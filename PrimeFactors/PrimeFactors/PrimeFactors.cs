using System;
using System.Collections.Generic;

namespace PrimeFactor.Service
{
    public class PrimeFactors
    {
        public static List<int> Calculate(int number)
        {
            List<int> list = new List<int>();
            while (number > 1)
            {
                for (int value = 2; value <= number; value++)
                {
                    if (number % value == 0)
                    {
                        list.Add(value);
                        number /= value;
                    }
                }
            }
            return list;
        }
    }
}
