using calculator.OneOpeation;
using NUnit.Framework;


namespace calculator.tests.OneOperation
{
    [TestFixture]
    public class CosxTests
    {
        [Test]
        public void SimpleTest()
        {
            Cosx calculator = new Cosx();
            double result = calculator.Doit(0);
            Assert.AreEqual(1, result);
        }
    }
}