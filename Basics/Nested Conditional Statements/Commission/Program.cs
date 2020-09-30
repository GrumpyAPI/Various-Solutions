using System;

namespace Commission
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (quantity > 0 && quantity <= 500)
                {
                    double output = quantity * 0.05;
                    Console.WriteLine($"{output:F2}");
                }
                else if (quantity > 500 && quantity <= 1000)
                {
                    double output = quantity * 0.07;
                    Console.WriteLine($"{output:F2}");
                }
                else if (quantity > 1000 && quantity <= 10000)
                {
                    double output = quantity * 0.08;
                    Console.WriteLine($"{output:F2}");
                }
                else if (quantity > 10000)
                {
                    double output = quantity * 0.12;
                    Console.WriteLine($"{output:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (quantity > 0 && quantity <= 500)
                {
                    double output = quantity * 0.045;
                    Console.WriteLine($"{output:F2}");
                }
                else if (quantity > 500 && quantity <= 1000)
                {
                    double output = quantity * 0.075;
                    Console.WriteLine($"{output:F2}");
                }
                else if (quantity > 1000 && quantity <= 10000)
                {
                    double output = quantity * 0.10;
                    Console.WriteLine($"{output:F2}");
                }
                else if (quantity > 10000)
                {
                    double output = quantity * 0.13;
                    Console.WriteLine($"{output:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (quantity > 0 && quantity <= 500)
                {
                    double output = quantity * 0.055;
                    Console.WriteLine($"{output:F2}");
                }
                else if (quantity > 500 && quantity <= 1000)
                {
                    double output = quantity * 0.08;
                    Console.WriteLine($"{output:F2}");
                }
                else if (quantity > 1000 && quantity <= 10000)
                {
                    double output = quantity * 0.12;
                    Console.WriteLine($"{output:F2}");
                }
                else if (quantity > 10000)
                {
                    double output = quantity * 0.145;
                    Console.WriteLine($"{output:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
