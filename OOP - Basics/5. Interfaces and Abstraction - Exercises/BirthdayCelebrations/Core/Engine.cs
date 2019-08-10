using System;
using System.Collections.Generic;
using System.Text;
using BirthdayCelebrations.Interfaces;
using System.Linq;

namespace BirthdayCelebrations.Core
{
    public class Engine
    {
        private ICollection<IBirthable> data;
        private ICollection<IIdentifiable> dataRobots;

        public Engine()
        {
            this.data = new List<IBirthable>();
            this.dataRobots = new List<IIdentifiable>();
        }

        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] parameters = input.Split();
                string type = parameters[0];
                string name = parameters[1];

                if(type == "Citizen")
                {
                    int age = int.Parse(parameters[2]);
                    string id = parameters[3];
                    string date = parameters[4];
                    IBirthable citizen = new Citizen(name, age, id, date);
                    data.Add(citizen);
                }
                else if(type == "Robot")
                {
                    string id = parameters[2];
                    IIdentifiable robot = new Robot(name, id);
                    dataRobots.Add(robot);
                }
                else if(type == "Pet")
                {
                    string birthdate = parameters[2];
                    IBirthable pet = new Pet(name, birthdate);
                    data.Add(pet);
                }
            }

            string specificYear = Console.ReadLine();
            List<IBirthable> outputWithSpecificYear = this.data.Where(a => a.Birthdate.EndsWith(specificYear)).ToList();
               
            foreach (IBirthable individ in outputWithSpecificYear)
            {
                Console.WriteLine(individ.Birthdate);
            }
        }
    }
}
