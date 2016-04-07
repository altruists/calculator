using calculator.TwoOperataion;
using NUnit.Framework;

namespace calculator.tests.TwoOperation
{
    [TestFixture]
    class DivideTests
    {
        [Test]
        public void SimpleTest()
        {
            Divide calcul = new Divide();
            double res = calcul.Doit(40, 5);
            Assert.AreEqual(8, res);
        }

        [Test]
        public void SimpleTest()
        {
            Divide calcul = new Divide();
            double res = calcul.Doit(40, 5);
            Assert.AreEqual(8, res);
        }
    }
}