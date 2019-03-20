namespace PersonInfo
{
    using System;

    public class Citizen : IPerson
    {
        private string name;
        private int age;

        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name
        {
            get => this.name;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get => this.age;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be zero or negative!");
                }
                this.age = value;
            }
        }
    }
}
