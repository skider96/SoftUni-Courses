namespace _4.SoftUniPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int usersCount = int.Parse(Console.ReadLine());
            Dictionary<string, User> users = new Dictionary<string, User>();

            for (int i = 0; i < usersCount; i++)
            {
                // "register {username} {licensePlateNumber}

                string[] arguments = Console.ReadLine().Split();

                string command = arguments[0];
                string username = arguments[1];
                string licensePlate = "";
                if (arguments.Length > 2)
                {
                    licensePlate = arguments[2];
                }

                // 
                // "{username} registered {licensePlateNumber} successfully"
                User userInfo = new User(username, licensePlate);

                if (command == "register")
                {
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, userInfo);
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                }
                else if (command == "unregister")
                {
                    if (!users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        users.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value.LicensePlate}");
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

/*
5
register John CS1234JS
register George JAVA123S
register Andy AB4142CD
register Jesica VR1223EE
unregister Andy
 */
