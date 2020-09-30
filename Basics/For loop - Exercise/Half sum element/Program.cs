using System;

namespace Half_sum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxValue = int.MinValue;

            for (int i = 0; i < amount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;

                if (number > maxValue)
                {
                    maxValue = number;
                }
            }

            int sumWithoutMaxValue = sum - maxValue;

            if (maxValue == sumWithoutMaxValue)
            {
                Console.WriteLine("Yes\nSum = " + maxValue);
            }
            else
            {
                sum = Math.Abs(maxValue - sumWithoutMaxValue);
                Console.WriteLine("No\nDiff = " + sum);
            }
        }
    }
}
