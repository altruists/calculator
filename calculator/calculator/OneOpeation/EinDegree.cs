using System;

namespace calculator.OneOpeation
{
    class EinDegree : IOneCalculator
    {
        public double Doit(double first)
        {
            return Math.Exp(first);
        }
    }
}
