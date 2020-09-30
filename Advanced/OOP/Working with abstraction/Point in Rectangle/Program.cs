using System;

namespace Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(3, 1, 1, 3);

            Console.WriteLine(rectangle.Contains(new Point(3, 1)));
        }
    }
}
