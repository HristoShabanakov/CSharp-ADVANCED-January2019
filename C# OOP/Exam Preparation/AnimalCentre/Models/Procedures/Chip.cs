namespace AnimalCentre.Models.Procedures
{
    using System;
    using AnimalCentre.Models.Contracts;

    public class Chip : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.IsChipped)
            {
                throw new ArgumentException($"{animal.Name} is already chipped");
            }

            //Calling the default behavior from Procedure class.
            base.DoService(animal, procedureTime);

            animal.Happiness -= 5;
            animal.IsChipped = true;
        }
    }
}
