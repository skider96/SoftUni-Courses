using System.Runtime.InteropServices.ComTypes;

namespace _01.OffroadChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialFuelInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] consumptionIndexesInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] neededQuantityInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> initialFuel = new(initialFuelInput);
            Queue<int> consumptionIndexes = new(consumptionIndexesInput);
            Queue<int> neededQuantity = new(neededQuantityInput);

            List<string> altitudes = new();
            int counterOfAltitudes = 0;
            while (initialFuel.Any() && consumptionIndexes.Any())
            {
                counterOfAltitudes++;
                int subtraction = initialFuel.Pop() - consumptionIndexes.Dequeue();

                if (subtraction >= neededQuantity.Dequeue())
                {
                    Console.WriteLine($"John has reached: Altitude {counterOfAltitudes}");
                    altitudes.Add($"Altitude {counterOfAltitudes}");
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {counterOfAltitudes}");
                    break;
                }
            }

            if (neededQuantity.Count > 0)
            {
                Console.WriteLine("John failed to reach the top.");
            }
            else
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
                return;
            }

            Console.WriteLine(counterOfAltitudes == 0
                ? "John didn't reach any altitude."
                : $"Reached altitudes: {string.Join(", ", altitudes)}");
        }
    }
}
//Solved ,but Judge gave me 50%.