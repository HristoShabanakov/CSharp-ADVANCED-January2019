namespace _03.Mankind
{
    using System;

    public class Startup
    {
        static void Main()
        {
            try
            {
                string[] studentArgs = Console.ReadLine().Split();

                string studentFirstName = studentArgs[0];
                string studentLastName = studentArgs[1];
                string facultyNumber = studentArgs[2];

                Student student = new Student(studentFirstName, studentLastName, facultyNumber);

                string[] workerArgs = Console.ReadLine().Split();

                string workerFirstName = workerArgs[0];
                string workerLastName = workerArgs[1];
                double salary = double.Parse(workerArgs[2]);
                double workedHoursPerday = double.Parse(workerArgs[3]);

                Worker worker = new Worker(workerFirstName, workerLastName, salary, workedHoursPerday);

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
