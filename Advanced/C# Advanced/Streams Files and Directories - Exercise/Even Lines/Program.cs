using System;
using System.IO;

namespace Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string specialSymbols = "-.,!?";
            int counter = 0;

            using (var reader = new StreamReader("../../../../Resources/text.txt"))
            {
                using (var writer = new StreamWriter("../../../../Resources/Output.txt"))
                {
                    while (true)
                    {
                        var line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }


                        if (counter % 2 == 0)
                        {
                            string changedLine = string.Empty;

                            foreach (var charr in line)
                            {
                                if (specialSymbols.Contains(charr))
                                {
                                    changedLine += '@';
                                }
                                else
                                {
                                    changedLine += charr;
                                }
                            }

                            string[] splitLine = changedLine.Split();

                            Array.Reverse(splitLine);

                            writer.WriteLine(string.Join(" ", splitLine));
                        }

                        counter++;
                    }

                }
            }
        }
    }
}
