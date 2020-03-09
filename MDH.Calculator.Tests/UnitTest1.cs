using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MDH.Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void BasicPlus()
        {
            var res = Calculator.Calculate("2*2 + 1 / 3 * 2");

            Assert.AreEqual(res, 4.66, 0.01);
            //test push
        }
    }
}
