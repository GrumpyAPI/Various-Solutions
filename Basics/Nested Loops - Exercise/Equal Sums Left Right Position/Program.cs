using System;

namespace Equal_Sums_Left_Right_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int number = start; number <= end; number++)
            {
                int leftSum = 0;
                int rightSum = 0;
                int currentNum = number;
                int middleDigit = 0;

                for (int i = 0; i < 5; i++)
                {
                    int currentDigit = currentNum % 10;
                    currentNum /= 10;

                    if (i == 2)
                    {
                        middleDigit = currentDigit;
                        continue;
                    }

                    if (i < 2)
                    {
                        leftSum += currentDigit;
                    }
                    else
                    {
                        rightSum += currentDigit;
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.Write($"{number} ");
                }
                else
                {
                    if (leftSum > rightSum)
                    {
                        rightSum += middleDigit;
                    }
                    else
                    {
                        leftSum += middleDigit;
                    }
                    if (leftSum == rightSum)
                    {
                        Console.Write($"{number} ");
                    }
                }
            }
        }
    }
}
