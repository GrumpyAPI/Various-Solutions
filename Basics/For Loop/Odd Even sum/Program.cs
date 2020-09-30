using System;

namespace Odd_Even_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < amount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine($"Yes\nSum = {evenSum}");
            }
            else
            {
                int difference = Math.Abs(evenSum - oddSum);
                Console.WriteLine($"No\nDiff = {difference}");
            }
        }
    }
}
