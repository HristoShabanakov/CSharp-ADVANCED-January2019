namespace P02_CarsSalesman
{
    using System.Collections.Generic;

    public class CarSalesman
    {
        private CarFactory carFactory;
        private EngineFactory engineFactory;
        private List<Car> cars;
        private List<Engine> engines ;

        //Dependency injection
        public CarSalesman(CarFactory carFactory, EngineFactory engineFactory)
        {
            this.cars = new List<Car>();
            this.engines = new List<Engine>();
            this.carFactory = carFactory;
            this.engineFactory = engineFactory;
        }

        public void AddEngine(string[] parameters)
        {
            Engine engine = engineFactory.Create(parameters);

            engines.Add(engine);
        }

        public void AddCar(string[] parameters)
        {
            Car car = carFactory.Create(parameters, this.engines);

            cars.Add(car);
        }

        public List<Car> GetCars()
        {
            return this.cars;
        }
    }
}
