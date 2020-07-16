using System;

namespace StringCalculator
{
    public class StringCalculatorService
    {
        public static int Add(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return 0;
            }
                
            return int.Parse(inputString);
        }
    }
}
