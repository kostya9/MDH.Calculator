using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MDH.Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {


        

        [TestMethod]
        public void Test29()
        {
            var res = Calculator.Calculate("6/(-a)");
           
            Assert.AreEqual(res, "error", 0.01);
            
        }

        [TestMethod]
        public void Test30()
        {
            var res = Calculator.Calculate("a+0.5");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        public void Test31()
        {
            var res = Calculator.Calculate("a-0.6");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        public void Test32()
        {
            var res = Calculator.Calculate("a*0.5");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        public void Test33()
        {
            var res = Calculator.Calculate("a/0.5");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        public void Test34()
        {
            var res = Calculator.Calculate("0.5-a");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        public void Test35()
        {
            var res = Calculator.Calculate("0.5/a");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        public void Test36()
        {
            var res = Calculator.Calculate("-0.5-a");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        public void Test37()
        {
            var res = Calculator.Calculate("0.5/a");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        public void Test38()
        {
            var res = Calculator.Calculate("5+6+8");

            Assert.AreEqual(res, 19, 0.01);
            //test push
        }

        public void Test39()
        {
            var res = Calculator.Calculate("5-6-8");

            Assert.AreEqual(res, -9, 0.01);
            //test push
        }

        public void Test40()
        {
            var res = Calculator.Calculate("5/6/8");

            Assert.AreEqual(res, 0.1, 0.01);
            //test push
        }

        public void Test41()
        {
            var res = Calculator.Calculate("5*6*8");

            Assert.AreEqual(res, 240, 0.01);
            //test push
        }

        public void Test42()
        {
            var res = Calculator.Calculate("5*6-1");

            Assert.AreEqual(res, 29, 0.01);
            //test push
        }

        public void Test43()
        {
            var res = Calculator.Calculate("5+6/1");

            Assert.AreEqual(res, 11, 0.01);
            //test push
        }

        public void Test44()
        {
            var res = Calculator.Calculate("5+6*8");

            Assert.AreEqual(res, 53, 0.01);
            //test push
        }

        public void Test45()
        {
            var res = Calculator.Calculate("5-6+8");

            Assert.AreEqual(res, 7, 0.01);
            //test push
        }

        public void Test46()
        {
            var res = Calculator.Calculate("5-6/8");

            Assert.AreEqual(res, 4.25, 0.01);
            //test push
        }

        public void Test47()
        {
            var res = Calculator.Calculate("5/6*8");

            Assert.AreEqual(res, 6.66, 0.01);
            //test push
        }

        public void Test48()
        {
            var res = Calculator.Calculate("5-6*8+1/4");

            Assert.AreEqual(res, -42.75, 0.01);
            //test push
        }

        public void Test49()
        {
            var res = Calculator.Calculate("-0.5+0.6*8/1");

            Assert.AreEqual(res, 4.25, 0.01);
            //test push
        }
    }
}
