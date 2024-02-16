using System.Collections.Specialized;

namespace _09.DeliveryBoy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[size[0], size[1]];

            int rowOfBoy = 0;
            int colOfBoy = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col].ToString();
                    if (matrix[row, col] == "B")
                    {
                        rowOfBoy = row;
                        colOfBoy = col;
                    }
                }
            }

            bool deliveredPizza = false;

            int startingColPositionOfTheBoy = colOfBoy;
            int startingRowPositionOfTheBoy = rowOfBoy;

            while (!deliveredPizza)
            {
                var command = Console.ReadLine();
                if (command == $"{Moves.up}")
                {
                    if (!IsInMatrix(matrix, rowOfBoy - 1, colOfBoy))
                    {
                        TheBoyEscaped(matrix, startingColPositionOfTheBoy, startingRowPositionOfTheBoy);
                    }

                    if (Logic(matrix, rowOfBoy - 1, colOfBoy, ref deliveredPizza)) continue;
                    rowOfBoy--;
                }
                if (command == $"{Moves.down}")
                {
                    if (!IsInMatrix(matrix, rowOfBoy + 1, colOfBoy))
                    {
                        TheBoyEscaped(matrix, startingColPositionOfTheBoy, startingRowPositionOfTheBoy);
                    }

                    if (Logic(matrix, rowOfBoy + 1, colOfBoy, ref deliveredPizza)) continue;
                    rowOfBoy++;
                }
                if (command == $"{Moves.left}")
                {
                    if (!IsInMatrix(matrix, rowOfBoy, colOfBoy - 1))
                    {
                        TheBoyEscaped(matrix, startingColPositionOfTheBoy, startingRowPositionOfTheBoy);
                    }

                    if (Logic(matrix, rowOfBoy, colOfBoy - 1, ref deliveredPizza)) continue;
                    colOfBoy--;
                }
                if (command == $"{Moves.right}")
                {
                    if (!IsInMatrix(matrix, rowOfBoy, colOfBoy + 1))
                    {
                        TheBoyEscaped(matrix, startingColPositionOfTheBoy, startingRowPositionOfTheBoy);
                    }

                    if (Logic(matrix, rowOfBoy, colOfBoy + 1, ref deliveredPizza)) continue;
                    colOfBoy++;
                }
            }

            PrintMatrix(matrix, startingColPositionOfTheBoy, startingRowPositionOfTheBoy, "B");
        }

        public static void TheBoyEscaped(string[,] matrix, int startingColPositionOfTheBoy, int startingRowPositionOfTheBoy)
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            PrintMatrix(matrix, startingColPositionOfTheBoy, startingRowPositionOfTheBoy, " ");
            Environment.Exit(0);
        }

        private static bool Logic(string[,] matrix, int rowOfBoy, int colOfBoy, ref bool deliveredPizza)
        {
            if (matrix[rowOfBoy, colOfBoy] == "P")
            {
                matrix[rowOfBoy, colOfBoy] = "R";
                Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
            }
            else if (matrix[rowOfBoy, colOfBoy] == "*")
            {
                return true;
            }
            else if (matrix[rowOfBoy, colOfBoy] == "A")
            {
                matrix[rowOfBoy, colOfBoy] = "P";
                Console.WriteLine("Pizza is delivered on time! Next order...");
                deliveredPizza = true;
            }
            else if (matrix[rowOfBoy, colOfBoy] == "-")
            {
                matrix[rowOfBoy, colOfBoy] = ".";
            }

            return false;
        }

        public enum Moves
        {
            up,
            down,
            left,
            right
        }
        public static bool IsInMatrix(string[,] matrix, int rowOfBoy, int colOfBoy)
        {
            if ((matrix.GetLength(0) > rowOfBoy && matrix.GetLength(1) > colOfBoy) && (rowOfBoy >= 0 && colOfBoy >= 0))
            {
                return true;
            }
            return false;
        }
        public static void PrintMatrix(string[,] matrix, int startingColPositionOfTheBoy, int startingRowPositionOfTheBoy, string boy)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == startingRowPositionOfTheBoy && col == startingColPositionOfTheBoy)
                    {
                        matrix[row, col] = $"{boy}";
                    }
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}