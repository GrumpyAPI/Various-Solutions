using System;
using System.Linq;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string, List<string>>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!words.ContainsKey(word))   // if (words.ContainsKey(word) == false)
                {
                    words.Add(word, new List<string>());
                    //words[word] = new List<string>();     - the way in the softuni lecture example.
                }

                words[word].Add(synonym);
            }

            foreach (var word in words)
            {
                // foreach loop needs to be foreach (var item in words)
                //var word = item.Key;
                //var synonym = item.Value;

                //Console.WriteLine($"{word} - {string.Join(", ", synonym)}");
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
