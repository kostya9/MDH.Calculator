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

            Assert.AreEqual(res, 1, 0.01);
            
        }

        [TestMethod]
        public void Test5()
        {
            var res = Calculator.Calculate("0/4");

            Assert.AreEqual(res, 0, 0.01);
            
        }

        [TestMethod]
        public void Test6()
        {
            var res = Calculator.Calculate("4/0");

            Assert.AreEqual(res, 'can not divide by 0', 0.01);
            
        }

        [TestMethod]
        public void Test7()
        {
            var res = Calculator.Calculate("5*6");

            Assert.AreEqual(res, 30, 0.01);
            
        }

        [TestMethod]
        public void Test8()
        {
            var res = Calculator.Calculate("0*5");

            Assert.AreEqual(res, 0, 0.01);
            
        }

        [TestMethod]
        public void Test9()
        {
            var res = Calculator.Calculate("-5-6");

            Assert.AreEqual(res, -11, 0.01);
          
        }

        [TestMethod]
        public void Test10()
        {
            var res = Calculator.Calculate("(-5)*(-5)");

            Assert.AreEqual(res, 25, 0.01);
           
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

            Assert.AreEqual(res, ?, 0.01);
            //test pyet
        }

        [TestMethod]
        public void Test22()
        {
            var res = Calculator.Calculate("a+5");

            Assert.AreEqual(res, ?, 0.01);
            //test pyet
        }

        [TestMethod]
        public void Test23()
        {
            var res = Calculator.Calculate("a-6");

            Assert.AreEqual(res, ?, 0.01);
            //test pyet
        }

        [TestMethod]
        public void Test24()
        {
            var res = Calculator.Calculate("a*6");

            Assert.AreEqual(res, ?, 0.01);
            //test pyet
        }

        [TestMethod]
        public void Test25()
        {
            var res = Calculator.Calculate("a/6");

            Assert.AreEqual(res, ?, 0.01);
            //test pyet
        }

        [TestMethod]
        public void Test26()
        {
            var res = Calculator.Calculate("6/a");

            Assert.AreEqual(res, ?, 0.01);
            //test pyet
        }

        [TestMethod]
        public void Test27()
        {
            var res = Calculator.Calculate("-a*6");

            Assert.AreEqual(res, ?, 0.01);
            //test pyet
        }

        [TestMethod]
        public void Test28()
        {
            var res = Calculator.Calculate("-a/6");

            Assert.AreEqual(res, ?, 0.01);
            //test pyet
        }
        
    }
}
