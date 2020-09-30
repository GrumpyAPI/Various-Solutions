using System;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] splittedInput = input
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;

            for (int i = 0; i < splittedInput.Length; i++)
            {
                string currentInput = splittedInput[i];
                char firstLetter = currentInput[0];
                char lastLetter = currentInput[currentInput.Length - 1];
                double number = double.Parse(currentInput.Substring(1, currentInput.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    number /= firstLetter - 'A' + 1;    // Finding the position of the letter in the alphabet.
                }
                else
                {
                    number *= firstLetter - 'a' + 1;
                }

                if (char.IsUpper(lastLetter))
                {
                    number -= lastLetter - 'A' + 1;
                }
                else
                {
                    number += lastLetter - 'a' + 1;
                }

                totalSum += number;
            }

            Console.WriteLine(totalSum.ToString("F2"));
        }
    }
}
