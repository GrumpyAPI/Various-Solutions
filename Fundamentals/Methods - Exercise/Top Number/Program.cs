using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                IsNumberDivisibleBy8(i);
            }
        }

        static void IsNumberDivisibleBy8(int a)
        {
            int savedValue = a;
            int sum = 0;
            string numberLength = Convert.ToString(a);

            for (int i = 0; i < numberLength.Length; i++)
            {
                int digit = a % 10;
                a /= 10;
                sum += digit;
            }

            if (sum % 8 == 0)
            {
                HasNumberOddDigit(savedValue);
            }
        }

        static void HasNumberOddDigit(int a)
        {
            int savedValue = a;
            string numberLength = Convert.ToString(a);

            for (int i = 0; i < numberLength.Length; i++)
            {
                int digit = a % 10;
                a /= 10;

                if (digit % 2 == 1)
                {
                    Console.WriteLine(savedValue);
                    break;
                }
            }
        }
    }
}
