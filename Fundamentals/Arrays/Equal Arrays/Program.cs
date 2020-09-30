using System;
using System.Linq;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arrayTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool printSum = default;

            for (int i = 0; i < arrayOne.Length; i++)
            {
                sum += arrayOne[i];

                if (arrayOne[i] != arrayTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index.");
                    printSum = false;
                    break;
                }
                printSum = true;
            }

            if (printSum == true)
            {
                Console.WriteLine($"Arrays are aidentical. Sum: {sum}");
            }
        }
    }
}
