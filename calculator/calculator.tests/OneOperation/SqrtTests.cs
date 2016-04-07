using calculator.OneOpeation;
using NUnit.Framework;

namespace calculator.tests.OneOperation
{
     [TestFixture]
    public class SqrtTests
    {
        [Test]
        public void SimpleTest()
        {
            Sqrt calculator = new Sqrt();
            double result = calculator.Doit(25);
            Assert.AreEqual(5, result);
        }   
    }
}