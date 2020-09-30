using System;

namespace Christmas_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            int fantasyBooks = int.Parse(Console.ReadLine());
            int horrorBooks = int.Parse(Console.ReadLine());
            int romanticBooks = int.Parse(Console.ReadLine());

            double salesSum = (fantasyBooks * 14.90) + (horrorBooks * 9.80) + (romanticBooks * 4.30);

            double sumAfterTax = salesSum - (salesSum * 0.20);

            if (sumAfterTax > moneyNeeded)
            {
                double charitySum = sumAfterTax - moneyNeeded;
                int sellersBonus = (int)Math.Floor(charitySum * 0.10);

                double finalSum = moneyNeeded + (charitySum - sellersBonus);

                Console.WriteLine($"{finalSum:F2} leva donated.\nSellers will receive {sellersBonus} leva.");
            }
            else
            {
                double finalSum = moneyNeeded - sumAfterTax;

                Console.WriteLine($"{finalSum:F2} money needed.");
            }
        }
    }
}
