using calculator.TwoOperataion;
using NUnit.Framework;

namespace calculator.tests.TwoOperation
{
    [TestFixture]
    class PlusTests
    {
        [Test]
        public void SimpleTest()
        {
            Plus calcul = new Plus();
            double res = calcul.Doit(23, 43);
            Assert.AreEqual(66, res);
        }
    }
}
