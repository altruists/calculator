using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.TwoOperation
{
    /// <summary>
    /// This class contains a method of rasing a number in some degree.
    /// </summary>
    public class Pow : ICalculator
    {
        /// <summary>
        /// This method includes a rasing a number in some degree.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Doit(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}
