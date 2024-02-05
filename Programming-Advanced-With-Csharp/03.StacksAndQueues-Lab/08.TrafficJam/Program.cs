using System.Reflection.Metadata.Ecma335;

namespace _08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsThatCanPass = int.Parse(Console.ReadLine());

            Queue<string> cars = new();

            int carsPassed = 0;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < carsThatCanPass; i++)
                    {
                        while (cars.Any())
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            carsPassed++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }

            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
// Solved but Judge gave me 75%...