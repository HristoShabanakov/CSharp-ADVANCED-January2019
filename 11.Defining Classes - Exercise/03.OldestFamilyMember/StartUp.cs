

namespace DefiningClasses
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            int memberCount = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < memberCount; i++)
            {
                string [] personArgs = Console.ReadLine().Split();

                string name = personArgs[0];
                int age = int.Parse(personArgs[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            Person oldestMember = family.GetOldestMember();

            Console.WriteLine(oldestMember);
        }
    }
}
