using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P04_Hospital
{
    public class Department
    {
        private string name;
        private List<Room> rooms;

        public Department(string name)
        {
            this.Name = name;
            this.rooms = new List<Room>()
            {
                new Room(1),
                new Room(2),
                new Room(3),
                new Room(4),
                new Room(5),
                new Room(6),
                new Room(7),
                new Room(8),
                new Room(9),
                new Room(10),
                new Room(11),
                new Room(12),
                new Room(13),
                new Room(14),
                new Room(15),
                new Room(16),
                new Room(17),
                new Room(18),
                new Room(19),
                new Room(20),
            };
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public List<Room> Rooms
        {
            get => this.rooms;
            set => this.rooms = value;
        }

        public void AddPatient(string pacient)
        {
            foreach (Room room in this.rooms)
            {
                if (room.freeRoom())
                {
                    room.AddPacient(pacient);
                    return;
                }     
            }
        }
    }
}
