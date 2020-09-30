using System;

namespace Christmas_sweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double baklavaPrice = double.Parse(Console.ReadLine());
            double muffinPrice = double.Parse(Console.ReadLine());
            double shtolenKg = double.Parse(Console.ReadLine());
            double candyKg = double.Parse(Console.ReadLine());
            int biscuitsKg = int.Parse(Console.ReadLine());

            double shtolenPrice = shtolenKg * (baklavaPrice + (baklavaPrice * 0.60));
            double candyPrice = candyKg * (muffinPrice + (muffinPrice * 0.80));
            double biscuitsPrice = biscuitsKg * 7.50;

            double totalPrice = shtolenPrice + candyPrice + biscuitsPrice;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
