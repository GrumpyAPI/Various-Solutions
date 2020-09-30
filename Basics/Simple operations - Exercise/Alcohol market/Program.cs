using System;

namespace Alcohol_market
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double beerAmount = double.Parse(Console.ReadLine());
            double wineAmount = double.Parse(Console.ReadLine());
            double rakiaAmount = double.Parse(Console.ReadLine());
            double wiskeyAmount = double.Parse(Console.ReadLine());

            double rakiaPrice = wiskeyPrice / 2;
            double winePrice = rakiaPrice - (0.4 * rakiaPrice);
            double beerPrice = rakiaPrice - (0.8 * rakiaPrice);

            double totalRakiaPrice = rakiaAmount * rakiaPrice;
            double totalWinePrice = wineAmount * winePrice;
            double totalBeerPrice = beerAmount * beerPrice;
            double totalWiskeyPrice = wiskeyAmount * wiskeyPrice;

            double totalPrice = totalBeerPrice + totalRakiaPrice + totalWinePrice + totalWiskeyPrice;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
