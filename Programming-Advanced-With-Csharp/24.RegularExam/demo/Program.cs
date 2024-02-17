namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static IEnumerable<int> InputFromConsole()
        {
            return Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
        }
        //PRINTING EVERY ELEMENT OF THE MATRIX. EVERY ROW ON A SEPARATED LINE.
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
        //IS THE OBJECT IN THE BOUNDARIES OF THE MATRIX
        public static bool IsInMatrix(string[,] matrix, int row, int col)
        {
            if ((matrix.GetLength(0) > row && matrix.GetLength(1) > col) && (row >= 0 && col >= 0))
            {
                return true;
            }
            return false;
        }

        //FASTER
        public enum Moves
        {
            up,
            down,
            left,
            right
        }
    }
}
