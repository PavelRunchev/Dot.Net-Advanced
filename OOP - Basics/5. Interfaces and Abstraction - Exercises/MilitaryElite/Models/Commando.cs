using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interfaces;
using MilitaryElite.Enums;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private ICollection<IMission> missions;

        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public ICollection<IMission> Missions
        {
            get => missions;
            set => missions = value;
        }

        public void AddMission(Mission newMission)
        {
            this.missions.Add(newMission);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(base.ToString())
                .AppendLine($"Corps: {base.Corps}")
                .AppendLine("Missions:");
            foreach (IMission mission in this.Missions)
            {
                builder.AppendLine($"  Code Name: {mission.CodeName} State: {mission.State}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}
