using System;

namespace Tailoring_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTables = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double rectangleCloth = numberOfTables * (length + 2 * 0.30) * (width + 2 * 0.30);
            double squareCloth = numberOfTables * (length / 2) * (length / 2);

            double priceUsd = rectangleCloth * 7 + squareCloth * 9;
            double priceBgn = priceUsd * 1.85;

            Console.WriteLine($"{priceUsd:F2} USD");
            Console.WriteLine($"{priceBgn:F2} BGN");
        }
    }
}
