using DefiningClasses;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person firstPerson = new()
            {
                Age = 20,
                Name = "Peter"
            };

            Person secondPerson = new();

            Person thirdPerson = new("Ivan", 25);
        }
    }
}
