using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticDay8;
namespace CalculatorNUNit.NUnit
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator calculator;

        [TestMethod]

        public void TestAdd()
        {
            calculator = new Calculator();
            int result = calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            calculator = new Calculator();
            int result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            calculator = new Calculator();
            int result = calculator.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            calculator = new Calculator();
            int result = calculator.Divide(6, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestDivideByZero()
        {
            calculator = new Calculator();
            bool exceptionThrown = false;
            try
            {
                calculator.Divide(6, 0);
            }
            catch (DivideByZeroException)
            {
                exceptionThrown = true;
            }
            Assert.IsTrue(exceptionThrown);
        }
    }
}
