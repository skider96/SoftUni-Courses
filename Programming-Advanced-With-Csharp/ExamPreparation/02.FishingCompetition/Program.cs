namespace _02.FishingCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());

            string[,] matrix = new string[squareMatrixSize, squareMatrixSize];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col].ToString();
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "collect the nets")
            {
                if (command == $"{Moves.up}")
                {

                }
                else if (command == $"{Moves.down}")
                {
                    
                }
                else if (command == $"{Moves.left}")
                {

                }
                else if (command == $"{Moves.right}")
                {

                }
            }
        }

        public enum Moves
        {
            up,
            down,
            left,
            right
        }

        //TODO
    }
}