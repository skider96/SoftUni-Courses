namespace _08.BalancedParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();
            Stack<char> stack = new();

            for (int i = 0; i < parentheses.Length; i++)
            {
                stack.Push(parentheses[i]);
            }

            for (int i = 0; i < parentheses.Length / 2; i++)
            {
                if (stack.Peek() == ')' && parentheses[i] == '(')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == ']' && parentheses[i] == '[')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '}' && parentheses[i] == '{')
                {
                    stack.Pop();
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
