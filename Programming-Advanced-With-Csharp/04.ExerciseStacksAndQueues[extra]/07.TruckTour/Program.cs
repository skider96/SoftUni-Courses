namespace _07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NpetrolPumps = int.Parse(Console.ReadLine());

            int[] tank = new int[NpetrolPumps];
            int[] distance = new int[NpetrolPumps];

            for (int i = 0; i < NpetrolPumps; i++)
            {
                int[] information = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                tank[i] = information[0];
                distance[i] = information[1];
            }

            Stack<int> differ = new();
            for (int i = 0; i < NpetrolPumps; i++)
            {
                differ.Push(tank[i] - distance[i]);

                //if (differ.Sum() > 0)
                //{
                //    Console.WriteLine(i);
                //    break;
                //}
            }

            int totalSum = tank.Sum() - distance.Sum();
            int stances = 0;
            while (totalSum >= 0 && differ.Any())
            {
                totalSum -= differ.Pop();
                stances++;
            }

            Console.WriteLine(stances);
        }
    }
}

// Solved at 40% in Judge...