namespace _02.SecondProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());

            string[,] matrix = new string[squareMatrixSize, squareMatrixSize];

            int jetfighterRow = 0;
            int jetfighterCol = 0;

            int enemiesCount = 0;
            int jetfighterArmor = 300;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col].ToString();
                    if (matrix[row, col] == "J")
                    {
                        jetfighterRow = row;
                        jetfighterCol = col;
                    }
                    else if (matrix[row, col] == "E")
                    {
                        enemiesCount++;
                    }
                }
            }

            while (jetfighterArmor != 0 || enemiesCount == 0)
            {
                var command = Console.ReadLine();
                IsItStartingPosition(matrix, jetfighterRow, jetfighterCol);
                if (command == "up")
                {
                    if (matrix[jetfighterRow - 1, jetfighterCol] == "-")
                    {
                        jetfighterRow--;
                    }
                    else if (matrix[jetfighterRow - 1, jetfighterCol] == "E")
                    {
                        matrix[jetfighterRow - 1, jetfighterCol] = "-";
                        enemiesCount--;
                        jetfighterRow--;

                        NoEnemiesLeft(enemiesCount, matrix, jetfighterRow, jetfighterCol);

                        jetfighterArmor -= 100;
                        NoMoreArmor(jetfighterArmor, jetfighterRow, jetfighterCol, matrix);
                    }
                    else if (matrix[jetfighterRow - 1, jetfighterCol] == "R")
                    {
                        jetfighterArmor = 300;
                        matrix[jetfighterRow - 1, jetfighterCol] = "-";

                        jetfighterRow--;
                    }
                }
                else if (command == "down")
                {
                    if (matrix[jetfighterRow + 1, jetfighterCol] == "-")
                    {
                        jetfighterRow++;
                    }
                    else if (matrix[jetfighterRow + 1, jetfighterCol] == "E")
                    {
                        matrix[jetfighterRow + 1, jetfighterCol] = "-";
                        enemiesCount--;
                        jetfighterRow++;

                        NoEnemiesLeft(enemiesCount, matrix, jetfighterRow, jetfighterCol);

                        jetfighterArmor -= 100;
                        NoMoreArmor(jetfighterArmor, jetfighterRow, jetfighterCol, matrix);
                    }
                    else if (matrix[jetfighterRow + 1, jetfighterCol] == "R")
                    {
                        jetfighterArmor = 300;
                        matrix[jetfighterRow + 1, jetfighterCol] = "-";

                        jetfighterRow++;
                    }
                }
                else if (command == "left")
                {
                    if (matrix[jetfighterRow, jetfighterCol - 1] == "-")
                    {
                        jetfighterCol--;
                    }
                    else if (matrix[jetfighterRow, jetfighterCol - 1] == "E")
                    {
                        matrix[jetfighterRow, jetfighterCol - 1] = "-";
                        enemiesCount--;
                        jetfighterCol--;

                        NoEnemiesLeft(enemiesCount, matrix, jetfighterRow, jetfighterCol);

                        jetfighterArmor -= 100;
                        NoMoreArmor(jetfighterArmor, jetfighterRow, jetfighterCol, matrix);
                    }
                    else if (matrix[jetfighterRow, jetfighterCol - 1] == "R")
                    {
                        jetfighterArmor = 300;
                        matrix[jetfighterRow, jetfighterCol - 1] = "-";

                        jetfighterCol--;
                    }
                }
                else if (command == "right")
                {
                    if (matrix[jetfighterRow, jetfighterCol + 1] == "-")
                    {
                        jetfighterCol++;
                    }
                    else if (matrix[jetfighterRow, jetfighterCol + 1] == "E")
                    {
                        matrix[jetfighterRow, jetfighterCol + 1] = "-";
                        enemiesCount--;
                        jetfighterCol++;

                        NoEnemiesLeft(enemiesCount, matrix, jetfighterRow, jetfighterCol);

                        jetfighterArmor -= 100;
                        NoMoreArmor(jetfighterArmor, jetfighterRow, jetfighterCol, matrix);
                    }
                    else if (matrix[jetfighterRow, jetfighterCol + 1] == "R")
                    {
                        jetfighterArmor = 300;
                        matrix[jetfighterRow, jetfighterCol + 1] = "-";

                        jetfighterCol++;
                    }
                }
            }

            PrintMatrix(matrix, jetfighterRow, jetfighterCol);
        }

        private static void IsItStartingPosition(string[,] matrix, int jetfighterRow, int jetfighterCol)
        {
            if (matrix[jetfighterRow, jetfighterCol] == "J")
            {
                matrix[jetfighterRow, jetfighterCol] = "-";
            }
        }

        private static void NoMoreArmor(int jetfighterArmor, int jetfighterRow, int jetfighterCol, string[,] matrix)
        {
            if (jetfighterArmor == 0)
            {
                Console.WriteLine(
                    $"Mission failed, your jetfighter was shot down! Last coordinates [{jetfighterRow}, {jetfighterCol}]!");
                PrintMatrix(matrix, jetfighterRow, jetfighterCol);

                Environment.Exit(0);
            }
        }

        public static void NoEnemiesLeft(int enemiesCount, string[,] matrix, int jetfighterRow, int jetfighterCol)
        {
            if (enemiesCount == 0)
            {
                Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                PrintMatrix(matrix, jetfighterRow, jetfighterCol);

                Environment.Exit(0);
            }
        }

        public static void PrintMatrix(string[,] matrix, int jetfighterRow, int jetfighterCol)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == jetfighterRow && col == jetfighterCol)
                    {
                        matrix[row, col] = "J";
                    }
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}