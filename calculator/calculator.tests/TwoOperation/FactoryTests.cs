using System;
using calculator.OneOperation;
using calculator.TwoOperation;
using NUnit.Framework;

namespace calculator.tests.TwoOperation
{
    [TestFixture]
    public class FactoryTests
    {
        [TestCase("button1", typeof(Plus))]
        [TestCase("button2", typeof(Multiply))]
        [TestCase("button3", typeof(Divide))]
        [TestCase("button4", typeof(Minus))]
        [TestCase("button9", typeof(Pow))]
        public void SimpleTest(string name, Type type)
        {
            ICalculator calculator = Factory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);

        }
    }
}