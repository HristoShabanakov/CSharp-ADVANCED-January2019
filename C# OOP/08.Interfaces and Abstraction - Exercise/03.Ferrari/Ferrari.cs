namespace _03.Ferrari
{
    public class Ferrari :ICar
    {
        public Ferrari(string driverName)
        {
            this.Driver = driverName;
        }

        public string Model => "488-Spider";
        
        public string Driver { get; private set; }
        

        public string Brakes()
        {
            return "Brakes!";
        }

        public string GasPedal()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.Brakes()}/{this.GasPedal()}/{this.Driver}";
        }
    }
}
