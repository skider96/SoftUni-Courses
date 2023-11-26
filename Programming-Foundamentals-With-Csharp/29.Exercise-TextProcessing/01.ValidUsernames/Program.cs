namespace _1.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();

            foreach (var username in input)
            {
                if (username.Length is >= 3 and <= 16)
                {

                    if (username.All(c => char.IsLetterOrDigit(c) || c == '-' || c == '_'))
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
