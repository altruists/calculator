using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneOperation
{
    /// <summary>
    /// This class contains calculation of log10.
    /// </summary>
    public class log10 : IOneCalculator
    {
        /// <summary>
        /// This method lets to calculate of log 10 . Also there is an exception which is thrown when the arg is less than zero.
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Doit(double first)
        {
            if (first <= 0)
            {
                throw new Exception("Аргумент меньше 0!");
            }
            return Math.Log10(first);
        }
    }
}
