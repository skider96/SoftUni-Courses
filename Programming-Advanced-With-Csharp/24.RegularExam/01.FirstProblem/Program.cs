namespace _01.FirstProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {



        }

        //ADDED BEFORE
        public static IEnumerable<int> InputFromConsole()
        {
            return Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
        }
    }
}
