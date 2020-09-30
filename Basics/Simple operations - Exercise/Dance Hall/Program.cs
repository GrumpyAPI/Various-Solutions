using System;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobe = double.Parse(Console.ReadLine());

            double roomArea = (length * 100) * (width * 100);
            double wardrobeArea = (wardrobe * 100) * (wardrobe * 100);
            double benchArea = roomArea / 10;
            double availableSpace = roomArea - wardrobeArea - benchArea;
            double dancers = Math.Floor(availableSpace / 7040);

            Console.WriteLine(dancers);
        }
    }
}
