

namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

   public class Person
    {
        public Person(string data)
        {
            if (int.TryParse(data[0].ToString(), out _))
            {
                this.BirthDate = data;
            }
            else
            {
                this.Name = data;
            }
        }

        public Person(string name, string birthdate)
        {
            this.Name = name;
            this.BirthDate = birthdate;
        }

        public string Name { get; set; }

        public string BirthDate { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.BirthDate}";
        }
    }
}
