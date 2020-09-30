using System;

namespace Football_Kit
{
    class Program
    {
        static void Main(string[] args)
        {
            double shirtPrice = double.Parse(Console.ReadLine());
            double moneyNeeded = double.Parse(Console.ReadLine());

            double shortsPrice = shirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.20;
            double shoesPrice = (shirtPrice + shortsPrice) * 2;

            double totalSum = shirtPrice + shortsPrice + socksPrice + shoesPrice;
            double sumAfterDiscount = totalSum - (totalSum * 0.15);

            if (sumAfterDiscount >= moneyNeeded)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {sumAfterDiscount:F2} lv.");
            }
            else
            {
                double moneyToBall = Math.Abs(sumAfterDiscount - moneyNeeded);
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {moneyToBall:F2} lv. more.");
            }

        }
    }
}
