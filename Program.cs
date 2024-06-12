using System.ComponentModel.DataAnnotations;

namespace Assignement6._4_Rotate_2D_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ints = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int length = ints.GetLength(0);

            Console.WriteLine("Original Matrix:");
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write($"| {ints[i, j]} ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Rotated Matrix:");
            for (int j = 0; j < length; j++)
            {
                for (int i = length - 1; i >= 0; i--)
                {
                    Console.Write($"| {ints[i, j]} ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
