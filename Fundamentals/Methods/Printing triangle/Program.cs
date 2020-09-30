using System;

namespace Printing_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                PrintLine(row);
            }

            for (int row = (n - 1); row >= 1; row--)
            {
                PrintLine(row);
            }
        }

        static void PrintLine(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }

            Console.WriteLine();
        }
    }
}
