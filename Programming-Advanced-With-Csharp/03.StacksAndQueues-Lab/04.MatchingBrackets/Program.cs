
namespace _04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();

            Stack<int> indexes = new Stack<int>();

            List<string> results = new List<string>();
            for (int i = 0; i < chars.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (chars[i] == ')')
                {
                    var startIndex = indexes.Pop();
                    var endIndex = i;
                    string result = new (chars.Skip(startIndex).Take(endIndex - startIndex + 1).ToArray());

                    results.Add(result);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, results));
        }
    }
}