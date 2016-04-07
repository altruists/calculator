using calculator.TwoOperataion;
using NUnit.Framework;

namespace calculator.tests.TwoOperation
{
    [TestFixture]
    public class MultiplyTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(4, 6, 24)]
        [TestCase(156, 489, 76284)]
        public void SimpleTest(double first, double second, double expected)
        {
            Multiply calculator = new Multiply();
            double result = calculator.Doit(first, second);
            Assert.AreEqual(expected, result);

        }
    }
}