using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = length * width * height;
            double totalLiters = volume * 0.001;
            double percentage = percent * 0.01;
            double liters = totalLiters * (1 - percentage);

            Console.WriteLine("{0:F3}", liters);

        }
    }
}
