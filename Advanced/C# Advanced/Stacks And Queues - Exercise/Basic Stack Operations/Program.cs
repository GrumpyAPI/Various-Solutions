using System;
using System.Linq;
using System.Collections.Generic;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            int[] operations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int itemsAmount = operations[0];
            int itemsToPop = operations[1];
            int elementToLookFor = operations[2];

            for (int i = 0; i < itemsAmount; i++)
            {
                numbers.Push(items[i]);
            }

            for (int i = 0; i < itemsToPop; i++)
            {
                numbers.Pop();
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                bool isLowest = false;
                int lowestNum = int.MaxValue;

                while (numbers.Any())
                {
                    int currentNum = numbers.Pop();

                    if (currentNum == elementToLookFor)
                    {
                        Console.WriteLine("true");
                        break;
                    }
                    else
                    {
                        if (currentNum < lowestNum)
                        {
                            lowestNum = currentNum;
                        }

                        if (numbers.Count == 0)
                        {
                            isLowest = true;
                        }
                    }
                }

                if (isLowest)
                {
                    Console.WriteLine(lowestNum);
                }
            }
        }
    }
}
