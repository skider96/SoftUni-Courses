namespace _02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new(inputNumbers);

            string command;
            while ((command = Console.ReadLine()).ToLower() != "end")
            {
                string[] tokens = command.Split();

                if (tokens.Length == 3 && tokens[0].ToLower() == "add")
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                }
                else if (tokens.Length == 2 && tokens[0].ToLower() == "remove")
                {
                    int numberToRemove = int.Parse(tokens[1]);
                    if (numberToRemove > stack.Count)
                    {
                        continue;
                    }

                    for (int i = 0; i < numberToRemove; i++)
                    {
                        stack.Pop();
                    }
                }
            }
            var sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
