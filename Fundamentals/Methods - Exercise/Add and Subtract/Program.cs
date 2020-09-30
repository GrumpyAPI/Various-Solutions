using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());
            int numberC = int.Parse(Console.ReadLine());

            int result = Sum(numberA , numberB);
            Subtract(result, numberC);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void Subtract(int a, int b)
        {
            int result = a - b;

            Console.WriteLine(result);
        }
    }
}
