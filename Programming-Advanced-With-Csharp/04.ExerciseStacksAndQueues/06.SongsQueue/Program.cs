using System.ComponentModel.Design;

namespace _06.SongQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sequenceStrings = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Queue<string> songs = new(sequenceStrings);

            string[] commands = Console.ReadLine().Split().ToArray();
            while (songs.Count > 0)
            {
                if (commands[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if (commands[0] == "Add")
                {
                    string[] array = commands[1..];
                    string str = string.Join(' ', array);

                    if (songs.Contains(str))
                    {
                        Console.WriteLine($"{str} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(str);
                    }
                }
                else if (commands[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
                commands = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine("No more songs!");
        }
    }
}

// It gives me 33% in judge...