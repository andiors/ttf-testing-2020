using System;
using System.Diagnostics.CodeAnalysis;

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

            if(inputString.Contains(',') || inputString.Contains('\n'))
            {
                int sum = 0;
                string[] tokens = inputString.Split(',', '\n');
                
                foreach(string text in tokens)
                {
                    int numberText = int.Parse(text);
                    sum += numberText;
                }

                return sum;
            }
            
            return int.Parse(inputString);
        }
    }
}
