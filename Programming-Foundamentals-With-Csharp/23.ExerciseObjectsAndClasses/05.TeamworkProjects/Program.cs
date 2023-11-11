using System.ComponentModel;

namespace _05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            List<Teams> teams = new List<Teams>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] input = Console.ReadLine().Split("-");

                string teamName = input[0];
                string creator = input[1];

                Teams team = new Teams(teamName, creator);
                if (teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    teams.Add(team);
                }

                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }


            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] commandSplited = command.Split("->");
                string member = commandSplited[0];
                string teamName = commandSplited[1];

                if (teams.Any(t => t.Member.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }
                else if (teams.Any(t => t.TeamName != teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else
                {
                    
                }
                
           
            }
        }
    }

    class Teams
    {
        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Member { get; set; }

        public Teams(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Member = new List<string>();
        }
    }
}
