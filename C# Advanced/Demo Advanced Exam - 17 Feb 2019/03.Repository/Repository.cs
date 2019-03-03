using System.Collections.Generic;

namespace Repository
{
    public class Repository
    {
        //that has data field, which stores entities
        private Dictionary<int, Person> people;
        private int id;

        public Repository()
        {
            this.people = new Dictionary<int, Person>();
            this.id = 0;
        }
        public int Count => this.people.Count;

        public Dictionary<int, Person> People
        {
            get { return this.people; }
            set { this.people = value; }
        }

        public void Add(Person person)
        {
            this.people.Add(id++, person);
            //this.id++;
        }

        public Person Get(int id)
        {
            return this.people[id];
        }

        public bool Update(int id, Person newPerson)
        {
            if (this.people.ContainsKey(id))
            {
                this.people[id] = newPerson;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            if (this.people.ContainsKey(id))
            {
                this.people.Remove(id);
                return true;
            }
            return false;
        }
    }
}
