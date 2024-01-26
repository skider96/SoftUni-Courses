namespace _01.UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> uniqueUsernames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                uniqueUsernames.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join("\n", uniqueUsernames));
            //TO BE CHECKED
        }
    }
}
