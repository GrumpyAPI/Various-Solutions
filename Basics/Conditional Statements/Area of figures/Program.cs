using System;

namespace Area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double squareSideLength = double.Parse(Console.ReadLine());
                double result = squareSideLength * squareSideLength;
                Console.WriteLine($"{result:F3}");
            }

            else if (figure == "rectangle")
            {
                double rectabgleSideLength = double.Parse(Console.ReadLine());
                double rectabgleSecondSideLength = double.Parse(Console.ReadLine());
                double result = rectabgleSideLength * rectabgleSecondSideLength;
                Console.WriteLine($"{result:F3}");
            }

            else if (figure == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());
                double result = Math.PI * Math.Pow(circleRadius, 2);
                Console.WriteLine($"{result:F3}");
            }

            else if (figure == "triangle")
            {
                double baseSideLength = double.Parse(Console.ReadLine());
                double heightLength = double.Parse(Console.ReadLine());
                double result = (baseSideLength * heightLength) / 2;
                Console.WriteLine($"{result:F3}");
            }
            
        }
    }
}
