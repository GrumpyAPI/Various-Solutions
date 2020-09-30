using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int income = int.Parse(Console.ReadLine());

            int i = 1;

            double total = 0.0;

            while (i <= income)
            {
                double increase = double.Parse(Console.ReadLine());
                if (increase < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += increase;
                Console.WriteLine($"Increase: {increase:f2}");
                i++;
            }

            Console.WriteLine($"Total: {total:f2}");

        }
    }
}
