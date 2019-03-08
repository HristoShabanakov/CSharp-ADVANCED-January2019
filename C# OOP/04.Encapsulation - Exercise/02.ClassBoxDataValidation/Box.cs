namespace _02.ClassBoxDataValidation
{
    using System;

    public class Box
    {
        //Fields
        private double length;
        private double width;
        private double height;

        //When having validations the constructor should pass through out properties, not fields.
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        //Property
        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                this.ValidateParameter(value, nameof(this.Length));
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                this.ValidateParameter(value, nameof(this.Width));
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                this.ValidateParameter(value, nameof(this.Height));
                this.height = value;
            }
        }

        private void ValidateParameter(double value, string parameterName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{parameterName} cannot be zero or negative.");
            }
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


