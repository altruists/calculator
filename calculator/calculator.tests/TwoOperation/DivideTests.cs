using System;
using calculator.TwoOperation;
using NUnit.Framework;

namespace calculator.tests.TwoOperation
{
    [TestFixture]
    class DivideTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(4, 2, 2)]
        [TestCase(76284, 489, 156)]
        public void SimpleTest(double first, double second, double expected)
        {
            Divide calcul = new Divide();
            double result = calcul.Doit(first, second);
            Assert.AreEqual(expected, result);
        }

//        [Test]
//        public void Zero()
//        {
            

//        }
    }
}