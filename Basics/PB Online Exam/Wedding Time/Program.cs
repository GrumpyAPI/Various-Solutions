using System;

namespace Wedding_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double waterAmount = double.Parse(Console.ReadLine());
            double wineAmount = double.Parse(Console.ReadLine());
            double shampaneAmount = double.Parse(Console.ReadLine());
            double wiskeyAmount = double.Parse(Console.ReadLine());


            double shampanePrice = wiskeyPrice * 0.50;
            double winePrice = shampanePrice * 0.40;
            double waterPrice = shampanePrice * 0.10;

            double totalSum = (wiskeyPrice * wiskeyAmount) + (waterAmount * waterPrice) + (wineAmount * winePrice) + (shampaneAmount * shampanePrice);

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
