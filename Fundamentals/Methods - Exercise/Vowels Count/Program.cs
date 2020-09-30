using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            VowelsCount(word);
        }

        static void VowelsCount(string word)
        {
            byte counter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];

                if ("aeiouAEIOU".Contains(currentChar))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
