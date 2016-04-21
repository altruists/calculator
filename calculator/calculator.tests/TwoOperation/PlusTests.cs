using System;
using calculator.TwoOperation;
using NUnit.Framework;

namespace calculator.tests.TwoOperation
{
    [TestFixture]
    class PlusTests
    {
        [TestCase(1, 1, 2)]
        [TestCase(4, 6, 10)]
        [TestCase(156, 400, 556)]
        public void SimpleTest(double first, double second, double expected)
        {
            Plus calculator = new Plus();
            double result = calculator.Doit(first, second);
            Assert.AreEqual(expected, result);

        }
    }
}