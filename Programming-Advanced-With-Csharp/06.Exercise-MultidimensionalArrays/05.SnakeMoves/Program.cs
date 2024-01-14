namespace _05.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sizeRows = input[0];
            int sizeCol = input[1];

            char[][] matrix = new char[sizeRows][];


            string stringInput = Console.ReadLine();
            int letterCounter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row] = new char[sizeCol];
                
                if (row % 2 == 1)
                {
                    for (int col = sizeCol - 1; col >= 0; col--)
                    {
                        letterCounter = ResetCounter(letterCounter, stringInput);
                        matrix[row][col] = stringInput[letterCounter];

                        letterCounter++;
                    }
                }
                else
                {
                    for (int col = 0; col < sizeCol; col++)
                    {
                        letterCounter = ResetCounter(letterCounter, stringInput);
                        matrix[row][col] = stringInput[letterCounter];

                        letterCounter++;
                    }
                }
            }

            PrintMatrix(sizeRows, sizeCol, matrix);
        }

        public static int ResetCounter(int letterCounter, string? stringInput)
        {
            if (letterCounter == stringInput.Length)
            {
                letterCounter = 0;
            }

            return letterCounter;
        }

        public static void PrintMatrix(int sizeRows, int sizeCol, char[][] matrix)
        {
            for (int row = 0; row < sizeRows; row++)
            {
                for (int col = 0; col < sizeCol; col++)
                {
                    Console.Write($"{matrix[row][col]}");
                }

                Console.WriteLine();
            }
        }
    }
}
