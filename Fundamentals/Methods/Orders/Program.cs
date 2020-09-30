using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PriceCalculation(product, quantity);
        }

        static void PriceCalculation(string product, int quantity)
        {
            if (product == "coffee")
            {
                double result = quantity * 1.50;
                Console.WriteLine($"{result:F2}");
            }
            else if (product == "water")
            {
                double result = quantity * 1.00;
                Console.WriteLine($"{result:F2}");
            }
            else if (product == "coke")
            {
                double result = quantity * 1.40;
                Console.WriteLine($"{result:F2}");
            }
            else if (product == "snacks")
            {
                double result = quantity * 2.00;
                Console.WriteLine($"{result:F2}");
            }
        }
    }
}
