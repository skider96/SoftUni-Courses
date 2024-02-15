namespace _05.MouseInTheKitchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];

            int rowOfMouse = 0;
            int colOfMouse = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string matrixInput = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrixInput[col].ToString();
                    if (matrix[row, col] == "M")
                    {
                        rowOfMouse = row;
                        colOfMouse = col;
                    }
                }
            }

            int lastRowPosition = 0;
            int lastColPosition = 0;
            string command;
            while ((command = Console.ReadLine()) != "danger")
            {
                if (command == $"{Moves.up}")
                {
                    if (IsInMatrix(matrix, rowOfMouse - 1, colOfMouse))
                    {
                        if (matrix[rowOfMouse - 1, colOfMouse] == "C")
                        {
                            matrix[rowOfMouse, colOfMouse] = "*";
                            lastRowPosition = rowOfMouse - 1;
                            rowOfMouse--;
                            lastColPosition = colOfMouse;
                            matrix[lastRowPosition, lastColPosition] = "M";
                            IsAnyCheese(matrix);
                        }
                        else if ((matrix[rowOfMouse - 1, colOfMouse] == "T"))
                        {
                            matrix[rowOfMouse - 1, colOfMouse] = "M";
                            matrix[rowOfMouse, colOfMouse] = "*";
                            Console.WriteLine("Mouse is trapped!");
                            PrintMatrix(matrix);
                            Environment.Exit(0);
                        }
                        else if ((matrix[rowOfMouse - 1, colOfMouse] == "*"))
                        {
                            matrix[rowOfMouse, colOfMouse] = "*";
                            matrix[rowOfMouse - 1, colOfMouse] = "M";
                            rowOfMouse--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        PrintMatrix(matrix);
                        Environment.Exit(0);
                    }
                }
                else if (command == $"{Moves.down}")
                {
                    if (IsInMatrix(matrix, rowOfMouse + 1, colOfMouse))
                    {
                        if (matrix[rowOfMouse + 1, colOfMouse] == "C")
                        {
                            matrix[rowOfMouse, colOfMouse] = "*";
                            lastRowPosition = rowOfMouse + 1;
                            lastColPosition = colOfMouse;
                            rowOfMouse++;
                            matrix[lastRowPosition, lastColPosition] = "M";
                            IsAnyCheese(matrix);
                        }
                        else if ((matrix[rowOfMouse + 1, colOfMouse] == "T"))
                        {
                            matrix[rowOfMouse + 1, colOfMouse] = "M";
                            matrix[rowOfMouse, colOfMouse] = "*";
                            Console.WriteLine("Mouse is trapped!");
                            PrintMatrix(matrix);
                            Environment.Exit(0);
                        }
                        else if ((matrix[rowOfMouse + 1, colOfMouse] == "*"))
                        {
                            matrix[rowOfMouse, colOfMouse] = "*";
                            matrix[rowOfMouse + 1, colOfMouse] = "M";
                            rowOfMouse++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        PrintMatrix(matrix);
                        Environment.Exit(0);
                    }
                }
                else if (command == $"{Moves.right}")
                {
                    if (IsInMatrix(matrix, rowOfMouse, colOfMouse + 1))
                    {
                        if (matrix[rowOfMouse, colOfMouse + 1] == "C")
                        {
                            matrix[rowOfMouse, colOfMouse] = "*";
                            lastRowPosition = rowOfMouse;
                            lastColPosition = colOfMouse + 1;
                            colOfMouse++;
                            matrix[lastRowPosition, lastColPosition] = "M";
                            IsAnyCheese(matrix);
                        }
                        else if ((matrix[rowOfMouse, colOfMouse + 1] == "T"))
                        {
                            matrix[rowOfMouse, colOfMouse] = "*";
                            matrix[rowOfMouse, colOfMouse + 1] = "M";
                            Console.WriteLine("Mouse is trapped!");
                            PrintMatrix(matrix);
                            Environment.Exit(0);
                        }
                        else if ((matrix[rowOfMouse, colOfMouse + 1] == "*"))
                        {
                            matrix[rowOfMouse, colOfMouse] = "*";
                            matrix[rowOfMouse, colOfMouse + 1] = "M";
                            colOfMouse++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        PrintMatrix(matrix);
                        Environment.Exit(0);
                    }
                }
                else if (command == $"{Moves.left}")
                {
                    if (IsInMatrix(matrix, rowOfMouse, colOfMouse - 1))
                    {
                        if (matrix[rowOfMouse, colOfMouse - 1] == "C")
                        {
                            matrix[rowOfMouse, colOfMouse] = "*";
                            lastRowPosition = rowOfMouse;
                            lastColPosition = colOfMouse - 1;
                            colOfMouse--;
                            matrix[lastRowPosition, lastColPosition] = "M";
                            IsAnyCheese(matrix);
                        }
                        else if ((matrix[rowOfMouse, colOfMouse - 1] == "T"))
                        {
                            matrix[rowOfMouse, colOfMouse] = "*";
                            matrix[rowOfMouse, colOfMouse - 1] = "M";
                            Console.WriteLine("Mouse is trapped!");
                            PrintMatrix(matrix);
                            Environment.Exit(0);
                        }
                        else if ((matrix[rowOfMouse, colOfMouse - 1] == "*"))
                        {
                            matrix[rowOfMouse, colOfMouse] = "*";
                            matrix[rowOfMouse, colOfMouse - 1] = "M";
                            colOfMouse--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        PrintMatrix(matrix);
                        Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine("Mouse will come back later!");
            PrintMatrix(matrix);
        }

        private static void IsAnyCheese(string[,] matrix)
        {
            bool isAnyCheese = false;
            foreach (var ch in matrix)
            {
                if (ch == "C")
                {
                    isAnyCheese = true;
                }
            }

            if (isAnyCheese == false)
            {
                Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                PrintMatrix(matrix);
                Environment.Exit(0);
            }
        }

        public enum Moves
        {
            up,
            down,
            left,
            right
        }

        public static bool IsInMatrix(string[,] matrix, int row, int col)
        {
            if ((matrix.GetLength(0) > row && matrix.GetLength(1) > col) && (row >= 0 && col >= 0))
            {
                return true;
            }
            return false;
        }

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