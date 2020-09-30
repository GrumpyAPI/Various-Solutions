using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            var colorClothesCount = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                string[] clothesColor = Console.ReadLine().Split(" -> ");

                string color = clothesColor[0];
                string[] clothes = clothesColor[1].Split(",");

                if (!colorClothesCount.ContainsKey(color))
                {
                    colorClothesCount[color] = new Dictionary<string, int>();
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string clothing = clothes[j];

                    if (!colorClothesCount[color].ContainsKey(clothing))
                    {
                        colorClothesCount[color][clothing] = 0;
                    }

                    colorClothesCount[color][clothing]++;
                }
            }

            string[] search = Console.ReadLine().Split();

            string colorToFind = search[0];
            string clothingToFind = search[1];

            // One line printing:
            //Console.WriteLine(string.Join(Environment.NewLine, colorClothesCount
            //    .Select(x => $"{x.Key} clothes:" + Environment.NewLine + string.Join(Environment.NewLine, x.Value
            //    .Select(v => v.Key == clothingToFind && x.Key == colorToFind ? $"* {v.Key} - {v.Value} (found!)" : $"* {v.Key} - {v.Value}")))));

            foreach (var kvp in colorClothesCount)
            {
                string color = kvp.Key;
                var clothesCount = kvp.Value;

                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var kvpClothesCount in clothesCount)
                {
                    string clothing = kvpClothesCount.Key;
                    int count = kvpClothesCount.Value;

                    if (color == colorToFind && clothing == clothingToFind)
                    {
                        Console.WriteLine($"* {clothing} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing} - {count}");
                    }
                }
            }
        }
    }
}
