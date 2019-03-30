namespace Skeleton.Test
{
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void Creating_A_New_Axe()
        {
            Axe axe = new Axe(10,10);

            Assert.AreEqual(10, axe.AttackPoints);

            Assert.AreEqual(10, axe.DurabilityPoints);
        }

        //3A Pattern
        [Test]
        public void Axe_Loses_Durability_After_Attack()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            //Act
            axe.Attack(dummy);

            //Assert
            axe.DurabilityPoints.Should().Be(9);
        }

        [Test]
        public void Broken_Axe_Cant_Attack()
        {
            Axe axe = new Axe(1, 1);

            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.That(() => axe.Attack(dummy), 
                Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }
    }
}
