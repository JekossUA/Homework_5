using System;

namespace Project_Library
{
    public class ArrayMatrixHelper
    {
            //Find the number of array elements that are greater than all their neighbors at the same time
            //Flip an array about its main diagonal

        public static int GetMinElementOfArrayMatrix(int[,] array )
        {
            (int minRow, int minCol) = GetMinIndexMatrix(array);
            return array[minRow, minCol];
        }

        public static int GetMaxElementOfArrayMatrix(int[,] array)
        {
            (int maxRow, int maxCol) = GetMaxIndexMatrix(array);
            return array[maxRow, maxCol];
        }

        public static (int minRow, int minCol) GetMinIndexMatrix(int [,] array)
        {
            if (array == null)
            {
                throw new NullReferenceException();
            }

            int minRow = 0;
            int minCol = 0;
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        minRow = i;
                        minCol = j;
                    }
                }
            }

            return (minRow, minCol);
        }

        public static (int maxRow, int maxCol) GetMaxIndexMatrix(int[,] array)
        {
            if (array == null)
            {
                throw new NullReferenceException();
            }

            int maxRow = 0;
            int maxCol = 0;
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            return (maxRow, maxCol);
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}

