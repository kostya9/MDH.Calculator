using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//push test
namespace MDH.Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        /*
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

            Assert.AreEqual(res, 1, 0.01);

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
            //error
        }

        [TestMethod]
        public void Test22()
        {
            var res = Calculator.Calculate("a+5");

            Assert.AreEqual(res, ?, 0.01);
            //error
        }

        [TestMethod]
        public void Test23()
        {
            var res = Calculator.Calculate("a-6");

            Assert.AreEqual(res, ?, 0.01);
            //error
        }

        [TestMethod]
        public void Test24()
        {
            var res = Calculator.Calculate("a*6");

            Assert.AreEqual(res, ?, 0.01);
            //error
        }

        [TestMethod]
        public void Test25()
        {
            var res = Calculator.Calculate("a/6");

            Assert.AreEqual(res, ?, 0.01);
            //error
        }

        [TestMethod]
        public void Test26()
        {
            var res = Calculator.Calculate("6/a");

            Assert.AreEqual(res, ?, 0.01);
            //error
        }

        [TestMethod]
        public void Test27()
        {
            var res = Calculator.Calculate("-a*6");

            Assert.AreEqual(res, ?, 0.01);
            //error
        }

        [TestMethod]
        public void Test28()
        {
            var res = Calculator.Calculate("-a/6");

            Assert.AreEqual(res, ?, 0.01);
            //error
        }

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

        public void Test50()
        {
            var res = Calculator.Calculate("5+-6");

            Assert.AreEqual(res,"error", 0.01);
            //test push
        }

        public void Test51()
        {
            var res = Calculator.Calculate("5+-6");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        public void Test52()
        {
            var res = Calculator.Calculate("5*//*6");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        public void Test53()
        {
            var res = Calculator.Calculate("--56");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }

        public void Test54()
        {
            var res = Calculator.Calculate("5+-6");

            Assert.AreEqual(res, "error", 0.01);
            //test push
        }*/

        [TestMethod]
        public void BasicPlus()
        {
            var res = Parser.Parse("2*9/66*9999+5");
            //var res = Calculator.Eval("2+2+2");
            //Assert.AreEqual(res, 6);
        }

    }
}
