using System;
using Demo.Classses;
using NUnit.Framework;

namespace DemoTest
{
    [TestFixture]
    public class PlusTests
    {
        private PlusClass _instanse;

        [OneTimeSetUp]
        public void PlusClassOneTimeSetUp()
        {
            _instanse = new PlusClass();
        }

        [Test]
        public void PositivePlusTest()
        {
            Assert.AreEqual(2, _instanse.PlusOneMethod(1), "Sum is not equal to 1");
        }

        [Test]
        public void NegativePlusTest()
        {
            Assert.AreEqual(1, _instanse.PlusOneMethod(1), "Sum is not equal to 1");
        }

        [Test]
        public void ExceptionPlusTest()
        {
            throw new Exception("Test with exception");
            Assert.AreEqual(1, _instanse.PlusOneMethod(1), "Sum is not equal to 1");
        }
    }
}
