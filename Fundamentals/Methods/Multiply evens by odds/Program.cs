using System;

namespace Multiply_evens_by_odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sumOfEven = 0;

            while (number != 0)
            {
                int nextNum = number % 10;

                if (nextNum % 2 == 0)
                {
                    sumOfEven += nextNum;
                }
                number -= nextNum;
                number /= 10;
            }

            return sumOfEven;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sumOfOdds = 0;

            while (number != 0)
            {
                int nextNum = number % 10;

                if (nextNum % 2 == 1)
                {
                    sumOfOdds += nextNum;
                }
                number -= nextNum;
                number /= 10;
            }

            return sumOfOdds;
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int result = GetSumOfOddDigits(number) * GetSumOfEvenDigits(number);
            return result;
        }
    }
}
