using System;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            ClosestToZeroCoordinates(x1, y1, x2, y2);
        }

        static void ClosestToZeroCoordinates(int a, int b, int c, int d)
        {
            int result = Math.Abs(a) + Math.Abs(b);
            int result2 = Math.Abs(c) + Math.Abs(d);

            if (result < result2)
            {
                Console.WriteLine($"({a}, {b})");
            }
            else if (result > result2)
            {
                Console.WriteLine($"({c}, {d})");
            }
            else
            {
                Console.WriteLine($"({a}, {b})");
            }
        }
    }
}
