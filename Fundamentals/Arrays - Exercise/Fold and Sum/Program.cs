using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] upperArray = new int[numbers.Length / 2];
            int[] lowerArray = new int[numbers.Length / 2];
            int[] tempArray = new int[numbers.Length / 2];

            int frontAndBack = (numbers.Length / 2) / 2;
            int middle = numbers.Length / 2;

            byte counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < frontAndBack || i >= (numbers.Length - frontAndBack))
                {
                    tempArray[counter] = numbers[i];
                    counter++;
                }
                else
                {
                    lowerArray[i - counter] = numbers[i];
                }
            }
            // Array index mirroring:
            byte firstCounter = (byte)((upperArray.Length / 2) - 1);
            byte secondCounter = (byte)(upperArray.Length - 1);
            for (int i = 0; i < upperArray.Length; i++)
            {
                if (i < (upperArray.Length / 2))
                {
                    upperArray[i] = tempArray[firstCounter];
                    firstCounter--;
                }
                else
                {
                    upperArray[i] = tempArray[secondCounter];
                    secondCounter--;
                }
            }

            for (int i = 0; i < upperArray.Length; i++)
            {
                int currentNumber = upperArray[i] + lowerArray[i];
                Console.Write(currentNumber + " ");
            }
            Console.WriteLine();
        }
    }
}
