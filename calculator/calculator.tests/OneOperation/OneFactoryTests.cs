using System;
using calculator.OneOperation;
using NUnit.Framework;

namespace calculator.tests.OneOperation
{
    [TestFixture]
    public class OneFactoryTests
    {
        [TestCase("button5", typeof(Cosx))]
        [TestCase("button6", typeof(Sinx))]
        [TestCase("button7", typeof(Sqrt))]
        [TestCase("button8", typeof(EinDegree))]
        [TestCase("button10", typeof(log10))]
        [TestCase("button11", typeof(Asinx))]
        [TestCase("button12", typeof(Acosx))]
        public void SimpleTest(string name, Type type)
        {
            IOneCalculator calculator = OneFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type,calculator);

        } 
    }
}