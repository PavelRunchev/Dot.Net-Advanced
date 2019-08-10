using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Doctor
    {
        private string name;
        private List<string> pacients;

        public Doctor(string name)
        {
            this.Name = name;
            this.Pacients = new List<string>();
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public List<string> Pacients
        {
            get => pacients;
            set => pacients = value;
        }

        public void AddPacient(string pacient)
        {
            this.pacients.Add(pacient);
        }
    }
}
