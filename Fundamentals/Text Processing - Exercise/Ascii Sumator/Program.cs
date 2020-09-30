using System;

namespace Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            bool isNormal = false;  // To check if the starting character and ending character are not reversed.

            if (startChar < endChar)
            {
                isNormal = true;
            }

            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (isNormal)
                {
                    if (currentChar > startChar && currentChar < endChar)
                    {
                        sum += currentChar;
                    }
                }
                else
                {
                    if (currentChar < startChar && currentChar > endChar)
                    {
                        sum += currentChar;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
