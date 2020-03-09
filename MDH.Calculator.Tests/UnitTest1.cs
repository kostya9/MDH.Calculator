using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MDH.Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Test1()
        {
            var res = Calculator.Calculate("5+6");

            Assert.AreEqual(res, 11, 0.01);
            
        }

        [TestMethod]
        public void Test2()
        {
            var res = Calculator.Calculate("6-5");

            Assert.AreEqual(res, 1, 0.01);
            
        }

        [TestMethod]
        public void Test3()
        {
            var res = Calculator.Calculate("5-6");

            Assert.AreEqual(res, -1, 0.01);
            
        }

        [TestMethod]
        public void Test4()
        {
            var res = Calculator.Calculate("5/6");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        [TestMethod]
        public void Test5()
        {
            var res = Calculator.Calculate("0/4");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        [TestMethod]
        public void Test6()
        {
            var res = Calculator.Calculate("4/0");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        [TestMethod]
        public void Test7()
        {
            var res = Calculator.Calculate("5*6");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        [TestMethod]
        public void Test8()
        {
            var res = Calculator.Calculate("0*5");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        [TestMethod]
        public void Test9()
        {
            var res = Calculator.Calculate("-5-6");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        [TestMethod]
        public void Test10()
        {
            var res = Calculator.Calculate("(-5)*(-5)");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        [TestMethod]
        public void Test11()
        {
            var res = Calculator.Calculate("8/(-4)");

            Assert.AreEqual(res, -2, 0.01);
           
        }

        [TestMethod]
        public void Test12()
        {
            var res = Calculator.Calculate("(-8)/(-4)");

            Assert.AreEqual(res, 2, 0.01);
        
        }

        [TestMethod]
        public void Test13()
        {
            var res = Calculator.Calculate("0.5+0.6");

            Assert.AreEqual(res, 1.1, 0.01);
   
        }

        [TestMethod]
        public void Test14()
        {
            var res = Calculator.Calculate("0.5+(-0.5)");

            Assert.AreEqual(res, 0, 0.01);
       
        }

        [TestMethod]
        public void Test15()
        {
            var res = Calculator.Calculate("0.5*0.6");

            Assert.AreEqual(res, 0.3, 0.01);
       
        }

        [TestMethod]
        public void Test16()
        {
            var res = Calculator.Calculate("(-0.5)*(-0.6)");

            Assert.AreEqual(res, 0, 0.01);
            
        }

        [TestMethod]
        public void Test17()
        {
            var res = Calculator.Calculate("(-0.5)*0");

            Assert.AreEqual(res, 0, 0.01);
            
        }

        [TestMethod]
        public void Test18()
        {
            var res = Calculator.Calculate("(-0.5)/(-0.5)");

            Assert.AreEqual(res, 1 , 0.01);
          
        }

        [TestMethod]
        public void Test19()
        {
            var res = Calculator.Calculate("(-0.6)/0.6");

            Assert.AreEqual(res, -1, 0.01);
           
        }

        [TestMethod]
        public void Test20()
        {
            var res = Calculator.Calculate("0/0.5");

            Assert.AreEqual(res, 0, 0.01);
          
        }

        [TestMethod]
        public void Test21()
        {
            var res = Calculator.Calculate("0.5/0");

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
