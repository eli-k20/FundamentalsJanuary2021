using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    class Team
    {
        public Team()
        {
            Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] teamData = Console.ReadLine()
                    .Split("-");

                string creator = teamData[0];
                string teamName = teamData[1];

                if (IsTeamExisting(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (IsCreatorExisting(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team()
                {
                    Creator = creator,
                    TeamName = teamName
                };

                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of assignment")
                {
                    break;
                }

                string[] userData = line.Split("->");

                string userName = userData[0];
                string teamName = userData[1];

                if (!IsTeamExisting(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (IsMember(teams, userName))
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                    continue;
                }

                Team existingTeam = GetTeamByName(teams, teamName);

                existingTeam.Members.Add(userName);
            }

            List<Team> sorted = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.TeamName)
                .ToList();

            foreach (var team in sorted)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");

                List<string> sortedMembers = team.Members
                    .OrderBy(m => m)
                    .ToList();

                foreach (var member in sortedMembers)
                {
                    Console.WriteLine($"-- {member}");
                }
            }


            List<Team> disbanded = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.TeamName)
                .ToList();

            Console.WriteLine($"Teams to disband:");
            foreach (var team in disbanded)
            {
                Console.WriteLine(team.TeamName);
            }

        }

        private static Team GetTeamByName(List<Team> teams, string teamName)
        {
            foreach (var team in teams)
            {
                if (team.TeamName == teamName)
                {
                    return team;
                }
            }

            return null;
        }

        private static bool IsMember(List<Team> teams, string userName)
        {
            foreach (var team in teams)
            {
                if (team.Creator == userName || 
                    team.Members.Contains(userName))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsCreatorExisting(List<Team> teams, string creator)
        {
            foreach (var team in teams)
            {
                if (creator == team.Creator)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsTeamExisting(List<Team> teams, string teamName)
        {
            foreach (var team in teams)
            {
                if (teamName == team.TeamName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
