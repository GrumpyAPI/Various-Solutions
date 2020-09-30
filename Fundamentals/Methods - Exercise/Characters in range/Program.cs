using System;

namespace Characters_in_range
{
    class Program
    {
        static void Main(string[] args)
        {
            char charA = char.Parse(Console.ReadLine());
            char charB = char.Parse(Console.ReadLine());

            CharactersInBetween(charA, charB);
        }

        static void CharactersInBetween(char a, char b)
        {
            for (int i = (a + 1); i < b; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
