
namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Result
    {
        public Result()
        {
            this.Parents = new List<Person>();
            this.Children = new List<Person>();
        }

        public Person MainPerson { get; set; }

        public List<Person> Parents { get; set; }

        public List<Person> Children { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(MainPerson.ToString());
            stringBuilder.AppendLine("Parents:");

            if (Parents.Any())
            {
                stringBuilder.AppendLine(string.Join(Environment.NewLine, Parents));
            }
            
            stringBuilder.AppendLine("Children:");
            stringBuilder.AppendLine(string.Join(Environment.NewLine, Children));

            return stringBuilder.ToString().TrimEnd();
        }

    }
}
