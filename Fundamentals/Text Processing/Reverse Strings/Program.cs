using System;
using System.Diagnostics;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            while (line != "end")
            {
                var stopWatch = Stopwatch.StartNew();   // Start a stopwatch to check how long it takes to go through the conversion process.
                string reversed = "";

                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reversed += line[i];
                }

                Console.WriteLine($"{line} = {reversed}");

                Console.WriteLine($"Time for conversion: {stopWatch.Elapsed}");   // Displays the elapsed time.

                line = Console.ReadLine();
            }
        }
    }
}
