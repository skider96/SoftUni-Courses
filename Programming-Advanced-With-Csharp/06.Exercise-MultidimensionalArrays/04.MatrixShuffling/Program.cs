

namespace _04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sizeRows = input[0];
            int sizeCol = input[1];

            string[][] matrix = new string[sizeRows][];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] inputNumbers = Console.ReadLine().Split();
                
                matrix[row] = new string[sizeCol];
                for (int col = 0; col < sizeCol; col++)
                {
                    matrix[row][col] = inputNumbers[col];
                }
            }

            string command;
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

                    if (row1 < 0 || row1 > sizeRows || row2 < 0 || row2 > sizeRows || col1 < 0 || col1 > sizeCol || col2 < 0 || col2 > sizeCol)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    (matrix[row2][col2], matrix[row1][col1]) = (matrix[row1][col1], matrix[row2][col2]);

                    for (int row = 0; row < sizeRows; row++)
                    {
                        for (int col = 0; col < sizeCol; col++)
                        {
                            Console.Write($"{matrix[row][col]} ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
