using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;

namespace _04.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] input = Console.ReadLine().ToCharArray(0, size);

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
