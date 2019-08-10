using System;

namespace Mankind
{
    class StartUp
    {
        static void Main()
        {
            try
            {
                string[] studentInfo = Console.ReadLine().Split();
                string studentFirstName = studentInfo[0];
                string studentLastName = studentInfo[1];
                string studentNumber = studentInfo[2];
                string[] workerInfo = Console.ReadLine().Split();

                string workerFirstName = workerInfo[0];
                string workerLastName = workerInfo[1];
                decimal weekSalary = decimal.Parse(workerInfo[2]);
                decimal hoursPerDay = decimal.Parse(workerInfo[3]);

                Student student = new Student(studentFirstName, studentLastName, studentNumber);
                Worker worker = new Worker(workerFirstName, workerLastName, weekSalary, hoursPerDay);

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch(ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                Environment.Exit(0);
            }       
        }
    }
}
