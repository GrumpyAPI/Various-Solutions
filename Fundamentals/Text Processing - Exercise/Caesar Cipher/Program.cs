using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                int newCharNumber = currentChar + 3;
                char newChar = (char)newCharNumber;

                result += newChar;
            }

            Console.WriteLine(result);
        }
    }
}
