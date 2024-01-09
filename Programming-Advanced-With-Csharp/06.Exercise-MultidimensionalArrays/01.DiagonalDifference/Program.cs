using System.Data;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;

namespace _01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int rows = 0; rows < matrix.GetLength(1); rows++)
            {
                int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int cols = 0; cols < matrix.GetLength(0); cols++)
                {
                    matrix[rows, cols] = inputNumbers[cols];
                }
            }

            int sumFirstDiagonal = 0;
            int counter = 0;
            for (int rows = 0; rows < matrix.GetLength(1); rows++)
            {
                sumFirstDiagonal += matrix[rows, counter];

                counter++;
            }

            counter = size - 1;
            int sumSecondDiagonal = 0;
            for (int rows = 0; rows < matrix.GetLength(1); rows++)
            {
                sumSecondDiagonal += matrix[rows, counter];

                counter--;
            }

            int sum = Math.Abs(sumFirstDiagonal - sumSecondDiagonal);
            Console.WriteLine(sum);
        }
    }
}
