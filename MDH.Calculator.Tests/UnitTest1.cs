using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MDH.Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void BasicNaturalPositives1()
        {
            var res = Calculator.Calculate("5+6");

            Assert.AreEqual(res, 11, 0.01);
            //test push
        }

        [TestMethod]
        public void BasicNaturalPositives2()
        {
            var res = Calculator.Calculate("6-5");

            Assert.AreEqual(res, 1, 0.01);
            //test push
        }

        [TestMethod]
        public void BasicNaturalPositives3()
        {
            var res = Calculator.Calculate("5-6");

            Assert.AreEqual(res, -1, 0.01);
            //test push
        }

        [TestMethod]
        public void BasicNaturalPositives4()
        {
            var res = Calculator.Calculate("5/6");

            Assert.AreEqual(res, 1, 0.01);
            //test push
        }

        [TestMethod]
        public void BasicNaturalPositives5()
        {
            var res = Calculator.Calculate("0/4");

            Assert.AreEqual(res, 0, 0.01);
            //test push
        }

        [TestMethod]
        public void BasicNaturalPositives6()
        {
            var res = Calculator.Calculate("4/0");

            Assert.AreEqual(res, 'can not divide by 0', 0.01);
            //test push
        } 
    }
}
