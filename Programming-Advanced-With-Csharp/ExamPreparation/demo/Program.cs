namespace OffRoadCahllange
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> fuel = new Stack<int>(Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse));

            Queue<int> consumption = new Queue<int>(Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse));

            Queue<int> altitude = new Queue<int>(Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse));

            int counter = 0;

            // Checked
            bool hasReachedAny = false;

            while (fuel.Any() && consumption.Any())
            {
                counter++;
                int temp = fuel.Peek() - consumption.Peek();

                if (temp >= altitude.Peek())
                {
                    hasReachedAny = true;

                    fuel.Pop();
                    consumption.Dequeue();
                    altitude.Dequeue();

                    Console.WriteLine($"John has reached: Altitude {counter}");
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {counter}");
                    Console.WriteLine("John failed to reach the top.");
                    if (hasReachedAny)
                    {
                        Console.Write("Reached altitudes: ");

                        List<string> strings = new List<string>();

                        for (int i = 1; i < counter; i++)
                        {
                            strings.Add($"Altitude {i}");
                        }

                        Console.WriteLine(string.Join(", ", strings));
                    }
                    else
                    {
                        Console.WriteLine("John didn't reach any altitude.");
                    }
                    return;
                }

                if (altitude.Count == 0)
                {
                    Console.WriteLine($"John has reached all the altitudes and managed to reach the top!");
                    return;
                }
            }
        }
    }
}