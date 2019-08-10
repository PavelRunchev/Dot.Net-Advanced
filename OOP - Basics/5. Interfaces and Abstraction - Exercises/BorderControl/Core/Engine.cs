using System;
using System.Collections.Generic;
using BorderControl.Interfaces;
using System.Linq;

namespace BorderControl.Core
{
    public class Engine
    {
        private ICollection<IIdentifiable> allEntriesInCity;

        public Engine()
        {
            this.allEntriesInCity = new List<IIdentifiable>();
        }

        public void Run()
        {
            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] parameters = input.Split();
                if(parameters.Length == 2)
                {
                    string robotName = parameters[0];
                    string robotId = parameters[1];
                    IIdentifiable robot = new Robot(robotName, robotId);
                    allEntriesInCity.Add(robot);
                }
                else if(parameters.Length == 3)
                {
                    string citizenName = parameters[0];
                    int citizenAge = int.Parse(parameters[1]);
                    string citizenId = parameters[2];
                    IIdentifiable citizen = new Citizen(citizenName, citizenAge, citizenId);
                    allEntriesInCity.Add(citizen);
                }
            }

            string fakeId = Console.ReadLine();
            //printed all citizen with fake id!
            print(fakeId);
        }

        private void print(string fakeId)
        {            
            foreach (IIdentifiable id in this.allEntriesInCity.Where(c => c.Id.EndsWith(fakeId)))
            {
                Console.WriteLine(id.Id);
            }
        }
    }
}
