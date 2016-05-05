using System;

namespace calculator.OneOperation
{
    /// <summary>
    /// This class contains calculation of sinus.
    /// </summary>
    public class Sinx : IOneCalculator
    {
        /// <summary>
        /// This method lets to calculate of sinus of every angle.
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Doit(double first)
        {
            return Math.Sin(first);
        }
    }
}
