using System;
using System.Linq;
using System.Collections.Generic;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string message = Console.ReadLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                int index = CalculateIndex(currentNumber);

                var currentCharAndRealIndex = GetCharFromMessage(index, message);
                Console.Write(currentCharAndRealIndex.Item1);

                message = message.Remove(currentCharAndRealIndex.Item2, 1);     // We need to assign the new value back to the original string as it does not update itself.
            }

            Console.WriteLine();
        }

        static int CalculateIndex(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int currentNumber = number % 10;
                sum += currentNumber;
                number /= 10;
            }

            return sum;
        }
        static Tuple<char, int> GetCharFromMessage(int index, string message)
        {
            int countIndex = 0;

            for (int i = 0; i < index; i++)
            {
                countIndex++;

                if (countIndex == message.Length)
                {
                    countIndex = 0;
                }
            }

            char currentChar = message[countIndex];
            return Tuple.Create(currentChar, countIndex);       // Returning 2 values.
        }
    }
}
