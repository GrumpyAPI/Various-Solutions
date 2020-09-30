using System;
using System.Linq;
using System.Collections.Generic;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxValue = 1;

            for (int i = 0; i < maxValue; i++)      // For some reason it still does not accept multiple conditions. The syntax is accepted but the flow of the program disregards it and continues.
            {
                if (firstPlayer[i] > secondPlayer[i])
                {
                    firstPlayer.Add(firstPlayer[i]);
                    firstPlayer.Add(secondPlayer[i]);
                    firstPlayer.RemoveAt(i);
                    secondPlayer.RemoveAt(i);
                }
                else if (firstPlayer[i] < secondPlayer[i])
                {
                    secondPlayer.Add(secondPlayer[i]);
                    secondPlayer.Add(firstPlayer[i]);
                    secondPlayer.RemoveAt(i);
                    firstPlayer.RemoveAt(i);
                }
                else
                {
                    firstPlayer.RemoveAt(i);
                    secondPlayer.RemoveAt(i);
                }

                maxValue = Math.Min(firstPlayer.Count, secondPlayer.Count);

                i--;
            }

            if (firstPlayer.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
    }
}
