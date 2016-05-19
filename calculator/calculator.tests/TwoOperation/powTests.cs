using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.TwoOperation;
using NUnit.Framework;

namespace calculator.tests.TwoOperation
{
    [TestFixture]
    class powTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(4, 2, 16)]
        [TestCase(562, 3, 177504328 )]
        public void SimpleTest(double first, double second, double expected)
        {
            Pow calcul = new Pow();
            double result = calcul.Doit(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
