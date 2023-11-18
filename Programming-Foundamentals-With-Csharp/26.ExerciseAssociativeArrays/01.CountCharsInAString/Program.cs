/*
text
-------
text text text
 */
namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
         
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (keyValuePairs.ContainsKey(input[i])) keyValuePairs[input[i]]++;
                else keyValuePairs.Add(input[i], 1);
            }
            keyValuePairs.Remove(' ');
            foreach (var key in keyValuePairs)
            {
                Console.WriteLine($"{key.Key} -> {key.Value}");
            }
        }
    }
}
