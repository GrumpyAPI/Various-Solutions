using System;
using System.IO;

namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"..\..\..\..\Resources\01. Odd Lines\Input.txt")) // '..\' returns 1 directory back. The path can be written with '/' as well and without the '@' which escapes the special symbols.
            {
                using (var writer = new StreamWriter("../../../../Resources/01. Odd Lines/Output.txt", true))   // 'true' is for append. Watch out for the exact names of the dirs!!!
                {
                    int counter = 0;

                    while (true)
                    {
                        var line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        if (counter % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }

                        counter++;
                    }
                }
            }
        }
    }
}
