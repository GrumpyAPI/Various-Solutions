using System;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string finalString = RepeatString(word, count);

            Console.WriteLine(finalString);
        }

        static string RepeatString(string str, int count)
        {
            string result = "";

            for (int i = 0; i < count; i++)
            {
                result += str;
            }

            return result;
        }
    }
}
