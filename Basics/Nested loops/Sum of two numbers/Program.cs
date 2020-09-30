using System;

namespace Sum_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startOfInterval = int.Parse(Console.ReadLine());
            int endOfInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = startOfInterval; i <= endOfInterval ; i++)
            {
                for (int j = startOfInterval; j <= endOfInterval; j++)
                {
                    int matchingNumber = i + j;
                    counter++;

                    if (matchingNumber == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {matchingNumber})");
                        return;
                    }
                }
                if (startOfInterval == endOfInterval)
                {
                    break;
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
