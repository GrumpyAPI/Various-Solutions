using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());

            int rows = dimensions;
            int cols = dimensions;

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentLine = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }

            int currentRow = 0;
            int currentCol = 0;
            int sum = 0;

            while (true)
            {
                if (currentRow >= matrix.GetLength(0) || currentCol >= matrix.GetLength(1))
                {
                    break;
                }

                sum += matrix[currentRow, currentCol];

                currentRow++;
                currentCol++;
            }

            Console.WriteLine(sum);
        }
    }
}
