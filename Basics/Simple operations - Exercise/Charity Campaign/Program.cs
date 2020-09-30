using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfBakers = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());

            int priceOfCakes = numberOfCakes * 45;
            double priceOfWaffles = numberOfWaffles * 5.80;
            double priceOfPancakes = numberOfPancakes * 3.20;
            double pricePerDay = (priceOfCakes + priceOfPancakes + priceOfWaffles) * numberOfBakers;
            double totalPrice = pricePerDay * numberOfDays;
            double finalPrice = totalPrice - (totalPrice / 8);

            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}
