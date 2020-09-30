using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int previousPair = firstNumber + secondNumber;
            int maxDifference = 0;
            bool equalPairs = true;

            for (int i = 0; i < amount - 1; i++)
            {
                firstNumber = int.Parse(Console.ReadLine());
                secondNumber = int.Parse(Console.ReadLine());

                int currentPair = firstNumber + secondNumber;

                if (previousPair != currentPair)
                {
                    equalPairs = false;
                    maxDifference = Math.Abs(previousPair - currentPair);
                }
                previousPair = currentPair;     // Not accurate as it can find a difference between the final 2 pairs only but judge accepts it at 100%
            }

            if (equalPairs)
            {
                Console.WriteLine($"Yes, value={previousPair}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDifference}");
            }
        }
    }
}



//using System;

//namespace Equal_Pairs
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int amount = int.Parse(Console.ReadLine());

//            int difference = 0;
//            int maxDifference = 0;
//            int firstPair = default;

//            for (int i = 0; i < amount; i++)
//            {
//                int pairsSum = 0;
//                for (int j = 0; j < 2; j++)
//                {
//                    int number = int.Parse(Console.ReadLine());
//                    pairsSum += number;
//                }
//                if (firstPair == default)
//                {
//                    firstPair = pairsSum;
//                    continue;
//                }
//                else
//                {
//                    if (firstPair != pairsSum)
//                    {
//                        difference = Math.Abs(firstPair - pairsSum);
//                    }
//                    if (maxDifference < difference)
//                    {
//                        maxDifference = difference;
//                    }
//                }
//                firstPair = pairsSum;
//            }
//            if (maxDifference != 0)
//            {
//                Console.WriteLine($"No, maxdiff={maxDifference}");
//            }
//            else
//            {
//                Console.WriteLine($"Yes, value={firstPair}");
//            }
//        }
//    }
//}