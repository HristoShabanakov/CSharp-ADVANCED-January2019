

namespace DefiningClasses
{
    public class Connection
    {
        public Connection(Person parent, Person child)
        {
            this.Parent = parent;
            this.Child = child;
        }

        public Person Parent { get; set; }

        public Person Child { get; set; }


    }
}
