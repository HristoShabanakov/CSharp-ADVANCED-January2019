
namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        //The class should have a list of people.
        private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        //Method for adding members.
        public void AddMember(Person member)
        {
            this.people.Add(member);
        }

        //Method returning the oldest family member
        public Person GetOldestMember()
        {
            return this.people.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public List<Person> GetPeopleOverThirty()
        {
            return this.people.Where(x => x.Age > 30).ToList();
        }
    }
}
