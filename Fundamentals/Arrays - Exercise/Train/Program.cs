using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonCount = int.Parse(Console.ReadLine());

            int[] train = new int[wagonCount];
            int sum = 0;

            for (int i = 0; i < wagonCount; i++)
            {
                int peopleInWagon = int.Parse(Console.ReadLine());

                train[i] = peopleInWagon;
                sum += peopleInWagon;
            }

            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(sum);
        }
    }
}
