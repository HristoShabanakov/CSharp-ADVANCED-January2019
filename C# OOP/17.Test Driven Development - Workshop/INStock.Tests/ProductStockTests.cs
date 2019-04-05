namespace INStock.Tests
{
    using INStock.Contracts;
    using NUnit.Framework;
    using System;

    public class ProductStockTests
    {
        private IProductStock productStock;
        [SetUp]
        public void SetUp()
        {
            this.productStock = new ProductStock();
        }
        //int Count { get; }

        //IProduct this[int index] { get; set; }

        //bool Contains(IProduct product);

        //void Add(IProduct product);

        //bool Remove(IProduct product);

        [Test]
        public void Constructor_Should_Initialize_The_Array()
        {
            var expectedValue = 4;
            var actualValue = this.productStock.Capacity;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Add_Should_Increase_Quantity_For_Products_With_Same_Label()
        {
            var label = "SSD";
            var price = 12.47m;
            var quantity = 2;

            var dummyProduct = new Product(label, price, quantity);
            var dummyProduct2 = new Product(label, price, quantity);


            productStock.Add(dummyProduct);
            productStock.Add(dummyProduct2);

            var expectedValue = 1;
            var actualValue = productStock.Count;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Add_Method_Should_Add_Successfully()
        {
            var label = "SSD";
            var price = 118.47m;
            var quantity = 2;

            var dummyProduct = new Product(label, price, quantity);

            productStock.Add(dummyProduct);


            var expectedValue = 1;
            var actualValue = productStock.Count;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Add_Should_Resize_When_Count_Is_Equal_To_Array_Length()
        {
            var products = new[]
            {
                new Product("Test1",12,12),
                new Product("Test2",12,12),
                new Product("Test3",12,12),
                new Product("Test4",12,12),
                new Product("Test5",12,12),
            };

            foreach (var product in products)
            {
                this.productStock.Add(product);
            }

            var expectedValue = 8;
            var actualValue = this.productStock.Capacity;

            Assert.AreEqual(expectedValue, actualValue);

        }
        [Test]
        public void Add_Should_Throw_Invalid_Operation_Exception_When_Null_Is_Passed()
        {
            Assert.Throws<InvalidOperationException>(() => this.productStock.Add(null));
        }

        [Test]
        public void Set_Invalid_Index_Should_Return_Index_Out_Of_Range_Exception()
        {
            var product = new Product("DummyLabel", 1, 2);

            Assert.Throws<IndexOutOfRangeException>(() => this.productStock[this.productStock.Capacity + 2] = product);
        }
    }
}
