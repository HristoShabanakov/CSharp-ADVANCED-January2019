﻿

namespace P01_RawData
{
    public class Car
    {
        //Fields
        

        //Constructor
        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }

        //Properties 
        public Engine Engine { get; private set; }

        public Cargo Cargo { get;  private set; }

        public Tire[] Tires { get; private set; }

        public string Model { get; private set; }
    }
}
