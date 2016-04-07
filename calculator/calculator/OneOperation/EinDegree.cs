using System;

namespace calculator.OneOpeation
{
    public class EinDegree : IOneCalculator
    {
        public double Doit(double first)
        {
            return Math.Exp(first);
        }
    }
}
