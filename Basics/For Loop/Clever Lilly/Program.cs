using System;

namespace Clever_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int money = 0;
            int toys = 0;
            int evenYears = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10 + (10 * evenYears);
                    money = money - 1;
                    evenYears++;
                }
                else
                {
                    toys++;
                }
            }
            int sumOfToys = toys * toyPrice;
            double finalSum = sumOfToys + money;
            double amount = Math.Abs(finalSum - washingMachinePrice);

            if (finalSum >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {amount:F2}");
            }
            else
            {
                Console.WriteLine($"No! {amount:F2}");
            }
        }
    }
}
