using System;

namespace calculator.OneOperation
{
    public class Sqrt : IOneCalculator
    {
        public double Doit(double first)
        {
            return Math.Sqrt(first);
        }
    }
}
