using System;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            double centimeters = inch * 2.54;

            Console.WriteLine("{0:F2}",centimeters);
        }
    }
}
