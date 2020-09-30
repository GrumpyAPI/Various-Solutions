using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int rows = size;
            int cols = size;

            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = new int[cols];

                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = currentRow[col];
                }
            }

            int[] coordinatesLine = Console.ReadLine().Split(',', ' ').Select(int.Parse).ToArray();

            Queue<int> bombCoords = new Queue<int>(coordinatesLine);

            while (bombCoords.Any())
            {
                int bombRow = bombCoords.Dequeue();
                int bombCol = bombCoords.Dequeue();

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (row == bombRow && col == bombCol)
                        {
                            int bombValue = matrix[row][col];

                            if (bombValue > 0)
                            {
                                matrix[row][col] = 0;
                                matrix = Bombard(matrix, bombRow, bombCol, bombValue);
                            }
                            else
                            {
                                matrix[row][col] = 0;
                            }
                        }
                    }
                }
            }

            int activeCellsCount = 0;
            int activeCellsSum = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row][col] > 0)
                    {
                        activeCellsCount++;
                        activeCellsSum += matrix[row][col];
                    }
                }
            }

            Console.WriteLine($"Active cells: {activeCellsCount}");
            Console.WriteLine($"Sum: {activeCellsSum}");

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static int[][] Bombard(int[][] matrix, int row, int col, int bombValue)
        {
            if (row - 1 >= 0 && col - 1 >= 0 && matrix[row - 1][col - 1] > 0)
            {
                matrix[row - 1][col - 1] -= bombValue;
            }
            if (row - 1 >= 0 && matrix[row - 1][col] > 0)
            {
                matrix[row - 1][col] -= bombValue;
            }
            if (row - 1 >= 0 && col + 1 < matrix[col].Length && matrix[row - 1][col + 1] > 0)
            {
                matrix[row - 1][col + 1] -= bombValue;
            }
            if (col + 1 < matrix[col].Length && matrix[row][col + 1] > 0)
            {
                matrix[row][col + 1] -= bombValue;
            }
            if (row + 1 < matrix[row].Length && col + 1 < matrix[col].Length && matrix[row + 1][col + 1] > 0)
            {
                matrix[row + 1][col + 1] -= bombValue;
            }
            if (row + 1 < matrix[row].Length && matrix[row + 1][col] > 0)
            {
                matrix[row + 1][col] -= bombValue;
            }
            if (row + 1 < matrix[row].Length && col - 1 >= 0 && matrix[row + 1][col - 1] > 0)
            {
                matrix[row + 1][col - 1] -= bombValue;
            }
            if (col - 1 >= 0 && matrix[row][col - 1] > 0)
            {
                matrix[row][col - 1] -= bombValue;
            }

            return matrix;
        }
    }
}
