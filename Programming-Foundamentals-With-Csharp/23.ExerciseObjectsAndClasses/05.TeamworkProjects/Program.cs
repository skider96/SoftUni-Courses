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

                string creator = input[0];
                string teamName = input[1];

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
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] commandSplited = command.Split("->");
                string member = commandSplited[0];
                string teamName = commandSplited[1];
                Teams team = teams.FirstOrDefault(t => t.TeamName == teamName);
                if (teams.Any(t => t.Member.Contains(member)) || teams.Any(t => t.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }
                else if (teams.Any(t => t.TeamName != teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else
                { 
                    team.Member.Add(member);
                }
            }
            List<Teams> disbandedTeamsList = teams.Where(t => t.Member.Count == 0)
                .ToList();
            teams = teams.Where(t => t.Member.Count > 0)
                .ToList();

            teams = teams.OrderByDescending(t => t.Member.Count)
                .ThenBy(t => t.TeamName)
                .ToList();

            disbandedTeamsList = disbandedTeamsList.OrderBy(t => t.TeamName).ToList();

            foreach (var team in teams)
            {
                Console.WriteLine($"${team.TeamName}\n- {team.Creator}\n-- {team.Member}…");
            }

            foreach (var team in disbandedTeamsList)
            {
                Console.WriteLine("Teams to disband:");
                Console.WriteLine($"{string.Join($"{team.TeamName}\n",disbandedTeamsList )}");
            }
        }
    }

    class Teams
    {
        public Teams(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Member = new List<string>();
        }
        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Member { get; set; }

    }
}
