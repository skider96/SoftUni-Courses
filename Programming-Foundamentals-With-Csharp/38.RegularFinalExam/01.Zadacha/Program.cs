using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _01.Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputedString = Console.ReadLine();
            if (inputedString == null)
            {
                return;
            }
            string command;
            while ((command = Console.ReadLine()) != "done")
            {
                if (command == null)
                {
                    return;
                }
                string[] arguments = command.Split().ToArray();

                string action = arguments[0];
                if (arguments.Length == 3 && action == "Change")
                {
                    string chars = arguments[1];
                    string replacement = arguments[2];
                    inputedString = inputedString.Replace(chars, replacement);
                    Console.WriteLine(inputedString);
                }
                if (arguments.Length == 2 && action == "Includes")
                {
                    string substring = arguments[1];
                    bool isIncluded = inputedString.Contains(substring);
                    Console.WriteLine(isIncluded);
                }
                if (arguments.Length == 2 && action == "End")
                {
                    string ending = arguments[1];
                    bool isEnding = inputedString.EndsWith(ending);
                    Console.WriteLine(isEnding);
                }
                if (arguments.Length == 1 && action == "Uppercase")
                {
                    inputedString = inputedString.ToUpper();
                    Console.WriteLine(inputedString);
                }
                if (arguments.Length == 2 && action == "FindIndex")
                {
                    char searchedChar = char.Parse(arguments[1]);
                    int foundIndex = inputedString.IndexOf(searchedChar);
                    Console.WriteLine(foundIndex);
                }
                if (arguments.Length == 3 && action == "Cut")
                {
                    int startIndex = int.Parse(arguments[1]);
                    int count = int.Parse(arguments[2]);
                    string cutSubstring = inputedString.Substring(startIndex, count);
                    Console.WriteLine(cutSubstring);
                }
            }
        }
    }
}
/*
//Th1s 1s my str1ng!//
Change 1 i
Includes string
End my
Uppercase
FindIndex I
Cut 5 5
Done
 */