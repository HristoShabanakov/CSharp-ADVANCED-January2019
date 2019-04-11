namespace AnimalCentre.Models.Procedures
{
    using AnimalCentre.Models.Contracts;

    public class NailTrim : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Happiness -= 7;
            
        }
    }
}
