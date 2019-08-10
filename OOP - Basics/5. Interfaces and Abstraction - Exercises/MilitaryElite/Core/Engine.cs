using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Models;
using MilitaryElite.Interfaces;
using MilitaryElite.Enums;
using System.Linq;

namespace MilitaryElite.Core
{
    public class Engine
    {
        private ICollection<Soldier> soldiers;

        public Engine()
        {
            this.soldiers = new List<Soldier>();
        }

        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                String[] commands = input.Split();
                string command = commands[0];
             
                if(command == "Private")
                {
                    int id = int.Parse(commands[1]);
                    string firstName = commands[2];
                    string lastName = commands[3];
                    decimal salary = decimal.Parse(commands[4]);
                    Private soldier = new Private(id, firstName, lastName, salary);
                    this.soldiers.Add(soldier);
                }
                else if(command == "LieutenantGeneral")
                {
                    int id = int.Parse(commands[1]);
                    string firstName = commands[2];
                    string lastName = commands[3];
                    decimal salary = decimal.Parse(commands[4]);
                    LieutenantGeneral general = new LieutenantGeneral(id, firstName, lastName, salary);
                    foreach  (string privateId in commands.Skip(5))
                    {
                        IPrivate getId = (IPrivate)this.soldiers.SingleOrDefault(i => i.Id == int.Parse(privateId));
                        if(getId != null)
                            general.AddPrivate(getId);
                    }
                    this.soldiers.Add(general);
                }
                else if(command == "Engineer")
                {
                    int id = int.Parse(commands[1]);
                    string firstName = commands[2];
                    string lastName = commands[3];
                    decimal salary = decimal.Parse(commands[4]);
                    if (Enum.TryParse<Corps>(commands[5], out Corps corps))
                    {
                        Engineer enginner = new Engineer(id, firstName, lastName, salary, corps);
                        string[] repairParts = commands.Skip(6).ToArray();
                        for (int i = 0; i < repairParts.Length; i += 2)
                        {
                            string repairPart = repairParts[i];
                            int repairHour = int.Parse(repairParts[i + 1]);
                            Repair repair = new Repair(repairPart, repairHour);
                            enginner.AddRepair(repair);
                        }

                        this.soldiers.Add(enginner);
                    }                        
                }

                else if(command == "Commando")
                {
                    int id = int.Parse(commands[1]);
                    string firstName = commands[2];
                    string lastName = commands[3];
                    decimal salary = decimal.Parse(commands[4]);
                    if (Enum.TryParse<Corps>(commands[5], out Corps corps))
                    {
                        Commando soldier = new Commando(id, firstName, lastName, salary, corps);
                        string[] missions = commands.Skip(6).ToArray();
                        for (int i = 0; i < missions.Length; i += 2)
                        {
                            string missionName = missions[i];
                            string missionState = missions[i + 1];
                            if(Enum.TryParse(missionState, out State state))
                            {
                                Mission mission = new Mission(missionName, state);
                                soldier.AddMission(mission);
                            }                                
                        }

                        this.soldiers.Add(soldier);
                    }
                }
                else if(command == "Spy")
                {
                    int id = int.Parse(commands[1]);
                    string firstName = commands[2];
                    string lastName = commands[3];
                    int codeNumber = int.Parse(commands[4]);
                    Spy soldier = new Spy(id, firstName, lastName, codeNumber);
                    this.soldiers.Add(soldier);
                }
            }

            print();
        }

        private void print()
        {
            foreach (Soldier soldier in this.soldiers)
            {
                Console.WriteLine(soldier.ToString());
            }
        }
    }
}
