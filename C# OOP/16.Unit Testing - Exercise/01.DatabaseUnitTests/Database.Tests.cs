using _01.Database;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        private Database database;

        [SetUp]
        //By default create new database collection.
        public void Setup()
        {
            this.database = new Database(1, 2, 3, 4, 5, 6);
        }

        [Test]
        public void Add_Method_Should_Throw_Exception_With_Invalid_Parameter()
        {
            for (int i = 0; i < 10; i++)
            {
                this.database.Add(45);
            }

            Assert.Throws<InvalidOperationException>(() => this.database.Add(458));
        }

        [Test]
        public void Add_Method_Should_Work_Correctly()
        {
            for (int i = 0; i < 5; i++)
            {
                this.database.Add(45);
            }

            Assert.That(11, Is.EqualTo(this.database.DatabaseElements.Length));
        }

        [Test]
        public void Remove_Method_Should_Throw_Exception_With_Empty_Database()
        {
            for (int i = 0; i < 6; i++)
            {
                this.database.Remove();
            }

            Assert.Throws<InvalidOperationException>(() => this.database.Remove());
        }

        [Test]
        public void Remove_Method_Should_Remove_One_Element()
        {
            this.database.Remove();

            Assert.That(5, Is.EqualTo(this.database.DatabaseElements.Length));
        }

        [Test]
        public void Constructor_Should_Initialize_Correctly()
        {
            this.database = new Database(1, 2, 3, 5);

            Assert.That(4, Is.EqualTo(this.database.DatabaseElements.Length));
        }

        [Test]
        // - empty constructor
        [TestCase()]
        //More than 16 elements in the collection
        [TestCase(1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0)]
        public void Constructor_Should_Throw_Exception(params int[] collection)
        {
            Assert.Throws<InvalidOperationException>(() => this.database = new Database(collection));
        }

        [Test]

        public void Property_Database_Elements_Should_Set_Correctly()
        {
            var collection = new List<int>() { 1, 2, 3, 4, 5, 6 };

            CollectionAssert.AreEqual(collection, this.database.DatabaseElements);
        }

        [Test]

        public void Property_Database_Elements_Should_Get_Correctly()
        {
            int expectedCount = 6;

            Assert.That(expectedCount, Is.EqualTo
                (this.database.DatabaseElements.Length));
        }
    }
}