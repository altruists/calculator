using System;
using calculator.OneOperation;
using NUnit.Framework;

namespace calculator.tests.OneOperation
{
     [TestFixture]
    public class SqrtTests
    {
        [TestCase(25, 5)]
        [TestCase(4, 2)]
        [TestCase(1, 1)]
        public void SimpleTest(double first, double expected)
        {
            Sqrt calculator = new Sqrt();
            double result = calculator.Doit(first);
            Assert.AreEqual(expected, result, 0.000001);

        }
     [Test]
        public void NegNum()
        {
            Sqrt calcul = new Sqrt();
            Assert.Throws<Exception>(() => calcul.Doit(-16));

        }
    }
 }