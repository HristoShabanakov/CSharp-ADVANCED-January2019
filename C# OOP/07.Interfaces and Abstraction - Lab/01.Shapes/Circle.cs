namespace Shapes
{
    using System;
    using System.Text;

    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius
        {
            get => this.radius;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius cannot be zero or negative!");
                }
                this.radius = value;
            }
        }

        public string Draw()
        {
            var stringBuilder = new StringBuilder();

            double rIn = this.Radius - 0.4;
            double rOut = this.Radius + 0.4;

            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        stringBuilder.Append("*");
                    }

                    else
                    {
                        stringBuilder.Append(" ");
                    }
                }
                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }
    }
}
