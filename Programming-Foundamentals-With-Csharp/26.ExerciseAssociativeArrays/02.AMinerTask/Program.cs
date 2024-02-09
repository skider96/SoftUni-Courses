namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resource = new Dictionary<string, int>();
            string command;
            int i = 0;
            string previousCommand = "";
            while ((command = Console.ReadLine()) != "stop")
            {
                if (i % 2 == 0)
                {
                    if (resource.ContainsKey(command))
                    {
                        previousCommand = command; 
                        i++;
                        continue;
                    }
                    resource.Add(command, 0);
                }
                else
                {
                    if (resource.ContainsKey(previousCommand))
                    {
                        resource[previousCommand] += int.Parse(command);
                    }
                }
                previousCommand = command;
                i++;
            }

            foreach (var kvp in resource)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
/*
Gold
155
Silver
10
Copper
17
stop
 */
