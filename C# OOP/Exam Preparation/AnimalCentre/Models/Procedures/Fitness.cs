namespace AnimalCentre.Models.Procedures
{
    using AnimalCentre.Models.Contracts;


    public class Fitness : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Happiness -= 3;
            animal.Energy += 10;
            
        }
    }
}
