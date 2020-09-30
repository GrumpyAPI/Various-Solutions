using System;
using System.IO;

namespace Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new FileStream("../../../../Resources/copyMe.png", FileMode.Open))
            {
                using (var writer = new FileStream("../../../../Resources/copied.png", FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];

                        int byteSize = reader.Read(buffer, 0, buffer.Length);

                        if (byteSize < 1)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, byteSize);  // Writing to byteSize to ensure that we are not copying any blanks from the buffer.
                    }
                }
            }
        }
    }
}
