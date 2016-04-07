using calculator.OneOpeation;
using NUnit.Framework;

namespace calculator.tests.OneOperation
{
    [TestFixture]
    public class SinxTests
    {
             [Test]
        public void SimpleTest()
        {
            Sinx calculator = new Sinx();
            double result = calculator.Doit(0);
            Assert.AreEqual(0, result);
        }
    }  
    }
