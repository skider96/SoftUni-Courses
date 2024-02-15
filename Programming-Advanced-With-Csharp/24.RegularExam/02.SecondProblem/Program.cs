namespace _02.SecondProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {




        }

        //ADDED BEFORE
        public static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
