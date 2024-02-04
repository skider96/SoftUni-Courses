namespace _3.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new();

            int queries = int.Parse(Console.ReadLine());

            for (int i = 0; i < queries; i++)
            {
                int[] input  = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                if (input.Length > 1) stack.Push(input[1]);
                else if (stack.Any() && input[0] == 2) stack.Pop();
                if (stack.Any() && input[0] == 3) Console.WriteLine(stack.Max());
                if (stack.Any() && input[0] == 4) Console.WriteLine(stack.Min());
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}

/*
9
1 97
2
1 20
2
1 26
1 20
3
1 91
4
*/