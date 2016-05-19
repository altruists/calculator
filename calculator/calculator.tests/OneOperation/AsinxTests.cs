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
    public class AsinxTests
    {
        [TestCase(0, 0)]
        [TestCase(0.5, Math.PI / 6)]
        [TestCase(1, Math.PI / 2)]
        public void SimpleTest(double first, double expected)
        {
            Asinx calculator = new Asinx();
            double result = calculator.Doit(first);
            Assert.AreEqual(expected, result, 0.000001);

        }
    }
}
