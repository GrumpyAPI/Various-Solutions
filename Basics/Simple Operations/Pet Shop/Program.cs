using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());

            double dogFood = dogs * 2.50;
            int neigborFood = otherAnimals * 4;

            double finalSum = dogFood + neigborFood;

            Console.Write("{0:F2}", finalSum);
            Console.WriteLine(" lv.");

        }
    }
}
