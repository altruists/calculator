using System;

namespace calculator.OneOpeation
{
    public class Sinx : IOneCalculator
    {
        public double Doit(double first)
        {
            return Math.Sin(first);
        }
    }
}
