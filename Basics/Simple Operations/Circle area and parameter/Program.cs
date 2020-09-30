using System;

namespace Circle_area_and_parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double pi = 3.14159265358979323846;
            double perimeter = 2 * pi * radius;
            double area = pi * radius * radius;

            Console.WriteLine("{0:F2}", area);
            Console.WriteLine("{0:F2}", perimeter);
        }
    }
}
