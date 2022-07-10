using System;
using Project_Library;

namespace Project_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = GenerateMatrix(3, 3);
            PrintMatrix(array);
            Console.WriteLine();
        }

        static int[,] GenerateMatrix(int x, int y)
        {
            Random random = new Random();
            int[,] matrix = new int[x, y];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, x * y);
                }
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

