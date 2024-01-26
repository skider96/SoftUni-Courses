namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] twoNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < twoNumbers[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < twoNumbers[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

           HashSet<int> repeatedNums = new HashSet<int>();
            if (firstSet.Count >= secondSet.Count)
            {
                firstSet.IntersectWith(secondSet);
                Print();
            }
            else
            {
                secondSet.IntersectWith(firstSet);
                Print();
            }

            void Print()
            {
                Console.WriteLine(string.Join(" ", firstSet));
            }


            // TO BE CHECKED
        }
    }
}
