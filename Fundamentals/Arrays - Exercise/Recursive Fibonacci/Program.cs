using System;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInSequence = int.Parse(Console.ReadLine());
            int[] array = new int[numberInSequence];
            array[0] = 1;
            array[1] = 1;

            for (int i = 2; i < numberInSequence; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            //for (int i = 0; i < numberInSequence; i++)        //If we need to see all the numbers.
            //{
            //    Console.WriteLine(array[i]);
            //}
            Console.WriteLine(array[numberInSequence - 1]);
        }
    }
}
