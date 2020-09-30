using System;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();

            int count = numbers.Length > 3 ? 3 : numbers.Length;       // Ternary operator.

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Much simpler solution with .Take(), other function is .Skip()
            //Console
            //    .ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .OrderByDescending(n => n)
            //    .Take(3)
            //    .ToList()
            //    .ForEach(Console.WriteLine);
        }
    }
}
