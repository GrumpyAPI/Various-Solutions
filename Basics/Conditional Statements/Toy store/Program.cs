using System;

namespace Toy_store
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double totalSumOfToys = (numberOfBears * 4.10) + (numberOfDolls * 3) + (numberOfMinions * 8.20) + (numberOfPuzzles * 2.60) + (numberOfTrucks * 2);
            int totalAmountOfToys = numberOfTrucks + numberOfPuzzles + numberOfMinions + numberOfDolls + numberOfBears;
            double rent = totalSumOfToys * 0.10;
            double finalSum = totalSumOfToys - rent - holidayPrice;

            if (totalAmountOfToys >= 50)
            {
                double discount = totalSumOfToys * 0.25;
                rent = (totalSumOfToys - discount) * 0.10;
                finalSum = totalSumOfToys - discount - rent - holidayPrice;
            }

            if (finalSum < 0)
            {
                Console.WriteLine($"Not enough money! {Math.Abs(finalSum):F2} lv needed.");
            }

            else if (finalSum > 0)
            {
                Console.WriteLine($"Yes! {finalSum:F2} lv left.");
            }

            else
            {
                Console.WriteLine($"Yes! {finalSum:F2} lv left.");
            }

        }
    }
}
