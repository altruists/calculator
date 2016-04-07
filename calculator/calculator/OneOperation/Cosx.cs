using System;

namespace calculator.OneOpeation
{
    public class Cosx:IOneCalculator
    {
        public double Doit(double first)
        {
            return Math.Cos(first);
        }
    }
}
