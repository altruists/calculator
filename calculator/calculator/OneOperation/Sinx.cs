using System;

namespace calculator.OneOperation
{
    public class Sinx : IOneCalculator
    {
        public double Doit(double first)
        {
            return Math.Sin(first);
        }
    }
}
