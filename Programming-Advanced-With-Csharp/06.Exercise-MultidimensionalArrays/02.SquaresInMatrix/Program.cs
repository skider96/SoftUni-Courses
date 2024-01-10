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

            char firstCapture = Char.MinValue;
            char secondCapture = Char.MinValue;
            int counter = 0;
            int match = 0;

            Dictionary<int, List<int>> matches = new Dictionary<int, List<int>>();
            List<int> positions = new List<int>();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
               
                for (int col = 0; col < sizeCol - 1; col++)
                {
                    firstCapture = matrix[row][col];
                    secondCapture = matrix[row][col + 1];
                    if (firstCapture == secondCapture)
                    {
                        positions.Add(col);
                        positions.Add(col + 1);
                        if (!matches.ContainsKey(row))
                        {
                            matches.Add(row, positions);
                        }
                        //else
                        //{
                        //    matches[row].Add(col);
                        //    matches[row].Add(col + 1);
                        //}
                    }

                }


            }


        }
    }
}
