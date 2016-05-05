using System;

namespace calculator.OneOperation
{
    /// <summary>
    /// This class contains calculation of cosinus.
    /// </summary>
    public class Cosx:IOneCalculator
    {
        /// <summary>
        /// This method lets to calculate of cosinus of every angle.
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Doit(double first)
        {
            return Math.Cos(first);
        }
    }
}
