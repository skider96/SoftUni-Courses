using System.Reflection.Metadata.Ecma335;

namespace _04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sizeRows = input[0];
            int sizeCol = input[1];

            int[][] matrix = new int[sizeRows][];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                matrix[row] = new int[sizeCol];
                for (int col = 0; col < sizeCol; col++)
                {
                    matrix[row][col] = inputNumbers[col];
                }
            }

            string command = Console.ReadLine();
            while ((command = Console.ReadLine()) != "END")
            {
                string[] arguments = command.Split();

                if (arguments.Length == 5 && arguments[0] == "swap")
                {
                    var action = arguments[0];
                    int row1 = int.Parse(arguments[1]);
                    int col1 = int.Parse(arguments[2]);
                    int row2 = int.Parse(arguments[3]);
                    int col2 = int.Parse(arguments[4]);


                    (matrix[row2][col2], matrix[row1][col1]) = (matrix[row1][col1], matrix[row2][col2]);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }




            }


            //TO BE SOLVED
        }
    }
}
