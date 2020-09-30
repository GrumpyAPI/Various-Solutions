using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>(input);

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0].ToLower() == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else if (command[0].ToLower() == "remove")
                {
                    int amountToPop = int.Parse(command[1]);

                    if (amountToPop < stack.Count)
                    {
                        for (int i = 0; i < amountToPop; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            int sum = 0;

            while (stack.Any())
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
