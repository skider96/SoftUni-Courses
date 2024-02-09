using System.Text.RegularExpressions;

namespace _02.Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string pattern = @"^(?<dolar>^\$|^\%)(?<tag>[A-z][a-z]{2,})\1: \[(?<firstNumber>\d*)]\|\[(?<secondNumber>\d*)]\|\[(?<thirdNumber>\d*)]\|$";
            
            Regex regex = new Regex(pattern);
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);
                if (match.Success)
                {
                    int[] numChars = new int[3];
                    Group group = match.Groups[3];
                    numChars[0] = int.Parse(group.Value);
                    group = match.Groups[4];
                    numChars[1] = int.Parse(group.Value);
                    group = match.Groups[5];
                    numChars[2] = int.Parse(group.Value);
                    char[] chars = new char[3];
                    for (int j = 0; j < 3; j++)
                    {
                        chars[j] = (char)numChars[j];
                    }
                    string charsToString = new string(chars);

                    Console.WriteLine($"{match.Groups["tag"].Value}: {charsToString}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}

/*
4
$Request$: [73]|[115]|[105]|
%Taggy$: [73]|[73]|[73]|
%Taggy%: [118]|[97]|[108]|
$Request$: [73]|[115]|[105]|[32]|[75]|
 */
