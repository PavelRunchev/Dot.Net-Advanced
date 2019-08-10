using MilitaryElite.Interfaces;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private ICollection<IRepair> repairs;

        public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<IRepair>();
        }

        public ICollection<IRepair> Repairs
        {
            get => repairs;
        }

        public void AddRepair(IRepair newRepair)
        {
            this.repairs.Add(newRepair);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(base.ToString())
                .AppendLine($"Corps: {base.Corps}")
                .AppendLine("Repairs:");
            foreach (Repair repair in this.Repairs)
            {
                builder.AppendLine($"  Part Name: {repair.PartName} Hours Worked: {repair.HoursWorked}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}
