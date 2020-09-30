using System;
using System.Linq;
using System.Collections.Generic;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> bombAndPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombAndPower[0])
                {
                    int startIndex = 0;
                    int deleteAmount = ((bombAndPower[1] * 2) + 1);

                    if (i - bombAndPower[1] >= 0)
                    {
                        startIndex = i - bombAndPower[1];
                    }

                    if ((startIndex + (deleteAmount - 1)) >= numbers.Count)
                    {
                        int count = numbers.Count - startIndex;

                        for (int j = 0; j < count; j++)
                        {
                            numbers.RemoveAt(startIndex);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < deleteAmount; j++)
                        {
                            numbers.RemoveAt(startIndex);
                        }
                    }
                }
            }

            int result = numbers.Sum();
            Console.WriteLine(result);
        }
    }
}
