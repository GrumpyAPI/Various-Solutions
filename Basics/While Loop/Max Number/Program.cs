using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int highestNumber = int.MinValue;
            int i = 1;

            while (i <= numberCount)
            {
                int number = int.Parse(Console.ReadLine());
                if (highestNumber <= number)
                {
                    highestNumber = number;
                }
                i++;
            }

            Console.WriteLine(highestNumber);
        }
    }
}
