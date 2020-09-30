using System;

namespace Time___15_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int plusTime = minutes + 15;

            int additionalTime = plusTime - 60;

            if (plusTime >= 60)
            {
                minutes = 00 + additionalTime;
                hours++;
            }
            else
            {
                minutes = minutes + 15;
            }

            if (hours >= 24)
            {
                hours = 00;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");

        }
    }
}
