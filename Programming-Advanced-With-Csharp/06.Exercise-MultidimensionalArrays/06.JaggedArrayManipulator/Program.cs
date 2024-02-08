namespace _06.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {

            }

            char[][] matrix = new char[sizeRows][];
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int colSize = input.Length;

                matrix[row] = new char[colSize];

                for (int col = 0; col < colSize; col++)
                {
                    matrix[row][col] = matrix[input[col]];
                }
            }

            int previousLength = 0;
            int currentLength = 0;
            for (int row = 0; row < n; row++)
            {
                currentLength = matrix[row][col];

                for (int col = 0; col < f; col++)
                {
                    currentLength = matrix[row][col];

                    if (matrix[row].Length - 1 >= 0)
                        previousLength = matrix[row] - 1;
                }
            }

            //TO BE SOLVED
        }
    }
}
