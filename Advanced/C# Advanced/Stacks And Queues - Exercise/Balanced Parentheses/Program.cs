using System;
using System.Collections.Generic;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<char> firstSequence = new Queue<char>();
            Stack<char> secondSequence = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (i < (input.Length / 2))
                {
                    firstSequence.Enqueue(input[i]);
                }
                else
                {
                    secondSequence.Push(input[i]);
                }
            }

            for (int i = 0; i < firstSequence.Count; i++)
            {
                i--;

                char firstSymbol = firstSequence.Dequeue();
                char secondSymbol = secondSequence.Pop();

                if (firstSymbol == '(' && secondSymbol == ')')
                {
                    continue;
                }
                else if (firstSymbol == '[' && secondSymbol == ']')
                {
                    continue;
                }
                else if (firstSymbol == 123 && secondSymbol == 125)     // Works with both char and int representation of the char from the Ascii table. 
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
