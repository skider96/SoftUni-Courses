namespace _03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            input = input.Reverse().ToArray();

            Stack<string> stack = new(input);
            Stack<int> resultStack = new();

            int firstNubmer = 0;
            int result = 0;
            while (stack.Any())
            {
                if (stack.Count == 2 || stack.Peek() == "-" || stack.Peek() == "+")
                {
                    firstNubmer = result;
                }
                else
                {
                    firstNubmer = int.Parse(stack.Pop());

                }
                char operation = char.Parse(stack.Pop());
                int secondNumber = int.Parse(stack.Pop());

                if (operation == '+')
                {
                    result = firstNubmer + secondNumber;
                    resultStack.Push(result);
                }
                else if (operation == '-')
                {
                    result = firstNubmer - secondNumber;
                    resultStack.Push(result);
                }
                Console.WriteLine();
            }

            Console.WriteLine(result);
        }
    }
}
