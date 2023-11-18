namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourse = new Dictionary<string, int>();
            string command;
            int i = 0;
            string previousCommand = "";
            while ((command = Console.ReadLine()) != "stop")
            {
                if (i % 2 == 0)
                {
                    if (resourse.ContainsKey(command))
                    {
                        previousCommand = command; 
                        i++;
                        continue;
                    }
                    else resourse.Add(command, 0);
                }
                else
                {
                    if (resourse.ContainsKey(previousCommand))
                    {
                        resourse[previousCommand] += int.Parse(command);
                    }
                  
                }
                previousCommand = command;
                i++;
            }

            foreach (var kvp in resourse)
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
