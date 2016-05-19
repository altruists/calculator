using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneOperation;
using NUnit.Framework;

namespace calculator.tests.OneOperation
{
    [TestFixture]
    public class log10Tests
    {
        [TestCase(10, 1)]
        [TestCase(100, 2)]
        [TestCase(10000, 4)]
        public void SimpleTest(double first, double expected)
        {
            log10 calculator = new log10();
            double result = calculator.Doit(first);
            Assert.AreEqual(expected, result, 0.000001);
        }
        [Test]
        public void Zero()
        {
            log10 calcul = new log10();
            Assert.Throws<Exception>(() => calcul.Doit(-1));
            Assert.Throws<Exception>(() => calcul.Doit(0));
        }
    }
}
