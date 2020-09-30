using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());

            double counterUnder200 = 0;     //Obviously if it is "int" it does not calculate the % right as the division in the first example equals to 0 as opposed to the actual number (0.66).
            double counter200To399 = 0;
            double counter400To599 = 0;
            double counter600To799 = 0;
            double counterOver800 = 0;

            for (int i = 0; i < amount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    counterUnder200++;
                }
                if (number >= 200 && number < 400)
                {
                    counter200To399++;
                }
                if (number >= 400 && number < 600)
                {
                    counter400To599++;
                }
                if (number >= 600 && number < 800)
                {
                    counter600To799++;
                }
                if (number >= 800)
                {
                    counterOver800++;
                }
            }

            Console.WriteLine($"{counterUnder200 / amount * 100:F2}%");
            Console.WriteLine($"{counter200To399 / amount * 100:F2}%");
            Console.WriteLine($"{counter400To599 / amount * 100:F2}%");
            Console.WriteLine($"{counter600To799 / amount * 100:F2}%");
            Console.WriteLine($"{counterOver800 / amount * 100:F2}%");
        }
    }
}
