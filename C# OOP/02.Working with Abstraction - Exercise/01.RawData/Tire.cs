
namespace P01_RawData
{
    public class Tire
    {
        //Field
        private int age;

        //Constructor
        public Tire(double pressure, int age)
        {
            this.Pressure = pressure;
            this.age = age;
        }

        //Property
        public double Pressure { get; private set; }

    }
}
