using System;

namespace Cookie_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBatches = int.Parse(Console.ReadLine());
            string ingredient;
            int count = 0;

            int flour = 0;
            int eggs = 0;
            int sugar = 0;

            for (int i = 0; i < numberOfBatches; i++)
            {
                count++;
                while ((ingredient = Console.ReadLine()) != "Bake!")
                {
                    if (ingredient == "flour")
                    {
                        flour++;
                    }
                    if (ingredient == "eggs")
                    {
                        eggs++;
                    }
                    if (ingredient == "sugar")
                    {
                        sugar++;
                    }
                }
                if (flour == 0 || eggs == 0 || sugar == 0)
                {
                    Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    count--;
                    i--;
                }
                else
                {
                    Console.WriteLine($"Baking batch number {count}...");
                    flour = 0; eggs = 0; sugar = 0;
                }
            }
        }
    }
}
