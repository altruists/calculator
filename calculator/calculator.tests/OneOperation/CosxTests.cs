using System;
using calculator.OneOperation;
using NUnit.Framework;


namespace calculator.tests.OneOperation
{
    [TestFixture]
    public class CosxTests
    {
        [TestCase(0, 1)]
        [TestCase(Math.PI/3, 0.5 )]
        [TestCase(Math.PI/2, 0)]
        public void SimpleTest(double first,  double expected)
        {
            Cosx calculator = new Cosx();
            double result = calculator.Doit(first);
            Assert.AreEqual(expected, result, 0.000001);

        }
    }
}