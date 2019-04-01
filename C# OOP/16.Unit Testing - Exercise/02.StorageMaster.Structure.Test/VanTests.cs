namespace Tests
{
    using NUnit.Framework;
    using StorageMaster.Entities.Products;
    using StorageMaster.Entities.Vehicles;
    using System;
    using System.Linq;

    public class VanTests
    {
        private Vehicle van;

        [SetUp]
        public void Setup()
        {
            this.van = new Van();
        }

        [Test]
        public void Load_Method_For_Van_Should_Work_Correctly()
        {
            Product product = new Ram(2.57);

            this.van.LoadProduct(product);

            int expectedCount = 1;

            Product insertedProduct = this.van.Trunk.Last();

            Assert.That(expectedCount == this.van.Trunk.Count);

            Assert.That(product == insertedProduct);
        }

        [Test]
        public void Load_Method_Van_Should_Throw_Exception_When_Is_Full()
        {
            Product product = new Ram(2.57);
            //The trunk capacity is 20 items.
            for (int i = 0; i < 20; i++)
            {
                this.van.LoadProduct(product);
            }
            int expectedCount = 20;

            Assert.That(expectedCount == this.van.Trunk.Count);

            Assert.Throws<InvalidOperationException>(() =>this.van.LoadProduct(product));
        }

        [Test]
        public void UnLoad_Method_Van_Should_Throw_Exception_When_Is_Empty()
        {
            Assert.Throws<InvalidOperationException>(() => this.van.Unload());
        }

        [Test]
        public void UnLoad_Method_Van_Should_Works_Correctly()
        {
            Product product = new Ram(2.57);
            
            for (int i = 0; i < 5; i++)
            {
                this.van.LoadProduct(product);
            }

            Product lasrProduct = new HardDrive(3.25);

            this.van.LoadProduct(lasrProduct);

            Product resultProduct = this.van.Unload();

            int expectedCount = 5;

            Assert.That(expectedCount == this.van.Trunk.Count);
            Assert.That(lasrProduct == resultProduct);
        }

        [Test]
        public void Is_Empty_Returns_True()
        {
            var result = this.van.IsEmpty;

            Assert.IsTrue(result);
        }

        [Test]
        public void Is_Empty_Returns_False()
        {
            Product product = new Ram(2.35);

            this.van.LoadProduct(product);

            var result = this.van.IsEmpty;

            Assert.IsFalse(result);
        }

        [Test]
        public void Is_Full_Returns_True()
        {
            Product product = new HardDrive(2.35);

            this.van.LoadProduct(product);
            this.van.LoadProduct(product);

            var result = this.van.IsFull;

            Assert.IsTrue(result);
        }
        
        [Test]
        public void Is_Full_Returns_False()
        {
            var result = this.van.IsFull;

            Assert.IsFalse(result);
        }

        [Test]
        public void Capacity_Is_Set_Correctly()
        {
            Assert.IsTrue(2 == this.van.Capacity);
        }

        [Test]
        public void Trunk_Property_Returns_Correct_Data()
        {
            Assert.That(0 == this.van.Trunk.Count);
        }
    }
}