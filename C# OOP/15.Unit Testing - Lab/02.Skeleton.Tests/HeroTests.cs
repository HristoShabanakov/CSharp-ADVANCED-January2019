namespace Skeleton.Test
{
    using Moq;
    using NUnit.Framework;
    using Skeleton.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    [TestFixture]
    public class HeroTests
    {
        [Test]
        public void MockDemo()
        {
            Mock<IWeapon> mockWeapon = new Mock<IWeapon>();
            Mock<ITarget> mockTarget = new Mock<ITarget>();

            mockWeapon.Setup(p => p.Attack(mockTarget.Object));

            mockTarget.Setup(t => t.GiveExperience()).Returns(() => 55);

            var exp = mockTarget.Object.GiveExperience();

            Hero batman = new Hero("TestHero", mockWeapon.Object);
        }
    }
}
