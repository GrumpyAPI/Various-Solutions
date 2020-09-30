using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
         {
            double budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());

            double totalCost = 0.0;

            if (season == "Spring")
            {
                int springCost = 3000;
                if (fishermanCount <= 6)
                {
                    double discount = 0.0;
                    discount -= springCost * 0.10;
                    totalCost = springCost + discount;
                    if (fishermanCount % 2 == 0)
                    {
                        double additionalDiscount = 0.0;
                        additionalDiscount -= totalCost * 0.05;
                        totalCost = springCost + discount + additionalDiscount;     //Needs to be a "+" because we are adding the discounts.
                    }
                }
                else if (fishermanCount >= 7 && fishermanCount <= 11)
                {
                    double discount = 0.0;
                    discount -= springCost * 0.15;
                    totalCost = springCost + discount;
                    if (fishermanCount % 2 == 0)
                    {
                        double additionalDiscount = 0.0;
                        additionalDiscount -= totalCost * 0.05;
                        totalCost = springCost + discount + additionalDiscount;
                    }
                }
                else if (fishermanCount >= 12)
                {
                    double discount = 0.0;
                    discount -= springCost * 0.25;
                    totalCost = springCost + discount;
                    if (fishermanCount % 2 == 0)
                    {
                        double additionalDiscount = 0.0;
                        additionalDiscount -= totalCost * 0.05;
                        totalCost = springCost + discount + additionalDiscount;
                    }
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                int summerAndAutumnCost = 4200;
                if (fishermanCount <= 6)
                {
                    double discount = 0.0;
                    discount -= summerAndAutumnCost * 0.10;
                    totalCost = summerAndAutumnCost + discount;
                    if (fishermanCount % 2 == 0)
                    {
                        if (season == "Summer")
                        {
                            double additionalDiscount = 0.0;
                            additionalDiscount -= totalCost * 0.05;
                            totalCost = summerAndAutumnCost + discount + additionalDiscount;
                        }
                    }
                }
                else if (fishermanCount >= 7 && fishermanCount <= 11)
                {
                    double discount = 0.0;
                    discount -= summerAndAutumnCost * 0.15;
                    totalCost = summerAndAutumnCost + discount;
                    if (fishermanCount % 2 == 0)
                    {
                        if (season == "Summer")
                        {
                            double additionalDiscount = 0.0;
                            additionalDiscount -= totalCost * 0.05;
                            totalCost = summerAndAutumnCost + discount + additionalDiscount;
                        }
                    }
                }
                else if (fishermanCount >= 12)
                {
                    double discount = 0.0;
                    discount -= summerAndAutumnCost * 0.25;
                    totalCost = summerAndAutumnCost + discount;
                    if (fishermanCount % 2 == 0)
                    {
                        if (season == "Summer")
                        {
                            double additionalDiscount = 0.0;
                            additionalDiscount -= totalCost * 0.05;
                            totalCost = summerAndAutumnCost + discount + additionalDiscount;
                        }
                    }
                }
            }
            else if (season == "Winter")
            {
                int winterCost = 2600;
                if (fishermanCount <= 6)
                {
                    double discount = 0.0;
                    discount -= winterCost * 0.10;
                    totalCost = winterCost + discount;
                    if (fishermanCount % 2 == 0)
                    {
                        double additionalDiscount = 0.0;
                        additionalDiscount -= totalCost * 0.05;
                        totalCost = winterCost + discount + additionalDiscount;
                    }
                }
                else if (fishermanCount >= 7 && fishermanCount <= 11)
                {
                    double discount = 0.0;
                    discount -= winterCost * 0.15;
                    totalCost = winterCost + discount;
                    if (fishermanCount % 2 == 0)
                    {
                        double additionalDiscount = 0.0;
                        additionalDiscount -= totalCost * 0.05;
                        totalCost = winterCost + discount + additionalDiscount;
                    }
                }
                else if (fishermanCount >= 12)
                {
                    double discount = 0.0;
                    discount -= winterCost * 0.25;
                    totalCost = winterCost + discount;
                    if (fishermanCount % 2 == 0)
                    {
                        double additionalDiscount = 0.0;
                        additionalDiscount -= totalCost * 0.05;
                        totalCost = winterCost + discount + additionalDiscount;
                    }
                }
            }

            double moneyLeft = budget - totalCost;

            if (budget > totalCost)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
            else if (budget == totalCost)       //Not mentioned what happens in that scenario in the description. Added by a hunch. Lucky guess!
            {
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):F2} leva.");
            }
        }
    }
}
