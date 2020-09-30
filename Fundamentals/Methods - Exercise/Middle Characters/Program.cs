using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            MiddleChar(word);
        }

        static void MiddleChar(string word)
        {
            if (word.Length % 2 == 1)
            {
                int i = word.Length / 2;
                char middleChar = word[i];

                Console.WriteLine(middleChar);
            }
            else
            {
                int j = word.Length / 2;
                char firstChar = word[j - 1];
                char secondChar = word[j];

                Console.WriteLine($"{firstChar}{secondChar}");
            }
        }
    }
}
