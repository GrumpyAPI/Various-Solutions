using System;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var rhombusDrawer = new RhombusAsStringDrawer();
            var rhombusAsString = rhombusDrawer.Draw(n);

            Console.WriteLine(rhombusAsString);
        }
    }
}
