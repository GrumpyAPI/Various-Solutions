using System;
using System.Linq;
using System.Collections.Generic;

namespace Pokemon_Dont_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int pokemon = 0;

                if (index < 0)
                {
                    index = 0;
                    pokemon = numbers[index];
                    numbers.RemoveAt(0);
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                }
                else if (index > (numbers.Count - 1))
                {
                    index = numbers.Count - 1;
                    pokemon = numbers[index];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Add(numbers[0]);
                }
                else
                {
                    pokemon = numbers[index];
                    numbers.RemoveAt(index);
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > pokemon)
                    {
                        numbers[i] = numbers[i] - pokemon;
                    }
                    else if (numbers[i] <= pokemon)
                    {
                        numbers[i] = numbers[i] + pokemon;
                    }
                }

                sum += pokemon;
            }

            Console.WriteLine(sum);
        }
    }
}
