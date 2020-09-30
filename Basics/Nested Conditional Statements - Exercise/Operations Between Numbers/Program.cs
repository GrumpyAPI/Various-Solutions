using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = int.Parse(Console.ReadLine());
            double n2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            if (n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (symbol == "+")
            {
                double result = n1 + n2;
                double evenOrOdd = result % 2;
                if (evenOrOdd == 0)
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
                }
            }
            else if (symbol == "-")
            {
                double result = n1 - n2;
                double evenOrOdd = result % 2;
                if (evenOrOdd == 0)
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
                }
            }
            else if (symbol == "*")
            {
                double result = n1 * n2;
                double evenOrOdd = result % 2;
                if (evenOrOdd == 0)
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
                }
            }
            else if (symbol == "/")
            {
                double result = n1 / n2;
                Console.WriteLine($"{n1} {symbol} {n2} = {result:F2}");
            }
            else if (symbol == "%")
            {
                double result = n1 % n2;
                Console.WriteLine($"{n1} {symbol} {n2} = {result}");
            }

        }
    }
}
