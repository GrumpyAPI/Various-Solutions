using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numbersDotLengthMinusOne = numbers.Length - 1;      // For some reason if i type "i < numbers.length - 1" in the "for loop", it does not work properly.
            int finalResult = 0;

            for (int i = 0; i < numbersDotLengthMinusOne; i++)
            {
                int[] condenced = new int[numbers.Length - 1];
                for (int j = 0; j < condenced.Length; j++)
                {
                    condenced[j] = numbers[j] + numbers[j + 1];
                }
                numbers = condenced;
                finalResult = condenced[0];
            }
            Console.WriteLine(finalResult);
        }
    }
}
