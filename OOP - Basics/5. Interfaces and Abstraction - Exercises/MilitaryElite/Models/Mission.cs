using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interfaces;
using MilitaryElite.Enums;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        private string codeName;
        private State state;

        public Mission(string codeName, State state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName
        {
            get => codeName;
            private set => codeName = value;
        }

        public State State
        {
            get => state;
            private set => state = value;
        }

        public void CompleteMission()
        {
            this.State = State.Finished;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
