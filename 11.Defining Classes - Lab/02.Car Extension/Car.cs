using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Car_Extension
{
    class Car
    {
        private string make;

        private string model;

        private int year;

        private double fuelQuantity;

        private double fuelConsumption;


        public string Model { get; set; }

        public int Year { get; set; }

        public string Make { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        //Method
        public void Drive(double distance)
        {
            var canContinue = this.FuelQuantity - this.FuelConsumption * distance / 100 >= 0;

            if (canContinue)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
            }
            else
            {
                throw new InvalidOperationException("Not enough fuel!");
            }
        }

        public string GetInformation()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Make: { this.Make}");
            result.AppendLine($"Model: { this.Model}");
            result.AppendLine($"Year: { this.Year}");
            result.Append($"Fuel: { this.FuelQuantity:f2}L");
            return result.ToString();
        }
    }
}
