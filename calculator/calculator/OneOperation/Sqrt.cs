using System;

namespace calculator.OneOperation
{
    /// <summary>
    /// This class contains Square root`s method.
    /// </summary>
    public class Sqrt : IOneCalculator
    {
        /// <summary>
        /// This method includes extract of square root. When extracts a negative number the method throws an exception about error operation.
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Doit(double first)
        {
            if (first < 0)
            {
                throw new Exception("Число отрицательное!");
            }
            return Math.Sqrt(first);
        }
    }
}
