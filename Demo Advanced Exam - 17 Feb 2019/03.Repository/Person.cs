

namespace Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        public Person(string name, int age, DateTime birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.BirthDate = birthdate;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }

       


        
    }
}
