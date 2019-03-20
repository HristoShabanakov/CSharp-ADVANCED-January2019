namespace Cars.Interfaces
{
    public class Tesla : Car, IElectricCar
    {
        public Tesla(string model, string color, int batteries)
            : base(model, color)
        {
            this.Batteries = batteries;
        }

        public int Batteries { get; private set; }

        public override string ToString()
        {
            return $"{base.GetInfo()} with {this.Batteries} Batteries";
        }
    }
}
