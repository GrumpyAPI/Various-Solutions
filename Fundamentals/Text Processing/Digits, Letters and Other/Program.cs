using System;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string numbers = "";
            string letters = "";
            string other = "";

            foreach (var letter in input)
            {
                if (char.IsDigit(letter))
                {
                    numbers += letter;
                }
                else if (char.IsLetter(letter))
                {
                    letters += letter;
                }
                else
                {
                    other += letter;
                }
            }

            Console.WriteLine($"{numbers}\n{letters}\n{other}");
        }
    }
}
