using System.Collections.Generic;

namespace _07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new(Console.ReadLine().Split());
            int n = int.Parse(Console.ReadLine());

            string removedKid;
            while (queue.Count != 1)
            {
                for (int i = 1; i < n; i++)
                {
                    removedKid = queue.Dequeue();
                    queue.Enqueue(removedKid);
                }

                removedKid = queue.Dequeue();
                Console.WriteLine($"Removed {removedKid}");
            }

            foreach (var kid in queue)
            {
                Console.WriteLine($"Last is {kid}");
            }
        }
    }
}