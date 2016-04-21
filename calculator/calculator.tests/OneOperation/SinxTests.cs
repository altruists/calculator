using System;
using calculator.OneOperation;
using NUnit.Framework;

namespace calculator.tests.OneOperation
{
    [TestFixture]
    public class SinxTests
    {
        [TestCase(0, 0)]
        [TestCase(Math.PI / 6, 0.5)]
        [TestCase(Math.PI / 2, 1)]
        public void SimpleTest(double first, double expected)
        {
            Sinx calculator = new Sinx();
            double result = calculator.Doit(first);
            Assert.AreEqual(expected, result, 0.000001);

        }
    }
}