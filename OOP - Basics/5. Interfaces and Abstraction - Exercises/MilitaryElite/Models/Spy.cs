using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    class Spy : Soldier, ISpy
    {
        private int codeNumber;

        public Spy(int id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber
        {
            get => codeNumber;
            private set => codeNumber = value;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            return builder
                .AppendLine(base.ToString())
                .AppendLine($"Code Number: {this.CodeNumber}")
                .ToString()
                .TrimEnd();
        }
    }
}
