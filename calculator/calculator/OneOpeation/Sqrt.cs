using System;

namespace calculator.OneOpeation
{
    class Sqrt : IOneCalculator
    {
        public double Doit(double first)
        {
            return Math.Sqrt(first);
        }
    }
}
