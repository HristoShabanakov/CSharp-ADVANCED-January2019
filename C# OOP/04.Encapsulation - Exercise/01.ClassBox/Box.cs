namespace _01.ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double CalculateSurfaceArea()
        {
            return 2 * (this.length * this.width) + this.CalculateLateralSurfaceArea();
        }

        public double CalculateLateralSurfaceArea()
        {
            return 2 * (this.length * this.height + this.width * this.height);
        }

        public double CalculateVolume()
        {
            return this.width * this.height * this.length;
        }
    }
}
