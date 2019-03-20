namespace PersonInfo.Interfaces
{
    using System;

    public class Citizen : IPerson, IBirthable, IIdentifiable
    {
        private string name;
        private int age;
        private string birthdate;
        private string id;


        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;

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

        public string Birthdate
        {
            get => this.birthdate;

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Birthday cannot be empty!");
                }
                this.birthdate = value;
            }
        }

        public string Id
        {
            get => this.id;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Id cannot be empty!");
                }
                this.id = value;
            }
        }
    }
}
