using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileWordsReader = new StreamReader(@"..\..\..\..\Resources\03. Word Count\Words.txt");
            var fileTextReader = new StreamReader(@"..\..\..\..\Resources\03. Word Count\Text.txt");
            var writer = new StreamWriter("../../../../Resources/03. Word Count/Output.txt");
            var words = new Dictionary<string, int>();

            using (fileWordsReader)
            {
                string line = fileWordsReader.ReadLine();

                while (line != null)
                {
                    string[] lineWords = line.ToLower().Split();

                    for (int i = 0; i < lineWords.Length; i++)
                    {
                        if (!(words.ContainsKey(lineWords[i])))
                        {
                            words.Add(lineWords[i], 0);
                        }
                    }

                    line = fileWordsReader.ReadLine();
                }
            }

            using (fileTextReader)
            {
                string lineText = fileTextReader.ReadLine();

                while (lineText != null)
                {
                    // For some reason it was not splitting the text by "..." so i had to use the unicode for the ellipsis character.
                    string[] currentLine = lineText.ToLower().Split(new[] { ' ', '.', '!', '?', '-', ',', '\u2026' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < currentLine.Length; i++)
                    {
                        if (words.ContainsKey(currentLine[i]))
                        {
                            words[currentLine[i]]++;
                        }
                    }

                    lineText = fileTextReader.ReadLine();
                }
            }

            using (writer)
            {
                foreach (var word in words.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine("{0} - {1}", word.Key, word.Value);
                }
            }
        }
    }
}
