using System;

namespace Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int menCount = int.Parse(Console.ReadLine());
            int womenCount = int.Parse(Console.ReadLine());
            int maxTables = int.Parse(Console.ReadLine());

            byte counter = 0;

            for (int i = 1; i <= menCount; i++)
            {
                for (int j = 1; j <= womenCount; j++)
                {
                    if (counter == maxTables)
                    {
                        return;
                    }

                    counter++;

                    Console.Write($"({i} <-> {j}) ");
                }
            }

        }
    }
}
