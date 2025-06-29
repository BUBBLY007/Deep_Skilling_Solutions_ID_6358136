using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TearDown]
        public void Teardown()
        {
            calculator = null;
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, 1, 0)]
        public void Add_ShouldReturnCorrectSum(int a, int b, int expected)
        {
            var result = calculator.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Ignore("Skip subtraction for now")]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            var result = calculator.Subtract(5, 3);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
