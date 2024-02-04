using System.Data.Common;
using System.Diagnostics.CodeAnalysis;

namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> clothes = new(clothesInBox);

            int capacityOfRack = int.Parse(Console.ReadLine());

            int sumOfRacks = 0;
            int currentSum = 0;
            for (int i = 0; i < clothesInBox.Length; i++)
            {
                if (currentSum + clothes.Peek() <= capacityOfRack)
                {
                    currentSum += clothes.Pop();
                }
                else
                {
                    sumOfRacks ++;
                    currentSum = 0;
                    currentSum += clothes.Pop();
                }

                if (currentSum > 0 && !clothes.Any())
                {
                    sumOfRacks++;
                }
            }

            Console.WriteLine(sumOfRacks);
        }
    }
}
