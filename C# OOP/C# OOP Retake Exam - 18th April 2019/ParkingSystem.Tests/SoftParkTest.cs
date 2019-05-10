namespace ParkingSystem.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    [TestFixture]
    public class SoftParkTest
    {
        private Car car;
        public object First { get; private set; }

        [SetUp]
        public void Setup()
        {
            car = new Car("BMW", "myModel");
        }

        [Test]
        public void Constructor_ShouldSetPropertiesCorrectly()
        {
            Assert.AreEqual("BMW", car.Make);
            Assert.AreEqual("myModel", car.RegistrationNumber);
        }

        [Test]
        public void ParkCar_Should_Throw_ArgumentException()
        {
            SoftPark softPark = new SoftPark();

            Car car = new Car("BMW", "123");

            string parkSpot2 = "Z41";

            Assert.Throws<ArgumentException>(() => softPark.ParkCar(parkSpot2, car));
        }

        [Test]
        public void ParkCar_Should_Throw_ArgumentException_Null()
        {
            SoftPark softPark = new SoftPark();

            Car car = new Car("BMW", "Test");

            string parkSpot2 ="A1";
            softPark.ParkCar(parkSpot2, car);

            Assert.Throws<ArgumentException>(() => softPark.ParkCar(parkSpot2, car));
        }

        [Test]
        public void Remove_Car_Should_Throw_ArgumentException()
        {
            SoftPark softPark = new SoftPark();

            Car car = new Car("BMW", "123");

            string parkSpot2 = "Z41";

            Assert.Throws<ArgumentException>(() => softPark.RemoveCar(parkSpot2, car));
        }

        [Test]
        public void Remove_Car_Should_Throw_ArgumentException_Car_Does_Not_Exist()
        {
            SoftPark softPark = new SoftPark();

            Car car = new Car("BMW", "123");
            Car car2 = new Car("M1", "124");

            string parkSpot2 = "A1";

            Assert.Throws<ArgumentException>(() => softPark.RemoveCar(parkSpot2, car2));
        }

        [Test]
        public void Remove_Car_Should_Throw_ArgumentException_Car_Already_Parked()
        {
            SoftPark softPark = new SoftPark();

            Car car = new Car("BMW", "123");

            string parkSpot = "A3";
            string parkSpot2 = "B1";

            softPark.ParkCar(parkSpot, car);
            

            var carExists = softPark.Parking.GetType()
                .GetFields((BindingFlags)60)
                .FirstOrDefault(c => c.FieldType == typeof(Dictionary<string, Car>));

            var actualMake = ((Dictionary<string, Car>)carExists.GetValue(car)).First().Key;
            var actualNumber = ((Dictionary<string, Car>)carExists.GetValue(car)).First().Value;

            Assert.AreEqual("A3", actualMake);
            Assert.AreEqual("BMW", "123");

            //Assert.Throws<ArgumentException>(() => softPark.ParkCar(parkSpot2, car));
        }
    }
}