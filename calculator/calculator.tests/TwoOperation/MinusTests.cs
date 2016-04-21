using System;
using calculator.TwoOperation;
using NUnit.Framework;

namespace calculator.tests.TwoOperation
{
    [TestFixture]
    class MinusTests
    {
        [TestCase(3, 1, 2)]
        [TestCase(16, 6, 10)]
        [TestCase(956, 400, 556)]
        public void SimpleTest(double first, double second, double expected)
        {
            Minus calculator = new Minus();
            double result = calculator.Doit(first, second);
            Assert.AreEqual(expected, result);

        }
    }
}
