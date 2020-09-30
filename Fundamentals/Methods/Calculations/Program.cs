using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Adding(numberA, numberB);
                    break;
                case "subtract":
                    Subtracting(numberA, numberB);
                    break;
                case "multiply":
                    Multiplying(numberA, numberB);
                    break;
                case "divide":
                    Dividing(numberA, numberB);
                    break;
            }
        }

        static void Adding(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }

        static void Subtracting(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
        }

        static void Multiplying(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
        }

        static void Dividing(int a, int b)
        {
            int result = a / b;
            Console.WriteLine(result);
        }
    }
}
