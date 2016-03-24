using System;

namespace calculator.OneOpeation
{
    class Cosx:IOneCalculator
    {
        public double Doit(double first)
        {
            return Math.Cos(first);
        }
    }
}
