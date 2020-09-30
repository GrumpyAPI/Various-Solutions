using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());

            int rows = dimensions;
            int cols = dimensions;

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int startIndexFirst = 0;
            int startIndexSecond = cols - 1;
            int firstSum = 0;
            int secondSum = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == startIndexFirst && col == startIndexFirst)
                    {
                        startIndexFirst++;
                        firstSum += matrix[row, col];
                    }

                    if (col == startIndexSecond)
                    {
                        startIndexSecond--;
                        secondSum += matrix[row, col];
                    }
                }
            }

            int result = Math.Abs(firstSum - secondSum);

            Console.WriteLine(result);
        }
    }
}
