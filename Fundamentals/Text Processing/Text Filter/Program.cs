using System;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord, new string('*', banWord.Length));  // Do not use a second variable for the result as it checks the original text once more and not the result from the first iteration, thus masking only the last word from the array. 
                }
            }

            Console.WriteLine(text);
        }
    }
}
