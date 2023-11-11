using System.Collections.Generic;
using System.Linq;
namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> studentsList = new List<Students>();

            for (var i = 0; i < n; i++)
            {
                string[] inputOfStudent = Console.ReadLine().Split();
                string firstName = inputOfStudent[0];
                string lastName = inputOfStudent[1];
                float grade = float.Parse(inputOfStudent[2]);
                studentsList.Add(new Students(firstName, lastName, grade));
            }

            studentsList = studentsList.OrderByDescending(students=> students.Grade).ToList();

            foreach (var student in studentsList)
            {
                System.Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }

        public Students(string firstName, string lastName, float grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        
    }
}