using System;

namespace calculator.OneOperation
{
    public class EinDegree : IOneCalculator
    {
        public double Doit(double first)
        {
            return Math.Exp(first);
        }
    }
}
