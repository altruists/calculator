using System;

namespace calculator.OneOpeation
{
    public class Sqrt : IOneCalculator
    {
        public double Doit(double first)
        {
            return Math.Sqrt(first);
        }
    }
}
