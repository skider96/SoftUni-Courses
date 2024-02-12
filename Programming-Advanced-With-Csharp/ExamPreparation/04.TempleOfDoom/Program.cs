namespace _04.TempleOfDoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> tools = new(InputFromConsole());
            Stack<int> substances = new(InputFromConsole());
            List<int> challenges = InputFromConsole()
            .ToList();

            while (challenges.Any())
            {
                int multipliedNumber = tools.Peek() * substances.Peek();
                if (challenges.Contains(multipliedNumber))
                {
                    challenges.Remove(multipliedNumber);
                    tools.Dequeue();
                    substances.Pop();
                }
                else
                {
                    int removedTool = tools.Dequeue() + 1;
                    tools.Enqueue(removedTool);
                    int removedSubstance = substances.Pop() - 1;
                    substances.Push(removedSubstance);
                    if (substances.Peek() == 0)
                    {
                        substances.Pop();
                    }
                }
                if ((!tools.Any() || !substances.Any()) && challenges.Any())
                {
                    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");

                    PrintCollection(tools, "Tools");
                    PrintCollection(substances, "Substances");
                    PrintCollection(challenges, "Challenges");
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");

            PrintCollection(tools, "Tools");
            PrintCollection(substances, "Substances");
            PrintCollection(challenges, "Challenges");
        }

        public static void PrintCollection(IEnumerable<int> collection, string name)
        {
            if (collection.Any())
            {
                Console.Write($"{name}: " + string.Join(", ", collection));
                Console.WriteLine();
            }
        }

        public static IEnumerable<int> InputFromConsole()
        {
           return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
        }
    }
}