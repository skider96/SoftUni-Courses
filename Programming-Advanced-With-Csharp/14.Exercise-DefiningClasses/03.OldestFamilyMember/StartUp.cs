using DefiningClasses;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
          Family family = new();

            int number = int.Parse(Console.ReadLine());

            Person oldestPerson = new Person();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person member = new(name, age);

                family.AddMember(member);
            }

          oldestPerson =  family.GetOldestMember();

          Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
   
}
/*
3
Peter 3
George 4
Annie 5
 */
