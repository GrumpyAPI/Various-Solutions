using System;

namespace Divide_without_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());

            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;

            for (int i = 0; i < amount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    counter2++;
                }
                if (number % 3 == 0)
                {
                    counter3++;
                }
                if (number % 4 == 0)
                {
                    counter4++;
                }
            }

            Console.WriteLine($"{counter2 / amount * 100:F2}%");
            Console.WriteLine($"{counter3 / amount * 100:F2}%");
            Console.WriteLine($"{counter4 / amount * 100:F2}%");
        }
    }
}
