using System;

namespace Coffee_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int coffeeAmount = int.Parse(Console.ReadLine());

            string coffeeType = "";

            double profit = 0;

            while ((coffeeType = Console.ReadLine()) != "closed")
            {
                double coffeePrice = 0;

                if (coffeeType == "espresso")
                {
                    if (coffeeAmount < 50)
                    {
                        Console.WriteLine("Not enough coffee!");
                        continue;
                    }

                    coffeePrice = 3.00;
                    coffeeAmount -= 50;
                }
                else if (coffeeType == "cappuccino")
                {
                    if (coffeeAmount < 30)
                    {
                        Console.WriteLine("Not enough coffee!");
                        continue;
                    }

                    coffeePrice = 3.50;
                    coffeeAmount -= 30;
                }
                else if (coffeeType == "latte")
                {
                    if (coffeeAmount < 20)
                    {
                        Console.WriteLine("Not enough coffee!");
                        continue;
                    }

                    coffeePrice = 3.50;
                    coffeeAmount -= 20;
                }

                profit += coffeePrice;

                if (coffeeAmount == 0)
                {
                    Console.WriteLine("No more coffee left!");
                    break;
                }
            }

            if (coffeeAmount > 0)
            {
                Console.WriteLine($"Coffee left: {coffeeAmount}g");
            }
            Console.WriteLine($"Profit: {profit:F2} lv.");
        }
    }
}
