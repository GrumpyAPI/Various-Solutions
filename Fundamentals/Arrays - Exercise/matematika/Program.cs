using System;
using System.Linq;

namespace matematika
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0 && array[i] % 2 != 0)
                {
                    Console.WriteLine($"{array[i]} is: True for the 1st condition.");
                }
                if (array[i] % 9 == 0 && array[i] % 5 != 0)
                {
                    Console.WriteLine($"{array[i]} is: True for the 2nd condition.");
                }
                if (array[i] % 3 == 0 && array[i] % 9 != 0)
                {
                    Console.WriteLine($"{array[i]} is: True for the 3rd condition.");
                }
                if (array[i] % 2 == 0 && array[i] % 9 != 0)
                {
                    Console.WriteLine($"{array[i]} is: True for the 4th condition.");
                }
            }
        }
    }
}
// 207 9045 3513 7356 888 2790 3666
