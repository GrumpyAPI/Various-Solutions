using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../../../Resources/text.txt"))
            {
                int counter = 1;

                using (var writer = new StreamWriter("../../../../Resources/Output.txt"))
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        int lettersCount = 0;
                        int symbolsCount = 0;

                        // To remove the empty line at the end of the output file:
                        //if (counter != 1)
                        //{
                        //    writer.WriteLine();
                        //}

                        foreach (var @char in line)
                        {
                            if (char.IsLetter(@char))
                            {
                                lettersCount++;
                            }
                            else if (char.IsPunctuation(@char))
                            {
                                symbolsCount++;
                            }
                        }

                        writer.WriteLine($"Line {counter}: {line} ({lettersCount}) ({symbolsCount})");  // If we are removing the last blank line, this needs to be writer.Write(...);

                        counter++;

                        line = reader.ReadLine();
                    }

                }
            }
        }
    }
}
