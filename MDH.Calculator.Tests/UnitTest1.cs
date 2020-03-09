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
            var res = Parser.Parse("1-9+66-9999+5");

        }
    }
}
