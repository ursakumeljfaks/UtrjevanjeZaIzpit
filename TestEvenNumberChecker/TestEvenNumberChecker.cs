using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace TestEvenNumberChecker
{
    [TestClass]
    public class TestEvenNumberChecker
    {
        [TestMethod]
        public void IsEven_PositiveEvenNumber_ReturnsTrue()
        {
            bool result = EvenNumberChecker.EvenNumberChecker.IsEven(4);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEven_PositiveOddNumber_ReturnsFalse()
        {
            bool result = EvenNumberChecker.EvenNumberChecker.IsEven(3);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsEven_NegativeEvenNumber_ReturnsTrue()
        {
            bool result = EvenNumberChecker.EvenNumberChecker.IsEven(-2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEven_NegativeOddNumber_ReturnsFalse()
        {
            bool result = EvenNumberChecker.EvenNumberChecker.IsEven(-3);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsEven_Zero_ReturnsTrue()
        {
            bool result = EvenNumberChecker.EvenNumberChecker.IsEven(0);
            Assert.IsTrue(result);
        }
    }
}

