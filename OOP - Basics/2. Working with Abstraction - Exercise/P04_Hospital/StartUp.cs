using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class StartUp
    {
        public static void Main()
        {
            Hospital hospital = new Hospital();
            string inputPatient;
            while ((inputPatient = Console.ReadLine()) != "Output")
            {
                string[] arguments = inputPatient.Split();
                var departamentName = arguments[0];
                var doctorName = arguments[1] + " " + arguments[2];
                var pacient = arguments[3];

                Department currentDepartment = hospital.Departmens.FirstOrDefault(d => d.Name == departamentName);
                if(currentDepartment == null)
                {
                    currentDepartment = new Department(departamentName);
                    hospital.AddDepartment(currentDepartment);
                }

                currentDepartment.AddPatient(pacient);

                Doctor currentDoctor = hospital.Doctors.FirstOrDefault(d => d.Name == doctorName);
                if (currentDoctor == null)
                {
                    currentDoctor = new Doctor(doctorName);
                    hospital.Doctors.Add(currentDoctor);
                }

                currentDoctor.AddPacient(pacient);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    string departmentName = args[0];
                    Department currentDepartment = hospital.Departmens.FirstOrDefault(d => d.Name == departmentName);
                    if(currentDepartment != null)
                    {
                        foreach (Room room in currentDepartment.Rooms)
                        {
                            foreach (string pacient in room.Pacients)
                            {
                                if(pacient != null)
                                    Console.WriteLine(pacient);
                            }
                        }
                    }
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int roomName))
                {
                    string departmentName = args[0];
                    Department currentDepartment = hospital.Departmens.FirstOrDefault(d => d.Name == departmentName);
                    if (currentDepartment != null)
                    {
                        Room currentRoom = currentDepartment.Rooms.FirstOrDefault(r => r.Name == roomName);
                        foreach (string patient in currentRoom.Pacients.OrderBy(p => p))
                        {
                            if (patient != null)
                                Console.WriteLine(patient);
                        }
                    }
                }
                else
                {
                    string doctorName = args[0] + " " + args[1];
                    Doctor currentDoctor = hospital.Doctors.FirstOrDefault(d => d.Name == doctorName);
                    if (currentDoctor != null)
                    {
                        foreach (string patientOfDoctor in currentDoctor.Pacients.OrderBy(p => p))
                        {
                            if (patientOfDoctor != null)
                                Console.WriteLine(patientOfDoctor);
                        }
                    }
                }
            }
        }
    }
}
