namespace Cars.Interfaces
{
    using System.Text;

    public abstract class Car : ICar
    {
        public string Model { get; protected set; }

        public string Color { get; protected set; }

        public Car(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Start()
        {
            return "Engine start!";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public virtual string GetInfo()
        {
            return $"{this.Color} {this.GetType().Name} {this.Model}";
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(this.GetInfo());
            stringBuilder.AppendLine(this.Start());
            stringBuilder.Append(this.Stop());

            return stringBuilder.ToString();
        }
    }
}
