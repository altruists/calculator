using System;

namespace calculator.OneOpeation
{
    class Sinx : IOneCalculator
    {
        public double Doit(double first)
        {
            return Math.Sin(first);
        }
    }
}
