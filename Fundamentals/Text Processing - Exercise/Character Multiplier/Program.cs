using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");

            string word1 = words[0];
            string word2 = words[1];

            int count = 0;

            if (word1.Length > word2.Length)
            {
                count = word1.Length;
            }
            else
            {
                count = word2.Length;
            }

            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                int firstWordLetter = word1[i];
                int secondWordLetter = word2[i];

                sum += firstWordLetter * secondWordLetter;

                if (word1.Length == i + 1)
                {
                    for (int j = i + 1; j < word2.Length; j++)
                    {
                        sum += word2[j];
                    }

                    break;
                }
                else if (word2.Length == i + 1)
                {
                    for (int j = i + 1; j < word1.Length; j++)
                    {
                        sum += word1[i];
                    }

                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
