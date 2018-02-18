using System;
using Demo.Classses;
using NUnit.Framework;

namespace DemoTest
{
    [TestFixture]
    public class MinusTests
    {
        private MinusClass _instanse;

        [OneTimeSetUp]
        public void MinusTetstOneTimeSetUp()
        {
            _instanse = new MinusClass();
        }

        [Test]
        public void PositiveMinusTest()
        {
            Assert.AreEqual(1, _instanse.MinusOneMethod(2), "Difference is not equal to 1");
        }

        [Test]
        public void MinusPlusTest()
        {
            Assert.AreEqual(1, _instanse.MinusOneMethod(1), "Sum is not equal to 1");
        }

        [Test]
        [Ignore("Ignored test")]
        public void IgnoredMinusTest()
        {
            Assert.AreEqual(1, _instanse.MinusOneMethod(1), "Sum is not equal to 1");
        }
    }
}
