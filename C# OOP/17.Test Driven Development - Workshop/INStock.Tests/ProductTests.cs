namespace INStock.Tests
{
    using INStock.Contracts;
    using NUnit.Framework;
    using System;

    public class ProductTests
    {
        [Test]
        public void Constructor_Should_Initialize_Correct_Values()
        {
            //label, price, quantity
            string label = "SSD";
            decimal price = 12.34m;
            int quantity = 3;

            IProduct product = new Product(label, price, quantity);

            Assert.AreEqual(label, product.Label);
            Assert.AreEqual(price, product.Price);
            Assert.AreEqual(quantity, product.Quantity);
        }

        [Test]
        public void Constructor_InvalidLabel_Should_Throw_Argument_Null_Exception()
        {
            string invalidLabel = null;
            decimal price = 12.34m;
            int quantity = 3;

            Assert.Throws<ArgumentNullException>(() => new Product(invalidLabel, price, quantity));
        }

        [Test]
        public void Constructor_InvalidPrice_Should_Throw_ArgumentException()
        {
            string label = "HDD";
            decimal invalidPrice = -1;
            int quantity = 3;

            Assert.Throws<ArgumentException>(() => new Product(label, invalidPrice, quantity));
        }

        [Test]
        public void Constructor_InvalidQuantity_Should_Throw_ArgumentException() 
        {
            string label = "HDD";
            decimal price = 14.25m;
            int invalidQuantity = -3;

            Assert.Throws<ArgumentException>(() => new Product(label, price, invalidQuantity));
        }

        [Test]
        public void Compare_To_Should_Return_Label_With_Greater_Ascii_Code()
        {
            var greaterProductLabel = "Zoom";
            var greaterProductPrice = 19.25m;
            var greaterProductQuantity = 2;

            var smallerProductLabel = "Do";
            var smallerProductPrice = 12.25m;
            var smallerProductQuantity = 3;

            var greaterProduct = new Product(greaterProductLabel, greaterProductPrice, greaterProductQuantity);
            var smallerProduct = new Product(smallerProductLabel, smallerProductPrice, smallerProductQuantity);

            var actualResult = greaterProduct.CompareTo(smallerProduct);
            var expectedResult = 1;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}