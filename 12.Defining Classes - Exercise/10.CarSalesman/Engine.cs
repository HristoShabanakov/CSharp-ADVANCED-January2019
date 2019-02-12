
namespace DefiningClasses
{
    using System.Text;

    public class Engine
    {
        //Creating a constructor
        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement)
            : this(model, power, displacement, "n/a")
        {
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power, -1, efficiency)
        {
        }

        public Engine(string model, int power)
            : this(model, power, -1, "n/a")
        {
        }

        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"  {this.Model}:");
            stringBuilder.AppendLine($"    Power: {this.Power}");

            stringBuilder.AppendLine(this.Displacement == -1
                ? $"    Displacement: n/a"
                : $"    Displacement: {this.Displacement}");

            stringBuilder.Append($"    Efficiency: {this.Efficiency}");

            return stringBuilder.ToString();
        }
    }
}
