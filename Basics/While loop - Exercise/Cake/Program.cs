using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeSize = cakeLength * cakeWidth;

            int pieces = 0;
            int neededPieces = 0;
            string command;

            while ((command = Console.ReadLine()) != "STOP")
            {
                pieces += int.Parse(command);

                neededPieces = Math.Abs(cakeSize - pieces);
                
                if (cakeSize < pieces)
                {
                    Console.WriteLine($"No more cake left! You need {neededPieces} pieces more.");
                    return;
                }
            }
            Console.WriteLine($"{neededPieces} pieces are left.");
        }
    }
}
