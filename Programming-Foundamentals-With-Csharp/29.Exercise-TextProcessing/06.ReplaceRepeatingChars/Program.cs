namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToList();
            List<char> output = new List<char>();
            char previousChar = ' ';

            for (int i = 0; i < input.Count; i++)
            {
                if (i == 0)
                {
                    output.Add(input[i]);
                }
                else if (!(output[output.Count - 1] == input[i]))
                {
                    output.Add(input[i]);
                }
            }

            foreach (var element in output)
            {
                Console.Write(element);
            }
        }
    }
}
