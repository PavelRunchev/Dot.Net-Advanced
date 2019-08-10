using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Hospital
    {
        private List<Department> departments;
        private List<Doctor> doctors;

        public Hospital()
        {
            this.departments = new List<Department>();
            this.doctors = new List<Doctor>();
        }

        public List<Department> Departmens
        {
            get => departments;
        }

        public List<Doctor> Doctors
        {
            get => doctors;
        }

        public void AddDepartment(Department department)
        {
            this.departments.Add(department);
        }

        public void AddDoctors(Doctor doctor)
        {
            this.doctors.Add(doctor);
        }
    }
}
