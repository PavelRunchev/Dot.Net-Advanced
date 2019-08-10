using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FootballTeamGenerator
{
    class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get => name;
            set {
                if (String.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public List<Player> Players
        {
            get => players;
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {           
            this.players = this.players.Where(p => p.Name != playerName).ToList();           
        }

        private double CalculateTeamRating()
        {
            double allPlayers = this.players.Sum(p => p.PlayerStats());
            return allPlayers;
        }

        public string TeamRating()
        {
            return $"{this.Name} - {this.CalculateTeamRating()}";
        }
    }
}
