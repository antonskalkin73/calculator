using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethodSumPlus()
        {
            CalculatorBC.Calculator calculator = new CalculatorBC.Calculator();

            calculator.add(2);
            calculator.add(2);

            Assert.AreEqual(calculator.GetResult(), 4);
        }

        [TestMethod]
        public void TestMethodSumMinus()
        {
            CalculatorBC.Calculator calculator = new CalculatorBC.Calculator();

            calculator.add(2);
            calculator.add(2);

            Assert.AreNotEqual(calculator.GetResult(), 5);
        }

        [TestMethod]
        public void TestMethodDividePlus()
        {
            CalculatorBC.Calculator calculator = new CalculatorBC.Calculator();

            calculator.add(2);
            calculator.divide(2);

            Assert.AreEqual(calculator.GetResult(), 1);
        }

        [TestMethod]
        public void TestMethodDivideMinus()
        {
            CalculatorBC.Calculator calculator = new CalculatorBC.Calculator();

            calculator.add(2);
            calculator.divide(2);

            Assert.AreNotEqual(calculator.GetResult(), 2);
        }
    }
}
