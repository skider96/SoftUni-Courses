namespace _03.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[3, 3];

            int increment = 0;
            int sumOfPrimaryDiagonal = 0;
            for (int row = 0; row < size; row++)
            {
                int[]? numbersInput = Console.ReadLine()?.Split().Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = numbersInput[col];
                }

                sumOfPrimaryDiagonal += numbersInput[increment];
                increment++;
            }

            Console.WriteLine(sumOfPrimaryDiagonal);
        }
    }
}
