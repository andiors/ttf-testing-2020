using System;
using System.Collections.Generic;

namespace PrimeFactor.Service
{
    public class PrimeFactors
    {
        public static List<int> Calculate(int number)
        {
            List<int> list = new List<int>();
            
            int value = 2;
            while(value <= number)
            {
                if (number % value == 0)
                {
                    list.Add(value);
                    number /= value;
                }
                else
                {
                    value++;
                }
            }
               
            return list;
        }
    }
}
