namespace Repository
{
    using System.Collections.Generic;

    public class Repository
    {
        //Data field, which stores entities from class Person.
        private Dictionary<int,Person> dataField;
        private int id;

        public Repository()
        {
            this.dataField = new Dictionary<int, Person>();
            this.id = 0;
        }

        public void Add(Person person)
        {
            this.dataField.Add(id, person);
            this.id++;
        }


        public int Count => this.dataField.Count;

        //Returns the entity with given ID.
        public Person Get(int id)
        {
            return this.dataField[id];
        }

        public bool Update(int id, Person newPerson)
        {
            if (this.dataField.ContainsKey(id))
            {
                this.dataField[id] = newPerson;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            if (this.dataField.ContainsKey(id))
            {
                this.dataField.Remove(id);
                return true;
            }

            return false;
        }

    }
}
