using NUnit.Framework;
using calculator.TwoOperataion;

namespace calculator.tests.TwoOperation
{
    [TestFixture]
    class MinusTests
    {
        [Test]
        public void SimpleTest()
        {
            Minus calcul = new Minus();
            double res = calcul.Doit(53, 43);
            Assert.AreEqual(10, res);
        }  
    }
}
