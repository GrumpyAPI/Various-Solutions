using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());

            double resultA = FactorialNumber(numberA);
            double resultB = FactorialNumber(numberB);

            double result = resultA / resultB;

            Console.WriteLine($"{result:F2}");
        }

        static double FactorialNumber(int a)
        {
            double result = a * (a - 1);

            for (int i = (a - 2); i > 0; i--)
            {
                result = result * i; 
            }

            return result;
        }
    }
}
