using System;
using System.Linq;
using System.Collections.Generic;

namespace Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double leftRacer = 0;
            double rightRacer = 0;

            int track = numbers.Count / 2;

            for (int i = 0; i < track; i++)
            {
                leftRacer += numbers[i];
                rightRacer += numbers[(numbers.Count - 1) - i];

                if (numbers[i] == 0)
                {
                    leftRacer *= 0.8;
                }
                if ((numbers.Count - 1) - i == 0)
                {
                    rightRacer *= 0.8;
                }
            }

            string winner = "";
            decimal totalTime = 0;

            if (leftRacer > rightRacer)
            {
                winner = "right";
                totalTime = (decimal)rightRacer;
            }
            else
            {
                winner = "left";
                totalTime = (decimal)leftRacer;
            }

            Console.WriteLine($"The winner is {winner} with total time: {totalTime}");
        }
    }
}
