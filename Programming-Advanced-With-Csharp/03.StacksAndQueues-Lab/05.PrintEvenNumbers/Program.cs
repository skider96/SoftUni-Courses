namespace _05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(input);

            Console.Write(string.Join(", ", queue.Where(n => n % 2 == 0).ToList()));
        }
    }
}