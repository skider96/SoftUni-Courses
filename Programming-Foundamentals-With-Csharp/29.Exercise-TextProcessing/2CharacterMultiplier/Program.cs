namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split();

            char[] firstStringChars = inputStrings[0].ToCharArray();
            char[] secondStringChars = inputStrings[1].ToCharArray();

            var sum = SumChars(inputStrings, secondStringChars, firstStringChars);

            Console.WriteLine(sum);
        }

        private static int SumChars(string[] inputStrings, char[] secondStringChars, char[] firstStringChars)
        {
            int n = inputStrings[0].Length >= inputStrings[1].Length ? inputStrings[0].Length : inputStrings[1].Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i >= inputStrings[0].Length)
                {
                    sum += secondStringChars[i];
                }
                else if (i >= inputStrings[1].Length)
                {
                    sum += firstStringChars[i];
                }
                else sum += firstStringChars[i] * secondStringChars[i];
            }

            return sum;
        }
    }
}
