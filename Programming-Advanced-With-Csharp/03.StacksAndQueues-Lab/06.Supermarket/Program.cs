using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System;

namespace _06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command != "Paid")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
