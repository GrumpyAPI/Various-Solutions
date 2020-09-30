using System;

namespace Godzilla_vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            clothesPrice = extras * clothesPrice;
            
            if (extras > 150)
            {
                clothesPrice = clothesPrice - (clothesPrice * 0.10);
            }

            if (decor + clothesPrice > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget - decor - clothesPrice):F2} leva more.");
            }

            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - decor - clothesPrice:F2} leva left.");
            }

        }
    }
}
