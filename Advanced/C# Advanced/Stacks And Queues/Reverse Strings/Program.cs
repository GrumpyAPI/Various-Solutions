using System;
using System.Collections.Generic;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var words = new Stack<char>();

            foreach (var symbol in input)
            {
                words.Push(symbol);
            }

            foreach (var symbol in words)
            {
                Console.Write(symbol);
            }
        }
    }
}
