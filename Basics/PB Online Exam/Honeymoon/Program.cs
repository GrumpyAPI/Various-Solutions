using System;

namespace Honeymoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string city = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            int nightSum = 0;
            int ticketSum = 0;

            if (city == "Cairo")
            {
                nightSum = nights * (250 * 2);
                ticketSum = 600;
            }
            else if (city == "Paris")
            {
                nightSum = nights * (150 * 2);
                ticketSum = 350;
            }
            else if(city == "Lima")
            {
                nightSum = nights * (400 * 2);
                ticketSum = 850;
            }
            else if(city == "New York")
            {
                nightSum = nights * (300 * 2);
                ticketSum = 650;
            }
            else if(city == "Tokyo")
            {
                nightSum = nights * (350 * 2);
                ticketSum = 700;
            }

            double discount = 0;

            if (nights >= 1 && nights <= 4)
            {
                if (city == "Cairo" || city == "New York")
                {
                    discount = 0.03;
                }
            }
            else if(nights >= 5 && nights <= 9)
            {
                if (city == "Cairo" || city == "New York")
                {
                    discount = 0.05;
                }
                else if (city == "Paris")
                {
                    discount = 0.07;
                }
            }
            else if (nights >= 10 && nights <= 24)
            {
                if (city == "Cairo")
                {
                    discount = 0.10;
                }
                else if (city == "Paris" || city == "New York" || city == "Tokyo")
                {
                    discount = 0.12;
                }
            }
            else if (nights >= 25 && nights <= 49)
            {
                if (city == "Tokyo" || city == "Cairo")
                {
                    discount = 0.17;
                }
                else if (city == "New York" || city == "Lima")
                {
                    discount = 0.19;
                }
                else if (city == "Paris")
                {
                    discount = 0.22;
                }
            }
            else if (nights >= 50)
            {
                discount = 0.30;
            }

            double totalSum = nightSum + ticketSum;
            double totalSumAfterDiscount = totalSum - (totalSum * discount);
            double finalSum = Math.Abs(budget - totalSumAfterDiscount);

            if (totalSumAfterDiscount <= budget)
            {
                Console.WriteLine($"Yes! You have {finalSum:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {finalSum:F2} leva.");
            }

        }
    }
}
