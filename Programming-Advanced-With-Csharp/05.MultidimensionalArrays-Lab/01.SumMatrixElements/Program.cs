namespace _01.SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[rowsCols[0], rowsCols[1]];
            int sumAllElements = 0;
            for (int row = 0; row < rowsCols[0]; row++)
            {

                int[] inputData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < rowsCols[1]; col++)
                {
                    matrix[row, col] = inputData[col];
                    sumAllElements += inputData[col];
                }
            }

            Console.WriteLine($"{rowsCols[0]}\n{rowsCols[1]}\n{sumAllElements}");
        }
    }
}
