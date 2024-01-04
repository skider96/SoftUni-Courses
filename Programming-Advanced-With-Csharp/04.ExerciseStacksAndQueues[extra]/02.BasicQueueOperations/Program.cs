namespace _02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new();
            string[] input = Console.ReadLine().Split().ToArray();

            int nToEnqueue = int.Parse(input[0]);
            int nToDequeue = int.Parse(input[1]);
            int nToLook = int.Parse(input[2]);

            int[] numbersFromConsole = new int[nToEnqueue];

            string[] secondInput = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < nToEnqueue; i++)
            {
                queue.Enqueue(int.Parse(secondInput[i]));
            }

            for (int i = 0; i < nToDequeue; i++)
            {
                queue.Dequeue();
            }

            bool found = queue.Contains(nToLook);
            if (queue.Any())
            {
                if (found)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }

            }
            else Console.WriteLine(0);
        }
    }
}