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
    public class AcosxTests
    {
        [TestCase(1, 0)]
        [TestCase(0.5, Math.PI / 3)]
        [TestCase(0, Math.PI / 2)]
        public void SimpleTest(double first, double expected)
        {
            Acosx calculator = new Acosx();
            double result = calculator.Doit(first);
            Assert.AreEqual(expected, result, 0.000001);

        }
    }
}
