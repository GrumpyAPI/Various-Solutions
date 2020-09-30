using System;

namespace New_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double flowerCost = 0.0;

            if (flowerType == "Roses")
            {
                double rosesPrice = 5.00;
                flowerCost = flowerCount * rosesPrice;
                if (flowerCount > 80)
                {
                    flowerCost -= flowerCost * 0.10;
                }
            }
            else if (flowerType == "Dahlias")
            {
                double dahliasPrice = 3.80;
                flowerCost = flowerCount * dahliasPrice;
                if (flowerCount > 90)
                {
                    flowerCost -= flowerCost * 0.15;    // Same as typing: flowerCost = flowerCost - (flowerCost * 0.15)
                }
            }
            else if (flowerType == "Tulips")
            {
                double tulipsPrice = 2.80;
                flowerCost = flowerCount * tulipsPrice;
                if (flowerCount > 80)
                {
                    flowerCost -= flowerCost * 0.15;
                }
            }
            else if (flowerType == "Narcissus")
            {
                double narcissusPrice = 3.00;
                flowerCost = flowerCount * narcissusPrice;
                if (flowerCount < 120)
                {
                    flowerCost += flowerCost * 0.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                double gladiolusPrice = 2.50;
                flowerCost = flowerCount * gladiolusPrice;
                if (flowerCount < 80)
                {
                    flowerCost += flowerCost * 0.20;
                }
            }

            double moneyLeft = budget - flowerCost;

            if (moneyLeft < 0)
            {
                moneyLeft = Math.Abs(moneyLeft);
                Console.WriteLine($"Not enough money, you need {moneyLeft:F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {moneyLeft:F2} leva left.");
            }

        }
    }
}
