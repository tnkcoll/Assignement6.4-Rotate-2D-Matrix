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
