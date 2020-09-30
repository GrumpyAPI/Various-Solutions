using System;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (season == "summer")
            {
                if (budget <= 100)
                {
                    double amount = budget * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {amount:F2}");
                }
                else if (budget <= 1000 && budget > 100)
                {
                    double amount = budget * 0.40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {amount:F2}");
                }
                else if (budget > 1000)
                {
                    double amount = budget * 0.90;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {amount:F2}");
                }
            }
            else if (season == "winter")
            {
                if (budget <= 100)
                {
                    double amount = budget * 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {amount:F2}");
                }
                else if (budget <= 1000 && budget > 100)
                {
                    double amount = budget * 0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {amount:F2}");
                }
                else if (budget > 1000)
                {
                    double amount = budget * 0.90;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {amount:F2}");
                }
            }

        }
    }
}
