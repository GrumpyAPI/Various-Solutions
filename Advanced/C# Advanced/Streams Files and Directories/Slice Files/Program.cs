using System;
using System.Collections.Generic;
using System.IO;

namespace Slice_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = "../../../../Resources/05. Slice File/sliceMe.txt";
            int parts = 4;

            List<string> files = new List<string> { "Part-1.txt", "Part-2.txt", "Part-3.txt", "Part-4.txt" };

            using (var streamReadFile = new FileStream(sourceFile, FileMode.Open))
            {
                long pieceSize = (long)Math.Ceiling((double)streamReadFile.Length / parts);

                for (int i = 0; i < parts; i++)
                {
                    long currentPieceSize = 0;

                    using (var streamCreatFile = new FileStream($"../../../../Resources/05. Slice File/{files[i]}", FileMode.Create))
                    {
                        while (true)
                        {
                            byte[] buffer = new byte[4096];

                            if (streamReadFile.Read(buffer, 0, buffer.Length) != default)
                            {
                                currentPieceSize += buffer.Length;
                                streamCreatFile.Write(buffer, 0, buffer.Length);
                            }
                            else
                            {
                                break;
                            }

                            if (currentPieceSize >= pieceSize)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
