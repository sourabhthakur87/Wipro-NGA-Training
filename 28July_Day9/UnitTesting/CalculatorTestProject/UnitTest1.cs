using UnitTesting;
namespace CalculatorTestProject
{
    public class Tests
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void AddSum()
        {
            int result = calculator.Add(2,3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void SubtractSum()
        {
            int result = calculator.Sub(5,3);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}