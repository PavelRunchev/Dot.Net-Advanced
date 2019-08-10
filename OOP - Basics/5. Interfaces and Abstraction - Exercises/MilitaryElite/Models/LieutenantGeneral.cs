using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private ICollection<IPrivate> privates;

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<IPrivate>();
        }

        public ICollection<IPrivate> Privates
        {
            get => privates;
        }

        public void AddPrivate(IPrivate newPrivate)
        {
            this.privates.Add(newPrivate);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder
                .AppendLine(base.ToString())
                .AppendLine("Privates:");

            foreach (Private p in this.Privates)
            {
                builder.AppendLine($"  {p.ToString()}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}
