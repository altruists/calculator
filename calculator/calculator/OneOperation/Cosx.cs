using System;

namespace calculator.OneOperation
{
    public class Cosx:IOneCalculator
    {
        public double Doit(double first)
        {
            return Math.Cos(first);
        }
    }
}
