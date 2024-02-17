using System.Security.Cryptography;

namespace _01.FirstProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> amountMoney = new(InputFromConsole());
            Queue<int> priceOfFoods = new(InputFromConsole());

            int foods = 0;
            while (amountMoney.Any() && priceOfFoods.Any())
            {
                if (amountMoney.Peek() == priceOfFoods.Peek())
                {
                    amountMoney.Pop();
                    priceOfFoods.Dequeue();
                    foods++;
                }
                else if (amountMoney.Peek() > priceOfFoods.Peek())
                {
                    int change = amountMoney.Pop() - priceOfFoods.Dequeue();
                    int lastMoney = 0;
                    if (amountMoney.Any())
                    {
                        lastMoney = amountMoney.Pop();
                    }
                    amountMoney.Push(lastMoney + change);
                    foods++;
                }
                else
                {
                    amountMoney.Pop();
                    priceOfFoods.Dequeue();
                }
            }

            if (foods >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {foods} foods.");
            }
            else if (foods is < 4 and > 1)
            {
                Console.WriteLine($"Henry ate: {foods} foods.");
            }
            else if (foods == 1)
            {
                Console.WriteLine($"Henry ate: {foods} food.");
            }
            else if (foods == 0)
            {
                Console.WriteLine("Henry remained hungry. He will try next weekend again.");
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
