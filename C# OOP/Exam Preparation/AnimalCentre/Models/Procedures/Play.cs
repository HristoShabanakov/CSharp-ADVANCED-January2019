﻿namespace AnimalCentre.Models.Procedures
{
    using AnimalCentre.Models.Contracts;

    public class Play : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Energy -= 6;
            animal.Happiness += 12;
           
        }
    }
}
