namespace _02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sizeRows = input[0];
            int sizeCol = input[1];

            char[][] matrix = new char[sizeRows][];

            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                char[] inputChars = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < sizeCol; col++)
                {
                    matrix[row][col] = inputChars[col];
                }
            }
            

            char firstCapture = Char.MinValue;
            char secondCapture = Char.MinValue;
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = 0; col < matrix.GetLength(0) -1; col++)
                {
                    firstCapture = matrix[row][col];
                    secondCapture = matrix[row][col+1];
                    if (firstCapture == secondCapture)
                    {
                        counter++;
                    }
                }


            }

            //TODO
        }
    }
}
