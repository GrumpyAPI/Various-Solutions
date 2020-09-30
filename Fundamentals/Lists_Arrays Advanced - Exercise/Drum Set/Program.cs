using System;
using System.Linq;
using System.Collections.Generic;

namespace Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> drumSet = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> drumSetDefault = new List<int>(drumSet);

            string input = Console.ReadLine();

            while (input != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= hitPower;

                    if (drumSet[i] <= 0)
                    {
                        if (savings < drumSetDefault[i] * 3)
                        {
                            drumSet.RemoveAt(i);
                            drumSetDefault.RemoveAt(i);
                            i--;
                        }
                        else
                        {
                            drumSet[i] = drumSetDefault[i];
                            savings -= drumSetDefault[i] * 3;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
