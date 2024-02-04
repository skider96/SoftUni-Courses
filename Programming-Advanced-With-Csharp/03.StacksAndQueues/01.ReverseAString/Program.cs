namespace _01.ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>(input);

            while (stack.Any())
            {
                char popedChar = stack.Pop();

                Console.Write(popedChar);
            }
        }
    }
}
