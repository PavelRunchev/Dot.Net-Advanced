using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Room
    {
        private int name;
        private List<string> pacients;

        public Room(int name)
        {
            this.Name = name;
            this.Pacients = new List<string>();
        }

        public int Name
        {
            get => name;
            set => name = value;
        }

        public List<string> Pacients
        {
            get => pacients;
            set => pacients = value;
        }

        public bool freeRoom()
        {
            return this.Pacients.Count < 3;
        }

        public void AddPacient(string pacient)
        {
            if(freeRoom())
            {
                this.pacients.Add(pacient);
            }
        }
    }
}
