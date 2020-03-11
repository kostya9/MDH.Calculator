using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//push test
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

            Assert.AreEqual(res, 8, 0.01);

        } //Division by 0 

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
        public void Test13()
        {
            var res = Calculator.Calculate("0.5+0.6");

            Assert.AreEqual(res, 1.1, 0.01);

        }


        [TestMethod]
        public void Test15()
        {
            var res = Calculator.Calculate("0.5*0.6");

            Assert.AreEqual(res, 0.3, 0.01);

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

            Assert.AreEqual(res, 8 , 0.01);
            //error
        }

        
        public void Test22()
        {
            var res = Calculator.Calculate("5+6+8");

            Assert.AreEqual(res, 19, 0.01);
            //test push
        }

        public void Test23()
        {
            var res = Calculator.Calculate("5-6-8");

            Assert.AreEqual(res, -9, 0.01);
            //test push
        }

        public void Test24()
        {
            var res = Calculator.Calculate("5/6/8");

            Assert.AreEqual(res, 0.1, 0.01);
            //test push
        }

        public void Test25()
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

        public void Test26()
        {
            var res = Calculator.Calculate("5+6/1");

            Assert.AreEqual(res, 11, 0.01);
            //test push
        }

        public void Test27()
        {
            var res = Calculator.Calculate("5+6*8");

            Assert.AreEqual(res, 53, 0.01);
            //test push
        }

        public void Test28()
        {
            var res = Calculator.Calculate("5-6+8");

            Assert.AreEqual(res, 7, 0.01);
            //test push
        }

        public void Test29()
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
            var res = Calculator.Calculate("5+--/6");

            Assert.AreEqual(res, 0.8333, 0.01);
            //test push
        }

        public void Test51()
        {
            var res = Calculator.Calculate("5+-6");

            Assert.AreEqual(res,-1, 0.01);
            //test push
        }

        public void Test52()
        {
            var res = Calculator.Calculate("5*//*6");

            Assert.AreEqual(res, 30, 0.01);
            //test push
        }

        public void Test53()
        {
            var res = Calculator.Calculate("--56");

            Assert.AreEqual(res, -56, 0.01);
            //test push
        }


        public void Test54()
        {
            var res = Calculator.Calculate("+");

            Assert.AreEqual(res, 0, 0.01);
            //test push
        }

        public void Test53()
        {
            var res = Calculator.Calculate("*");

            Assert.AreEqual(res, 0, 0.01);
            //test push
        }

        public void Test55()
        {
            var res = Calculator.Calculate("/");

            Assert.AreEqual(res, 0, 0.01);
            //test push
        }

        public void Test56()
        {
            var res = Calculator.Calculate("-");

            Assert.AreEqual(res, 0, 0.01);
            //test push
        }
    }
}
