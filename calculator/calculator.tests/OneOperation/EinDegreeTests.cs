using System;
using calculator.OneOperation;
using NUnit.Framework;

namespace calculator.tests.OneOperation
{
     [TestFixture]
    public class EinDegreeTests
    {
        [TestCase(1, 2.718281)]
        [TestCase(2, 7.389056)]
        [TestCase(0, 1)]
        public void SimpleTest(double first, double expected)
        {
            EinDegree calculator = new EinDegree();
            double result = calculator.Doit(first);
            Assert.AreEqual(expected, result, 0.000001);

        }
    }
 }