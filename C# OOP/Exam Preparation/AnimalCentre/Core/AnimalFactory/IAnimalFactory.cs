namespace AnimalCentre.Core.AnimalFactory
{
    using global::AnimalCentre.Models.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IAnimalFactory
    {
        IAnimal CreateAnimal(string type, string name, int energy, int happiness, int procedureTime);
    }
}
