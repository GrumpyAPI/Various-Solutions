using System;
using System.Linq;

namespace Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberKey = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string sequence = string.Empty;

            while ((sequence = Console.ReadLine()) != "find")
            {
                int counter = 0;
                string newSequence = "";

                for (int i = 0; i < sequence.Length; i++)
                {
                    int num = sequence[i] - numberKey[counter];

                    newSequence += (char)num;

                    counter++;

                    if (counter >= numberKey.Length)
                    {
                        counter = 0;
                    }
                }

                string[] treasure = newSequence.Split('&', '<', '>');

                string treasureType = treasure[1];

                string treasureCoordinates = treasure[3];

                Console.WriteLine($"Found {treasureType} at {treasureCoordinates}");
            }
        }
    }
}
