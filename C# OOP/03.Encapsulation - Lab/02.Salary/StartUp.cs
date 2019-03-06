

namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var commandArgs = Console.ReadLine().Split();
                var person = new Person(commandArgs[0],
                    commandArgs[1],
                    int.Parse(commandArgs[2]),
                    decimal.Parse(commandArgs[3]));

                persons.Add(person);
            }
            var percentage = decimal.Parse(Console.ReadLine());

            persons.ForEach(p => p.IncreaseSalary(percentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
