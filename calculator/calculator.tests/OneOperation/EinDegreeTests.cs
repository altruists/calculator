using calculator.OneOpeation;
using NUnit.Framework;

namespace calculator.tests.OneOperation
{
     [TestFixture]
    public class EinDegreeTests
    {
        [Test]
        public void SimpleTest()
        {
            EinDegree calculator = new EinDegree();
            double result = calculator.Doit(3);
            Assert.AreEqual(20.0855369, result, 0.001);
        }  
    }
}