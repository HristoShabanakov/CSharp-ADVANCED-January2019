

namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            string dateOrName = Console.ReadLine();

            List<Connection> connections = new List<Connection>();
            List<Person> peopleInfo = new List<Person>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input.Contains("-"))
                {
                    string[] splitedInput = input.Split(" - ");

                    string parentArgument = splitedInput[0];
                    string childArgument = splitedInput[1];

                    Person parent = new Person(parentArgument);
                    Person child = new Person(childArgument);

                    Connection connection = new Connection(parent, child);

                    connections.Add(connection);
                }
                else
                {
                    string[] splitedInput = input.Split();

                    string name = $"{splitedInput[0]} {splitedInput[1]}";
                    string birthdate = splitedInput[2];

                    Person person = new Person(name, birthdate);

                    peopleInfo.Add(person);
                }

                input = Console.ReadLine();
            }

            Person mainPerson = peopleInfo
                .FirstOrDefault(x => x.BirthDate == dateOrName || x.Name == dateOrName);

            var filteredConnections = connections
                .Where(x => x.Parent.BirthDate == mainPerson.BirthDate
                || x.Child.BirthDate == mainPerson.BirthDate
                || x.Parent.Name == mainPerson.Name
                || x.Child.Name == mainPerson.Name)
                .ToList();

            Result result = new Result();

            result.MainPerson = mainPerson;

            foreach (var connection in filteredConnections)
            {
                bool isChildByDate = connection.Child.BirthDate == mainPerson.BirthDate;
                bool isChildByName = connection.Child.Name == mainPerson.Name;

                bool isParentByDate = connection.Parent.BirthDate == mainPerson.BirthDate;
                bool isParentByName = connection.Parent.Name == mainPerson.Name;

                if (isChildByDate || isChildByName)
                {
                    Person parent = peopleInfo.FirstOrDefault(x => x.Name == connection.Parent.Name
                    || x.BirthDate == connection.Parent.BirthDate);

                    result.Parents.Add(parent);
                }
                else if (isParentByDate || isParentByName)
                {
                    Person child = peopleInfo.FirstOrDefault(x => x.Name == connection.Child.Name
                    || x.BirthDate == connection.Child.BirthDate);

                    result.Children.Add(child);
                }
            }
            Console.WriteLine(result);
        }
    }
}
