using System;
using System.Linq;
using System.Collections.Generic;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            // A solution with remove:
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] < 0)
            //    {
            //        numbers.Remove(numbers[i]);
            //        i = -1;
            //    }
            //}
            //
            //numbers.Reverse();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    result.Add(numbers[i]);
                }
            }

            result.Reverse();

            //if (numbers.Count == 0)
            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                //Console.WriteLine(string.Join(" ", numbers));
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
