namespace BankAccount.Tests
{
    using System;
    using NUnit.Framework;
    
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Constructor_Should_Set_Proper_Values()
        {
            string name = "Gosho";
            decimal balance = 345.54m;

            var bankAccount = new BankAccount(name,balance);

            Assert.AreEqual(name, bankAccount.Name);
            Assert.AreEqual(balance, bankAccount.Balance);
        }

        [Test]
        [TestCase("1", 3450.34)]
        [TestCase("StringWithLengthMoreThan25SymbolsWow!!!!!!", 3450.34)]
        public void Constructor_Should_Throw_Argument_Exception_Invalid_Name_Length(string name, decimal balance)
        {
            Assert.Throws<ArgumentException>(() => new BankAccount(name, balance));
        }

        [Test]
        [TestCase("Gosho",-1)]
        [TestCase("Pesho", - 20)]
        public void Constructor_Should_Throw_Argument_Exception_Invalid_Balance(string name, decimal balance)
        {
            Assert.Throws<ArgumentException>(() => new BankAccount(name, balance));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        public void Deposit_Should_Throw_Invalid_Operation_Exception_Invalid_Amount(decimal amount)
        {
            string name = "Gosho";
            decimal balance = 345.54m;

            var bankAccount = new BankAccount(name, balance);

            Assert.Throws<InvalidOperationException>(() => bankAccount.Deposit(amount));
        }

        [Test]
        public void Deposit_Should_Increae_Ballance_Valid_Amount()
        {
            string name = "Gosho";
            decimal balance = 340.34m;

            var bankAccount = new BankAccount(name, balance);

            bankAccount.Deposit(120);

            var expected = 460.34m;
            var actual = bankAccount.Balance;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Withdraw_Should_Throw_Invalid_Operation_Exception_Invalid_Balance()
        {
            string name = "Gosho";
            decimal balance = 340.34m;

            var bankAccount = new BankAccount(name, balance);

            var invalidAmount = -1;

            Assert.Throws<InvalidOperationException>(() => bankAccount.Withdraw(invalidAmount));
        }
        [Test]
        public void Withdraw_Should_Throw_Invalid_Operation_Exception_Insufficeint_Funds()
        {
            string name = "Gosho";
            decimal balance = 340.34m;

            var bankAccount = new BankAccount(name, balance);

            var invalidAmount = 500;

            Assert.Throws<InvalidOperationException>(() => bankAccount.Withdraw(invalidAmount));
        }

        [Test]
        public void Withdraw_Should_Decrease_Balance_Correctly()
        {
            string name = "Gosho";
            decimal balance = 340.34m;

            var bankAccount = new BankAccount(name, balance);

            var validAmount = 40.34m;

            bankAccount.Withdraw(validAmount);

            var expectedAmount = 300;
            var actualAmount = bankAccount.Balance;

            Assert.AreEqual(expectedAmount, actualAmount);

        }
    }
}