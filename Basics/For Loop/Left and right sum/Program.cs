using System;

namespace Left_and_right_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());

            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < amount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSum += number;
            }
            for (int i = 0; i < amount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSum += number;
            }

            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes, sum = {firstSum}");
            }
            else
            {
                int difference = Math.Abs(firstSum - secondSum);
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
