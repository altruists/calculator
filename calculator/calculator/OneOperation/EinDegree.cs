using System;

namespace calculator.OneOperation
{
    /// <summary>
    ///  This class contains a calculation of exhibitor in degree.
    /// </summary>
    public class EinDegree : IOneCalculator
    {
        /// <summary>
        /// This method includes a calculation of exhibitor in some degree. Degree takes a various number.
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Doit(double first)
        {
            return Math.Exp(first);
        }
    }
}
