namespace OpinionPoll
{
    public class OpinionPoll
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                personList.Add(person);
            }

            personList = personList.FindAll(a => a.Age > 30).OrderBy(p => p.Name).ToList();

            foreach (var person in personList)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
