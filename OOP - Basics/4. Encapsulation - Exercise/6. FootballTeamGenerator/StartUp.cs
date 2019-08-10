using System;
using System.Linq;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    class StartUp
    {
        static void Main()
        {
            try
            {
                List<Team> teams = new List<Team>();
                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] tokens = input.Split(";");
                    string teamName = tokens[1];
                    if (tokens[0] == "Team")
                    {
                        if(teams.Any(t => t.Name == teamName))
                        {
                            continue;
                        }
                        else
                        {
                            try
                            {
                                Team team = new Team(teamName);
                                teams.Add(team);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }                         
                        }                  
                    }
                    else if (tokens[0] == "Add")
                    {
                        if(!teams.Any(t => t.Name == teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }

                        string playerName = tokens[2];                      
                        int endurance = int.Parse(tokens[3]);                       
                        int sprint = int.Parse(tokens[4]);                     
                        int dribble = int.Parse(tokens[5]);                       
                        int passing = int.Parse(tokens[6]);                       
                        int shooting = int.Parse(tokens[7]);
                       
                        try
                        {
                            Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                            Team currentTeam = teams.FirstOrDefault(t => t.Name == teamName);
                            currentTeam.AddPlayer(player);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (tokens[0] == "Remove")
                    {
                        if (!teams.Any(t => t.Name == teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }

                        Team currentTeam = teams.FirstOrDefault(t => t.Name == teamName);
                        string playerName = tokens[2];

                        if (!currentTeam.Players.Any(p => p.Name == playerName))
                        {
                            Console.WriteLine($"Player {playerName} is not in {teamName} team.");
                            continue;
                        }

                        
                        currentTeam.RemovePlayer(playerName);                    
                    }
                    else if (tokens[0] == "Rating")
                    {
                        if (!teams.Any(t => t.Name == teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }

                        Team currentTeam = teams.FirstOrDefault(t => t.Name == teamName);
                        Console.WriteLine(currentTeam.TeamRating());                     
                    }
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }          
        }
    }
}