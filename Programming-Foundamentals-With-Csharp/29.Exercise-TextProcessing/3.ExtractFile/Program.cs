namespace _3.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\', '.');

            string fileName = input[input.Length - 2];
            string extensionType = input[input.Length - 1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extensionType}");
        }
    }
}
/*
 C:\Internal\training-internal\Template.pptx
 */
