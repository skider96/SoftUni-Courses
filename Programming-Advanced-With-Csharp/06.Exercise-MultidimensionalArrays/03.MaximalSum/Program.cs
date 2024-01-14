namespace _03.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rowSize = input[0];
            int columnSize = input[1];

            int[][] matrix = new int[rowSize][];

            for (int row = 0; row < rowSize; row++)
            {
                int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = new int[columnSize];

                for (int col = 0; col < columnSize; col++)
                {
                    matrix[row][col] = inputs[col];
                }
            }

            int sumOfAll = 0;

            int topLeft = 0;
            int topCenter = 0;
            int topRight = 0;

            int middleLeft = 0;
            int middleCenter = 0;
            int middleRight = 0;

            int bottomLeft = 0;
            int bottomCenter = 0;
            int bottomRight = 0;

            int sumCurrentMatrix = 0;
            int sumBiggest = 0;
            string biggestNumbersMatrix = String.Empty;

            int num = matrix.GetLength(0);
            int num2 = matrix.GetLength(1);
            for (int row = 0; row < rowSize - 2; row++)
            {
                for (int col = 0; col < columnSize - 2; col++)
                {
                    if (matrix.GetLength(0) > 3 && matrix.GetLength(1) > 3)
                    {
                        topLeft = matrix[row][col];
                        topCenter = matrix[row][col + 1];
                        topRight = matrix[row][col + 2];

                        middleLeft = matrix[row + 1][col];
                        middleCenter = matrix[row + 1][col + 1];
                        middleRight = matrix[row + 1][col + 2];

                        bottomLeft = matrix[row + 2][col];
                        bottomCenter = matrix[row + 2][col + 1];
                        bottomRight = matrix[row + 2][col + 2];

                        if (sumCurrentMatrix > sumBiggest)
                        {
                            sumBiggest = sumCurrentMatrix;

                            biggestNumbersMatrix = $"{topLeft} + {topRight} + {topCenter} + {middleLeft} + {middleRight} + {middleCenter} + {bottomLeft} + {bottomCenter} + {bottomRight}";
                        }
                    }
                    else
                    {
                        sumOfAll += matrix[row][col];
                    }
                }
            }

            Console.WriteLine(biggestNumbersMatrix);


            // TO BE SOLVED...
        }
    }
}
