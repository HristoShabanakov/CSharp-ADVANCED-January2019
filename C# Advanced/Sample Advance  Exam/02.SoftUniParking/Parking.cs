namespace SoftUniParking
{
    using System.Collections.Generic;

    public class Parking
    {
        private Dictionary<string, Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new Dictionary<string,Car>();
        }

        //returns the number of stored cars. Calculated property.
        public int Count { get => this.cars.Count;}

        //This method returns messages so it has to be public string
        public string AddCar(Car car)
        {
            //Checks if there is already a car with tha provided car registration number
            if (this.cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            //Checks if the count of the cars in the parking is more than the capacity.
            else if (this.cars.Count == this.capacity)
            {
                  return"Parking is full!";
            }
            //Just adds the current car to the cars in the parking
            else
            {
                this.cars.Add(car.RegistrationNumber, car);
            }
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!this.cars.ContainsKey(registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }

            this.cars.Remove(registrationNumber);

            return $"Successfully removed {registrationNumber}";
        }

        public Car GetCar(string registrationNumber)
        {
            //Returns the Car with the provided registration number 
            return this.cars[registrationNumber];
        }

        //Removes all cars having the provided registration numbers. Each car is removed only if the registration number exists.
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registrationNumber in registrationNumbers)
            {
                this.RemoveCar(registrationNumber);
            }
        }



    }
}
