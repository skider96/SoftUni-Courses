namespace _03.Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(" | ");
            string[] secondLine = Console.ReadLine().Split(" | ");
            string thirdLine = Console.ReadLine();

            Dictionary<string, List<string>> notebook = new Dictionary<string, List<string>>();

            for (int i = 0; i < firstLine.Length; i++)
            {
                string[] separated = firstLine[i].Split(": ");
                if (notebook.ContainsKey(separated[0]))
                {
                    notebook[separated[0]].Add(separated[1]);
                }
                else
                {
                    notebook.Add(separated[0], new List<string>());
                    notebook[separated[0]].Add(separated[1]);
                }
            }

            if (thirdLine == "Test")
            {
                for (int i = 0; i < secondLine.Length; i++)
                {
                    foreach (var kvp in notebook)
                    {
                        if (kvp.Key == secondLine[i])
                        {
                            Console.WriteLine($"{kvp.Key}:");
                            Console.WriteLine(" -" + string.Join("\n -", kvp.Value));
                        }
                    }
                }
            }
            else if (thirdLine == "Hand Over")
            {
                foreach (var kvp in notebook)
                {
                    Console.Write($"{kvp.Key} ");
                }
            }
        }
    }
}
/*
programmer: an animal, which turns coffee into code | developer: a magician
fish | domino
Hand Over
 */

