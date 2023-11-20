using System.Collections.Generic;
namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionaryCourses = new Dictionary<string, List<string>>();
            string command;
            List<string> studentsNameList = new List<string>();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split(" : ");
                string courseName = arguments[0];
                string studentName = arguments[1];

                if (!dictionaryCourses.ContainsKey(courseName))
                {
                    dictionaryCourses.Add(courseName, new List<string>());
                }
                dictionaryCourses[courseName].Add(studentName);
            }

            foreach (var kvp in dictionaryCourses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                Console.WriteLine($"-- {string.Join("\n-- ", kvp.Value)}");
            }
        }
    }
}
/*
Programming Fundamentals : John Smith
Programming Fundamentals : Linda Johnson
JS Core : Will Wilson
Java Advanced : Harrison White
end
 */