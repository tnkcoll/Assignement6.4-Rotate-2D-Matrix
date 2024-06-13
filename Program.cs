using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Assignement6._4_Rotate_2D_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ints = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

            int length = ints.GetLength(0);

            PrintMatrix("Original Matrix:", ints);
            //for (int i = 0; i < length; i++)
            //{
            //    for (int j = 0; j < length; j++)
            //    {
            //        Console.Write($"| {ints[i, j]} ");
            //    }
            //    Console.Write("|");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            for (int i = 0; i < length / 2; i++)
            {
                for (int j = i; j < length - i - 1; j++)
                {
                    int temp = ints[i, j];
                    ints[i, j] = ints[length - 1 - j, i];
                    ints[length - 1 - j, i] = ints[length - 1 - i, length - 1 - j];
                    ints[length - 1 - i, length - 1 - j] = ints[j, length - 1 - i];
                    ints[j, length - 1 - i] = temp;
                }
            }

            //for (int j = 0; j < length; j++)
            //{
            //    for (int i = length - 1; i >= 0; i--)
            //    {
            //        int temp = ints[j, length - i - 1];
            //        ints[j, length - i - 1] = ints[i, j];
            //        ints[length - i - 1, length - j - 1] = temp;
            //        //Console.Write($"| {ints[i, j]} ");
            //    }
            //}
            PrintMatrix("Rotated Matrix:", ints);
        }

        static void PrintMatrix(string s, int[,] matrix)
        {
            Console.WriteLine(s);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write($"| {matrix[i, j]} ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
