using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        //The first constructor should take no arguments and produce a person with name “No name” and age = 1.
        public Person()
            : this("No name", 1)
        {
        }
        //The second should accept only an integer number for the age and produce 
        //a person with name “No name” and age equal to the passed parameter.
        public Person(int age)
            : this("No name", age)
        {
        }
        //The third one should accept a string for the name and 
        //an integer for the age and should produce a person with the given name and age.
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Age}";
        }
    }
}
