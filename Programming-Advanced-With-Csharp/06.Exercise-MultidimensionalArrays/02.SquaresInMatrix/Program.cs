using System.Linq;

namespace _02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sizeRows = input[0];
            int sizeCol = input[1];

            char[][] matrix = new char[sizeRows][];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] inputChars = Console.ReadLine().Split().Select(char.Parse).ToArray();

                matrix[row] = new char[sizeCol];
                for (int col = 0; col < sizeCol; col++)
                {
                    matrix[row][col] = inputChars[col];
                }
            }

            int counter = 0;
            char topLeft = Char.MinValue; char topRight = Char.MinValue; char bottomLeft = Char.MinValue; char bottomRight = Char.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < sizeCol - 1; col++)
                {
                    topLeft = matrix[row][col];
                    topRight = matrix[row][col + 1];
                    bottomLeft = matrix[row + 1][col];
                    bottomRight = matrix[row + 1][col + 1];

                    if (topLeft == topRight && topLeft == bottomLeft && topLeft == bottomRight)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
//Solved but with 80% at Judge...