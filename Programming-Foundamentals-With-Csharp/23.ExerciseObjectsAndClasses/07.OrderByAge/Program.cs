using System.Security.Cryptography;

namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string ,Person> people = new Dictionary<string, Person>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split().ToArray();
                string name = arguments[0];
                string id = arguments[1];
                int age = int.Parse(arguments[2]);

                if (people.ContainsKey(id))
                {
                    people[id].Age = age;
                    people[id].Name = name;
                }
                else
                {
                    people[id] = new Person()
                    {
                        Name = name,
                        Age = age,
                        Id = id
                    };
                }
            }

            var sortedPeople = people.Values.OrderBy(p => p.Age);
            foreach (var kvp in sortedPeople)
            {
                Console.WriteLine($"{kvp.Name} with ID: {kvp.Id} is {kvp.Age} years old.");
            }
        }
    }

    class Person
    {
        public Person()
        {
        }
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }

    }
}
/* the input below ->
George 123456 20
Peter 78911 15
Stephen 524244 10
End
 */