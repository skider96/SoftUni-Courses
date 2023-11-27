namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a program that keeps the information about students and their grades.
You will receive n pair of rows. First, you will receive the student's name, after that, you will receive their grade.
Check if the student already exists and if not, add him. Keep track of all grades for each student.
When you finish reading the data, keep the students with an average grade higher than or equal to 4.50.
Print the students and their average grade in the following format:
"{name} –> {averageGrade}"
Format the average grade to the 2
nd decimal place.*/

            int n = int.Parse(Console.ReadLine());

        }
    }

    class Students
    {
        public Students(string studentName, double studentGrades)
        {
            StudentName = studentName;
            StudentGrades = studentGrades;
        }

        public string StudentName { get; set; }

        public double StudentGrades { get; set; }


    }
}
