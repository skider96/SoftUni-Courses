namespace _02.FishingCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());

            string[,] matrix = new string[squareMatrixSize, squareMatrixSize];

            int rowOfShip = 0;
            int colOfShip = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col].ToString();
                    if (matrix[row, col] == "S")
                    {
                        rowOfShip = row;
                        colOfShip = col;
                    }
                }
            }
            int quantity = 0;

            string command;
            while ((command = Console.ReadLine()) != "collect the nets")
            {
                if (command == $"{Moves.up}")
                {
                    if (IsInMatrix(matrix, rowOfShip - 1, colOfShip))
                    {
                        if (matrix[rowOfShip - 1, colOfShip] == "-")
                        {
                            matrix[rowOfShip, colOfShip] = "-";
                            matrix[rowOfShip - 1, colOfShip] = "S";
                            rowOfShip--;
                        }
                        else if (matrix[rowOfShip - 1, colOfShip] == "W")
                        {
                            Whirpool(rowOfShip - 1, colOfShip);
                        }
                        else
                        {
                            quantity += FishPassageAdded(matrix, rowOfShip - 1, colOfShip, quantity);
                            matrix[rowOfShip, colOfShip] = "-";
                            matrix[rowOfShip - 1, colOfShip] = "S";
                            rowOfShip--;
                        }
                    }
                    else
                    {
                        matrix[rowOfShip, colOfShip] = "-";
                        rowOfShip = squareMatrixSize - 1;
                        if (matrix[rowOfShip, colOfShip] == "-")
                        {
                            matrix[rowOfShip, colOfShip] = "S";
                        }
                        else if (matrix[rowOfShip, colOfShip] == "W")
                        {
                            Whirpool(rowOfShip, colOfShip);
                        }
                        else
                        {
                            quantity += FishPassageAdded(matrix, rowOfShip, colOfShip, quantity);
                            matrix[rowOfShip, colOfShip] = "S";
                        }
                    }
                }
                else if (command == $"{Moves.down}")
                {
                    if (IsInMatrix(matrix, rowOfShip + 1, colOfShip))
                    {
                        if (matrix[rowOfShip + 1, colOfShip] == "-")
                        {
                            matrix[rowOfShip, colOfShip] = "-";
                            matrix[rowOfShip + 1, colOfShip] = "S";
                            rowOfShip++;
                        }
                        else if (matrix[rowOfShip + 1, colOfShip] == "W")
                        {
                            Whirpool(rowOfShip + 1, colOfShip);
                        }
                        else
                        {
                            quantity += FishPassageAdded(matrix, rowOfShip + 1, colOfShip, quantity);
                            matrix[rowOfShip, colOfShip] = "-";
                            matrix[rowOfShip + 1, colOfShip] = "S";
                            rowOfShip++;
                        }
                    }
                    else
                    {
                        matrix[rowOfShip, colOfShip] = "-";
                        rowOfShip = 0;

                        if (matrix[rowOfShip, colOfShip] == "-")
                        {
                            matrix[rowOfShip, colOfShip] = "S";
                        }
                        else if (matrix[rowOfShip, colOfShip] == "W")
                        {
                            Whirpool(rowOfShip, colOfShip);
                        }
                        else
                        {
                            quantity += FishPassageAdded(matrix, rowOfShip, colOfShip, quantity);
                            matrix[rowOfShip, colOfShip] = "S";
                        }
                    }
                }
                else if (command == $"{Moves.left}")
                {
                    if (IsInMatrix(matrix, rowOfShip, colOfShip - 1))
                    {
                        if (matrix[rowOfShip, colOfShip - 1] == "-")
                        {
                            matrix[rowOfShip, colOfShip] = "-";
                            matrix[rowOfShip, colOfShip - 1] = "S";
                            colOfShip--;
                        }
                        else if (matrix[rowOfShip, colOfShip - 1] == "W")
                        {
                            Whirpool(rowOfShip, colOfShip - 1);
                        }
                        else
                        {
                            quantity += FishPassageAdded(matrix, rowOfShip, colOfShip - 1, quantity);
                            matrix[rowOfShip, colOfShip] = "-";
                            matrix[rowOfShip, colOfShip - 1] = "S";
                            colOfShip--;
                        }
                    }
                    else
                    {
                        matrix[rowOfShip, colOfShip] = "-"; 
                        colOfShip = squareMatrixSize - 1;
                        if (matrix[rowOfShip, colOfShip] == "-")
                        {
                            matrix[rowOfShip, colOfShip] = "S";
                        }
                        else if (matrix[rowOfShip, colOfShip] == "W")
                        {
                            Whirpool(rowOfShip, colOfShip);
                        }
                        else
                        {
                            quantity += FishPassageAdded(matrix, rowOfShip, colOfShip, quantity);
                            matrix[rowOfShip, colOfShip] = "S";
                        }
                    }
                }
                else if (command == $"{Moves.right}")
                {
                    if (IsInMatrix(matrix, rowOfShip, colOfShip + 1))
                    {
                        if (matrix[rowOfShip, colOfShip + 1] == "-")
                        {
                            matrix[rowOfShip, colOfShip] = "-";
                            matrix[rowOfShip, colOfShip + 1] = "S";
                            colOfShip++;
                        }
                        else if (matrix[rowOfShip, colOfShip + 1] == "W")
                        {
                            Whirpool(rowOfShip, colOfShip + 1);
                        }
                        else
                        {
                            quantity += FishPassageAdded(matrix, rowOfShip, colOfShip + 1, quantity);
                            matrix[rowOfShip, colOfShip] = "-";
                            matrix[rowOfShip, colOfShip + 1] = "S";
                            colOfShip++;
                        }
                    }
                    else
                    {
                        matrix[rowOfShip, colOfShip] = "-";
                        colOfShip = 0;
                        if (matrix[rowOfShip, colOfShip] == "-")
                        {
                            matrix[rowOfShip, colOfShip] = "S";
                        }
                        else if (matrix[rowOfShip, colOfShip] == "W")
                        {
                            Whirpool(rowOfShip, colOfShip);
                        }
                        else
                        {
                            quantity += FishPassageAdded(matrix, rowOfShip, colOfShip, quantity);
                            matrix[rowOfShip, colOfShip] = "S";
                        }
                    }
                }
            }

            if (quantity >= 20)
            {
                Console.WriteLine("Success! You managed to reach the quota!");
            }
            else
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - quantity} tons of fish more.");
            }

            if (quantity > 0)
            {
                Console.WriteLine($"Amount of fish caught: {quantity} tons.");
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static bool IsInMatrix(string[,] matrix, int rowOfShip, int colOfShip)
        {
            if ((matrix.GetLength(0)  > rowOfShip && matrix.GetLength(1)  > colOfShip) && (rowOfShip >= 0 && colOfShip >= 0))
            {
                return true;
            }
            return false;
        }

        public static int FishPassageAdded(string[,] matrix, int rowOfShip, int colOfShip, int quantity)
        {

            quantity = 0;
            for (int number = 0; number < 10; number++)
            {
                if (matrix[rowOfShip, colOfShip] == $"{number}")
                {
                    quantity = number;
                }
            }
            return quantity;
        }

        public static void Whirpool(int rowOfShip, int colOfShip)
        {
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{rowOfShip},{colOfShip}]");
            Environment.Exit(0);
        }

        public enum Moves
        {
            up,
            down,
            left,
            right
        }
    }
}