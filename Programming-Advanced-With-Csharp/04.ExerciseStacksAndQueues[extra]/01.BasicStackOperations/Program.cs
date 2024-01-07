using System.Globalization;

namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new();
            string[] input = Console.ReadLine().Split().ToArray();
            
            int nToPush = int.Parse(input[0]);
            int nToPop = int.Parse(input[1]);
            int nToLook = int.Parse(input[2]);

            int[] numbersFromConsole = new int[nToPush];

            string[] secondInput = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < nToPush; i++)
            {
                stack.Push(int.Parse(secondInput[i]));
            }
            
            for (int i = 0; i < nToPop; i++)
            {
                stack.Pop();
            }

            bool found = stack.Contains(nToLook);
            if (stack.Any())
            {
                if (found)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }

            }
            else Console.WriteLine(0);
        }
    }
}
