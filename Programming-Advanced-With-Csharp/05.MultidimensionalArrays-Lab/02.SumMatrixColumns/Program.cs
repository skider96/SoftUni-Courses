using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Xml.Linq;

namespace _02.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
            .ToArray();
            int[,] matrix = new int[rowsCols[0], rowsCols[1]];

            int[] sumNumbersInCols = new int[rowsCols[1]];

            for (int row = 0; row < rowsCols[0]; row++)
            {
                int[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < rowsCols[1]; col++)
                {
                    matrix[row, col] = inputData[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int numbersInCols = 0;

                for (var row = 0; row < matrix.GetLength(0); row++)
                {
                    numbersInCols += matrix[row, col];
                }

                sumNumbersInCols[col] = numbersInCols;
            }

            foreach (var numbers in sumNumbersInCols)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
