using System;

namespace Point_in_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(0, 0, 2);

            Console.WriteLine(circle.Contains(new Point(0, 0)));
            Console.WriteLine(circle.Contains(new Point(0, 2)));
            Console.WriteLine(circle.Contains(new Point(2, 0)));
            Console.WriteLine(circle.Contains(new Point(3, 0)));
        }
    }
}
