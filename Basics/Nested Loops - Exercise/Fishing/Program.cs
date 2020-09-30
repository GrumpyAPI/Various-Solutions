using System;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int fishQuota = int.Parse(Console.ReadLine());

            string fishName;
            bool profit = false;
            byte counter = 0;
            double totalSum = 0;

            while ((fishName = Console.ReadLine()) != "Stop")
            {
                double fishWeight = double.Parse(Console.ReadLine());
                counter++;
                int totalNameSum = 0;

                for (int i = 0; i < fishName.Length; i++)
                {
                    byte letterSum = (byte)fishName[i];
                    totalNameSum += letterSum;
                }

                double money = (totalNameSum / fishWeight);

                if (counter % 3 == 0)
                {
                    totalSum += money;
                }
                else
                {
                    totalSum -= money;
                }

                if (counter == fishQuota)
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    break;
                }
            }

            if (totalSum > 0)
            {
                profit = true;
            }

            if (profit)
            {
                Console.WriteLine($"Lyubo's profit from {counter} fishes is {totalSum:F2} leva.");
            }
            else
            {
                Console.WriteLine($"Lyubo lost {Math.Abs(totalSum):F2} leva today.");
            }
        }
    }
}
