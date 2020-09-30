using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            for (int i = numberOne; i <= numberTwo; i++)
            {
                string currentNum = Convert.ToString(i);

                int evenSum = 0;
                int oddSum = 0;

                for (int j = 0; j < currentNum.Length; j++)
                {
                    char currentNumConverted = currentNum[j];

                    if (j % 2 == 0)
                    {
                        evenSum += int.Parse(currentNumConverted.ToString());
                    }
                    else
                    {
                        oddSum += int.Parse(currentNumConverted.ToString());
                    }
                }

                if (evenSum == oddSum)
                {
                    Console.Write(currentNum + " ");
                }
            }

        }
    }
}


// Softuni solution:

//using System;

//namespace Equal_Sums_Even_Odd_Position
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int start = int.Parse(Console.ReadLine());
//            int end = int.Parse(Console.ReadLine());

//            for (int number = start; number <= end; number++)
//            {
//                int evenSum = 0;
//                int oddSum = 0;
//                int currentNum = number;

//                for (int i = 0; i < 6; i++)
//                {
//                    int currentDigit = currentNum % 10;
//                    currentNum /= 10;

//                    if (i % 2 == 0)
//                    {
//                        evenSum += currentDigit;
//                    }
//                    else
//                    {
//                        oddSum += currentDigit;
//                    }
//                }

//                if (evenSum == oddSum)
//                {
//                    Console.Write($"{number} ");
//                }
//            }
//        }
//    }
//}