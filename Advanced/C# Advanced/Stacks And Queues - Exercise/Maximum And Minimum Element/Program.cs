using System;
using System.Linq;
using System.Collections.Generic;

namespace Maximum_And_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int numOfQueries = int.Parse(Console.ReadLine());

            int minElement = int.MaxValue;
            int maxElement = int.MinValue;

            for (int i = 0; i < numOfQueries; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (command[0] == 1)
                {
                    stack.Push(command[1]);
                }
                else if (command[0] == 2)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else if (command[0] == 3)
                {
                    List<int> temp = new List<int>();

                    while (stack.Any())
                    {
                        int currentNum = stack.Pop();

                        if (currentNum > maxElement)
                        {
                            maxElement = currentNum;
                        }

                        temp.Add(currentNum);
                    }

                    temp.Reverse();

                    for (int j = 0; j < temp.Count; j++)
                    {
                        stack.Push(temp[j]);
                    }

                    Console.WriteLine(maxElement);
                }
                else if (command[0] == 4)
                {
                    List<int> temp = new List<int>();

                    while (stack.Any())
                    {
                        int currentNum = stack.Pop();

                        if (currentNum < minElement)
                        {
                            minElement = currentNum;
                        }

                        temp.Add(currentNum);
                    }

                    temp.Reverse();

                    for (int j = 0; j < temp.Count; j++)
                    {
                        stack.Push(temp[j]);
                    }

                    Console.WriteLine(minElement);
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
