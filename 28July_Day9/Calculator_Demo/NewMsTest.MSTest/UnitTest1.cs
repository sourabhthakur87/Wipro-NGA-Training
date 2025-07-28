using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_Demo;
namespace NewMsTest.MSTest
{
    [TestClass]
    public class UnitTest1
    {

        private Calculator calculate;

        [TestInitialize]
        public void TestInitialize()
        {
            calculate = new Calculator();
        }
        [TestMethod]
        public void Multiply_Return()
        {
            int result = calculate.Multiply(5, 5);
            Assert.AreEqual(25, result);
        }
        [TestMethod]
        public void ADD_Return()
        {
            int result = calculate.Add(5, 5);
            Assert.AreEqual(10, result);
        }
        [TestMethod]
        public void Divide_Return()
        {
            int result = calculate.Divice(10, 2);
            Assert.AreEqual(5, result);
        }
    }
}
