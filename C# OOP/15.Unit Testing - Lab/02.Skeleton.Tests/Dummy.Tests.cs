namespace Skeleton.Test
{
    using FluentAssertions;
    using NUnit.Framework;
    using System;

    [TestFixture]

    public class DummyTests
    {
        [Test]
        public void Dummy_Loses_Health_After_Attack()
        {
            //Arrange
            Dummy dummy = new Dummy(10,10);

            //Act
            dummy.TakeAttack(5);

            //Assert
            dummy.Health.Should().Be(5);
        }

        [Test]
        public void DeadDummy()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);

            dummy.TakeAttack(10);


            //Act && Assert
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(2));
        }

        [Test]
        
        public void GiveExperience()
        {
            //Arrange
            Dummy dummy = new Dummy(0, 10);

            //Act
            int exp = dummy.GiveExperience();

            //Assert
            exp.Should().Be(10);

        }

        [Test]
        public void CantGiveExperience()
        {
            //Arrange
            Dummy dummy = new Dummy(2, 10);
            
            //Act & Assert
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}
