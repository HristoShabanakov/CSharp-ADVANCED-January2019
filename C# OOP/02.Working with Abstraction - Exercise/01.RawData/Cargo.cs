

namespace P01_RawData
{
    public class Cargo
    {
        private int weight;

        public Cargo(int weight, string type)
        {
            this.weight = weight;
            this.Type = type;
        }

        public string Type { get; private set; }
    }
}
