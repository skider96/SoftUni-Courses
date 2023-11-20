namespace _4.SoftUniPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int usersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < usersCount; i++)
            {
                // "register {username} {licensePlateNumber}

                string[] arguments = Console.ReadLine().Split();

                string command = arguments[0];
                string username = arguments[1];
                if (arguments.Length > 2)
                {
                    string licensePlate = arguments[2];
                }
            }
        }
    }
    public class User
    {
        public string UserName { get; set; }

        public string LicensePlate { get; set; }

        public User(string userName, string licensePlate)
        {
            UserName = userName;
            LicensePlate = licensePlate;
        }
    }
}
