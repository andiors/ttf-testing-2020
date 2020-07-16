using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

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

            string customSeparator = "";
            if (IsCustomDelimiter(inputString))
            {
                customSeparator = inputString.Substring(2, 1);
                inputString = inputString.Substring(4);
            }

            int sum = 0;
            string[] tokens = inputString.Split(new string[] { ",", "\n", customSeparator, },
                StringSplitOptions.None);

            foreach (string text in tokens)
            {
                int numberText = int.Parse(text);
                sum += numberText;
            }

            return sum;

        }

        private static bool IsCustomDelimiter(string inputString)
        {
            return inputString.StartsWith("//");
        }
    }
}
