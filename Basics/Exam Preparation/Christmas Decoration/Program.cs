using System;

namespace Christmas_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());

            string itemName = "";

            while ((itemName = Console.ReadLine()) != "Stop")
            {
                int itemSum = 0;

                for (int i = 0; i < itemName.Length; i++)
                {
                    int currentCharacter = itemName[i];
                    itemSum += currentCharacter;
                }

                if (itemSum > budget)
                {
                    Console.WriteLine("Not enough money!");
                    break;
                }
                else
                {
                    budget -= itemSum;
                    Console.WriteLine("Item successfully purchased!");
                }
            }

            if (itemName == "Stop")
            {
                Console.WriteLine($"Money left: {budget}");
            }
        }
    }
}
