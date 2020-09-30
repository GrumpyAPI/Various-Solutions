using System;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < (text.Length - 1); i++)
            {
                if (text[i] == text[i + 1])
                {
                    text = text.Remove(i, 1);
                    //text = text.Remove(text[i]);
                    // There is no overload of "Remove()" that takes a char, so the character is implicitly converted to an int and the Remove method tries to use it as an index into the string, which is way outside the string.
                    // Thus shows: "startIndex must be less than length of string."
                    i--;
                }
            }

            Console.WriteLine(text);
        }
    }
}
